using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_STORE
{
    public partial class FormHDHoadon : Form
    {
        public FormHDHoadon()
        {
            InitializeComponent();
        }

        private void FormHDHoadon_Load(object sender, EventArgs e)
        {
            try
            {
                reportHoadon.LocalReport.ReportEmbeddedResource = "GUI_STORE.rptHoadon.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportHoadon.LocalReport.DataSources.Add(reportDataSource);

                this.reportHoadon.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Lỗi phần mềm");
            }
            
        }
    }
}
