﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace GUI_STORE
{
    public partial class ReportLogin : Form
    {
        public ReportLogin()
        {
            InitializeComponent();
        }

        private void ReportLogin_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_STORE.rptHuongdanlogin.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Lỗi phần mềm");
            }
        }
    }
}
