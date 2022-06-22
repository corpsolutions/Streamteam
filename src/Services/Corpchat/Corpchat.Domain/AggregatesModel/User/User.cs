// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Corpchat.Domain.AggregatesModel.User;

public class User : IdentityUser
{
    [Required] public string FirstName { get; set; }

    [Required] public string LastName { get; set; }

    [Required] public bool IsBanned { get; set; }

    [Required] public bool IsBot { get; set; }

    [Required] public string Avatar { get; set; }

    [Required] public string StatusIcon { get; set; }

    [Required] public string Language { get; set; }

    [Required] public long LastActive { get; set; }

    [Required] public List<Role> Roles { get; set; }

    [Required] public bool MailVerified { get; set; }
}