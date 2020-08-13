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

        private void UC_KhuVuc_Load(object sender, EventArgs e)
        {
            this.khuVucTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.KhuVuc);
            this.banTableAdapter.Fill(this.doAn_QuanLyQuanCafeDataSet.Ban);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.khuVucBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.doAn_QuanLyQuanCafeDataSet);
        }
    }
}
