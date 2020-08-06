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
    public partial class UC_DanhMucMatHang_DongChai : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_DanhMucMatHang_DongChai()
        {
            InitializeComponent();
        }

        private void DanhMucMatHang_DongChai_Load(object sender, EventArgs e)
        {
            this.matHang_DongChaiTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.MatHang_DongChai);
        }

        private void matHang_DongChaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matHang_DongChaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }
    }
}
