using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Helpers
{
    public class ProcessManager
    {
        private List<Process> lstProcess = new List<Process>();

        public void AddProcess(string processName)
        {
            Process process = new Process
            {

                StartInfo = { FileName = processName, WindowStyle = ProcessWindowStyle.Maximized, UseShellExecute = true }
            };

            lstProcess.Add(process);
        }

        public void ExcecuteProcesses()
        {
            foreach (var process in lstProcess)
            {
                process.Start();
            } 
        }
    }
}
