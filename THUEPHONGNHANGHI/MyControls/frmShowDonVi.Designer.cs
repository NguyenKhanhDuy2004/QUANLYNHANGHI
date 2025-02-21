namespace THUEPHONGNHANGHI.MyControls
{
	partial class frmShowDonVi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDonVi));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.cboCongTy = new System.Windows.Forms.ComboBox();
			this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
			this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENDVI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.Controls.Add(this.cboCongTy);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(754, 100);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Công ty/ Chi nhánh";
			// 
			// cboCongTy
			// 
			this.cboCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboCongTy.FormattingEnabled = true;
			this.cboCongTy.Location = new System.Drawing.Point(12, 47);
			this.cboCongTy.Name = "cboCongTy";
			this.cboCongTy.Size = new System.Drawing.Size(730, 37);
			this.cboCongTy.TabIndex = 2;
			// 
			// gcDanhSach
			// 
			this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcDanhSach.Location = new System.Drawing.Point(0, 100);
			this.gcDanhSach.MainView = this.gvDanhSach;
			this.gcDanhSach.Name = "gcDanhSach";
			this.gcDanhSach.Size = new System.Drawing.Size(754, 200);
			this.gcDanhSach.TabIndex = 1;
			this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
			// 
			// gvDanhSach
			// 
			this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
			this.gvDanhSach.Appearance.Row.Options.UseFont = true;
			this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MADVI,
            this.TENDVI});
			this.gvDanhSach.GridControl = this.gcDanhSach;
			this.gvDanhSach.Name = "gvDanhSach";
			this.gvDanhSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			this.gvDanhSach.OptionsView.ShowGroupPanel = false;
			this.gvDanhSach.RowHeight = 25;
			// 
			// MADVI
			// 
			this.MADVI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.MADVI.AppearanceHeader.Options.UseFont = true;
			this.MADVI.Caption = "MÃ ĐƠN VỊ";
			this.MADVI.FieldName = "MADVI";
			this.MADVI.MinWidth = 30;
			this.MADVI.Name = "MADVI";
			this.MADVI.Visible = true;
			this.MADVI.VisibleIndex = 0;
			this.MADVI.Width = 112;
			// 
			// TENDVI
			// 
			this.TENDVI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENDVI.AppearanceHeader.Options.UseFont = true;
			this.TENDVI.Caption = "TÊN ĐƠN VỊ";
			this.TENDVI.FieldName = "TENDVI";
			this.TENDVI.MinWidth = 30;
			this.TENDVI.Name = "TENDVI";
			this.TENDVI.Visible = true;
			this.TENDVI.VisibleIndex = 1;
			this.TENDVI.Width = 112;
			// 
			// btnThoat
			// 
			this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
			this.btnThoat.Location = new System.Drawing.Point(538, 320);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(180, 73);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Đóng";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnThucHien
			// 
			this.btnThucHien.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnThucHien.Appearance.Options.UseFont = true;
			this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
			this.btnThucHien.Location = new System.Drawing.Point(355, 320);
			this.btnThucHien.Name = "btnThucHien";
			this.btnThucHien.Size = new System.Drawing.Size(177, 73);
			this.btnThucHien.TabIndex = 2;
			this.btnThucHien.Text = "Thực hiện";
			this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
			// 
			// frmShowDonVi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 405);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnThucHien);
			this.Controls.Add(this.gcDanhSach);
			this.Controls.Add(this.groupControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmShowDonVi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn đơn vị cần chạy báo cáo";
			this.Load += new System.EventHandler(this.frmShowDonVi_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.ComboBox cboCongTy;
		private DevExpress.XtraGrid.GridControl gcDanhSach;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
		private DevExpress.XtraGrid.Columns.GridColumn MADVI;
		private DevExpress.XtraGrid.Columns.GridColumn TENDVI;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
		private DevExpress.XtraEditors.SimpleButton btnThucHien;
	}
}