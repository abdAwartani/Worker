﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Worker.Data;
using Worker.Helper;
using Worker.Services;

namespace Worker
{
    public partial class MainForm : Form
    {
        private readonly IWorkerService _workerService;


        public MainForm(IWorkerService workerService)
        {
            InitializeComponent();
            _workerService = workerService;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {

            var db = _workerService.GetBundleWithDetails(1);

            //Test for static path
            List<Process> processes = new List<Process>();

            //Process externalProcess1 = new Process
            //{
            //    StartInfo = { FileName = "Notepad.exe", WindowStyle = ProcessWindowStyle.Maximized }
            //};
            //Process externalProcess2 = new Process
            //{
            //    StartInfo = { FileName = "https://www.google.com/", UseShellExecute = true }
            //};
            //processes.Add(externalProcess1);
            //processes.Add(externalProcess2);


            //using (var opnDlg = new OpenFileDialog()) //ANY dialog
            //{
            //    //opnDlg.Filter = "Png Files (*.png)|*.png";
            //    //opnDlg.Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx|CSV Files (*.csv)|*.csv"

            //    if (opnDlg.ShowDialog() == DialogResult.OK)
            //    {
            //        Process externalProcess3 = new Process
            //        {
                        
            //            StartInfo = {   FileName = opnDlg.FileName, WindowStyle = ProcessWindowStyle.Maximized,UseShellExecute = true}
            //        };
            //        processes.Add(externalProcess3);
            //    }
            //}

            //Process externalProcess4 = new Process
            //{
            //    StartInfo = { FileName = "https://www.github.com/", UseShellExecute = true }
            //};
            //processes.Add(externalProcess4);

            var bundles = db.BundleDetails.ToList();
            ProcessManager processManager = new ProcessManager();

            ProcessExecuter processExecuter = new ProcessExecuter();

            foreach (var bundle in bundles)
            {
                processExecuter.AddProcess(bundle.ProcessName);
            }
            processExecuter.Execute();

        }

        private void LoadBundle_Click(object sender, EventArgs e)
        {
            LoadAllBundleWithDetials();
        }

        private void LoadAllBundleWithDetials()
        {
            var bundles = _workerService.GetAllBundlesWithDetails();
            gvAllBundle.DataSource = bundles.Select(s => new {bundleId = s.Id, bundleName = s.Name}).ToList();
            gvBundleDetails.DataSource = bundles.SelectMany(s => s.BundleDetails).Select(d =>
                new {BundleName = bundles.FirstOrDefault(b => b.Id == d.BundleId).Name, processName = d.Name}).ToList();
        }
    }
}
