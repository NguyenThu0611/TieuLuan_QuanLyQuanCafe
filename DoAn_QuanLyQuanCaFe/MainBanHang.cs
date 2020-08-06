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
using DevExpress.Utils.Extensions;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class MainBanHang : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        public MainBanHang(int flag)
        {
            InitializeComponent();
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Blue";
            this.flag = flag;
        }

        #region Method

        private void TaoMenu(String[] lst, Control control)
        {
            control.Controls.Clear();
            foreach(String str in lst)
            {
                ButtonX btn = new ButtonX();
                btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                btn.Size = new Size(100, 50);
                btn.Text = str;
                btn.Click += Btn_Click;
                control.Controls.Add(btn);
            }    
        }

        public void initDropdown()
        {
            
        }
        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            String[] lst = { "abc1", "abc1", "abc1", "abc1", "ab1c", "abc1", "abc1", "abc1", "abc1", "abc1", "abc1", "abc1", "abc1", "abc1" };
            TaoMenu(lst, flHienThiMon);
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            String[] lst = { "abc", "abc", "abc", "abc", "abc", "abc", "abc", "abc" };
            TaoMenu(lst, flHienThiDanhMuc);

            initDropdown();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            UC_BanHang frmBanHang = new UC_BanHang();
            frmBanHang.Dock = DockStyle.Fill;
            pHienThiChinh.Hide();
            pChuyenGiaoDien.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void UC_MainBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 1)
            {
                frmMain frm = new frmMain();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Dispose();
            }
        }
    }
}