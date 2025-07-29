namespace THUEPHONGNHANGHI
{
	partial class frmDonVi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonVi));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
			this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
			this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENDVI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.cboCty = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
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
            this.btnSua,
            this.btnXoa});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1259, 80);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_add_1001;
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
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_recycle_bin_1002;
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
			this.gcDanhSach.Size = new System.Drawing.Size(1259, 232);
			this.gcDanhSach.TabIndex = 2;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.MACTY,
            this.MADVI,
            this.TENDVI,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
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
			this.MACTY.Width = 79;
			// 
			// MADVI
			// 
			this.MADVI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.MADVI.AppearanceHeader.Options.UseFont = true;
			this.MADVI.Caption = "MADVI";
			this.MADVI.FieldName = "MADVI";
			this.MADVI.MinWidth = 30;
			this.MADVI.Name = "MADVI";
			this.MADVI.Width = 112;
			// 
			// TENDVI
			// 
			this.TENDVI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENDVI.AppearanceHeader.Options.UseFont = true;
			this.TENDVI.Caption = "TÊN ĐƠN VỊ";
			this.TENDVI.FieldName = "TENDVI";
			this.TENDVI.MaxWidth = 250;
			this.TENDVI.MinWidth = 200;
			this.TENDVI.Name = "TENDVI";
			this.TENDVI.Visible = true;
			this.TENDVI.VisibleIndex = 1;
			this.TENDVI.Width = 246;
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
			this.DIENTHOAI.VisibleIndex = 2;
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
			this.FAX.VisibleIndex = 3;
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
			this.EMAIL.VisibleIndex = 4;
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
			this.DIACHI.VisibleIndex = 5;
			this.DIACHI.Width = 350;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.BtnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.cboCty);
			this.groupControl1.Controls.Add(this.label7);
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
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 312);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1259, 359);
			this.groupControl1.TabIndex = 3;
			this.groupControl1.Text = "Thông tin";
			// 
			// BtnHuy
			// 
			this.BtnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.BtnHuy.Appearance.Options.UseFont = true;
			this.BtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuy.ImageOptions.Image")));
			this.BtnHuy.Location = new System.Drawing.Point(998, 268);
			this.BtnHuy.Name = "BtnHuy";
			this.BtnHuy.Size = new System.Drawing.Size(151, 66);
			this.BtnHuy.TabIndex = 22;
			this.BtnHuy.Text = "Hủy";
			this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(834, 268);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(146, 66);
			this.btnLuu.TabIndex = 21;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// cboCty
			// 
			this.cboCty.Font = new System.Drawing.Font("Tahoma", 12F);
			this.cboCty.FormattingEnabled = true;
			this.cboCty.Location = new System.Drawing.Point(307, 58);
			this.cboCty.Name = "cboCty";
			this.cboCty.Size = new System.Drawing.Size(844, 37);
			this.cboCty.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label7.Location = new System.Drawing.Point(93, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(208, 29);
			this.label7.TabIndex = 14;
			this.label7.Text = "Công ty/Chi nhánh";
			// 
			// chkDisabled
			// 
			this.chkDisabled.AutoSize = true;
			this.chkDisabled.Font = new System.Drawing.Font("Tahoma", 12F);
			this.chkDisabled.Location = new System.Drawing.Point(986, 207);
			this.chkDisabled.Name = "chkDisabled";
			this.chkDisabled.Size = new System.Drawing.Size(165, 33);
			this.chkDisabled.TabIndex = 13;
			this.chkDisabled.Text = "Vô hiệu quá";
			this.chkDisabled.UseVisualStyleBackColor = true;
			// 
			// txtMa
			// 
			this.txtMa.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtMa.Location = new System.Drawing.Point(166, 106);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(283, 36);
			this.txtMa.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label6.Location = new System.Drawing.Point(92, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 29);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mã";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtDiaChi.Location = new System.Drawing.Point(645, 151);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(506, 36);
			this.txtDiaChi.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label5.Location = new System.Drawing.Point(553, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 29);
			this.label5.TabIndex = 8;
			this.label5.Text = "Địa chỉ";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtEmail.Location = new System.Drawing.Point(166, 204);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(283, 36);
			this.txtEmail.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label4.Location = new System.Drawing.Point(92, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email";
			// 
			// txtFax
			// 
			this.txtFax.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtFax.Location = new System.Drawing.Point(645, 203);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(335, 36);
			this.txtFax.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label3.Location = new System.Drawing.Point(576, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fax";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtDienThoai.Location = new System.Drawing.Point(645, 105);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(506, 36);
			this.txtDienThoai.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label2.Location = new System.Drawing.Point(511, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Điện Thoại";
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtTen.Location = new System.Drawing.Point(166, 152);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(283, 36);
			this.txtTen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(92, 156);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên";
			// 
			// frmDonVi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1259, 671);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDonVi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin Đơn vị";
			this.Load += new System.EventHandler(this.frmDonVi_Load);
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
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
		private DevExpress.XtraGrid.Columns.GridColumn MACTY;
		private DevExpress.XtraGrid.Columns.GridColumn TENDVI;
		private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
		private DevExpress.XtraGrid.Columns.GridColumn FAX;
		private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
		private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
		private DevExpress.XtraGrid.Columns.GridColumn MADVI;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.CheckBox chkDisabled;
		private System.Windows.Forms.TextBox txtMa;
		private System.Windows.Forms.Label label6;
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboCty;
		private DevExpress.XtraEditors.SimpleButton BtnHuy;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
	}
}