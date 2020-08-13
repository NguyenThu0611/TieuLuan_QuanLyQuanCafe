using BLL_DAL;
using BLL_DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class Dialog_ChuyenBan : Form
    {

        string mabanhientai = "";
        BanBLL banbll = new BanBLL();
        ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();

        public Dialog_ChuyenBan(string mabanhientai)
        {
            InitializeComponent();
            this.mabanhientai = mabanhientai;

            comboBoxEx1.DataSource = banbll.getDSBan();
            comboBoxEx1.DisplayMember = "TenBan";
            comboBoxEx1.ValueMember = "MaBan";
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            string mabanmoi = comboBoxEx1.SelectedValue.ToString();
            int kq = cthdbll.updateChuyenBan(mabanhientai, mabanmoi);
            if(kq == 0)
            {
                MessageBox.Show("Không chuyển bàn được"); 
            }
            else if(kq == -1)
            {
                MessageBox.Show("Bàn này đã cso người ngồi");
            }    
            else if(kq == 1)
            {
                MessageBox.Show("Chuyển bàn thành công");
            }
            this.Close();
        }
    }
}
