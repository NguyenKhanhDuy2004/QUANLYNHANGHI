namespace THUEPHONGNHANGHI
{
	partial class frmPhong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnThoat = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.chkDachothue = new System.Windows.Forms.CheckBox();
			this.cboLoaiphong = new System.Windows.Forms.ComboBox();
			this.cboTang = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenphong = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator4,
            this.btnThoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1225, 80);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources._299068_add_sign_icon;
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(60, 75);
			this.btnThem.Text = "Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::THUEPHONGNHANGHI.Properties.Resources._8725775_edit_icon__1_;
			this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(50, 75);
			this.btnSua.Text = "Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources._5402370_bin_delete_remove_trash_can_icon;
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(50, 75);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Image = global::THUEPHONGNHANGHI.Properties.Resources._1564506_close_exit_logout_power_icon;
			this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(61, 75);
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// gcDanhSach
			// 
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 80);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(1225, 343);
			this.gcDanhSach.TabIndex = 5;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.TRANGTHAI,
            this.IDTANG,
            this.TENTANG,
            this.IDLOAIPHONG,
            this.TENLOAIPHONG});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			// 
			// IDPHONG
			// 
			this.IDPHONG.Caption = "IDPHONG";
			this.IDPHONG.FieldName = "IDPHONG";
			this.IDPHONG.MinWidth = 30;
			this.IDPHONG.Name = "IDPHONG";
			this.IDPHONG.Width = 112;
			// 
			// TENPHONG
			// 
			this.TENPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENPHONG.AppearanceHeader.Options.UseFont = true;
			this.TENPHONG.Caption = "TÊN PHÒNG";
			this.TENPHONG.FieldName = "TENPHONG";
			this.TENPHONG.MaxWidth = 250;
			this.TENPHONG.MinWidth = 200;
			this.TENPHONG.Name = "TENPHONG";
			this.TENPHONG.Visible = true;
			this.TENPHONG.VisibleIndex = 0;
			this.TENPHONG.Width = 250;
			// 
			// TRANGTHAI
			// 
			this.TRANGTHAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TRANGTHAI.AppearanceHeader.Options.UseFont = true;
			this.TRANGTHAI.Caption = "TRẠNG THÁI";
			this.TRANGTHAI.FieldName = "TRANGTHAI";
			this.TRANGTHAI.MaxWidth = 150;
			this.TRANGTHAI.MinWidth = 100;
			this.TRANGTHAI.Name = "TRANGTHAI";
			this.TRANGTHAI.Visible = true;
			this.TRANGTHAI.VisibleIndex = 1;
			this.TRANGTHAI.Width = 150;
			// 
			// IDTANG
			// 
			this.IDTANG.Caption = "IDTANG";
			this.IDTANG.FieldName = "IDTANG";
			this.IDTANG.MinWidth = 30;
			this.IDTANG.Name = "IDTANG";
			this.IDTANG.Width = 99;
			// 
			// TENTANG
			// 
			this.TENTANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENTANG.AppearanceHeader.Options.UseFont = true;
			this.TENTANG.Caption = "TẦNG";
			this.TENTANG.FieldName = "TENTANG";
			this.TENTANG.MaxWidth = 250;
			this.TENTANG.MinWidth = 200;
			this.TENTANG.Name = "TENTANG";
			this.TENTANG.Visible = true;
			this.TENTANG.VisibleIndex = 2;
			this.TENTANG.Width = 214;
			// 
			// IDLOAIPHONG
			// 
			this.IDLOAIPHONG.Caption = "IDLOAIPHONG";
			this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
			this.IDLOAIPHONG.MinWidth = 30;
			this.IDLOAIPHONG.Name = "IDLOAIPHONG";
			this.IDLOAIPHONG.Width = 112;
			// 
			// TENLOAIPHONG
			// 
			this.TENLOAIPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENLOAIPHONG.AppearanceHeader.Options.UseFont = true;
			this.TENLOAIPHONG.Caption = "LOẠI PHÒNG";
			this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
			this.TENLOAIPHONG.MinWidth = 30;
			this.TENLOAIPHONG.Name = "TENLOAIPHONG";
			this.TENLOAIPHONG.Visible = true;
			this.TENLOAIPHONG.VisibleIndex = 3;
			this.TENLOAIPHONG.Width = 199;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.BtnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.chkDachothue);
			this.groupControl1.Controls.Add(this.cboLoaiphong);
			this.groupControl1.Controls.Add(this.cboTang);
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.txtTenphong);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 423);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1225, 251);
			this.groupControl1.TabIndex = 6;
			this.groupControl1.Text = "Thông tin";
			// 
			// chkDachothue
			// 
			this.chkDachothue.AutoSize = true;
			this.chkDachothue.Font = new System.Drawing.Font("Tahoma", 12F);
			this.chkDachothue.Location = new System.Drawing.Point(614, 64);
			this.chkDachothue.Name = "chkDachothue";
			this.chkDachothue.Size = new System.Drawing.Size(169, 33);
			this.chkDachothue.TabIndex = 20;
			this.chkDachothue.Text = "Đã cho thuê";
			this.chkDachothue.UseVisualStyleBackColor = true;
			// 
			// cboLoaiphong
			// 
			this.cboLoaiphong.Font = new System.Drawing.Font("Tahoma", 12F);
			this.cboLoaiphong.FormattingEnabled = true;
			this.cboLoaiphong.Location = new System.Drawing.Point(264, 168);
			this.cboLoaiphong.Name = "cboLoaiphong";
			this.cboLoaiphong.Size = new System.Drawing.Size(307, 37);
			this.cboLoaiphong.TabIndex = 19;
			// 
			// cboTang
			// 
			this.cboTang.Font = new System.Drawing.Font("Tahoma", 12F);
			this.cboTang.FormattingEnabled = true;
			this.cboTang.Location = new System.Drawing.Point(264, 108);
			this.cboTang.Name = "cboTang";
			this.cboTang.Size = new System.Drawing.Size(305, 37);
			this.cboTang.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label3.Location = new System.Drawing.Point(129, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Loại phòng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(192, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tầng";
			// 
			// txtTenphong
			// 
			this.txtTenphong.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtTenphong.Location = new System.Drawing.Point(264, 48);
			this.txtTenphong.Name = "txtTenphong";
			this.txtTenphong.Size = new System.Drawing.Size(305, 36);
			this.txtTenphong.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(132, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên phòng";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 80);
			// 
			// BtnHuy
			// 
			this.BtnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.BtnHuy.Appearance.Options.UseFont = true;
			this.BtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuy.ImageOptions.Image")));
			this.BtnHuy.Location = new System.Drawing.Point(811, 127);
			this.BtnHuy.Name = "BtnHuy";
			this.BtnHuy.Size = new System.Drawing.Size(196, 78);
			this.BtnHuy.TabIndex = 24;
			this.BtnHuy.Text = "Hủy";
			this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(601, 127);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(191, 78);
			this.btnLuu.TabIndex = 23;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// frmPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1225, 674);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmPhong";
			this.Text = "Quản lý phòng";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnThem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSua;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private System.Windows.Forms.ToolStripButton btnThoat;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
		private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
		private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenphong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkDachothue;
		private System.Windows.Forms.ComboBox cboLoaiphong;
		private System.Windows.Forms.ComboBox cboTang;
		private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private DevExpress.XtraEditors.SimpleButton BtnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
	}
}