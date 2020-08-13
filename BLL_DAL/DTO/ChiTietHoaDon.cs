using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.DTO
{
    public class ChiTietHoaDon
    {
        //cthdPC.MaHD, mhDC.TenMH_DC, mhDC.DonViTinh, cthdPC.SoLuong, cthdPC.DonGia, cthdPC.ThanhTien
        private string maHD;
        private string maSP;
        private string tenSP;
        private string donvitinh;
        private int soluong;
        private double dongia;
        private double thanhtien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }

        public ChiTietHoaDon(string maHD, string maSP, string tenSP, string donvitinh, int soluong, double dongia, double thanhtien)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donvitinh = donvitinh;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }

        public ChiTietHoaDon() { }
    }
}
