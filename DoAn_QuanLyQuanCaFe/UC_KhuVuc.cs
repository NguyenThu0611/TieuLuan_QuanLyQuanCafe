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
    public partial class UC_KhuVuc : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_KhuVuc()
        {
            InitializeComponent();
        }

        private void banBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.banBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);

        }
    }
}
