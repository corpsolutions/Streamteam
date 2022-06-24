// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Models;

public class TwoFactorProvider
{
    public bool Enabled { get; set; }

    public Dictionary<string, object> MetaData { get; set; } = new();

    public class WebAuthnData
    {
        public WebAuthnData()
        {
        }

        public WebAuthnData(dynamic o)
        {
            Name = o.Name;

            try
            {
                Descriptor = o.Descriptor;
            }
            catch
            {
                if (o.Descriptor.Type == 0)
                {
                    o.Descriptor.Type = "public-key";
                }

                Descriptor = JsonSerializer.Deserialize<PublicKeyCredentialDescriptor>(o.Descriptor.ToString(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            PublicKey = o.PublicKey;
            UserHandle = o.UserHandle;
            SignatureCounter = o.SignatureCounter;
            CredType = o.CredType;
            RegDate = o.RegDate;
            AaGuid = o.AaGuid;
            Migrated = o.Migrated;
        }

        public string Name { get; set; }
        public PublicKeyCredentialDescriptor Descriptor { get; internal set; }
        public byte[] PublicKey { get; internal set; }
        public byte[] UserHandle { get; internal set; }
        public uint SignatureCounter { get; set; }
        public string CredType { get; internal set; }
        public DateTime RegDate { get; internal set; }
        public Guid AaGuid { get; internal set; }
        public bool Migrated { get; internal set; }
    }
}