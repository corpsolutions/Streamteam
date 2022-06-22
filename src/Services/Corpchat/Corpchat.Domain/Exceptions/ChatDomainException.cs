// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.Corpchat.Domain.Exceptions;

public class ChatDomainException : Exception
{
    public ChatDomainException()
    {
    }

    public ChatDomainException(string message) : base(message)
    {
    }

    public ChatDomainException(string message, Exception exception) : base(message, exception)
    {
    }
}