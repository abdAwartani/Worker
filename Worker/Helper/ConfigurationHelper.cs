using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Worker.Helper
{
    
    public class ConfigurationHelper
    {
        private static IConfigurationRoot _configuration;

        public string this[string key] => _configuration[key];

        public ConfigurationHelper()
        {
            if (_configuration == null)
            {
                string conn = String.Empty;
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                _configuration = builder.Build();
            }
        }

        public string GetConnectionStringPath()
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
