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
using DevComponents.DotNetBar;
using DevExpress.Utils.Extensions;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class UC_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_BanHang()
        {
            InitializeComponent();
            //String[] lst = { "abc", "abc", "abc", "abc", "abc", "abc", "abc", "abc" };
            //loadMonAn(lst);
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            Dialog_ThanhToan thanhtoan = new Dialog_ThanhToan() { StartPosition = FormStartPosition.CenterScreen};
            thanhtoan.ShowDialog();
        }

        //public void loadMonAn(String[] lstMonAn)
        //{
        //    int i = 1;
        //    foreach (String str in lstMonAn)
        //    {
        //        ButtonItem btnitem = new ButtonItem();
        //        btnitem.GlobalItem = false;
        //        btnitem.Name = str;
        //        btnitem.Text = str + i;
        //        btnitem.Size = new Size(100, 50);
        //        btnitem.Click += Btnitem_Click;
        //        btnitem.Tag = btnitem;
        //        i++;
        //        cboMonAn.SubItems.Add(btnitem);
        //    }
        //}

        //private void Btnitem_Click(object sender, EventArgs e)
        //{
        //    ButtonItem btn = (ButtonItem)sender;
        //    cboMonAn.Text = btn.Text;
        //}
    }
}
