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

            string conn = String.Empty;
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            _configuration = builder.Build();

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
            //services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.AddDbContext<WorkerContext>(s => s.UseSqlServer(GetConnectionStringPath()), ServiceLifetime.Transient);
            services.AddScoped<IWorkerService, WorkerService>();

            services.AddSingleton<MainForm>();
            //services.AddTransient<SecondForm>();
        }

        private static string GetConnectionStringPath()
        {
            string executableName = Application.ExecutablePath;
            FileInfo executableFileInfo = new FileInfo(executableName);
            string parentName = executableFileInfo.Directory.Parent.FullName;
            string dbPath = string.Empty;
            if (parentName.Contains("bin\\Debug"))
            { 
                dbPath = parentName.Replace("bin\\Debug", "Data\\WorkerDB.mdf");
            }
            else
            {
                dbPath = parentName.Replace("bin\\Release", "Data\\WorkerDB.mdf");
            }
            string connectionString = string.Format(_configuration.GetConnectionString("WorkerDB"), dbPath);
            return connectionString;
        }
    }
}
