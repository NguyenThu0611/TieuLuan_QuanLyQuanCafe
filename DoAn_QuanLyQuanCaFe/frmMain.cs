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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát phải không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Dispose();
            }
        }

        public void TaoListButtonChucNang(string[] lst, Control control)
        {
            control.Controls.Clear();
            foreach (String str in lst)
            {
                ButtonX btn = new ButtonX();
                btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                btn.Size = new Size(150, 50);
                btn.Text = str;
                btn.Name = str;
                btn.Tag = btn.Name;
                btn.Click += Btn_Click;
                control.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string flag = ((ButtonX)sender).Tag.ToString();
            if(flag.Equals("Pha Chế"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_DanhMucMatHang_PhaChe() { Dock = DockStyle.Fill });
            }    
            else if(flag.Equals("Nguyên Liệu"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_DanhMucMatHang_NguyenLieu() { Dock = DockStyle.Fill });
            }
            else if (flag.Equals("Đóng Chai"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_DanhMucMatHang_DongChai() { Dock = DockStyle.Fill });
            }
            else if (flag.Equals("Bồi Thường"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_DanhMucMatHang_BoiThuong() { Dock = DockStyle.Fill });
            }
            else if (flag.Equals("Chấm Công"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_NhanVien_ChamCong() { Dock = DockStyle.Fill });
            }
            else if (flag.Equals("Báo Cáo"))
            {
                pContent.Controls.Clear();
                pContent.Controls.Add(new UC_NhanVien_BaoCao() { Dock = DockStyle.Fill });
            }

        }

        private void navBanHang_Click(object sender, EventArgs e)
        {
            MainBanHang frmBanHang = new MainBanHang(1) { Dock = DockStyle.Fill, WindowState = FormWindowState.Maximized };
            frmBanHang.Show();
            this.Hide();
        }

        private void navKhachHang_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            pContent.Controls.Add(new UC_KhachHang() { Dock = DockStyle.Fill });
        }

        private void navPhieuQuaTang_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            pContent.Controls.Add(new UC_GiamGia() { Dock = DockStyle.Fill });
        }

        private void navDanhMuc_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            String[] lst1 = { "Pha Chế", "Nguyên Liệu", "Đóng Chai", "Bồi Thường" };
            TaoListButtonChucNang(lst1, flChucNang);
        }

        private void navNhanVien_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            String[] lstChucnang = { "Chấm Công", "Báo Cáo" };
            TaoListButtonChucNang(lstChucnang, flChucNang);
        }

        private void navKhuVuc_Click(object sender, EventArgs e)
        {
            flChucNang.Controls.Clear();
            pContent.Controls.Clear();
            pContent.Controls.Add(new UC_KhuVuc() { Dock = DockStyle.Fill });
        }

        private void navNhapHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo");
        }

        private void navKeToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo");
        }

        private void navQuanLyKho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo");
        }

        private void navBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo");
        }

        private void navBaoMatHeThong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo");
        }
    }
}