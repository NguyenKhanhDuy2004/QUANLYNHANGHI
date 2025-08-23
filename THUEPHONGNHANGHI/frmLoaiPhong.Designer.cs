namespace THUEPHONGNHANGHI
{
	partial class frmLoaiPhong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiPhong));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.SONGUOIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.SOGIONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DONGIATHEOGIO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.spDonGiaTheoGio = new DevExpress.XtraEditors.SpinEdit();
			this.label5 = new System.Windows.Forms.Label();
			this.spDonGia = new DevExpress.XtraEditors.SpinEdit();
			this.nUDSogiuong = new System.Windows.Forms.NumericUpDown();
			this.nUDSonguoio = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenloaiphong = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spDonGiaTheoGio.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spDonGia.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDSogiuong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDSonguoio)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1513, 80);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_add_1003;
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(60, 75);
			this.btnThem.Text = "Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::THUEPHONGNHANGHI.Properties.Resources.user_avatar1;
			this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(50, 75);
			this.btnSua.Text = "Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_recycle_bin_1004;
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(50, 75);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// gcDanhSach
			// 
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 80);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(1513, 343);
			this.gcDanhSach.TabIndex = 4;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENLOAIPHONG,
            this.DONGIA,
            this.SONGUOIO,
            this.SOGIONG,
            this.DONGIATHEOGIO});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.RowHeight = 35;
			this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
			// 
			// TENLOAIPHONG
			// 
			this.TENLOAIPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENLOAIPHONG.AppearanceHeader.Options.UseFont = true;
			this.TENLOAIPHONG.Caption = "TÊN LOẠI PHÒNG";
			this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
			this.TENLOAIPHONG.MaxWidth = 250;
			this.TENLOAIPHONG.MinWidth = 200;
			this.TENLOAIPHONG.Name = "TENLOAIPHONG";
			this.TENLOAIPHONG.Visible = true;
			this.TENLOAIPHONG.VisibleIndex = 0;
			this.TENLOAIPHONG.Width = 246;
			// 
			// DONGIA
			// 
			this.DONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DONGIA.AppearanceHeader.Options.UseFont = true;
			this.DONGIA.Caption = "ĐƠN GIÁ";
			this.DONGIA.FieldName = "DONGIA";
			this.DONGIA.MaxWidth = 150;
			this.DONGIA.MinWidth = 100;
			this.DONGIA.Name = "DONGIA";
			this.DONGIA.Visible = true;
			this.DONGIA.VisibleIndex = 1;
			this.DONGIA.Width = 132;
			// 
			// SONGUOIO
			// 
			this.SONGUOIO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.SONGUOIO.AppearanceHeader.Options.UseFont = true;
			this.SONGUOIO.Caption = "SỐ NGƯỜI Ở";
			this.SONGUOIO.FieldName = "SONGUOIO";
			this.SONGUOIO.MaxWidth = 100;
			this.SONGUOIO.MinWidth = 80;
			this.SONGUOIO.Name = "SONGUOIO";
			this.SONGUOIO.Visible = true;
			this.SONGUOIO.VisibleIndex = 2;
			this.SONGUOIO.Width = 99;
			// 
			// SOGIONG
			// 
			this.SOGIONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.SOGIONG.AppearanceHeader.Options.UseFont = true;
			this.SOGIONG.Caption = "SỐ GIƯỜNG";
			this.SOGIONG.FieldName = "SOGIUONG";
			this.SOGIONG.MaxWidth = 300;
			this.SOGIONG.MinWidth = 250;
			this.SOGIONG.Name = "SOGIONG";
			this.SOGIONG.Visible = true;
			this.SOGIONG.VisibleIndex = 3;
			this.SOGIONG.Width = 300;
			// 
			// DONGIATHEOGIO
			// 
			this.DONGIATHEOGIO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DONGIATHEOGIO.AppearanceHeader.Options.UseFont = true;
			this.DONGIATHEOGIO.Caption = "ĐƠN GIÁ THEO GIỜ";
			this.DONGIATHEOGIO.FieldName = "DONGIATHEOGIO";
			this.DONGIATHEOGIO.MaxWidth = 200;
			this.DONGIATHEOGIO.MinWidth = 150;
			this.DONGIATHEOGIO.Name = "DONGIATHEOGIO";
			this.DONGIATHEOGIO.Visible = true;
			this.DONGIATHEOGIO.VisibleIndex = 4;
			this.DONGIATHEOGIO.Width = 150;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.BtnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.spDonGiaTheoGio);
			this.groupControl1.Controls.Add(this.label5);
			this.groupControl1.Controls.Add(this.spDonGia);
			this.groupControl1.Controls.Add(this.nUDSogiuong);
			this.groupControl1.Controls.Add(this.nUDSonguoio);
			this.groupControl1.Controls.Add(this.label4);
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.txtTenloaiphong);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 423);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1513, 376);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Thông tin";
			// 
			// BtnHuy
			// 
			this.BtnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.BtnHuy.Appearance.Options.UseFont = true;
			this.BtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuy.ImageOptions.Image")));
			this.BtnHuy.Location = new System.Drawing.Point(802, 239);
			this.BtnHuy.Name = "BtnHuy";
			this.BtnHuy.Size = new System.Drawing.Size(196, 78);
			this.BtnHuy.TabIndex = 22;
			this.BtnHuy.Text = "Hủy";
			this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(592, 239);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(191, 78);
			this.btnLuu.TabIndex = 21;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// spDonGiaTheoGio
			// 
			this.spDonGiaTheoGio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spDonGiaTheoGio.Location = new System.Drawing.Point(477, 161);
			this.spDonGiaTheoGio.Name = "spDonGiaTheoGio";
			this.spDonGiaTheoGio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.spDonGiaTheoGio.Properties.Appearance.Options.UseFont = true;
			this.spDonGiaTheoGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spDonGiaTheoGio.Size = new System.Drawing.Size(305, 36);
			this.spDonGiaTheoGio.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label5.Location = new System.Drawing.Point(280, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 29);
			this.label5.TabIndex = 19;
			this.label5.Text = "Đơn giá theo giờ";
			// 
			// spDonGia
			// 
			this.spDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spDonGia.Location = new System.Drawing.Point(477, 113);
			this.spDonGia.Name = "spDonGia";
			this.spDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.spDonGia.Properties.Appearance.Options.UseFont = true;
			this.spDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spDonGia.Size = new System.Drawing.Size(305, 36);
			this.spDonGia.TabIndex = 18;
			// 
			// nUDSogiuong
			// 
			this.nUDSogiuong.Font = new System.Drawing.Font("Tahoma", 12F);
			this.nUDSogiuong.Location = new System.Drawing.Point(943, 113);
			this.nUDSogiuong.Name = "nUDSogiuong";
			this.nUDSogiuong.Size = new System.Drawing.Size(218, 36);
			this.nUDSogiuong.TabIndex = 17;
			this.nUDSogiuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// nUDSonguoio
			// 
			this.nUDSonguoio.Font = new System.Drawing.Font("Tahoma", 12F);
			this.nUDSonguoio.Location = new System.Drawing.Point(943, 63);
			this.nUDSonguoio.Name = "nUDSonguoio";
			this.nUDSonguoio.Size = new System.Drawing.Size(218, 36);
			this.nUDSonguoio.TabIndex = 16;
			this.nUDSonguoio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label4.Location = new System.Drawing.Point(808, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "Số giường";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label3.Location = new System.Drawing.Point(808, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Số người ở";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(364, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đơn giá";
			// 
			// txtTenloaiphong
			// 
			this.txtTenloaiphong.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtTenloaiphong.Location = new System.Drawing.Point(477, 58);
			this.txtTenloaiphong.Name = "txtTenloaiphong";
			this.txtTenloaiphong.Size = new System.Drawing.Size(305, 36);
			this.txtTenloaiphong.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(301, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên loại phòng";
			// 
			// frmLoaiPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1513, 799);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLoaiPhong.IconOptions.Image")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLoaiPhong";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại Phòng";
			this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spDonGiaTheoGio.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spDonGia.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDSogiuong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDSonguoio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnThem;
		private System.Windows.Forms.ToolStripButton btnSua;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
		private DevExpress.XtraGrid.Columns.GridColumn SONGUOIO;
		private DevExpress.XtraGrid.Columns.GridColumn SOGIONG;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenloaiphong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nUDSogiuong;
		private System.Windows.Forms.NumericUpDown nUDSonguoio;
		private DevExpress.XtraEditors.SpinEdit spDonGia;
		private DevExpress.XtraEditors.SpinEdit spDonGiaTheoGio;
		private System.Windows.Forms.Label label5;
		private DevExpress.XtraGrid.Columns.GridColumn DONGIATHEOGIO;
		private DevExpress.XtraEditors.SimpleButton BtnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
	}
}