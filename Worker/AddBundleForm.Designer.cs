
namespace Worker
{
    partial class AddBundleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBundleName = new System.Windows.Forms.Label();
            this.txtBundleName = new System.Windows.Forms.TextBox();
            this.btnAddBundle = new System.Windows.Forms.Button();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.lblProcessCommand = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.txtProcessCommand = new System.Windows.Forms.TextBox();
            this.btnAddbundleDetails = new System.Windows.Forms.Button();
            this.cobxBundle = new System.Windows.Forms.ComboBox();
            this.lblCoBxBundleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBundleName
            // 
            this.lblBundleName.AutoSize = true;
            this.lblBundleName.Location = new System.Drawing.Point(12, 39);
            this.lblBundleName.Name = "lblBundleName";
            this.lblBundleName.Size = new System.Drawing.Size(79, 15);
            this.lblBundleName.TabIndex = 0;
            this.lblBundleName.Text = "Bundle Name";
            // 
            // txtBundleName
            // 
            this.txtBundleName.Location = new System.Drawing.Point(122, 36);
            this.txtBundleName.Name = "txtBundleName";
            this.txtBundleName.Size = new System.Drawing.Size(158, 23);
            this.txtBundleName.TabIndex = 1;
            // 
            // btnAddBundle
            // 
            this.btnAddBundle.Location = new System.Drawing.Point(454, 36);
            this.btnAddBundle.Name = "btnAddBundle";
            this.btnAddBundle.Size = new System.Drawing.Size(162, 23);
            this.btnAddBundle.TabIndex = 2;
            this.btnAddBundle.Text = "Add Bundle";
            this.btnAddBundle.UseVisualStyleBackColor = true;
            this.btnAddBundle.Click += new System.EventHandler(this.BtnAddBundle_Click);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(9, 237);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(82, 15);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Process Name";
            // 
            // lblProcessCommand
            // 
            this.lblProcessCommand.AutoSize = true;
            this.lblProcessCommand.Location = new System.Drawing.Point(9, 280);
            this.lblProcessCommand.Name = "lblProcessCommand";
            this.lblProcessCommand.Size = new System.Drawing.Size(107, 15);
            this.lblProcessCommand.TabIndex = 4;
            this.lblProcessCommand.Text = "Process Command";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(122, 237);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(158, 23);
            this.txtProcessName.TabIndex = 5;
            // 
            // txtProcessCommand
            // 
            this.txtProcessCommand.Location = new System.Drawing.Point(122, 280);
            this.txtProcessCommand.Name = "txtProcessCommand";
            this.txtProcessCommand.Size = new System.Drawing.Size(158, 23);
            this.txtProcessCommand.TabIndex = 6;
            // 
            // btnAddbundleDetails
            // 
            this.btnAddbundleDetails.Location = new System.Drawing.Point(454, 272);
            this.btnAddbundleDetails.Name = "btnAddbundleDetails";
            this.btnAddbundleDetails.Size = new System.Drawing.Size(162, 23);
            this.btnAddbundleDetails.TabIndex = 7;
            this.btnAddbundleDetails.Text = "Add bundle Details";
            this.btnAddbundleDetails.UseVisualStyleBackColor = true;
            this.btnAddbundleDetails.Click += new System.EventHandler(this.btnAddbundleDetails_Click);
            // 
            // cobxBundle
            // 
            this.cobxBundle.FormattingEnabled = true;
            this.cobxBundle.Location = new System.Drawing.Point(122, 319);
            this.cobxBundle.Name = "cobxBundle";
            this.cobxBundle.Size = new System.Drawing.Size(158, 23);
            this.cobxBundle.TabIndex = 8;
            // 
            // lblCoBxBundleName
            // 
            this.lblCoBxBundleName.AutoSize = true;
            this.lblCoBxBundleName.Location = new System.Drawing.Point(13, 326);
            this.lblCoBxBundleName.Name = "lblCoBxBundleName";
            this.lblCoBxBundleName.Size = new System.Drawing.Size(79, 15);
            this.lblCoBxBundleName.TabIndex = 9;
            this.lblCoBxBundleName.Text = "Bundle Name";
            // 
            // AddBundleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCoBxBundleName);
            this.Controls.Add(this.cobxBundle);
            this.Controls.Add(this.btnAddbundleDetails);
            this.Controls.Add(this.txtProcessCommand);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.lblProcessCommand);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.btnAddBundle);
            this.Controls.Add(this.txtBundleName);
            this.Controls.Add(this.lblBundleName);
            this.Name = "AddBundleForm";
            this.Text = "AddBundleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBundleName;
        private System.Windows.Forms.TextBox txtBundleName;
        private System.Windows.Forms.Button btnAddBundle;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Label lblProcessCommand;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.TextBox txtProcessCommand;
        private System.Windows.Forms.Button btnAddbundleDetails;
        public System.Windows.Forms.ComboBox cobxBundle;
        private System.Windows.Forms.Label lblCoBxBundleName;
    }
}