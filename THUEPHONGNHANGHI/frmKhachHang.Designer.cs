namespace THUEPHONGNHANGHI
{
	partial class frmKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGioitinh = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCCCD = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PHAI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
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
			this.toolStrip1.Size = new System.Drawing.Size(1414, 80);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_add_1002;
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
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_recycle_bin_1003;
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(50, 75);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.Controls.Add(this.BtnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.txtHoten);
			this.groupControl1.Controls.Add(this.label6);
			this.groupControl1.Controls.Add(this.txtGioitinh);
			this.groupControl1.Controls.Add(this.txtDiaChi);
			this.groupControl1.Controls.Add(this.label5);
			this.groupControl1.Controls.Add(this.txtCCCD);
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(963, 80);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(451, 673);
			this.groupControl1.TabIndex = 4;
			this.groupControl1.Text = "Thông Tin Khách Hàng";
			// 
			// BtnHuy
			// 
			this.BtnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.BtnHuy.Appearance.Options.UseFont = true;
			this.BtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuy.ImageOptions.Image")));
			this.BtnHuy.Location = new System.Drawing.Point(280, 338);
			this.BtnHuy.Name = "BtnHuy";
			this.BtnHuy.Size = new System.Drawing.Size(134, 59);
			this.BtnHuy.TabIndex = 18;
			this.BtnHuy.Text = "Hủy";
			this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(131, 338);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(129, 59);
			this.btnLuu.TabIndex = 17;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// txtHoten
			// 
			this.txtHoten.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtHoten.Location = new System.Drawing.Point(131, 140);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(283, 36);
			this.txtHoten.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(34, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 19);
			this.label6.TabIndex = 15;
			this.label6.Text = "Giới tính";
			// 
			// txtGioitinh
			// 
			this.txtGioitinh.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtGioitinh.Location = new System.Drawing.Point(131, 182);
			this.txtGioitinh.Name = "txtGioitinh";
			this.txtGioitinh.Size = new System.Drawing.Size(283, 36);
			this.txtGioitinh.TabIndex = 14;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtDiaChi.Location = new System.Drawing.Point(131, 266);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(283, 36);
			this.txtDiaChi.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(34, 277);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Địa chỉ";
			// 
			// txtCCCD
			// 
			this.txtCCCD.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtCCCD.Location = new System.Drawing.Point(131, 224);
			this.txtCCCD.Name = "txtCCCD";
			this.txtCCCD.Size = new System.Drawing.Size(283, 36);
			this.txtCCCD.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(34, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "CCCD";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(34, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ và Tên";
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
			this.gvDanhSach.Appearance.Row.Options.UseFont = true;
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HOTEN,
            this.PHAI,
            this.CCCD,
            this.DIACHI});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.RowHeight = 35;
			this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
			this.gvDanhSach.DoubleClick += new System.EventHandler(this.gvDanhSach_DoubleClick);
			// 
			// HOTEN
			// 
			this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.HOTEN.AppearanceHeader.Options.UseFont = true;
			this.HOTEN.Caption = "HỌ TÊN";
			this.HOTEN.FieldName = "HOTEN";
			this.HOTEN.MaxWidth = 250;
			this.HOTEN.MinWidth = 200;
			this.HOTEN.Name = "HOTEN";
			this.HOTEN.Visible = true;
			this.HOTEN.VisibleIndex = 0;
			this.HOTEN.Width = 200;
			// 
			// PHAI
			// 
			this.PHAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.PHAI.AppearanceHeader.Options.UseFont = true;
			this.PHAI.Caption = "GIỚI TÍNH";
			this.PHAI.FieldName = "PHAI";
			this.PHAI.MaxWidth = 100;
			this.PHAI.MinWidth = 150;
			this.PHAI.Name = "PHAI";
			this.PHAI.Visible = true;
			this.PHAI.VisibleIndex = 1;
			this.PHAI.Width = 150;
			// 
			// CCCD
			// 
			this.CCCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.CCCD.AppearanceHeader.Options.UseFont = true;
			this.CCCD.Caption = "CCCD";
			this.CCCD.FieldName = "CCCD";
			this.CCCD.MaxWidth = 100;
			this.CCCD.MinWidth = 150;
			this.CCCD.Name = "CCCD";
			this.CCCD.Visible = true;
			this.CCCD.VisibleIndex = 2;
			this.CCCD.Width = 150;
			// 
			// DIACHI
			// 
			this.DIACHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DIACHI.AppearanceHeader.Options.UseFont = true;
			this.DIACHI.Caption = "ĐỊA CHỈ";
			this.DIACHI.FieldName = "DIACHI";
			this.DIACHI.MaxWidth = 350;
			this.DIACHI.MinWidth = 250;
			this.DIACHI.Name = "DIACHI";
			this.DIACHI.Visible = true;
			this.DIACHI.VisibleIndex = 3;
			this.DIACHI.Width = 250;
			// 
			// gcDanhSach
			// 
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 80);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(963, 673);
			this.gcDanhSach.TabIndex = 3;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1414, 753);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmKhachHang.IconOptions.Image")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKhachHang";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý khách hàng";
			this.Load += new System.EventHandler(this.frmKhachHang_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnThem;
		private System.Windows.Forms.ToolStripButton btnSua;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCCCD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGioitinh;
		private System.Windows.Forms.TextBox txtHoten;
		private DevExpress.XtraEditors.SimpleButton BtnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
		private DevExpress.XtraGrid.Columns.GridColumn PHAI;
		private DevExpress.XtraGrid.Columns.GridColumn CCCD;
		private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
	}
}