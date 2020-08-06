namespace DoAn_QuanLyQuanCaFe
{
    partial class UC_DanhMucMatHang_PhaChe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhMucMatHang_PhaChe));
            System.Windows.Forms.Label maMH_PCLabel;
            System.Windows.Forms.Label tenMH_PCLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label donGiaLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.doAn_QuanLyQuanCafeDataSet = new DoAn_QuanLyQuanCaFe.DoAn_QuanLyQuanCafeDataSet();
            this.matHang_PCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHang_PCTableAdapter = new DoAn_QuanLyQuanCaFe.DoAn_QuanLyQuanCafeDataSetTableAdapters.MatHang_PCTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyQuanCaFe.DoAn_QuanLyQuanCafeDataSetTableAdapters.TableAdapterManager();
            this.matHang_PCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.matHang_PCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matHang_PCDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.maMH_PCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenMH_PCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.donViTinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.donGiaTextEdit = new DevExpress.XtraEditors.TextEdit();
            maMH_PCLabel = new System.Windows.Forms.Label();
            tenMH_PCLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doAn_QuanLyQuanCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCBindingNavigator)).BeginInit();
            this.matHang_PCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maMH_PCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMH_PCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.matHang_PCDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // doAn_QuanLyQuanCafeDataSet
            // 
            this.doAn_QuanLyQuanCafeDataSet.DataSetName = "DoAn_QuanLyQuanCafeDataSet";
            this.doAn_QuanLyQuanCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHang_PCBindingSource
            // 
            this.matHang_PCBindingSource.DataMember = "MatHang_PC";
            this.matHang_PCBindingSource.DataSource = this.doAn_QuanLyQuanCafeDataSet;
            // 
            // matHang_PCTableAdapter
            // 
            this.matHang_PCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableAdapter = null;
            this.tableAdapterManager.ChiTietCaLamTableAdapter = null;
            this.tableAdapterManager.ChiTietDatHang_DongChaiTableAdapter = null;
            this.tableAdapterManager.ChiTietDatHang_NguyenLieuTableAdapter = null;
            this.tableAdapterManager.ChiTietGiaoHang_MHDongChaiTableAdapter = null;
            this.tableAdapterManager.ChiTietGiaoHang_MHNguyenLieuTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDon_BoiThuongTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDon_DongChaiTableAdapter = null;
            this.tableAdapterManager.ChiTietHoaDon_PhaCheTableAdapter = null;
            this.tableAdapterManager.GiamGiaTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhauHaoNguyenLieuTableAdapter = null;
            this.tableAdapterManager.KhuVucTableAdapter = null;
            this.tableAdapterManager.LoaiCaTableAdapter = null;
            this.tableAdapterManager.MatHang_BoiThuongTableAdapter = null;
            this.tableAdapterManager.MatHang_DongChaiTableAdapter = null;
            this.tableAdapterManager.MatHang_NguyenLieuTableAdapter = null;
            this.tableAdapterManager.MatHang_PCTableAdapter = this.matHang_PCTableAdapter;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuDatHangTableAdapter = null;
            this.tableAdapterManager.PhieuGiaoHangTableAdapter = null;
            this.tableAdapterManager.TheKhachHangTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyQuanCaFe.DoAn_QuanLyQuanCafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // matHang_PCBindingNavigator
            // 
            this.matHang_PCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.matHang_PCBindingNavigator.BindingSource = this.matHang_PCBindingSource;
            this.matHang_PCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.matHang_PCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.matHang_PCBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.matHang_PCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.matHang_PCBindingNavigatorSaveItem});
            this.matHang_PCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.matHang_PCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.matHang_PCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.matHang_PCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.matHang_PCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.matHang_PCBindingNavigator.Name = "matHang_PCBindingNavigator";
            this.matHang_PCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.matHang_PCBindingNavigator.Size = new System.Drawing.Size(1182, 27);
            this.matHang_PCBindingNavigator.TabIndex = 4;
            this.matHang_PCBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // matHang_PCBindingNavigatorSaveItem
            // 
            this.matHang_PCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matHang_PCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matHang_PCBindingNavigatorSaveItem.Image")));
            this.matHang_PCBindingNavigatorSaveItem.Name = "matHang_PCBindingNavigatorSaveItem";
            this.matHang_PCBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.matHang_PCBindingNavigatorSaveItem.Text = "Save Data";
            this.matHang_PCBindingNavigatorSaveItem.Click += new System.EventHandler(this.matHang_PCBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn Vị Tính";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMH_PC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Mặt Hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMH_PC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Mặt Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // matHang_PCDataGridView
            // 
            this.matHang_PCDataGridView.AutoGenerateColumns = false;
            this.matHang_PCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matHang_PCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matHang_PCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.matHang_PCDataGridView.DataSource = this.matHang_PCBindingSource;
            this.matHang_PCDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matHang_PCDataGridView.Location = new System.Drawing.Point(3, 200);
            this.matHang_PCDataGridView.Name = "matHang_PCDataGridView";
            this.matHang_PCDataGridView.RowHeadersWidth = 51;
            this.matHang_PCDataGridView.RowTemplate.Height = 24;
            this.matHang_PCDataGridView.Size = new System.Drawing.Size(1176, 456);
            this.matHang_PCDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.donGiaTextEdit, 1, 3);
            this.tableLayoutPanel2.Controls.Add(donGiaLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.donViTinhTextEdit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(donViTinhLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tenMH_PCTextEdit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(tenMH_PCLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maMH_PCTextEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(maMH_PCLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 191);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // maMH_PCLabel
            // 
            maMH_PCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            maMH_PCLabel.AutoSize = true;
            maMH_PCLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            maMH_PCLabel.Location = new System.Drawing.Point(3, 11);
            maMH_PCLabel.Name = "maMH_PCLabel";
            maMH_PCLabel.Size = new System.Drawing.Size(229, 24);
            maMH_PCLabel.TabIndex = 1;
            maMH_PCLabel.Text = "Mã Mặt Hàng Pha Chế";
            // 
            // maMH_PCTextEdit
            // 
            this.maMH_PCTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maMH_PCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHang_PCBindingSource, "MaMH_PC", true));
            this.maMH_PCTextEdit.Location = new System.Drawing.Point(238, 8);
            this.maMH_PCTextEdit.Name = "maMH_PCTextEdit";
            this.maMH_PCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maMH_PCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maMH_PCTextEdit.Size = new System.Drawing.Size(346, 30);
            this.maMH_PCTextEdit.TabIndex = 2;
            // 
            // tenMH_PCLabel
            // 
            tenMH_PCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            tenMH_PCLabel.AutoSize = true;
            tenMH_PCLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            tenMH_PCLabel.Location = new System.Drawing.Point(3, 58);
            tenMH_PCLabel.Name = "tenMH_PCLabel";
            tenMH_PCLabel.Size = new System.Drawing.Size(229, 24);
            tenMH_PCLabel.TabIndex = 3;
            tenMH_PCLabel.Text = "Tên Mặt Hàng Pha Chế";
            // 
            // tenMH_PCTextEdit
            // 
            this.tenMH_PCTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tenMH_PCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHang_PCBindingSource, "TenMH_PC", true));
            this.tenMH_PCTextEdit.Location = new System.Drawing.Point(238, 55);
            this.tenMH_PCTextEdit.Name = "tenMH_PCTextEdit";
            this.tenMH_PCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tenMH_PCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenMH_PCTextEdit.Size = new System.Drawing.Size(346, 30);
            this.tenMH_PCTextEdit.TabIndex = 4;
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            donViTinhLabel.Location = new System.Drawing.Point(3, 105);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(229, 24);
            donViTinhLabel.TabIndex = 5;
            donViTinhLabel.Text = "Đơn Vị Tính";
            // 
            // donViTinhTextEdit
            // 
            this.donViTinhTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donViTinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHang_PCBindingSource, "DonViTinh", true));
            this.donViTinhTextEdit.Location = new System.Drawing.Point(238, 102);
            this.donViTinhTextEdit.Name = "donViTinhTextEdit";
            this.donViTinhTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.donViTinhTextEdit.Properties.Appearance.Options.UseFont = true;
            this.donViTinhTextEdit.Size = new System.Drawing.Size(346, 30);
            this.donViTinhTextEdit.TabIndex = 6;
            // 
            // donGiaLabel
            // 
            donGiaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            donGiaLabel.Location = new System.Drawing.Point(3, 154);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(229, 24);
            donGiaLabel.TabIndex = 7;
            donGiaLabel.Text = "Đơn Giá";
            // 
            // donGiaTextEdit
            // 
            this.donGiaTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donGiaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHang_PCBindingSource, "DonGia", true));
            this.donGiaTextEdit.Location = new System.Drawing.Point(238, 151);
            this.donGiaTextEdit.Name = "donGiaTextEdit";
            this.donGiaTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.donGiaTextEdit.Properties.Appearance.Options.UseFont = true;
            this.donGiaTextEdit.Size = new System.Drawing.Size(346, 30);
            this.donGiaTextEdit.TabIndex = 8;
            // 
            // DanhMucMatHang_PhaChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.matHang_PCBindingNavigator);
            this.Name = "DanhMucMatHang_PhaChe";
            this.Size = new System.Drawing.Size(1182, 686);
            this.Load += new System.EventHandler(this.DanhMucMatHang_PhaChe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doAn_QuanLyQuanCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCBindingNavigator)).EndInit();
            this.matHang_PCBindingNavigator.ResumeLayout(false);
            this.matHang_PCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matHang_PCDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maMH_PCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMH_PCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DoAn_QuanLyQuanCafeDataSet doAn_QuanLyQuanCafeDataSet;
        private System.Windows.Forms.BindingSource matHang_PCBindingSource;
        private DoAn_QuanLyQuanCafeDataSetTableAdapters.MatHang_PCTableAdapter matHang_PCTableAdapter;
        private DoAn_QuanLyQuanCafeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator matHang_PCBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton matHang_PCBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView matHang_PCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit donGiaTextEdit;
        private DevExpress.XtraEditors.TextEdit donViTinhTextEdit;
        private DevExpress.XtraEditors.TextEdit tenMH_PCTextEdit;
        private DevExpress.XtraEditors.TextEdit maMH_PCTextEdit;
    }
}
