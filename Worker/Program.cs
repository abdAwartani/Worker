using System;
using System.Collections.Generic;
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
                //.ConfigureAppConfiguration((context, builder) =>
                //{
                //    builder.AddJsonFile("appsettings.local.json", optional: true);
                //})
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
            services.AddDbContext<WorkerContext>(s => s.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LP-AbdallahA\source\repos\Worker\Worker\WorkerDB.mdf;Integrated Security=True"), ServiceLifetime.Transient);
            services.AddScoped<IWorkerService, WorkerService>();

            services.AddSingleton<MainForm>();
            //services.AddTransient<SecondForm>();
        }
    }
}
