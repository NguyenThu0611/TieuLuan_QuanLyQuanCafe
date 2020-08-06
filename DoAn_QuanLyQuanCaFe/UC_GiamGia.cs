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
    public partial class UC_GiamGia : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_GiamGia()
        {
            InitializeComponent();

        }

        private void giamGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giamGiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }

        private void UC_GiamGia_Load(object sender, EventArgs e)
        {
            this.giamGiaTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.GiamGia);
        }
    }
}
