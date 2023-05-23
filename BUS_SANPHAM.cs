using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QLBH;
using DTO_QLBH;
using System.Data;
using System.Data.SqlClient;

namespace BUS_QLBH
{
    public class BUS_SANPHAM
    {
        DAO_SANPHAM SANPHAM = new DAO_SANPHAM();
        public DataTable getSanPham()
        {
            return SANPHAM.getSanPham();
        }
        public bool themSanPham(DTO_SANPHAM SP)
        {
            return SANPHAM.themSanPham(SP);
        }
       
        public bool suaSanPham(DTO_SANPHAM SP)
        {
            return SANPHAM.suaSanPham(SP);
        }
        public bool xoaSanPham(string MASP)
        {
            return SANPHAM.xoaSanPham(MASP);
        }

    }
}
