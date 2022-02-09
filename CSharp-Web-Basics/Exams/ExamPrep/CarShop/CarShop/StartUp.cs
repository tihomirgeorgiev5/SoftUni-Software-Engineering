﻿namespace CarShop
{
    using MyWebServer;
    using CarShop.Data;
    using System.Threading.Tasks;
    using MyWebServer.Controllers;
    using MyWebServer.Results.Views;
    using Microsoft.EntityFrameworkCore;
    public class Startup
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers())
                .WithServices(services => services
                .Add<IViewEngine, CompilationViewEngine>()
                .Add<CarShopDbContext>())
                .WithConfiguration<CarShopDbContext>(context => context
                    .Database.Migrate())
                .Start();
    }
}
