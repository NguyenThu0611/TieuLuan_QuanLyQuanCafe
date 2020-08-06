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
    public partial class UC_DanhMucMatHang_BoiThuong : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_DanhMucMatHang_BoiThuong()
        {
            InitializeComponent();
        }

        private void matHang_BoiThuongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matHang_BoiThuongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }

        private void DanhMucMatHang_BoiThuong_Load(object sender, EventArgs e)
        {
            this.matHang_BoiThuongTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.MatHang_BoiThuong);
        }
    }
}
