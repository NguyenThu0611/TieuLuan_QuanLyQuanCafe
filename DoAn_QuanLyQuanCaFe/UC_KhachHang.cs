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

namespace DoAn_QuanLyQuanCaFe
{
    public partial class UC_KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.KhachHang);
            this.theKhachHangTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.TheKhachHang);
        }

        private void theKhachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.theKhachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);
        }
    }
}
