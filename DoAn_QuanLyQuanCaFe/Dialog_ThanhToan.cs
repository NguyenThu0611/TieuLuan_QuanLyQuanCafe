using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using BLL_DAL;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class Dialog_ThanhToan : DevExpress.XtraEditors.XtraForm
    {

        ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();
        double tongtien;
        string mahd;
        string maban;
        int flagq;
        public Dialog_ThanhToan(double tongtien, string mahd, string maban, int flagq)
        {
            InitializeComponent();
            this.tongtien = tongtien;
            txtTongTien.Text = tongtien + "";
            this.maban = maban;
            this.mahd = mahd;
            this.flagq = flagq;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            ButtonX btn = (ButtonX)sender;
            if (btn.Tag.Equals("c"))
            {
                txtTienKhachDua.Text = "";
            }
            else
                txtTienKhachDua.Text += btn.Tag.ToString();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            string str = txtTienKhachDua.Text;
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - 1, 1);
            }
            txtTienKhachDua.Text = str;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            double tienkhachdua;
            if (txtTienKhachDua.Text.Length <= 0)
            {
                tienkhachdua = 0;
            }    
            else 
            tienkhachdua = Convert.ToDouble(txtTienKhachDua.Text.Trim());
            double tienthua = tienkhachdua - tongtien;

            txtTienThua.Text = tienthua + "";
        }

        public int flag = 0; 
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int kq = cthdbll.updateThanhToan(maban, mahd);
            if (kq == 1)
            {
                MessageBox.Show("Thanh toán thành công");
                flag = 1;
                this.Close();
                
            }
            else
                MessageBox.Show("Thanh toán thất bại");
        }
    }
}