var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TOIMS_API>("toims-api");

builder.Build().Run();
