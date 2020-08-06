using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL_DAL;
using DevExpress.Utils.Filtering;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class UC_NhanVien_BaoCao : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVienBLL nhanvienbll = new NhanVienBLL();

        public UC_NhanVien_BaoCao()
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

        private void UC_NhanVien_BaoCao_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvienbll.getData_byTime(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnThongKe_byTime_Click(object sender, EventArgs e)
        {
            if (dtpkToDate.Value == null || dtpkFromDate == null)
            {
                
            }    
            dataGridView1.DataSource = nhanvienbll.getData_byTime(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}
