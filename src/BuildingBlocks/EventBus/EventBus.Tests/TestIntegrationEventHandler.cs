// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.EventBus.Tests;

public class TestIntegrationEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
{
    public bool Handled { get; private set; }

    public TestIntegrationEventHandler()
    {
        Handled = false;
    }

    public async Task Handle(TestIntegrationEvent @event)
    {
        Handled = true;
    }
}