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
    public partial class frmLogin : Form
    {
        public static string UserName = "";
        private int dem = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtPassword.PasswordChar = (char)0;
                
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Login_May";
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Connection = conn;
                UserName = txtUsername.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    this.Hide();
                    Welcome welcome = new Welcome();
                    welcome.ShowDialog();
                }
                else if (code == 2)
                {
                    lbcheck.Text ="Tài khoản hoặc mật khẩu không đúng !!";
                    dem++;
                    
                    if(dem >= 3)
                    {
                        MessageBox.Show("Bạn đã đăng nhập quá 3 lần. Vui lòng nhấn Quên mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dem++;

                    if(dem == 3)
                    {
                        Application.Exit();
                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmChangePasscs change = new frmChangePasscs();
            change.ShowDialog();  
        }
    }
}
