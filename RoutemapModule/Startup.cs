using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.BackgroundTasks;
using OrchardCore.Modules;
using System;
namespace RoutemapModule
{
  public  class Startup : StartupBase
    {
        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                    name: "RoutemapModule",
                    areaName: "RoutemapModule",
                    pattern: "RoutemapModule/Test/Index",
                    defaults: new { controller = "Test", action = "Index" }
                );
        }
        public override void ConfigureServices(IServiceCollection services)
        {
            
       

        }
    }
}
