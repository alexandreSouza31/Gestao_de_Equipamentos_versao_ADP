﻿namespace GestaoDeEquipamentos.WebApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseRouting();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
