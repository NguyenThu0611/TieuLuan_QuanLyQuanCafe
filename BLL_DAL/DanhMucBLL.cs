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

        #region Danh Mục Mặt Hàng Nguyên Liệu
        #endregion

        #region Danh Mục Mặt Hàng Đóng Chai
        public List<MatHang_DongChai> getDanhMuc_DongChai()
        {
            return data.MatHang_DongChais.Select(s => s).ToList<MatHang_DongChai>();
        }
        #endregion

        #region Danh Mục Mặt Hàng Pha Chế 
        public List<MatHang_PC> getDanhMuc_PC()
        {
            return data.MatHang_PCs.Select(s => s).ToList<MatHang_PC>();
        }
        #endregion

        #region Danh Mục Khu Vực
        public List<KhuVuc> getDanhMucKhuVuc()
        {
            return data.KhuVucs.Select(s => s).ToList<KhuVuc>();
        }
        #endregion

        #region Danh Mục Bàn
        public List<Ban> getDSBan_byTang(string makhuvuc)
        {
            return data.Bans.Where(b => b.MaKhuVuc.Equals(makhuvuc)).Select(s => s).ToList<Ban>();
        }
        #endregion

        #region Mặt Hàng
        #endregion
    }
}
