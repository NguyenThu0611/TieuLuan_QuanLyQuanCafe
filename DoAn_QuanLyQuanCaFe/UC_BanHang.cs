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
using BLL_DAL;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class UC_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public string soluong = "";
        public double thanhtienhientai = 0;

        string magiamgia = "";
        int flagq;
        Ban ban;
        ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();
        KhachHangBLL khbll = new KhachHangBLL();
        MatHangBLL mathangbll = new MatHangBLL();
        GiamGiaBLL giamgiabll = new GiamGiaBLL();
        public UC_BanHang(Ban ban, int flagq)
        {
            InitializeComponent();
            this.ban = ban;
            loadCTHD();
            this.flagq = flagq;
        }

        public void loadCTHD()
        {

            if (ban != null)
            {
                txtBanHienTai.Text = ban.TenBan;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cthdbll.getCTHoaDon(ban.MaBan);

                //setTongTien
                double tongtien = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tongtien += Convert.ToDouble(dataGridView1.Rows[i].Cells["ThanhTien"].Value);
                }
                txtTongTien.Text = tongtien.ToString();

                //setThanhTien

                double phantramVoucher = Convert.ToDouble(txtPhanTramGiam.Text.Trim());
                double phantramVAT = Convert.ToDouble(txtPhanTramVAT.Text.Trim());

                double tiengiam = (phantramVoucher * tongtien) / 100;
                txtTienGiam.Text = tiengiam + "";

                double tienVAT = (phantramVAT * tongtien) / 100;
                txtTienVAT.Text = tienVAT + "";

                double thanhtien = (tongtien - tiengiam) + tienVAT;
                txtThanhTien.Text = thanhtien.ToString();
                thanhtienhientai = thanhtien;
            }
            else
            {
                txtBanHienTai.Text = "";
                dataGridView1.DataSource = null;
            }

            //loadKhachhang
            cboKhachHang.DataSource = khbll.getDSKH();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }
        int flag = 0;
        private void btnTienMat_Click(object sender, EventArgs e)
        {

            Dialog_ThanhToan thanhtoan = new Dialog_ThanhToan(Convert.ToDouble(txtThanhTien.Text.Trim()), dataGridView1.Rows[0].Cells[0].Value.ToString(), ban.MaBan, flagq) { StartPosition = FormStartPosition.CenterScreen };
            thanhtoan.ShowDialog();

            this.Dispose();
            MainBanHang main = new MainBanHang(flagq) { WindowState = FormWindowState.Maximized};
            main.Show();
            
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {


        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            soluong = txtSoLuong.Text;
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            frmGiamGia frmgiamgia = new frmGiamGia() { StartPosition = FormStartPosition.CenterScreen };
            frmgiamgia.ShowDialog();

            magiamgia = frmgiamgia.magiamgia;

            if (frmgiamgia.magiamgia != "")
            {
                double phantramgiam = giamgiabll.getPhanTramGiam(DateTime.Now, frmgiamgia.magiamgia);
                txtPhanTramGiam.Text = phantramgiam.ToString();
                loadCTHD();
            }
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            double phuthu;
            if (txtPhuThu.Text.Length <= 0)
                phuthu = 0;
            else
                phuthu = Convert.ToDouble(txtPhuThu.Text.Trim());

            txtThanhTien.Text = (thanhtienhientai + phuthu) + "";
        }

        private void txtPhuThu_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 0)
                txt.Text = 0 + "";
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang cập nhật");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            txtPhanTramGiam.Text = "0";
            loadCTHD();
        }

        private void txtTienGiam_TextChanged(object sender, EventArgs e)
        {
            double tiengiam = Convert.ToDouble(txtTienGiam.Text.Trim());
            double tienvat = Convert.ToDouble(txtTienVAT.Text.Trim());

            txtThanhTien.Text = (Convert.ToInt32(txtTongTien.Text.Trim()) + tienvat) + "";
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            string mahd = "";
            if (dataGridView1.DataSource != null)
            {
                mahd = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                mahd = cthdbll.getHoaDonBy_Ban(ban.MaBan);
            }
            int kq = cthdbll.deleteHoaDon(mahd);
            if (kq == 0)
            {
                MessageBox.Show("Hoá đơn đã thanh toán không thể huỷ");
            }
            else
            {
                loadCTHD();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        { 
            HoaDon hd = new HoaDon();
            hd.MaHD = dataGridView1.Rows[0].Cells[0].Value.ToString();
            hd.MaBan = ban.MaBan;
            hd.NgayLap = DateTime.Now;
            hd.MaNV = "NV01";
            hd.TongTien = Convert.ToDouble(txtThanhTien.Text.Trim());
            hd.TinhTrang = true;
            if (txtMaKhachHang.Text.Length != 0)
                hd.MaKH = txtMaKhachHang.Text.Trim();
            if(giamgiabll.kiemTraGiamGia(DateTime.Now, magiamgia))
            {
                hd.MaGiamGia = magiamgia;
            }
            hd.ThanhToan = true;

            if (cthdbll.isThanhToan(hd.MaHD) == true)
            {
                cthdbll.updateHoaDon(hd);
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Hoá đơn chưa thanh toán không thể lưu được");
            }                
            loadCTHD();

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            Dialog_ChuyenBan frmchuyenban = new Dialog_ChuyenBan(ban.MaBan);
            frmchuyenban.ShowDialog();

            loadCTHD();
        }
    }
}
