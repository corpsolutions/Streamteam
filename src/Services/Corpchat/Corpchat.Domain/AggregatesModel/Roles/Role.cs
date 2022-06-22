// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

using Corpsolution.Streamteam.Corpchat.Domain.SeedWork;

namespace Corpsolution.Streamteam.Corpchat.Domain.AggregatesModel.Roles;

public class Role : Entity, IAggregateRoot
{
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
}