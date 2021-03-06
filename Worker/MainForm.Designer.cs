
namespace Worker
{
    partial class MainForm
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.btnLoadBundle = new System.Windows.Forms.Button();
            this.gvAllBundle = new System.Windows.Forms.DataGridView();
            this.gvBundleDetails = new System.Windows.Forms.DataGridView();
            this.btnAddNewBundle = new System.Windows.Forms.Button();
            this.btnAddNewBundleBundle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllBundle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBundleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(815, 553);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(86, 31);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // btnLoadBundle
            // 
            this.btnLoadBundle.Location = new System.Drawing.Point(81, 16);
            this.btnLoadBundle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadBundle.Name = "btnLoadBundle";
            this.btnLoadBundle.Size = new System.Drawing.Size(206, 31);
            this.btnLoadBundle.TabIndex = 1;
            this.btnLoadBundle.Text = "Load All Bundle with Details";
            this.btnLoadBundle.UseVisualStyleBackColor = true;
            this.btnLoadBundle.Click += new System.EventHandler(this.LoadBundle_Click);
            // 
            // gvAllBundle
            // 
            this.gvAllBundle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllBundle.Location = new System.Drawing.Point(14, 76);
            this.gvAllBundle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvAllBundle.Name = "gvAllBundle";
            this.gvAllBundle.RowHeadersWidth = 51;
            this.gvAllBundle.RowTemplate.Height = 25;
            this.gvAllBundle.Size = new System.Drawing.Size(314, 200);
            this.gvAllBundle.TabIndex = 2;
            this.gvAllBundle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAllBundle_CellDoubleClick);
            // 
            // gvBundleDetails
            // 
            this.gvBundleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBundleDetails.Location = new System.Drawing.Point(413, 76);
            this.gvBundleDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvBundleDetails.Name = "gvBundleDetails";
            this.gvBundleDetails.RowHeadersWidth = 51;
            this.gvBundleDetails.RowTemplate.Height = 25;
            this.gvBundleDetails.Size = new System.Drawing.Size(494, 200);
            this.gvBundleDetails.TabIndex = 3;
            // 
            // btnAddNewBundle
            // 
            this.btnAddNewBundle.Location = new System.Drawing.Point(81, 304);
            this.btnAddNewBundle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewBundle.Name = "btnAddNewBundle";
            this.btnAddNewBundle.Size = new System.Drawing.Size(206, 32);
            this.btnAddNewBundle.TabIndex = 4;
            this.btnAddNewBundle.Text = "Add New Bundle";
            this.btnAddNewBundle.UseVisualStyleBackColor = true;
            this.btnAddNewBundle.Click += new System.EventHandler(this.AddNewBundle_Click);
            // 
            // btnAddNewBundleBundle
            // 
            this.btnAddNewBundleBundle.Location = new System.Drawing.Point(574, 304);
            this.btnAddNewBundleBundle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewBundleBundle.Name = "btnAddNewBundleBundle";
            this.btnAddNewBundleBundle.Size = new System.Drawing.Size(238, 31);
            this.btnAddNewBundleBundle.TabIndex = 5;
            this.btnAddNewBundleBundle.Text = "Add New Bundle Bundle";
            this.btnAddNewBundleBundle.UseVisualStyleBackColor = true;
            this.btnAddNewBundleBundle.Click += new System.EventHandler(this.AddNewBundleDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "To excute Applcaition bundle please double click the bundle from bundle table";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewBundleBundle);
            this.Controls.Add(this.btnAddNewBundle);
            this.Controls.Add(this.gvBundleDetails);
            this.Controls.Add(this.gvAllBundle);
            this.Controls.Add(this.btnLoadBundle);
            this.Controls.Add(this.btnTest);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvAllBundle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBundleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLoadBundle;
        private System.Windows.Forms.DataGridView gvAllBundle;
        private System.Windows.Forms.DataGridView gvBundleDetails;
        private System.Windows.Forms.Button btnAddNewBundle;
        private System.Windows.Forms.Button btnAddNewBundleBundle;
        private System.Windows.Forms.Label label1;
    }
}