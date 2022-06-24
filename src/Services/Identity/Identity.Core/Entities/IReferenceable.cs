// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Entities;

public interface IReferenceable
{
    Guid Id { get; set; }
    string ReferenceData { get; set; }
    bool IsUser();
}