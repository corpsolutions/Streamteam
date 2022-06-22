// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Devspaces.Support;

public static class ServiceCollectionDevspacesExtensions
{
    public static IServiceCollection AddDevspaces(this IServiceCollection services)
    {
        services.AddTransient<DevspacesMessageHandler>();
        return services;
    }
}