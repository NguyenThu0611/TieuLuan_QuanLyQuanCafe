using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVienBLL
    {
        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public NhanVienBLL() { }

        public List<NhanVien> getData_byTime(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            List<NhanVien> lst = new List<NhanVien>();
            var tmp = data.getNhanVien_byDate(ngaybatdau, ngayketthuc);
            foreach (var item in tmp)
            {
                NhanVien ct = new NhanVien();
                ct.MaNV = item.MaNV;
                ct.TenNV = item.TenNV;
                ct.ThoiGianLam = item.ThoiGianLam;
                lst.Add(ct);
            }
            return lst;

        }

        public List<NhanVien> getData()
        {
            List<NhanVien> lst = new List<NhanVien>();
            var tmp = data.getNhanVien();
            foreach (var item in tmp)
            {
                NhanVien ct = new NhanVien();
                ct.MaNV = item.MaNV;
                ct.TenNV = item.TenNV;
                ct.ThoiGianLam = (double)item.Column1;
                lst.Add(ct);
            }
            return lst;
        }
    }
}
