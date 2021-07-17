using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Data;

namespace Worker.Helper
{
    public class ProcessExecuter
    {
        List<Process> processes = new List<Process>();

        public void AddProcess(string processCommand)
        {
            processes ??= new List<Process>();

            processes.Add(new Process()
            {

                StartInfo = { FileName = processCommand, WindowStyle = ProcessWindowStyle.Maximized, UseShellExecute = true }
            });
        }
        
        public void AddRangeProcess(List<BundleDetail> bundleDetails)
        {
            processes ??= new List<Process>();
            foreach (var bundle in bundleDetails)
            {
                processes.Add(new Process()
                {

                    StartInfo = { FileName = bundle.ProcessName, WindowStyle = ProcessWindowStyle.Maximized, UseShellExecute = true }
                });
            }
        }



        public void Execute()
        {
            foreach (var process in processes)
            {
                process.Start();
            }
        }
    }
}
