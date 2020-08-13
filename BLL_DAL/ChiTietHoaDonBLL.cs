using BLL_DAL.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ChiTietHoaDonBLL
    {

        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        MatHangBLL mathangbll = new MatHangBLL();

        public string getHoaDonBy_Ban(string maban)
        {
            string maHD = "";
            HoaDon hoadon = data.HoaDons.Where(hd => hd.MaBan.Equals(maban) && hd.TinhTrang == false).FirstOrDefault();
            if (hoadon != null)
                maHD = hoadon.MaHD;
            return maHD;
        }

        public HoaDon getHoaDon_byBan(string maban)
        {
            HoaDon hoadon = data.HoaDons.Select(hd => hd).FirstOrDefault();
            return hoadon;
        }

        public List<ChiTietHoaDon> getChiTietHoaDonDongChai_byMaBan(string maban)
        {
            string mahoadon = getHoaDonBy_Ban(maban);
            //List<ChiTietHoaDon_DongChai> lstDongChai = data.ChiTietHoaDon_DongChais.Where(c => c.MaHD.Equals(mahoadon)).Select(s => s).ToList<ChiTietHoaDon_DongChai>();
            var lstDongChai = from cthdDC in data.ChiTietHoaDon_DongChais
                              join hd in data.HoaDons
                              on cthdDC.MaHD equals hd.MaHD
                              join mhDC in data.MatHang_DongChais
                              on cthdDC.MaMH_DC equals mhDC.MaMH_DC
                              where hd.MaBan.Equals(maban)
                              && hd.TinhTrang == false
                              select new { cthdDC.MaHD, mhDC.MaMH_DC, mhDC.TenMH_DC, mhDC.DonViTinh, cthdDC.SoLuong, cthdDC.DonGia, cthdDC.ThanhTien };

            List<ChiTietHoaDon> lstCTHD_DC = new List<ChiTietHoaDon>();
            foreach (var item in lstDongChai)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = item.MaHD;
                cthd.MaSP = item.MaMH_DC;
                cthd.TenSP = item.TenMH_DC;
                cthd.Soluong = item.SoLuong;
                cthd.Dongia = item.DonGia;
                cthd.Donvitinh = item.DonViTinh;
                cthd.Thanhtien = item.ThanhTien;
                lstCTHD_DC.Add(cthd);
            }
            return lstCTHD_DC;
        }

        public List<ChiTietHoaDon> getChiTietHoaDonPhaChe_byMaBan(string maban)
        {
            string mahoadon = getHoaDonBy_Ban(maban);
            //List<ChiTietHoaDon_PhaChe> lstCTPhaChe = data.ChiTietHoaDon_PhaChes.Where(c => c.MaHD.Equals(mahoadon)).Select(s => s).ToList<ChiTietHoaDon_PhaChe>();
            var lstCTPhaChe = from cthdPC in data.ChiTietHoaDon_PhaChes
                              join hd in data.HoaDons
                              on cthdPC.MaHD equals hd.MaHD
                              join mhPC in data.MatHang_PCs
                              on cthdPC.MaMH_PC equals mhPC.MaMH_PC
                              where hd.MaBan.Equals(maban)
                              && hd.TinhTrang == false
                              select new { cthdPC.MaHD, mhPC.MaMH_PC, mhPC.TenMH_PC, mhPC.DonViTinh, cthdPC.SoLuong, cthdPC.DonGia, cthdPC.ThanhTien };
            List<ChiTietHoaDon> lstCTHD_PC = new List<ChiTietHoaDon>();
            foreach (var item in lstCTPhaChe)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHD = item.MaHD;
                cthd.MaSP = item.MaMH_PC;
                cthd.TenSP = item.TenMH_PC;
                cthd.Soluong = item.SoLuong;
                cthd.Dongia = item.DonGia;
                cthd.Donvitinh = item.DonViTinh;
                cthd.Thanhtien = item.ThanhTien;
                lstCTHD_PC.Add(cthd);
            }
            return lstCTHD_PC;
        }

        public List<DTO.ChiTietHoaDon> getCTHoaDon(string maban)
        {
            List<ChiTietHoaDon> lstCTHD = getChiTietHoaDonDongChai_byMaBan(maban);
            List<ChiTietHoaDon> lstPhaChe = getChiTietHoaDonPhaChe_byMaBan(maban);

            foreach (ChiTietHoaDon sp in lstPhaChe)
            {
                lstCTHD.Add(sp);
            }
            return lstCTHD;
        }

        public bool kiemTraTonTaiTrongCTHD(string mahd, string mamh)
        {
            bool kq = true;
            if (mathangbll.isMatHangDongChai(mamh))
            {
                ChiTietHoaDon_DongChai ct = data.ChiTietHoaDon_DongChais.Where(s => s.MaHD.Equals(mahd) && s.MaMH_DC.Equals(mamh)).FirstOrDefault();
                if (ct != null)
                {
                    kq = true;
                }
                else
                    kq = false;
            }
            else if (mathangbll.isMatHangPhaChe(mamh))
            {
                ChiTietHoaDon_PhaChe ct = data.ChiTietHoaDon_PhaChes.Where(s => s.MaHD.Equals(mahd) && s.MaMH_PC.Equals(mamh)).FirstOrDefault();
                if (ct != null)
                {
                    kq = true;
                }
                else
                    kq = false;
            }
            else
                kq = false;
            return kq;
        }

        public void insertCTHD_DC(ChiTietHoaDon_DongChai cthd_dc)
        {
            data.ChiTietHoaDon_DongChais.InsertOnSubmit(cthd_dc);
            data.SubmitChanges();
        }

        public void insertCTHD_PC(ChiTietHoaDon_PhaChe cthd_pc)
        {
            data.ChiTietHoaDon_PhaChes.InsertOnSubmit(cthd_pc);
            data.SubmitChanges();
        }

        public void updateCTHD_DC(string mahd, string mamh, string soluong)
        {
            ChiTietHoaDon_DongChai ct = data.ChiTietHoaDon_DongChais.Where(c => c.MaHD.Equals(mahd) && c.MaMH_DC.Equals(mamh)).FirstOrDefault();
            int soluongmoi = ct.SoLuong + Convert.ToInt32(soluong);
            if(soluongmoi > 0)
            {
                ct.SoLuong = soluongmoi;
                ct.ThanhTien = soluongmoi * ct.DonGia;
                data.SubmitChanges();
            }
            else
            {
                data.ChiTietHoaDon_DongChais.DeleteOnSubmit(ct);
                data.SubmitChanges();
            }
        }

        public void updateCTHD_PC(string mahd, string mamh, string soluong)
        {
            ChiTietHoaDon_PhaChe ct = data.ChiTietHoaDon_PhaChes.Where(c => c.MaHD.Equals(mahd) && c.MaMH_PC.Equals(mamh)).FirstOrDefault();
            if (ct.SoLuong > 0)
            {
                int soluongmoi = ct.SoLuong + Convert.ToInt32(soluong);
                ct.SoLuong = soluongmoi;
                ct.ThanhTien = soluongmoi * ct.DonGia;
                data.SubmitChanges();
            }
            else
            {
                data.ChiTietHoaDon_PhaChes.DeleteOnSubmit(ct);
                data.SubmitChanges();
            }
        }

        public int getHauSoHoaDonMax()
        {
            int kq = 0;
            string hausoHD = data.HoaDons.OrderBy(m => m.MaHD).Select(s => s.MaHD).Max();

            if (hausoHD != null)
            {
                string hauso = hausoHD.Split('_')[1];
                kq = Convert.ToInt32(hauso);
            }
            return kq;
        }

        public void insertHoaDon(HoaDon hd)
        {
            data.HoaDons.InsertOnSubmit(hd);
            data.SubmitChanges();
        }

        public int deleteHoaDon(string mahd)
        {
            HoaDon hd = data.HoaDons.Where(c => c.MaHD.Equals(mahd)).FirstOrDefault();
            if(!hd.TinhTrang)
            {
                data.HoaDons.DeleteOnSubmit(hd);
                data.SubmitChanges();
                return 1;
            }
            return 0;
        }

        public int updateHoaDon(HoaDon hoadon)
        {
            HoaDon hd = data.HoaDons.Where(c => c.MaHD.Equals(hoadon.MaHD)).FirstOrDefault();
            if (hd != null)
            {
                hd.MaGiamGia = hoadon.MaGiamGia;
                hd.MaKH = hoadon.MaKH;
                hd.TongTien = hoadon.TongTien;
                hd.TinhTrang = hoadon.TinhTrang;
                hd.ThanhToan = hoadon.ThanhToan;
                data.SubmitChanges();
                return 1;
            }
            else
                return 0;
        }

        public bool? isThanhToan(string mahd)
        {
            HoaDon hd = data.HoaDons.Where(s => s.MaHD.Equals(mahd)).FirstOrDefault();
            return  hd.ThanhToan;
        }

        public int updateThanhToan(string maban, string mahd)
        {
            HoaDon hd = data.HoaDons.Where(h => h.MaHD == mahd && h.MaBan == maban && h.TinhTrang == false).FirstOrDefault();
            if(hd != null)
            {
                hd.ThanhToan = true;
                data.SubmitChanges();
                return 1;
            }
            return 0;
        }

        public int updateChuyenBan(string mabanhientai, string mabanchuyen)
        {
            string mahdbanmoi = getHoaDonBy_Ban(mabanchuyen);
            if (mahdbanmoi == null)
            {
                HoaDon hd = getHoaDon_byBan(mabanhientai);
                if (hd != null)
                {
                    hd.MaBan = mabanchuyen;
                    data.SubmitChanges();
                    return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
                
        }
    }
}
