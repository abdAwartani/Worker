using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worker.Data;
using Worker.Services;

namespace Worker
{
    public partial class AddBundleForm : Form
    {
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler refreshMainForm;
        private readonly IWorkerService _workerService;

        public AddBundleForm(IWorkerService workerService)
        {
            InitializeComponent();
            _workerService = workerService;
        }

        private void BtnAddBundle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBundleName.Text)) MessageBox.Show("fill bundle name first!");

            Bundle bundle = new Bundle() { Name = txtBundleName.Text };
            _workerService.AddBundle(bundle);
            this.Close();
            refreshMainForm(this, e);

        }

        public void SetFormPropert(Enums.AddbundleMode addBundleMode)
        {
            txtBundleName.Text = string.Empty;
            txtProcessCommand.Text = string.Empty;
            txtProcessName.Text = string.Empty;

            switch (addBundleMode)
            {
                case Enums.AddbundleMode.AddBundel:
                    txtBundleName.Enabled = true;
                    btnAddBundle.Enabled = true;

                    cobxBundle.Enabled = false;
                    txtProcessCommand.Enabled = false;
                    txtProcessName.Enabled = false;
                    btnAddbundleDetails.Enabled = false;

                    break;
                case Enums.AddbundleMode.AddBundelDetails:
                    txtBundleName.Enabled = false;
                    btnAddBundle.Enabled = false;

                    cobxBundle.Enabled = true;
                    txtProcessCommand.Enabled = true;
                    txtProcessName.Enabled = true;
                    btnAddbundleDetails.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        private void btnAddbundleDetails_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtBundleName.Text)) MessageBox.Show("fill bundle name first!");

            BundleDetail bundleDet = new BundleDetail() { Name = txtBundleName.Text, ProcessName = txtProcessCommand.Text, BundleId = (int)cobxBundle.SelectedItem };
            _workerService.AddBundleDetails(bundleDet);
            this.Close();

            refreshMainForm(this, e);
        }
        protected override void OnClosed(EventArgs e)
        {
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
