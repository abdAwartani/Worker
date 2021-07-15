using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Worker.Data;
using Worker.Helper;
using Worker.Services;

namespace Worker
{
    static class Program
    {
        private static IConfigurationRoot _configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(context.Configuration, services);
                })
                .ConfigureLogging(logging =>
                {
                    // Add other loggers...
                })
                .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
        
        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            ConfigurationHelper _configuration = new ConfigurationHelper();
            
            services.AddDbContext<WorkerContext>(s => s.UseSqlServer(_configuration.GetConnectionStringPath()), ServiceLifetime.Transient);
            services.AddScoped<IWorkerService, WorkerService>();

            services.AddSingleton<MainForm>();
        }

        
    }
}
