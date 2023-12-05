var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

builder.AddProject<Aspire.WheaterApi>("webfrontend")
    .WithReference(cache);

builder.Build().Run();
