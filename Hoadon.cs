using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI_STORE
{
    public partial class Hoadon : Form
    {
       
        public Hoadon()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
        private void comboboxload()
        {
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT MASP FROM SANPHAM2", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboMaHang.Items.Add(dr["MASP"].ToString());
                comboMaHang.DisplayMember = (dr["MASP"].ToString());
            }
            if (conn.State == 0)
            {
                conn.Close();
            }
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
            comboboxload();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                n = dgvCTHD.Rows.Add();
                dgvCTHD.Rows[n].Cells[0].Value = comboMaHang.Text;
                dgvCTHD.Rows[n].Cells[1].Value = txtTenHang.Text;
                dgvCTHD.Rows[n].Cells[2].Value = numerSoLuong.Value;
                dgvCTHD.Rows[n].Cells[3].Value = txtDongia.Text;
                dgvCTHD.Rows[n].Cells[4].Value = Convert.ToDouble(txtDongia.Text) * Convert.ToDouble(numerSoLuong.Value);
                double tongtien = 0;
                int x = dgvCTHD.Rows.Count;
                for (int i = 0; i < x; i++)
                {
                    tongtien = tongtien + Convert.ToDouble(dgvCTHD.Rows[i].Cells[4].Value);
                }
                txtTongtien.Text = tongtien.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            int n = dgvCTHD.CurrentRow.Index;
            dgvCTHD.Rows.RemoveAt(n);
            double tongtien = 0;
            int y = dgvCTHD.Rows.Count;
            for (int i = 0; i < y; i++)
            {
                tongtien = -(Convert.ToDouble(dgvCTHD.Rows[i].Cells[4].Value)) - tongtien;
            }
            txtTongtien.Text = tongtien.ToString();
        }

        

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvCTHD.CurrentRow.Index;
            comboMaHang.Text = dgvCTHD.Rows[n].Cells[0].Value.ToString();
            txtTenHang.Text = dgvCTHD.Rows[n].Cells[1].Value.ToString();
            numerSoLuong.Value = Convert.ToDecimal(dgvCTHD.Rows[n].Cells[2].Value.ToString());
            txtDongia.Text = dgvCTHD.Rows[n].Cells[3].Value.ToString();
            txtThanhtien.Text = dgvCTHD.Rows[n].Cells[4].Value.ToString();
            numerSoLuong.Maximum = numerSoLuong.Maximum - numerSoLuong.Value;
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                string SQl = "INSERT INTO HOADON VALUES(@MAHD,@NGHD,@MAKH,@MANV,@TONGTIEN)";
                SqlCommand cmd = new SqlCommand(SQl, conn);
                cmd.Parameters.AddWithValue("MAHD", txtmhd.Text);
                cmd.Parameters.AddWithValue("NGHD", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("MAKH", txtKH.Text);
                cmd.Parameters.AddWithValue("MANV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("TONGTIEN", txtTongtien.Text);
                cmd.ExecuteNonQuery();

                if (txtTenHang.Text != "")
                {
                    string Sql = "INSERT INTO CTHD VALUES(@MAHD,@MASP,@TENSP,@DONGIA,@SL,@THANHTIEN)";
                    SqlCommand cmd2 = new SqlCommand(Sql, conn);
                    cmd2.Parameters.AddWithValue("MAHD", txtmhd.Text);
                    cmd2.Parameters.AddWithValue("MASP", comboMaHang.Text);
                    cmd2.Parameters.AddWithValue("TENSP", txtTenHang.Text);
                    cmd2.Parameters.AddWithValue("SL", numerSoLuong.Value);
                    cmd2.Parameters.AddWithValue("DONGIA", txtDongia.Text);
                    cmd2.Parameters.AddWithValue("THANHTIEN", txtThanhtien.Text);
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Nhập hóa đơn thành công.","Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không nhập đầy đủ tính năng!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numerSoLuong_ValueChanged(object sender, EventArgs e)
        {
            double sl;
            double dg;
            double tt;
            sl = Convert.ToDouble(numerSoLuong.Value);
            dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }

        private void comboMaHang_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select TENSP,SOLUONG,DONGIA from SANPHAM2 where MASP = '" + comboMaHang.Text + "'", conn);
            SqlDataReader ka = cmd.ExecuteReader();
            while (ka.Read())
            {
                txtTenHang.Text = ka.GetValue(0).ToString();
                
                numerSoLuong.Maximum = Convert.ToInt32(ka.GetValue(2));
                txtDongia.Text = ka.GetValue(2).ToString();
            }
            numerSoLuong.Value = 0;
            txtThanhtien.Text = "";
            if (conn.State == 0)
            {
                conn.Close();
            }
        }

        private void comboMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporthd rphd = new Reporthd();
            rphd.ShowDialog();
        }
       
    }
}
