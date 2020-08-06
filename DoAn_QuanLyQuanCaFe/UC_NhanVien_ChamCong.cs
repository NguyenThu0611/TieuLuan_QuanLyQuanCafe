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
    public partial class UC_NhanVien_ChamCong : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_NhanVien_ChamCong()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter1.Fill(this.doAn_QuanLyQuanCafeDataSet1.NhanVien);
            this.loaiCaTableAdapter1.Fill(this.doAn_QuanLyQuanCafeDataSet1.LoaiCa);
            this.chiTietCaLamTableAdapter1.Fill(this.doAn_QuanLyQuanCafeDataSet1.ChiTietCaLam);
        }

        private void nhanVienBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.doAn_QuanLyQuanCafeDataSet1);

        }

        private void loaiCaBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaiCaBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.doAn_QuanLyQuanCafeDataSet1);
        }

        private void chiTietCaLamBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietCaLamBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.doAn_QuanLyQuanCafeDataSet1);
        }
    }
}
