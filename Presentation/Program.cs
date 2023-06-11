using App.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows.Forms.Design;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
           // Application.Run(new MainForm());

    //        // Configure DI container
    //        var services = new ServiceCollection();
    //        services.AddScoped<IBookRepository, BookRepository>();
    //        services.AddScoped<BookService>();
    //        services.AddDbContext<AppDbContext>(option =>
    //option.UseSqlServer("Server=localhost;Database=Taks10;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));

    //        // Register your forms, if needed
    //        services.AddTransient<MainForm>();

    //        var serviceProvider = services.BuildServiceProvider();

    //        // Resolve your main form from the DI container
    //        using (var scope = serviceProvider.CreateScope())
    //        {
    //            var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
    //            Application.Run(mainForm);
    //        }

            //from there
            var host = Host.CreateDefaultBuilder()
           .ConfigureServices((_, services) =>
           {
               services.AddDbContext<AppDbContext>(options =>
               {
                   options.UseSqlServer("Server=localhost;Database=Taks10;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
               });

               services.AddScoped<IBookRepository, BookRepository>();
               services.AddScoped<BookService>();

               services.AddTransient<MainForm>(); // Replace Form1 with your main form class
           })
           .Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var serviceProvider = serviceScope.ServiceProvider;
                var dbContext = serviceProvider.GetRequiredService<AppDbContext>();

                // Apply any pending migrations
                dbContext.Database.Migrate();
            }

            Application.Run(host.Services.GetRequiredService<MainForm>()); // Replace Form1 with your main form class
        }
    }
}