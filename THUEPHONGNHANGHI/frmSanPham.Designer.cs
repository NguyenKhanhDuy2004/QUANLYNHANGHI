namespace THUEPHONGNHANGHI
{
	partial class frmSanPham
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.label2 = new System.Windows.Forms.Label();
			this.nUDDongia = new System.Windows.Forms.NumericUpDown();
			this.txtTensp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDDongia)).BeginInit();
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
			this.toolStrip1.Size = new System.Drawing.Size(1255, 80);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_add_1006;
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
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_recycle_bin_1007;
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(50, 75);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// gcDanhSach
			// 
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 80);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(705, 631);
			this.gcDanhSach.TabIndex = 6;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENSP,
            this.DONGIA});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.RowHeight = 35;
			// 
			// TENSP
			// 
			this.TENSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENSP.AppearanceHeader.Options.UseFont = true;
			this.TENSP.Caption = "TÊN SẢN PHẨM";
			this.TENSP.FieldName = "TENSP";
			this.TENSP.MaxWidth = 250;
			this.TENSP.MinWidth = 200;
			this.TENSP.Name = "TENSP";
			this.TENSP.Visible = true;
			this.TENSP.VisibleIndex = 0;
			this.TENSP.Width = 246;
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
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.nUDDongia);
			this.groupControl1.Controls.Add(this.txtTensp);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupControl1.Location = new System.Drawing.Point(705, 80);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(550, 631);
			this.groupControl1.TabIndex = 7;
			this.groupControl1.Text = "Thông tin";
			// 
			// btnHuy
			// 
			this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnHuy.Appearance.Options.UseFont = true;
			this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
			this.btnHuy.Location = new System.Drawing.Point(371, 267);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(133, 62);
			this.btnHuy.TabIndex = 27;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(199, 267);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(133, 62);
			this.btnLuu.TabIndex = 26;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(87, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 29);
			this.label2.TabIndex = 17;
			this.label2.Text = "Đơn giá";
			// 
			// nUDDongia
			// 
			this.nUDDongia.Font = new System.Drawing.Font("Tahoma", 12F);
			this.nUDDongia.Location = new System.Drawing.Point(199, 194);
			this.nUDDongia.Maximum = new decimal(new int[] {
            1233977344,
            465661,
            0,
            0});
			this.nUDDongia.Name = "nUDDongia";
			this.nUDDongia.Size = new System.Drawing.Size(305, 36);
			this.nUDDongia.TabIndex = 16;
			this.nUDDongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTensp
			// 
			this.txtTensp.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtTensp.Location = new System.Drawing.Point(199, 139);
			this.txtTensp.Name = "txtTensp";
			this.txtTensp.Size = new System.Drawing.Size(305, 36);
			this.txtTensp.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(28, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên sản phẩm";
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 711);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmSanPham";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh mục Sản Phẩm - Dịch Vụ";
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDDongia)).EndInit();
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
		private DevExpress.XtraGrid.Columns.GridColumn TENSP;
		private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.TextBox txtTensp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nUDDongia;
		private DevExpress.XtraEditors.SimpleButton btnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
	}
}