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
    public partial class UC_DanhMucMatHang_NguyenLieu : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_DanhMucMatHang_NguyenLieu()
        {
            InitializeComponent();
        }

        private void matHang_NguyenLieuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matHang_NguyenLieuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }

        private void DanhMucMatHang_NguyenLieu_Load(object sender, EventArgs e)
        {
            this.matHang_NguyenLieuTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.MatHang_NguyenLieu);
        }
    }
}
