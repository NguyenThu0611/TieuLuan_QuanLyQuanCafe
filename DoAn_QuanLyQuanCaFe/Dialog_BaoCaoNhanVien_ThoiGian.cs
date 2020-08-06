using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL_DAL;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class Dialog_BaoCaoNhanVien_ThoiGian : DevExpress.XtraEditors.XtraForm
    {
        private List<NhanVien> lstNhanVien;
        public List<NhanVien> LstNhanVien
        {
            get { return lstNhanVien; }
            set
            {
                lstNhanVien = value;
                intent(lstNhanVien);
            }
        }

        private void intent(List<NhanVien> lst)
        {
            lst = getData_bythoigian(dtpkFromDate.Value, dtpkToDate.Value);
        }

        /// <summary>
        /// //////////////////////////////
        /// </summary>

        
        public Dialog_BaoCaoNhanVien_ThoiGian()
        {
            InitializeComponent();
            loadDateTimePickerBill();
        }

        private void loadDateTimePickerBill() //Set khoảng thời gian thống kê
        {
            DateTime today = DateTime.Now;
            //Ngày vào mặc định là ngày 1 của tháng hiện tại
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);

            //Ngày ra mặc định là ngày cuôi của tháng hiện tại
            /*Solve:- Lấy ngày đầu tiên của tháng (tức ngày vào) + thêm 1 tháng (dùng hàm .AddMonth(1))
                    -  Sau đó trừ đi 1 ngày (dùng hàm .AddDays(-1)) 
                        => sẽ ra ngày cuối của tháng trước đó(tức tháng hiện tại. do đã cộng thêm 1 tháng)         
             */
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        NhanVienBLL nhanvienbll = new NhanVienBLL();
        public List<NhanVien> getData_bythoigian(DateTime ngaybatdau, DateTime ngaykethuc)
        {
            return nhanvienbll.getData_byTime(ngaybatdau, ngaykethuc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();

        }


        #region event truyen du lieu
        public class Test : EventArgs
        {
            private List<DateTime> lsttime;

            public List<DateTime> Lsttime { get => lsttime; set => lsttime = value; }

            public Test (List<DateTime> lstTime)
            {
                this.Lsttime = lsttime;
            }
        }
        #endregion
    }
}