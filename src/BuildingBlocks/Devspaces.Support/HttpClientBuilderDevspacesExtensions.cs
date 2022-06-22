// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Devspaces.Support;

public static class HttpClientBuilderDevspacesExtensions
{
    public static IHttpClientBuilder AddDevspacesSupport(this IHttpClientBuilder builder)
    {
        builder.AddHttpMessageHandler<DevspacesMessageHandler>();
        return builder;
    }
}