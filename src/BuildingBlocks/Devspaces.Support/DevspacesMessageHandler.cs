// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Devspaces.Support;

public class DevspacesMessageHandler : DelegatingHandler
{
    private const string DevspacesHeaderName = "X-Devspaces-Request-Id";

    private readonly IHttpContextAccessor _httpContextAccessor;

    public DevspacesMessageHandler(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var req = _httpContextAccessor.HttpContext.Request;

        if (req.Headers.ContainsKey(DevspacesHeaderName))
        {
            request.Headers.Add(DevspacesHeaderName, req.Headers[DevspacesHeaderName] as IEnumerable<string>);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}