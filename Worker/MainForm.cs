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
using WindowsFormsNetCore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Worker
{
    public partial class MainForm : Form
    {

        private readonly ISampleService _sameplSerivce;
        private readonly IConfiguration _configuration;
        private readonly AppSettings _settings;

        public MainForm(ISampleService sameplSerivce, IConfiguration configuration, IOptions<AppSettings> settings)
        {
            InitializeComponent();
            _sameplSerivce = sameplSerivce;
            _configuration = configuration;
            _settings = settings.Value;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {

            label1.Text = _sameplSerivce.GetCurrentDate();
            var tes = _settings.WorkerDb;

            //Test for static path
            List<Process> processes = new List<Process>();

            Process externalProcess1 = new Process
            {
                StartInfo = { FileName = "Notepad.exe", WindowStyle = ProcessWindowStyle.Maximized }
            };
            Process externalProcess2 = new Process
            {
                StartInfo = { FileName = "https://www.google.com/", UseShellExecute = true }
            };
            processes.Add(externalProcess1);
            processes.Add(externalProcess2);


            using (var opnDlg = new OpenFileDialog()) //ANY dialog
            {
                //opnDlg.Filter = "Png Files (*.png)|*.png";
                //opnDlg.Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx|CSV Files (*.csv)|*.csv"

                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    Process externalProcess3 = new Process
                    {
                        
                        StartInfo = {   FileName = opnDlg.FileName, WindowStyle = ProcessWindowStyle.Maximized,UseShellExecute = true}
                    };
                    processes.Add(externalProcess3);
                }
            }

            Process externalProcess4 = new Process
            {
                StartInfo = { FileName = "https://www.github.com/", UseShellExecute = true }
            };
            processes.Add(externalProcess4);
            foreach (var externalProcess in processes)
            {
                externalProcess.Start();
            }

        }
    }
}
