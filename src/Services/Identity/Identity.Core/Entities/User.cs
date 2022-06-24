// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Entities;

public class User : ITableObject<Guid>, IRevisable, ITwoFactorProvidersUser, IReferenceable
{
    private Dictionary<TwoFactorProviderType, TwoFactorProvider> _twoFactorProviders;

    public Guid Id { get; set; }
    public string ReferenceData { get; set; }
    [MaxLength(50)] public string Name { get; set; }
    [Required] [MaxLength(256)] public string Email { get; set; }
    public bool EmailVerified { get; set; }
    [MaxLength(300)] public string Password { get; set; }
    [MaxLength(10)] public string Culture { get; set; } = "en-US";
    [Required] [MaxLength(50)] public string SecurityStamp { get; set; }
    public string TwoFactorProviders { get; set; }
    [MaxLength(32)] public string TwoFactorRecoveryCode { get; set; }
    public string Key { get; set; }
    public string PublicKey { get; set; }
    public string PrivateKey { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    public DateTime RevisionDate { get; set; } = DateTime.UtcNow;
    public bool ForcePasswordReset { get; set; }
    public bool UsesKeyConnector { get; set; }
    public int FailedLoginCount { get; set; }
    public DateTime? LastFailedLoginDate { get; set; }

    public void SetNewId()
    {
        Id = IdentityHelpers.GenerateComb();
    }

    public bool IsUser()
    {
        return true;
    }

    public Dictionary<TwoFactorProviderType, TwoFactorProvider>? GetTwoFactorProviders()
    {
        if (string.IsNullOrWhiteSpace(TwoFactorProviders))
        {
            return null;
        }

        try
        {
            if (_twoFactorProviders == null)
            {
                _twoFactorProviders =
                    JsonHelpers.LegacyDeserialize<Dictionary<TwoFactorProviderType, TwoFactorProvider>>(
                        TwoFactorProviders);
            }

            return _twoFactorProviders;
        }
        catch (JsonException)
        {
            return null;
        }
    }

    public Guid? GetUserId()
    {
        return Id;
    }

    public void SetTwoFactorProviders(Dictionary<TwoFactorProviderType, TwoFactorProvider> providers)
    {
        // When replacing with system.text remember to remove the extra serialization in WebAuthnTokenProvider.
        TwoFactorProviders = JsonHelpers.LegacySerialize(providers, JsonHelpers.LegacyEnumKeyResolver);
        _twoFactorProviders = providers;
    }

    public void ClearTwoFactorProviders()
    {
        SetTwoFactorProviders(new Dictionary<TwoFactorProviderType, TwoFactorProvider>());
    }

    public TwoFactorProvider GetTwoFactorProvider(TwoFactorProviderType provider)
    {
        var providers = GetTwoFactorProviders();
        if (providers == null || !providers.ContainsKey(provider))
        {
            return null;
        }

        return providers[provider];
    }

    public IdentityUser ToIdentityUser(bool twoFactorEnabled)
    {
        return new IdentityUser
        {
            Id = Id.ToString(),
            Email = Email,
            NormalizedEmail = Email,
            EmailConfirmed = EmailVerified,
            UserName = Email,
            NormalizedUserName = Email,
            TwoFactorEnabled = twoFactorEnabled,
            SecurityStamp = SecurityStamp
        };
    }
}