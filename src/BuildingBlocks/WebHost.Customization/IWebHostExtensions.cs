// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Npgsql;
using Polly;

namespace Corpsolution.Streamteam.WebHost.Customization;

public static class WebHostExtensions
{
    private static bool IsInKubernetes(this IWebHost webHost)
    {
        var cfg = webHost.Services.GetService<IConfiguration>();
        var orchestratorType = cfg.GetValue<string>("OrchestratorType");
        return orchestratorType?.ToUpper() == "K8S";
    }

    public static IWebHost MigrateDbContext<TContext>(this IWebHost webHost, Action<TContext, IServiceProvider> seeder)
        where TContext : DbContext
    {
        var underK8S = webHost.IsInKubernetes();

        using var scope = webHost.Services.CreateScope();
        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILogger<TContext>>();
        var context = services.GetService<TContext>();

        try
        {
            logger.LogInformation("Migrating database associated with context {DbContextName}", typeof(TContext).Name);

            if (underK8S)
            {
                InvokeSeeder(seeder!, context, services);
            }
            else
            {
                const int retries = 10;
                var retry = Policy.Handle<NpgsqlException>()
                    .WaitAndRetry(
                        retryCount: retries,
                        sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                        onRetry: (exception, timeSpan, retry, ctx) =>
                        {
                            logger.LogWarning(exception,
                                "[{Prefix}] Exception {ExceptionType} with message {Message} detected on attempt {Retry} of {Retries}",
                                nameof(TContext), exception.GetType().Name, exception.Message, retry, retries);
                        });
                retry.Execute(() => InvokeSeeder(seeder!, context, services));
            }

            logger.LogInformation("Migrated database associated with context {DbContextName}", typeof(TContext).Name);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred while migrating the database used on context {DbContextName}",
                typeof(TContext).Name);
            if (underK8S)
            {
                throw; // Rethrow under k8s because we rely on k8s to re-run the pod
            }
        }

        return webHost;
    }

    private static void InvokeSeeder<TContext>(Action<TContext, IServiceProvider> seeder, TContext context,
        IServiceProvider services)
        where TContext : DbContext?
    {
        context?.Database.Migrate();
        seeder(context, services);
    }
}