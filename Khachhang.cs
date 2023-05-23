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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
        private void LoadTable()
        {
            string sqlStr = "SELECT * FROM KHACHHANG";
            SqlDataAdapter db = new SqlDataAdapter(sqlStr, conn);
            DataSet myDataSet = new DataSet();
            db.Fill(myDataSet, "KHACHHANG");
            DataTable myTable = myDataSet.Tables["KHACHHANG"];
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = myTable;
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();  
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlInsert = "INSERT INTO KHACHHANG VALUES(@MAKH,@HOTEN,@NGAYSINH,@DIACHI,@DIENTHOAI,@EMAIL)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("MAKH", txtMKH.Text);
                cmd.Parameters.AddWithValue("HOTEN", txtTenKH.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", dtpKH.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.ExecuteNonQuery();
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDel = "DELETE FROM KHACHHANG WHERE MAKH=@MAKH";
                SqlCommand cmd = new SqlCommand(sqlDel, conn);
                cmd.Parameters.AddWithValue("MAKH", txtMKH.Text);
                cmd.Parameters.AddWithValue("HOTEN", txtTenKH.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", dtpKH.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.ExecuteNonQuery();
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlEdit = "UPDATE KHACHHANG SET HOTEN=@HOTEN,NGAYSINH=@NGAYSINH,DIACHI=@DIACHI,DIENTHOAI=@DIENTHOAI,EMAIL=@EMAIL WHERE MAKH=@MAKH";
                SqlCommand cmd = new SqlCommand(sqlEdit, conn);
                cmd.Parameters.AddWithValue("MAKH", txtMKH.Text);
                cmd.Parameters.AddWithValue("HOTEN", txtTenKH.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", dtpKH.Value.ToString());
                cmd.Parameters.AddWithValue("DIACHI", txtAddress.Text);
                cmd.Parameters.AddWithValue("DIENTHOAI", txtPhone.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.ExecuteNonQuery();
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Bạn nhập thông tin không đầy đủ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtMKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            dtpKH.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtPhone.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMKH.Text = " ";
            txtTenKH.Text = " ";
            
            txtAddress.Text = " ";
            txtPhone.Text = " ";
            txtEmail.Text = " ";
        }
    }
}
