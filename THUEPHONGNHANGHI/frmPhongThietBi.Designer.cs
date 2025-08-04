namespace THUEPHONGNHANGHI
{
	partial class frmPhongThietBi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongThietBi));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IDTB = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENTB = new DevExpress.XtraGrid.Columns.GridColumn();
			this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboPhong = new System.Windows.Forms.ComboBox();
			this.cboThietbi = new System.Windows.Forms.ComboBox();
			this.spSoluong = new DevExpress.XtraEditors.SpinEdit();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spSoluong.Properties)).BeginInit();
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
			this.toolStrip1.Size = new System.Drawing.Size(1357, 80);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_add_1005;
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
			this.btnXoa.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_recycle_bin_1006;
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
			this.gcDanhSach.Size = new System.Drawing.Size(867, 594);
			this.gcDanhSach.TabIndex = 8;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.IDTB,
            this.TENTB,
            this.SOLUONG});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.RowHeight = 35;
			this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
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
			this.TENPHONG.MaxWidth = 200;
			this.TENPHONG.MinWidth = 150;
			this.TENPHONG.Name = "TENPHONG";
			this.TENPHONG.Visible = true;
			this.TENPHONG.VisibleIndex = 0;
			this.TENPHONG.Width = 150;
			// 
			// IDTB
			// 
			this.IDTB.Caption = "IDTB";
			this.IDTB.FieldName = "IDTB";
			this.IDTB.MinWidth = 30;
			this.IDTB.Name = "IDTB";
			this.IDTB.Width = 112;
			// 
			// TENTB
			// 
			this.TENTB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENTB.AppearanceHeader.Options.UseFont = true;
			this.TENTB.Caption = "TÊN THIẾT BỊ";
			this.TENTB.FieldName = "TENTB";
			this.TENTB.MaxWidth = 500;
			this.TENTB.MinWidth = 300;
			this.TENTB.Name = "TENTB";
			this.TENTB.Visible = true;
			this.TENTB.VisibleIndex = 1;
			this.TENTB.Width = 400;
			// 
			// SOLUONG
			// 
			this.SOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.SOLUONG.AppearanceHeader.Options.UseFont = true;
			this.SOLUONG.Caption = "SỐ LƯỢNG";
			this.SOLUONG.FieldName = "SOLUONG";
			this.SOLUONG.MaxWidth = 100;
			this.SOLUONG.MinWidth = 150;
			this.SOLUONG.Name = "SOLUONG";
			this.SOLUONG.Visible = true;
			this.SOLUONG.VisibleIndex = 2;
			this.SOLUONG.Width = 150;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(39, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phòng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(13, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 29);
			this.label2.TabIndex = 17;
			this.label2.Text = "Số lượng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(28, 223);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 29);
			this.label3.TabIndex = 18;
			this.label3.Text = "Thiết bị";
			// 
			// cboPhong
			// 
			this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboPhong.FormattingEnabled = true;
			this.cboPhong.Location = new System.Drawing.Point(133, 178);
			this.cboPhong.Name = "cboPhong";
			this.cboPhong.Size = new System.Drawing.Size(305, 37);
			this.cboPhong.TabIndex = 19;
			// 
			// cboThietbi
			// 
			this.cboThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboThietbi.FormattingEnabled = true;
			this.cboThietbi.Location = new System.Drawing.Point(133, 223);
			this.cboThietbi.Name = "cboThietbi";
			this.cboThietbi.Size = new System.Drawing.Size(305, 37);
			this.cboThietbi.TabIndex = 20;
			// 
			// spSoluong
			// 
			this.spSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spSoluong.Location = new System.Drawing.Point(133, 270);
			this.spSoluong.Name = "spSoluong";
			this.spSoluong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.spSoluong.Properties.Appearance.Options.UseFont = true;
			this.spSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spSoluong.Size = new System.Drawing.Size(305, 36);
			this.spSoluong.TabIndex = 21;
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(133, 334);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(133, 62);
			this.btnLuu.TabIndex = 22;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnHuy.Appearance.Options.UseFont = true;
			this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
			this.btnHuy.Location = new System.Drawing.Point(305, 334);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(133, 62);
			this.btnHuy.TabIndex = 23;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.Controls.Add(this.btnHuy);
			this.groupControl1.Controls.Add(this.btnLuu);
			this.groupControl1.Controls.Add(this.spSoluong);
			this.groupControl1.Controls.Add(this.cboThietbi);
			this.groupControl1.Controls.Add(this.cboPhong);
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(867, 80);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(490, 594);
			this.groupControl1.TabIndex = 9;
			this.groupControl1.Text = "Thông tin các thiết bị của phòng";
			// 
			// frmPhongThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1357, 674);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPhongThietBi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phòng Thiết Bị Của Các Phòng";
			this.Load += new System.EventHandler(this.frmPhongThietBi_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spSoluong.Properties)).EndInit();
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
		private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn IDTB;
		private DevExpress.XtraGrid.Columns.GridColumn TENTB;
		private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
		private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboPhong;
		private System.Windows.Forms.ComboBox cboThietbi;
		private DevExpress.XtraEditors.SpinEdit spSoluong;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraEditors.SimpleButton btnHuy;
		private DevExpress.XtraEditors.GroupControl groupControl1;
	}
}