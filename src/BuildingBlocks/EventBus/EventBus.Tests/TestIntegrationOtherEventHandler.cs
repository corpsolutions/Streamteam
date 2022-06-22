// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Corpsolution.Streamteam.EventBus.Tests;

public class TestIntegrationOtherEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
{
    public bool Handled { get; private set; }

    public TestIntegrationOtherEventHandler()
    {
        Handled = false;
    }

    public async Task Handle(TestIntegrationEvent @event)
    {
        Handled = true;
    }
}