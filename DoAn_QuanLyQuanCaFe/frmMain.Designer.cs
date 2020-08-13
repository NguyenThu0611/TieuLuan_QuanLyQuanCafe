namespace DoAn_QuanLyQuanCaFe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.navBanHang = new DevComponents.DotNetBar.ButtonItem();
            this.navKhachHang = new DevComponents.DotNetBar.ButtonItem();
            this.navPhieuQuaTang = new DevComponents.DotNetBar.ButtonItem();
            this.navDanhMuc = new DevComponents.DotNetBar.ButtonItem();
            this.navNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.navKhuVuc = new DevComponents.DotNetBar.ButtonItem();
            this.navNhapHang = new DevComponents.DotNetBar.ButtonItem();
            this.navKeToan = new DevComponents.DotNetBar.ButtonItem();
            this.navQuanLyKho = new DevComponents.DotNetBar.ButtonItem();
            this.navBaoCao = new DevComponents.DotNetBar.ButtonItem();
            this.navBaoMatHeThong = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.flChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.pContent = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.tableLayoutPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(205, 711);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.navigationBar1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(199, 711);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.navBanHang,
            this.navKhachHang,
            this.navPhieuQuaTang,
            this.navDanhMuc,
            this.navNhanVien,
            this.navKhuVuc,
            this.navNhapHang,
            this.navKeToan,
            this.navQuanLyKho,
            this.navBaoCao,
            this.navBaoMatHeThong});
            this.navigationBar1.Location = new System.Drawing.Point(3, 239);
            this.navigationBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(193, 412);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 0;
            this.navigationBar1.Text = "Khách Hàng";
            // 
            // navBanHang
            // 
            this.navBanHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navBanHang.Image = ((System.Drawing.Image)(resources.GetObject("navBanHang.Image")));
            this.navBanHang.Name = "navBanHang";
            this.navBanHang.OptionGroup = "navBar";
            this.navBanHang.Text = "Bán Hàng";
            this.navBanHang.Click += new System.EventHandler(this.navBanHang_Click);
            // 
            // navKhachHang
            // 
            this.navKhachHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("navKhachHang.Image")));
            this.navKhachHang.Name = "navKhachHang";
            this.navKhachHang.OptionGroup = "navBar";
            this.navKhachHang.Text = "Khách hàng";
            this.navKhachHang.Click += new System.EventHandler(this.navKhachHang_Click);
            // 
            // navPhieuQuaTang
            // 
            this.navPhieuQuaTang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navPhieuQuaTang.Image = ((System.Drawing.Image)(resources.GetObject("navPhieuQuaTang.Image")));
            this.navPhieuQuaTang.Name = "navPhieuQuaTang";
            this.navPhieuQuaTang.OptionGroup = "navBar";
            this.navPhieuQuaTang.Text = "Phiếu Quà Tặng";
            this.navPhieuQuaTang.Click += new System.EventHandler(this.navPhieuQuaTang_Click);
            // 
            // navDanhMuc
            // 
            this.navDanhMuc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("navDanhMuc.Image")));
            this.navDanhMuc.Name = "navDanhMuc";
            this.navDanhMuc.OptionGroup = "navBar";
            this.navDanhMuc.Text = "Danh Mục";
            this.navDanhMuc.Click += new System.EventHandler(this.navDanhMuc_Click);
            // 
            // navNhanVien
            // 
            this.navNhanVien.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("navNhanVien.Image")));
            this.navNhanVien.Name = "navNhanVien";
            this.navNhanVien.OptionGroup = "navBar";
            this.navNhanVien.Text = "Nhân Viên";
            this.navNhanVien.Click += new System.EventHandler(this.navNhanVien_Click);
            // 
            // navKhuVuc
            // 
            this.navKhuVuc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navKhuVuc.Image = ((System.Drawing.Image)(resources.GetObject("navKhuVuc.Image")));
            this.navKhuVuc.Name = "navKhuVuc";
            this.navKhuVuc.OptionGroup = "navBar";
            this.navKhuVuc.Text = "Khu Vực";
            this.navKhuVuc.Click += new System.EventHandler(this.navKhuVuc_Click);
            // 
            // navNhapHang
            // 
            this.navNhapHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navNhapHang.Checked = true;
            this.navNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("navNhapHang.Image")));
            this.navNhapHang.Name = "navNhapHang";
            this.navNhapHang.OptionGroup = "navBar";
            this.navNhapHang.Text = "Nhập Hàng";
            this.navNhapHang.Click += new System.EventHandler(this.navNhapHang_Click);
            // 
            // navKeToan
            // 
            this.navKeToan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navKeToan.Checked = true;
            this.navKeToan.Image = ((System.Drawing.Image)(resources.GetObject("navKeToan.Image")));
            this.navKeToan.Name = "navKeToan";
            this.navKeToan.OptionGroup = "navBar";
            this.navKeToan.Text = "Kế Toán";
            this.navKeToan.Click += new System.EventHandler(this.navKeToan_Click);
            // 
            // navQuanLyKho
            // 
            this.navQuanLyKho.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navQuanLyKho.Checked = true;
            this.navQuanLyKho.Image = ((System.Drawing.Image)(resources.GetObject("navQuanLyKho.Image")));
            this.navQuanLyKho.Name = "navQuanLyKho";
            this.navQuanLyKho.OptionGroup = "navBar";
            this.navQuanLyKho.Text = "Quản Lý Kho";
            this.navQuanLyKho.Click += new System.EventHandler(this.navQuanLyKho_Click);
            // 
            // navBaoCao
            // 
            this.navBaoCao.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navBaoCao.Checked = true;
            this.navBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("navBaoCao.Image")));
            this.navBaoCao.Name = "navBaoCao";
            this.navBaoCao.OptionGroup = "navBar";
            this.navBaoCao.Text = "Báo Cáo";
            this.navBaoCao.Click += new System.EventHandler(this.navBaoCao_Click);
            // 
            // navBaoMatHeThong
            // 
            this.navBaoMatHeThong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.navBaoMatHeThong.Checked = true;
            this.navBaoMatHeThong.Image = ((System.Drawing.Image)(resources.GetObject("navBaoMatHeThong.Image")));
            this.navBaoMatHeThong.Name = "navBaoMatHeThong";
            this.navBaoMatHeThong.OptionGroup = "navBar";
            this.navBaoMatHeThong.Text = "Bảo Mật / Hệ thống";
            this.navBaoMatHeThong.Click += new System.EventHandler(this.navBaoMatHeThong_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.flChucNang);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 2);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(193, 233);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Chức năng";
            // 
            // flChucNang
            // 
            this.flChucNang.BackColor = System.Drawing.Color.Transparent;
            this.flChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flChucNang.Location = new System.Drawing.Point(0, 0);
            this.flChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flChucNang.Name = "flChucNang";
            this.flChucNang.Size = new System.Drawing.Size(187, 209);
            this.flChucNang.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pContent.DisabledBackColor = System.Drawing.Color.Empty;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(205, 0);
            this.pContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1111, 711);
            this.pContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pContent.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pContent.Style.GradientAngle = 90;
            this.pContent.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 711);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ QUÁN CAFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem navBanHang;
        private DevComponents.DotNetBar.ButtonItem navKhachHang;
        private DevComponents.DotNetBar.ButtonItem navPhieuQuaTang;
        private DevComponents.DotNetBar.ButtonItem navDanhMuc;
        private DevComponents.DotNetBar.ButtonItem navNhapHang;
        private DevComponents.DotNetBar.ButtonItem navKeToan;
        private DevComponents.DotNetBar.ButtonItem navQuanLyKho;
        private DevComponents.DotNetBar.ButtonItem navBaoCao;
        private DevComponents.DotNetBar.ButtonItem navBaoMatHeThong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.PanelEx pContent;
        private DevComponents.DotNetBar.ButtonItem navNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.FlowLayoutPanel flChucNang;
        private DevComponents.DotNetBar.ButtonItem navKhuVuc;
    }
}