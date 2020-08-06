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
using DevExpress.XtraBars.FluentDesignSystem;
using System.Windows.Input;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //admin - Quản Lý
            if ((textBoxX1.Text.Trim().Equals("admin") || textBoxX1.Text.Trim().Equals("Admin")) && (textBoxX2.Text.Trim().Equals("admin") || textBoxX2.Text.Trim().Equals("Admin")))
            {
                frmMain frmmain = new frmMain();
                this.Hide();
                frmmain.Show();
            }

            //Người Dùng - Nhân Viên
            else 
            {
                MainBanHang frmmainBH = new MainBanHang(0) { WindowState = FormWindowState.Maximized};
                this.Hide();
                frmmainBH.Show();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void textBoxX2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { buttonX1_Click(sender, e); }
        }
    }
}