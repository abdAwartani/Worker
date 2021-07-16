using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void Execute()
        {
            foreach (var process in processes)
            {
                process.Start();
            }
        }
    }
}
