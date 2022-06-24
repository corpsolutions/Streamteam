// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Enums;

public enum TwoFactorProviderType : byte
{
    Authenticator = 0,
    Email = 1,
    Yubikey = 2,
    Remember = 3,
    WebAuthn = 4,
}