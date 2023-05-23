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

namespace GUI_STORE
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
        private void HienThi_Load()
        {
            string DBStr = "SELECT * FROM NHANVIEN1";
            SqlDataAdapter db = new SqlDataAdapter(DBStr, conn);
            DataSet MyDataSet = new DataSet();
            db.Fill(MyDataSet, "NHANVIEN1");
            DataTable MyTable = MyDataSet.Tables["NHANVIEN1"];
            dgvNhanvien.AutoGenerateColumns = false;
            dgvNhanvien.DataSource = MyTable;

        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "INSERT INTO NHANVIEN1 VALUES(@MANV,@HOTENNV,@GIOITINH,@NGAYSINH,@DIACHI,@DIENTHOAI,@TENLOAINV,@NGAYVL,@TENDN,@MATKHAU)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("MANV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("HOTENNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("GIOITINH", cbxGT.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", DTPNV.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("TENLOAINV", cbxLNV.Text);
                cmd.Parameters.AddWithValue("NGAYVL", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("TENDN", txtDN.Text);
                cmd.Parameters.AddWithValue("MATKHAU", txtMK.Text);
                cmd.ExecuteNonQuery();
                HienThi_Load();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUPDATE = " UPDATE NHANVIEN1 SET HOTENNV=@HOTENNV,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,DIACHI=@DIACHI,DIENTHOAI=@DIENTHOAI,TENLOAINV=@TENLOAINV,NGAYVL=@NGAYVL,TENDN=@TENDN,MATKHAU=@MATKHAU WHERE MANV=@MANV";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
                cmd.Parameters.AddWithValue("MANV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("HOTENNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("GIOITINH", cbxGT.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", DTPNV.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("TENLOAINV", cbxLNV.Text);
                cmd.Parameters.AddWithValue("NGAYVL", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("TENDN", txtDN.Text);
                cmd.Parameters.AddWithValue("MATKHAU", txtMK.Text);
                cmd.ExecuteNonQuery();
                HienThi_Load();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDELETE = "DELETE FROM NHANVIEN1 WHERE MANV=@MANV";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("MANV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("HOTENNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("GIOITINH", cbxGT.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", DTPNV.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("TENLOAINV", cbxLNV.Text);
                cmd.Parameters.AddWithValue("NGAYVL", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("TENDN", txtDN.Text);
                cmd.Parameters.AddWithValue("MATKHAU", txtMK.Text);
                cmd.ExecuteNonQuery();
                HienThi_Load();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanvien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanvien.SelectedRows[0];

            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            cbxGT.Text = row.Cells[2].Value.ToString();
            DTPNV.Text = row.Cells[3].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value.ToString();
            cbxLNV.Text = row.Cells[6].Value.ToString();
            dateTimePicker1.Text = row.Cells[7].Value.ToString();
            txtDN.Text = row.Cells[8].Value.ToString();
            txtMK.Text = row.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtMaNV.Text = " ";
            txtTenNV.Text = " ";
            txtAddress.Text = " ";
            txtPhone.Text = " ";
            txtDN.Text = " ";
            txtMK.Text = " ";
            txtMaNV.Focus();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi_Load();
        }
    }
}
