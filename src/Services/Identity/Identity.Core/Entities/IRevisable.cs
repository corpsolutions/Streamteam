// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Entities;

public interface IRevisable
{
    DateTime CreationDate { get; }
    DateTime RevisionDate { get; }
}