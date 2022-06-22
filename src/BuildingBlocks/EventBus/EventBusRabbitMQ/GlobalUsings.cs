// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

global using System.Net.Sockets;
global using System.Text;
global using System.Text.Json;
global using Autofac;
global using Corpsolution.Streamteam.BuildingBlocks.EventBus;
global using Corpsolution.Streamteam.BuildingBlocks.EventBus.Abstractions;
global using Corpsolution.Streamteam.BuildingBlocks.EventBus.Events;
global using Corpsolution.Streamteam.BuildingBlocks.EventBus.Extensions;
global using Microsoft.Extensions.Logging;
global using Polly;
global using Polly.Retry;
global using RabbitMQ.Client;
global using RabbitMQ.Client.Events;
global using RabbitMQ.Client.Exceptions;