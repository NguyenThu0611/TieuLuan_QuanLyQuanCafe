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
using BLL_DAL;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class MainBanHang : DevExpress.XtraEditors.XtraForm
    {
        Ban banDangChon;
        DanhMucBLL danhmucbll = new DanhMucBLL();
        ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();
        MatHangBLL mathangbll = new MatHangBLL();
        UC_BanHang frm;

        string danhmucchon = "";
        int flag = 0; //xác định đăng nhập bằng quyền gì
        public MainBanHang(int flag)
        {
            InitializeComponent();
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Blue";
            this.flag = flag;
            frm = new UC_BanHang(banDangChon, flag);
        }

        #region Method
        private void TaoMenuDanhMuc(string[] lst, Control control)
        {
            control.Controls.Clear();
            foreach (String str in lst)
            {
                ButtonX btn = new ButtonX();
                btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                btn.Size = new Size(100, 50);
                btn.Text = str;
                btn.Name = str;
                btn.Tag = btn.Name;
                btn.Click += Btn_Click;
                control.Controls.Add(btn);
            }
        }

        public void TaoMenuThucUong(List<MatHang_PC> lstMTPhaChe, List<MatHang_DongChai> lstMTDongChai, Control control)
        {

            control.Controls.Clear();
            if (lstMTPhaChe != null)
            {
                foreach (MatHang_PC mathang in lstMTPhaChe)
                {
                    ButtonX btnmon = new ButtonX();
                    btnmon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                    btnmon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                    btnmon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    btnmon.Size = new Size(100, 50);
                    btnmon.Text = mathang.TenMH_PC;
                    btnmon.Tag = mathang;
                    btnmon.Click += Btnmon_Click;
                    control.Controls.Add(btnmon);
                }
            }
            else
            {
                foreach (MatHang_DongChai mathang in lstMTDongChai)
                {
                    ButtonX btnmon = new ButtonX();
                    btnmon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                    btnmon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                    btnmon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    btnmon.Size = new Size(100, 50);
                    btnmon.Text = mathang.TenMH_DC;
                    btnmon.Tag = mathang;
                    btnmon.Click += Btnmon_Click;
                    control.Controls.Add(btnmon);
                }
            }
        }

        private void Btnmon_Click(object sender, EventArgs e)
        {
            if (banDangChon == null)
            {
                return;
            }
            string mahd = cthdbll.getHoaDonBy_Ban(banDangChon.MaBan);

            //TH co hoa don roi
            if (mahd != "")
            {
                if (danhmucchon.Equals("Pha Chế"))
                {
                    MatHang_PC mathang = (MatHang_PC)((ButtonX)sender).Tag;
                    bool kqktr = false;
                    if (mahd != "")
                        kqktr = cthdbll.kiemTraTonTaiTrongCTHD(mahd, mathang.MaMH_PC);
                    if (kqktr)
                    {
                        //Có rồi cập nhật 
                        string soluong = frm.soluong;
                        if (soluong.Equals(""))
                        {
                            soluong = "1";
                        }
                        cthdbll.updateCTHD_PC(mahd, mathang.MaMH_PC, soluong);
                        frm.loadCTHD();
                        pHienThiChinh.Refresh();
                    }
                    else
                    {
                        //chưa có thêm mới
                        string soluong = frm.soluong;
                        string ma_CTHDMax = mathangbll.getMaxIDCTHD_PC();
                        int hauso_ct = 0;
                        if (ma_CTHDMax != null)
                        {
                            hauso_ct = Convert.ToInt32(ma_CTHDMax.Split('_')[1]);
                        }


                        if (soluong.Equals(""))
                        {
                            soluong = "1";
                        }

                        if (Convert.ToInt32(soluong.Trim()) > 0)
                        {
                            ChiTietHoaDon_PhaChe cthd_pc = new ChiTietHoaDon_PhaChe();
                            cthd_pc.MaCTHD_PC = "CTHD_" + (hauso_ct + 1);
                            cthd_pc.MaHD = mahd;
                            cthd_pc.MaMH_PC = mathang.MaMH_PC;
                            cthd_pc.SoLuong = Convert.ToInt32(soluong.Trim());

                            double dongia = mathangbll.getDonGia_byMaMH_PC(mathang.MaMH_PC);

                            cthd_pc.DonGia = dongia;
                            cthd_pc.ThanhTien = Convert.ToInt32(soluong.Trim()) * dongia;
                            cthd_pc.DonViTinh = mathangbll.getDonViTinh_byMaMH_PC(mathang.MaMH_PC);

                            cthdbll.insertCTHD_PC(cthd_pc);
                            frm.loadCTHD();
                            pHienThiChinh.Refresh();
                        }

                    }
                }

                if (danhmucchon.Equals("Đóng Chai"))
                {
                    MatHang_DongChai mathang = (MatHang_DongChai)((ButtonX)sender).Tag;
                    bool kqktr = false;
                    if (mahd != "")
                        kqktr = cthdbll.kiemTraTonTaiTrongCTHD(mahd, mathang.MaMH_DC);
                    if (kqktr)
                    {
                        //Có rồi cập nhật 
                        string soluong = frm.soluong;
                        if (soluong.Equals(""))
                        {
                            soluong = "1";
                        }
                        cthdbll.updateCTHD_DC(mahd, mathang.MaMH_DC, soluong);
                        frm.loadCTHD();
                        pHienThiChinh.Refresh();
                    }
                    else
                    {
                        //chưa có thêm mới
                        string soluong = frm.soluong;
                        string ma_CTHDMax = mathangbll.getMaxIDCTHD_DC();
                        int hauso_ct = 0;
                        if (ma_CTHDMax != null)
                        {
                            hauso_ct = Convert.ToInt32(ma_CTHDMax.Split('_')[1]);
                        }


                        if (soluong.Equals(""))
                        {
                            soluong = "1";
                        }

                        if (Convert.ToInt32(soluong.Trim()) > 0)
                        {

                            ChiTietHoaDon_DongChai cthd_dc = new ChiTietHoaDon_DongChai();
                            cthd_dc.MaCTHD_DC = "CTHD_" + (hauso_ct + 1);
                            cthd_dc.MaHD = mahd;
                            cthd_dc.MaMH_DC = mathang.MaMH_DC;
                            cthd_dc.SoLuong = Convert.ToInt32(soluong.Trim());

                            double dongia = mathangbll.getDonGia_byMaMH_DC(mathang.MaMH_DC);

                            cthd_dc.DonGia = dongia;
                            cthd_dc.ThanhTien = Convert.ToInt32(soluong.Trim()) * dongia;
                            cthd_dc.DonViTinh = mathangbll.getDonViTinh_byMaMH_DC(mathang.MaMH_DC);

                            cthdbll.insertCTHD_DC(cthd_dc);
                            frm.loadCTHD();
                            pHienThiChinh.Refresh();
                        }
                    }
                }
            }

            //TH chua co hoa don
            else
            {
                int hauso = cthdbll.getHauSoHoaDonMax();
                string mahd_them = "HD_" + (hauso + 1);

                HoaDon hd = new HoaDon();
                hd.MaHD = mahd_them;
                hd.MaBan = banDangChon.MaBan;
                hd.NgayLap = DateTime.Now;
                hd.MaNV = "NV01";
                hd.TongTien = 0;
                hd.TinhTrang = false;
                cthdbll.insertHoaDon(hd);

                if (danhmucchon.Equals("Pha Chế"))
                {
                    MatHang_PC mathang = (MatHang_PC)((ButtonX)sender).Tag;
                    string soluong = frm.soluong;
                    string ma_CTHDMax = mathangbll.getMaxIDCTHD_PC();
                    int hauso_ct = 0;
                    if (ma_CTHDMax != null)
                    {
                        hauso_ct = Convert.ToInt32(ma_CTHDMax.Split('_')[1]);
                    }

                    if (soluong.Equals(""))
                    {
                        soluong = "1";
                    }

                    if (Convert.ToInt32(soluong.Trim()) > 0)
                    {
                        ChiTietHoaDon_PhaChe cthd_pc = new ChiTietHoaDon_PhaChe();
                        cthd_pc.MaCTHD_PC = "CTHD_" + (Convert.ToInt32(hauso_ct) + 1);
                        cthd_pc.MaHD = mahd_them;
                        cthd_pc.MaMH_PC = mathang.MaMH_PC;
                        cthd_pc.SoLuong = Convert.ToInt32(soluong.Trim());

                        double dongia = mathangbll.getDonGia_byMaMH_PC(mathang.MaMH_PC);

                        cthd_pc.DonGia = dongia;
                        cthd_pc.ThanhTien = Convert.ToInt32(soluong.Trim()) * dongia;
                        cthd_pc.DonViTinh = mathangbll.getDonViTinh_byMaMH_PC(mathang.MaMH_PC);

                        cthdbll.insertCTHD_PC(cthd_pc);
                        frm.loadCTHD();
                        pHienThiChinh.Refresh();
                    }


                }

                if (danhmucchon.Equals("Đóng Chai"))
                {
                    MatHang_DongChai mathang = (MatHang_DongChai)((ButtonX)sender).Tag;
                    string soluong = frm.soluong;
                    string ma_CTHDMax = mathangbll.getMaxIDCTHD_DC();
                    int hauso_ct = 0;
                    if (ma_CTHDMax != null)
                    {
                        hauso_ct = Convert.ToInt32(ma_CTHDMax.Split('_')[1]);
                    }

                    if (soluong.Equals(""))
                    {
                        soluong = "1";
                    }

                    if (Convert.ToInt32(soluong.Trim()) > 0)
                    {

                        ChiTietHoaDon_DongChai cthd_dc = new ChiTietHoaDon_DongChai();
                        cthd_dc.MaCTHD_DC = "CTHD_" + (Convert.ToInt32(hauso_ct) + 1);
                        cthd_dc.MaHD = mahd_them;
                        cthd_dc.MaMH_DC = mathang.MaMH_DC;
                        cthd_dc.SoLuong = Convert.ToInt32(soluong.Trim());

                        double dongia = mathangbll.getDonGia_byMaMH_DC(mathang.MaMH_DC);

                        cthd_dc.DonGia = dongia;
                        cthd_dc.ThanhTien = Convert.ToInt32(soluong.Trim()) * dongia;
                        cthd_dc.DonViTinh = mathangbll.getDonViTinh_byMaMH_DC(mathang.MaMH_DC);

                        cthdbll.insertCTHD_DC(cthd_dc);
                        frm.loadCTHD();
                        pHienThiChinh.Refresh();
                    }

                }
            }
        }

        private void loadSoDoBan(List<Ban> lstBan, Control control)
        {
            control.Controls.Clear();

            foreach (Ban b in lstBan)
            {
                ButtonX btn = new ButtonX();
                btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                btn.Size = new Size(200, 100);
                btn.Text = b.TenBan + " \n " + b.TinhTrang;
                btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Tag = b;
                btn.Click += BtnBan_Click1;
                control.Controls.Add(btn);
            }
        }

        private void BtnBan_Click1(object sender, EventArgs e)
        {
            banDangChon = (Ban)(((ButtonX)sender).Tag);
            pHienThiChinh.Hide();
            frm = new UC_BanHang(banDangChon, flag);
            frm.Dock = DockStyle.Fill;

            pChuyenGiaoDien.Controls.Add(frm);
            frm.Show();
            btnQuayLai.Enabled = true;
        }
        #endregion

        #region Method
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Tạo danh mục thức uống
            String[] lst = { "Pha Chế", "Đóng Chai" };
            TaoMenuDanhMuc(lst, flHienThiDanhMuc);

            //Load danh sách khu vực - bàn trong danh sách
            List<KhuVuc> lstKhuVuc = danhmucbll.getDanhMucKhuVuc();
            foreach (KhuVuc tabkhuvuc in lstKhuVuc)
            {
                //Tạo tab
                TabControlPanel tabcontrolpanel = new TabControlPanel();
                TabItem tabitem = new TabItem();

                tabitem.AttachedControl = tabcontrolpanel;
                tabitem.Text = tabkhuvuc.TenKhuVuc;
                tabitem.Name = tabkhuvuc.MaKhuVuc;

                //Tạo tabcontrolpanel
                tabcontrolpanel.TabItem = tabitem;
                tabcontrolpanel.DisabledBackColor = System.Drawing.Color.Empty;
                tabcontrolpanel.Dock = System.Windows.Forms.DockStyle.Fill;
                tabcontrolpanel.Location = new System.Drawing.Point(0, 31);
                tabcontrolpanel.Padding = new System.Windows.Forms.Padding(1);
                tabcontrolpanel.Size = new System.Drawing.Size(882, 409);
                tabcontrolpanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
                tabcontrolpanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                tabcontrolpanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                tabcontrolpanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
                tabcontrolpanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
                tabcontrolpanel.Style.GradientAngle = 90;

                //Tạo FlowLayoutPanel
                FlowLayoutPanel flpanel = new FlowLayoutPanel();
                flpanel.Dock = DockStyle.Fill;
                flpanel.Location = new System.Drawing.Point(65, 116);
                flpanel.Size = new System.Drawing.Size(581, 186);
                flpanel.TabIndex = 0;
                flpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));

                tabcontrolpanel.Controls.Add(flpanel);
                tabControl1.Controls.Add(tabcontrolpanel);
                tabControl1.Tabs.Add(tabitem);

                List<Ban> lstBan = danhmucbll.getDSBan_byTang(tabkhuvuc.MaKhuVuc);
                loadSoDoBan(lstBan, flpanel);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            banDangChon = null;

            pChuyenGiaoDien.Controls.Clear();
            pChuyenGiaoDien.Controls.Add(pHienThiChinh);
            pHienThiChinh.Show();
            btnQuayLai.Enabled = false;
        }
        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            danhmucchon = ((ButtonX)sender).Tag.ToString();
            List<MatHang_DongChai> lstMHDongChai = danhmucbll.getDanhMuc_DongChai();
            List<MatHang_PC> lstMHPhaChe = danhmucbll.getDanhMuc_PC();
            if (danhmucchon.Equals("Pha Chế"))
            {
                TaoMenuThucUong(lstMHPhaChe, null, flHienThiMon);
            }
            else
            {
                TaoMenuThucUong(null, lstMHDongChai, flHienThiMon);
            }
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}