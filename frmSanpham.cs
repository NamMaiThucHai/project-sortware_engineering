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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
        private void HienThi_Load()
        {
            string DBStr = "SELECT * FROM SANPHAM2";
            SqlDataAdapter db = new SqlDataAdapter(DBStr, conn);
            DataSet MyDataSet = new DataSet();
            db.Fill(MyDataSet, "SANPHAM2");
            DataTable MyTable = MyDataSet.Tables["SANPHAM2"];
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = MyTable;

        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi_Load();
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSanPham.SelectedRows[0];

            txtMaSP.Text = row.Cells[0].Value.ToString();
            txtTenSP.Text = row.Cells[1].Value.ToString();
            txtDVT.Text = row.Cells[2].Value.ToString();
            txtNX.Text = row.Cells[3].Value.ToString();
            txtSL.Text = row.Cells[4].Value.ToString();
            txtGiaSP.Text = row.Cells[5].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtDVT.Text != "" && txtNX.Text != "" && txtSL.Text != "" && txtGiaSP.Text != "")
                {
                    string sqlINSERT = "INSERT INTO SANPHAM2 VALUES(@MASP,@TENSP,@DVT,@NUOCSX,@SOLUONG,@DONGIA)";
                    SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                    cmd.Parameters.AddWithValue("MASP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("TENSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("DVT", txtDVT.Text);
                    cmd.Parameters.AddWithValue("NUOCSX", txtNX.Text);
                    cmd.Parameters.AddWithValue("SOLUONG", txtSL.Text);
                    cmd.Parameters.AddWithValue("DONGIA", txtGiaSP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    HienThi_Load();

                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ các thông tin sản phẩm!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
          try
            {
                string sqldel = "DELETE FROM SANPHAM2 WHERE MASP=@MASP";
                SqlCommand cmd = new SqlCommand(sqldel, conn);
                cmd.Parameters.AddWithValue("MASP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("TENSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("DVT", txtDVT.Text);
                cmd.Parameters.AddWithValue("NUOCSX", txtNX.Text);
                cmd.Parameters.AddWithValue("SOLUONG", txtSL.Text);
                cmd.Parameters.AddWithValue("DONGIA", txtGiaSP.Text);
                cmd.ExecuteNonQuery();
                HienThi_Load();
            }
            catch (Exception)
            {

              MessageBox.Show("Hãy chọn sản phẩm muốn xóa");

            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtDVT.Text != "" && txtNX.Text != "" && txtSL.Text != "" && txtGiaSP.Text != "")
                {
                    string sqlINSERT = "UPDATE SANPHAM2 SET TENSP=@TENSP,DVT=@DVT,NUOCSX=@NUOCSX,SOLUONG=@SOLUONG,DONGIA=@DONGIA WHERE MASP=@MASP";
                    SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                    cmd.Parameters.AddWithValue("MASP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("TENSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("DVT", txtDVT.Text);
                    cmd.Parameters.AddWithValue("NUOCSX", txtNX.Text);
                    cmd.Parameters.AddWithValue("SOLUONG", txtSL.Text);
                    cmd.Parameters.AddWithValue("DONGIA", txtGiaSP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    HienThi_Load();

                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn sửa");
            }


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtDVT.Clear();
            txtGiaSP.Clear();
            txtMaSP.Clear();
            txtNX.Clear();
            txtSL.Clear();
            txtTenSP.Clear();
            txtMaSP.Focus();
        }
    }
}
