// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();