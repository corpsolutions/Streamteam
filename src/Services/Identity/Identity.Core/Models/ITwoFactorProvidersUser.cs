// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Models;

public interface ITwoFactorProvidersUser
{
    string TwoFactorProviders { get; }
    Dictionary<TwoFactorProviderType, TwoFactorProvider>? GetTwoFactorProviders();
    Guid? GetUserId();
}