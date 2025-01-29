var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.StatisticManager>("statisticmanager");

builder.Build().Run();
