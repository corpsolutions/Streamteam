// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Identity.Core.Entities;

public interface ITableObject<T> where T : IEquatable<T>
{
    T Id { get; set; }
    void SetNewId();
}