using AppsettingsConfigurations;
using AppsettingsConfigurations.ConfigModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context,services) =>
    {
        services.Configure<PositionOptions>(context.Configuration.GetSection(PositionOptions.Position));
        services.AddSingleton<IWorkerService, WorkerService>();
    })
    .Build();

host.StartAsync();

var root = host.Services.GetService<IWorkerService>();

await root.StartProcess();
//var svc = ActivatorUtilities.CreateInstance<WorkerService>(host.Services);


//svc.StartProcess();