namespace GUI_STORE
{
    partial class FormHDHoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDHoadon));
            this.reportHoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportHoadon
            // 
            this.reportHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportHoadon.Location = new System.Drawing.Point(0, 0);
            this.reportHoadon.Name = "reportHoadon";
            this.reportHoadon.ServerReport.BearerToken = null;
            this.reportHoadon.Size = new System.Drawing.Size(1014, 899);
            this.reportHoadon.TabIndex = 0;
            // 
            // FormHDHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 899);
            this.Controls.Add(this.reportHoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHDHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHDHoadon";
            this.Load += new System.EventHandler(this.FormHDHoadon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportHoadon;
    }
}