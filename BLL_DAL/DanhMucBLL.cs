using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DanhMucBLL
    {
        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public DanhMucBLL() { }


        #region Danh Mục Mặt Hàng Bồi Thường
        public void getDanhMuc_BoiThuong()
        {
            List<MatHang_BoiThuong> lstMHBoiThuong = data.MatHang_BoiThuongs.Select(s => s).ToList<MatHang_BoiThuong>();
        }

        #endregion
    }
}
