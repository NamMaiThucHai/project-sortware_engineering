using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_SANPHAM
    {
        private string _SANPHAM_MASP;
        private string _SANPHAM_TENSP;
        private string _SANPHAM_DVT;
        private string _SANPHAM_SOLUONG;
        private string _SANPHAM_NUOCSX;
        private string _SANPHAM_DONGIA;

        public DTO_SANPHAM(string MASP, string TENSP, string DVT, string SOLUONG, string NUOCSX, string DONGIA)
        {
           this.SANPHAM_MASP = MASP;
           this.SANPHAM_TENSP = TENSP;
           this.SANPHAM_DVT = DVT;
           this.SANPHAM_SOLUONG = SOLUONG;
           this.SANPHAM_NUOCSX = NUOCSX;
           this.SANPHAM_DONGIA = DONGIA;
        }
        public DTO_SANPHAM()
        { }
        public string SANPHAM_MASP { get => _SANPHAM_MASP; set => _SANPHAM_MASP = value; }
        public string SANPHAM_TENSP { get => _SANPHAM_TENSP; set => _SANPHAM_TENSP = value; }
        public string SANPHAM_DVT { get => _SANPHAM_DVT; set => _SANPHAM_DVT = value; }
        public string SANPHAM_SOLUONG { get => _SANPHAM_SOLUONG; set => _SANPHAM_SOLUONG = value; }
        public string SANPHAM_NUOCSX { get => _SANPHAM_NUOCSX; set => _SANPHAM_NUOCSX = value; }
        public string SANPHAM_DONGIA { get => _SANPHAM_DONGIA; set => _SANPHAM_DONGIA = value; }
    }
}