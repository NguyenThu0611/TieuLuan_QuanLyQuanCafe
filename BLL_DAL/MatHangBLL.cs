using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL_DAL
{
    public class MatHangBLL
    {
        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public MatHangBLL() { }

        public bool isMatHangDongChai(string mamh)
        {
            MatHang_DongChai mhdc = data.MatHang_DongChais.Where(c => c.MaMH_DC.Equals(mamh)).FirstOrDefault();
            if (mhdc != null)
                return true;
            else
                return false;
        }

        public bool isMatHangPhaChe(string mamh)
        {
            MatHang_PC mhpc = data.MatHang_PCs.Where(c => c.MaMH_PC.Equals(mamh)).FirstOrDefault();
            if (mhpc != null)
                return true;
            else
                return false;
        }

        public string getMaxIDCTHD_DC()
        {
            string macthd_dc = data.ChiTietHoaDon_DongChais.OrderBy(m => m.MaCTHD_DC).Select(s => s.MaCTHD_DC).Max();
            return macthd_dc;
        }

        public string getMaxIDCTHD_PC()
        {
            string macthd_pc = data.ChiTietHoaDon_PhaChes.OrderBy(m => m.MaCTHD_PC).Select(s => s.MaCTHD_PC).Max();
            return macthd_pc;
        }

        public double getDonGia_byMaMH_PC(string mamh)
        {
            MatHang_PC dongia = data.MatHang_PCs.Where(m => m.MaMH_PC.Equals(mamh)).FirstOrDefault();
            return Convert.ToDouble(dongia.DonGia);
        }

        public double getDonGia_byMaMH_DC(string mamh)
        {
            MatHang_DongChai dongia = data.MatHang_DongChais.Where(m => m.MaMH_DC.Equals(mamh)).FirstOrDefault();
            return Convert.ToDouble(dongia.DonGia);
        }

        public string getDonViTinh_byMaMH_PC(string mamh)
        {
            MatHang_PC dongia = data.MatHang_PCs.Where(m => m.MaMH_PC.Equals(mamh)).FirstOrDefault();
            return dongia.DonViTinh;
        }

        public string getDonViTinh_byMaMH_DC(string mamh)
        {
            MatHang_DongChai dongia = data.MatHang_DongChais.Where(m => m.MaMH_DC.Equals(mamh)).FirstOrDefault();
            return dongia.DonViTinh;
        }

    }
}
