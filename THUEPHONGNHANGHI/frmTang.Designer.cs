namespace THUEPHONGNHANGHI
{
	partial class frmTang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTang));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnThoat = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenTang = new System.Windows.Forms.TextBox();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnHuyKh = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuuKhachHang = new DevExpress.XtraEditors.SimpleButton();
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
			this.toolStrip1.Size = new System.Drawing.Size(925, 80);
			this.toolStrip1.TabIndex = 2;
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
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 80);
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
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 80);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(512, 413);
			this.gcDanhSach.TabIndex = 3;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENTANG});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
			// 
			// TENTANG
			// 
			this.TENTANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENTANG.AppearanceHeader.Options.UseFont = true;
			this.TENTANG.Caption = "TÊN TẦNG";
			this.TENTANG.FieldName = "TENTANG";
			this.TENTANG.MaxWidth = 200;
			this.TENTANG.MinWidth = 150;
			this.TENTANG.Name = "TENTANG";
			this.TENTANG.Visible = true;
			this.TENTANG.VisibleIndex = 0;
			this.TENTANG.Width = 150;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(33, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tầng";
			// 
			// txtTenTang
			// 
			this.txtTenTang.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtTenTang.Location = new System.Drawing.Point(94, 97);
			this.txtTenTang.Name = "txtTenTang";
			this.txtTenTang.Size = new System.Drawing.Size(283, 36);
			this.txtTenTang.TabIndex = 1;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.BtnHuyKh);
			this.groupControl1.Controls.Add(this.btnLuuKhachHang);
			this.groupControl1.Controls.Add(this.txtTenTang);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Location = new System.Drawing.Point(513, 80);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(412, 413);
			this.groupControl1.TabIndex = 4;
			this.groupControl1.Text = "Thông tin";
			// 
			// BtnHuyKh
			// 
			this.BtnHuyKh.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.BtnHuyKh.Appearance.Options.UseFont = true;
			this.BtnHuyKh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuyKh.ImageOptions.Image")));
			this.BtnHuyKh.Location = new System.Drawing.Point(243, 171);
			this.BtnHuyKh.Name = "BtnHuyKh";
			this.BtnHuyKh.Size = new System.Drawing.Size(134, 59);
			this.BtnHuyKh.TabIndex = 20;
			this.BtnHuyKh.Text = "Hủy";
			this.BtnHuyKh.Click += new System.EventHandler(this.BtnHuyKh_Click);
			// 
			// btnLuuKhachHang
			// 
			this.btnLuuKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnLuuKhachHang.Appearance.Options.UseFont = true;
			this.btnLuuKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKhachHang.ImageOptions.Image")));
			this.btnLuuKhachHang.Location = new System.Drawing.Point(94, 171);
			this.btnLuuKhachHang.Name = "btnLuuKhachHang";
			this.btnLuuKhachHang.Size = new System.Drawing.Size(129, 59);
			this.btnLuuKhachHang.TabIndex = 19;
			this.btnLuuKhachHang.Text = "Lưu";
			this.btnLuuKhachHang.Click += new System.EventHandler(this.btnLuuKhachHang_Click);
			// 
			// frmTang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 493);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lí tầng";
			this.Load += new System.EventHandler(this.frmTang_Load);
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnThoat;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenTang;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
		private DevExpress.XtraEditors.SimpleButton BtnHuyKh;
		private DevExpress.XtraEditors.SimpleButton btnLuuKhachHang;
	}
}