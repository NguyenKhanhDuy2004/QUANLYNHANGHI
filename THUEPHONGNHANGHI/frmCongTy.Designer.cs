namespace THUEPHONGNHANGHI
{
	partial class frmCongTy
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnLuu = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnHuy = new System.Windows.Forms.ToolStripButton();
			this.btnThoat = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
			this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.chkDisabled = new System.Windows.Forms.CheckBox();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
            this.btnLuu,
            this.toolStripSeparator4,
            this.btnHuy,
            this.btnThoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1282, 80);
			this.toolStrip1.TabIndex = 0;
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
			// btnLuu
			// 
			this.btnLuu.Image = global::THUEPHONGNHANGHI.Properties.Resources._285657_floppy_guardar_save_icon__1_;
			this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(50, 75);
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 80);
			// 
			// btnHuy
			// 
			this.btnHuy.Image = global::THUEPHONGNHANGHI.Properties.Resources._299045_sign_error_icon;
			this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(50, 75);
			this.btnHuy.Text = "Hủy";
			this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
			this.gcDanhSach.Location = new System.Drawing.Point(0, 83);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(1282, 389);
			this.gcDanhSach.TabIndex = 1;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.MACTY,
            this.TENCTY,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.RowHeight = 35;
			this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
			this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
			// 
			// DISABLED
			// 
			this.DISABLED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DISABLED.AppearanceHeader.Options.UseFont = true;
			this.DISABLED.Caption = "DEL";
			this.DISABLED.FieldName = "DISABLED";
			this.DISABLED.MaxWidth = 40;
			this.DISABLED.MinWidth = 25;
			this.DISABLED.Name = "DISABLED";
			this.DISABLED.Visible = true;
			this.DISABLED.VisibleIndex = 0;
			this.DISABLED.Width = 40;
			// 
			// MACTY
			// 
			this.MACTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.MACTY.AppearanceHeader.Options.UseFont = true;
			this.MACTY.Caption = "MACTY";
			this.MACTY.FieldName = "MACTY";
			this.MACTY.MaxWidth = 80;
			this.MACTY.MinWidth = 50;
			this.MACTY.Name = "MACTY";
			this.MACTY.Visible = true;
			this.MACTY.VisibleIndex = 1;
			this.MACTY.Width = 79;
			// 
			// TENCTY
			// 
			this.TENCTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENCTY.AppearanceHeader.Options.UseFont = true;
			this.TENCTY.Caption = "TÊN CÔNG TY";
			this.TENCTY.FieldName = "TENCTY";
			this.TENCTY.MaxWidth = 250;
			this.TENCTY.MinWidth = 200;
			this.TENCTY.Name = "TENCTY";
			this.TENCTY.Visible = true;
			this.TENCTY.VisibleIndex = 2;
			this.TENCTY.Width = 246;
			// 
			// DIENTHOAI
			// 
			this.DIENTHOAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DIENTHOAI.AppearanceHeader.Options.UseFont = true;
			this.DIENTHOAI.Caption = "ĐIỆN THOẠI";
			this.DIENTHOAI.FieldName = "DIENTHOAI";
			this.DIENTHOAI.MaxWidth = 150;
			this.DIENTHOAI.MinWidth = 100;
			this.DIENTHOAI.Name = "DIENTHOAI";
			this.DIENTHOAI.Visible = true;
			this.DIENTHOAI.VisibleIndex = 3;
			this.DIENTHOAI.Width = 132;
			// 
			// FAX
			// 
			this.FAX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.FAX.AppearanceHeader.Options.UseFont = true;
			this.FAX.Caption = "FAX";
			this.FAX.FieldName = "FAX";
			this.FAX.MaxWidth = 100;
			this.FAX.MinWidth = 80;
			this.FAX.Name = "FAX";
			this.FAX.Visible = true;
			this.FAX.VisibleIndex = 4;
			this.FAX.Width = 99;
			// 
			// EMAIL
			// 
			this.EMAIL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.EMAIL.AppearanceHeader.Options.UseFont = true;
			this.EMAIL.Caption = "EMAIL";
			this.EMAIL.FieldName = "EMAIL";
			this.EMAIL.MaxWidth = 300;
			this.EMAIL.MinWidth = 250;
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.Visible = true;
			this.EMAIL.VisibleIndex = 5;
			this.EMAIL.Width = 300;
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
			this.DIACHI.VisibleIndex = 6;
			this.DIACHI.Width = 350;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.chkDisabled);
			this.groupControl1.Controls.Add(this.txtMa);
			this.groupControl1.Controls.Add(this.label6);
			this.groupControl1.Controls.Add(this.txtDiaChi);
			this.groupControl1.Controls.Add(this.label5);
			this.groupControl1.Controls.Add(this.txtEmail);
			this.groupControl1.Controls.Add(this.label4);
			this.groupControl1.Controls.Add(this.txtFax);
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.txtDienThoai);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.txtTen);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 469);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.ShowCaption = false;
			this.groupControl1.Size = new System.Drawing.Size(1282, 272);
			this.groupControl1.TabIndex = 2;
			this.groupControl1.Text = "Thông tin";
			// 
			// chkDisabled
			// 
			this.chkDisabled.AutoSize = true;
			this.chkDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
			this.chkDisabled.Location = new System.Drawing.Point(992, 157);
			this.chkDisabled.Name = "chkDisabled";
			this.chkDisabled.Size = new System.Drawing.Size(142, 28);
			this.chkDisabled.TabIndex = 13;
			this.chkDisabled.Text = "Vô hiệu hoá";
			this.chkDisabled.UseVisualStyleBackColor = true;
			// 
			// txtMa
			// 
			this.txtMa.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtMa.Location = new System.Drawing.Point(231, 57);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(283, 32);
			this.txtMa.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label6.Location = new System.Drawing.Point(163, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mã";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtDiaChi.Location = new System.Drawing.Point(648, 106);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(487, 32);
			this.txtDiaChi.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label5.Location = new System.Drawing.Point(556, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Địa chỉ";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtEmail.Location = new System.Drawing.Point(231, 150);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(283, 32);
			this.txtEmail.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label4.Location = new System.Drawing.Point(163, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email";
			// 
			// txtFax
			// 
			this.txtFax.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtFax.Location = new System.Drawing.Point(648, 153);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(338, 32);
			this.txtFax.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label3.Location = new System.Drawing.Point(556, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fax";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtDienThoai.Location = new System.Drawing.Point(648, 60);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(487, 32);
			this.txtDienThoai.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label2.Location = new System.Drawing.Point(535, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Điện Thoại";
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtTen.Location = new System.Drawing.Point(231, 103);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(283, 32);
			this.txtTen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label1.Location = new System.Drawing.Point(163, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên";
			// 
			// frmCongTy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 741);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCongTy";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh mục Công ty";
			this.Load += new System.EventHandler(this.frmCongTy_Load);
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
		private System.Windows.Forms.ToolStripButton btnSua;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private System.Windows.Forms.ToolStripButton btnLuu;
		private System.Windows.Forms.ToolStripButton btnHuy;
		private System.Windows.Forms.ToolStripButton btnThoat;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
		private DevExpress.XtraGrid.Columns.GridColumn MACTY;
		private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
		private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
		private DevExpress.XtraGrid.Columns.GridColumn FAX;
		private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
		private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.TextBox txtMa;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkDisabled;
	}
}