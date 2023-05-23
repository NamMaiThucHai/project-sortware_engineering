using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_STORE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Start();
           
        }
        private Form currentFromChild;
        string conStr = @"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True";
        private void OPenChildform(Form childForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btSanpham_Click(object sender, EventArgs e)
        {
            OPenChildform(new frmSanPham());
        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
            OPenChildform(new NHANVIEN());
        }

        private void btHoadon_Click(object sender, EventArgs e)
        {
            OPenChildform(new Hoadon());
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            OPenChildform(new Thongke());
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            OPenChildform(new Khachhang());
        }

        private void btDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Close();
            Admin adm = new Admin();
            adm.Owner = this;
            adm.Show();
            
            string Str = "SELECT HOTENNV FROM NHANVIEN1 WHERE NHANVIEN1.TENDN = '" + frmLogin.UserName + "'";
            SqlDataAdapter adap = new SqlDataAdapter(Str, conStr);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            lblTen.Text = dt.Rows[0][0].ToString();

            string DBStr = "SELECT * FROM HOATDONGDIABAN1";
            SqlDataAdapter Db = new SqlDataAdapter(DBStr, conStr);
            DataSet MyDataset = new DataSet();
            Db.Fill(MyDataset, "HOATDONGDIABAN1");
            DataTable myTable = MyDataset.Tables["HOATDONGDIABAN1"];
            dgvPhanCong.AutoGenerateColumns = false;
            dgvPhanCong.DataSource = myTable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          lblTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            frmChangePasscs chg = new frmChangePasscs();
            chg.Show();
        }

        private void btKhuyenMai_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportLogin rptlog = new ReportLogin();
            rptlog.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbChuchay.Text = lbChuchay.Text.Substring(1) + lbChuchay.Text[0];
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHDHoadon hd = new FormHDHoadon();
            hd.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
