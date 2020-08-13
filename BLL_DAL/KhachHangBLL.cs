using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhachHangBLL
    {

        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public KhachHangBLL() { }

        public List<KhachHang> getDSKH()
        {
            return data.KhachHangs.Select(k => k).ToList<KhachHang>();
        }    
    }
}
