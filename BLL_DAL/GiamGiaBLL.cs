using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class GiamGiaBLL
    {
        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public GiamGiaBLL() { }

        public bool kiemTraGiamGia(DateTime ngaydung, string magiamgia)
        {
            GiamGia voucher = data.GiamGias.Where(s => s.MaGiamGia.Equals(magiamgia)).FirstOrDefault();
            if (voucher != null)
            {
                if (voucher.SoLuongCon <= 0)
                {
                    return false;
                }
                else
                {
                    if (ngaydung > voucher.NgayKetThuc)
                        return false;
                }
                return true;
            }
            else return false;
        }

        public double getPhanTramGiam(DateTime ngaydung, string magiamgia)
        {
            if (kiemTraGiamGia(ngaydung, magiamgia))
            {
                GiamGia phantram = data.GiamGias.Where(v => v.MaGiamGia.Equals(magiamgia)).FirstOrDefault();
                return phantram.SoLuongGiam;
            }
            return 0;
        }
    }
}
