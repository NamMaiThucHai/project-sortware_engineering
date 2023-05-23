using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace DAO_QLBH
{
    public class DAO_SANPHAM : dbConnection
    {
        public DataTable getSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM2", conn);
            DataTable dtSanPham = new DataTable();
            da.Fill(dtSanPham);
            return dtSanPham;
        }
        public bool themSanPham(DTO_SANPHAM SP)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO SANPHAM2(MASP,TENSP,DVT,SOLUONG,NUOCSX,DONGIA) VALUES('{0}','{1}','{2}', '{3}','{4}','{5}')",SP.SANPHAM_MASP,SP.SANPHAM_TENSP,SP.SANPHAM_DVT,SP.SANPHAM_SOLUONG,SP.SANPHAM_NUOCSX,SP.SANPHAM_DONGIA);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close(); 
            }
            return false;
        }
        public bool suaSanPham(DTO_SANPHAM SP)
        {
            try
            {
                
                conn.Open();
               

              string SQL = string.Format("UPDATE SANPHAM2 SET TENSP = '{0}',DVT = '{1}', SOLUONG = '{2}', NUOCSX = '{3}', DONGIA = '{4}' WHERE MASP = '{5}'",SP.SANPHAM_TENSP, SP.SANPHAM_DVT, SP.SANPHAM_SOLUONG, SP.SANPHAM_NUOCSX, SP.SANPHAM_DONGIA,SP.SANPHAM_MASP);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception )
            {
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }
        public bool xoaSanPham(string MASP)
        {
            try
            {
                // Ket noi
                conn.Open();
              
                string SQL = string.Format("DELETE FROM SANPHAM2 WHERE MASP = '{0}'", MASP);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception )
            {
                
            }
            finally
            {
               
                conn.Close();
            }
            return false;
        }
    }
    
}

