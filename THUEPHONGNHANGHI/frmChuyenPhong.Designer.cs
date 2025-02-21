namespace THUEPHONGNHANGHI
{
	partial class frmChuyenPhong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenPhong));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.btnChuyenPhong = new DevExpress.XtraEditors.SimpleButton();
			this.searchPhong = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPhong = new System.Windows.Forms.Label();
			this.lblPhongHienTai = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPhong.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.Controls.Add(this.btnThoat);
			this.groupControl1.Controls.Add(this.btnChuyenPhong);
			this.groupControl1.Controls.Add(this.searchPhong);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Controls.Add(this.lblPhong);
			this.groupControl1.Controls.Add(this.lblPhongHienTai);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(811, 317);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Chọn phòng chuyển đến";
			// 
			// btnThoat
			// 
			this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
			this.btnThoat.Location = new System.Drawing.Point(462, 218);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(152, 62);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnChuyenPhong
			// 
			this.btnChuyenPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.ImageOptions.Image")));
			this.btnChuyenPhong.Location = new System.Drawing.Point(244, 218);
			this.btnChuyenPhong.Name = "btnChuyenPhong";
			this.btnChuyenPhong.Size = new System.Drawing.Size(152, 62);
			this.btnChuyenPhong.TabIndex = 4;
			this.btnChuyenPhong.Text = "Chuyển phòng";
			this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
			// 
			// searchPhong
			// 
			this.searchPhong.Location = new System.Drawing.Point(320, 157);
			this.searchPhong.Name = "searchPhong";
			this.searchPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.searchPhong.Properties.NullText = "";
			this.searchPhong.Properties.PopupView = this.searchLookUpEdit1View;
			this.searchPhong.Size = new System.Drawing.Size(348, 26);
			this.searchPhong.TabIndex = 3;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.DONGIA});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// IDPHONG
			// 
			this.IDPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.IDPHONG.AppearanceHeader.Options.UseFont = true;
			this.IDPHONG.Caption = "ID";
			this.IDPHONG.FieldName = "IDPHONG";
			this.IDPHONG.Name = "IDPHONG";
			this.IDPHONG.Visible = true;
			this.IDPHONG.VisibleIndex = 0;
			// 
			// TENPHONG
			// 
			this.TENPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.TENPHONG.AppearanceHeader.Options.UseFont = true;
			this.TENPHONG.Caption = "TÊN PHÒNG";
			this.TENPHONG.FieldName = "TENPHONG";
			this.TENPHONG.Name = "TENPHONG";
			this.TENPHONG.Visible = true;
			this.TENPHONG.VisibleIndex = 1;
			// 
			// DONGIA
			// 
			this.DONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DONGIA.AppearanceHeader.Options.UseFont = true;
			this.DONGIA.Caption = "ĐƠN GIÁ";
			this.DONGIA.FieldName = "DONGIA";
			this.DONGIA.Name = "DONGIA";
			this.DONGIA.Visible = true;
			this.DONGIA.VisibleIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label1.Location = new System.Drawing.Point(140, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Phòng chuyển đến";
			// 
			// lblPhong
			// 
			this.lblPhong.AutoSize = true;
			this.lblPhong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lblPhong.ForeColor = System.Drawing.Color.Red;
			this.lblPhong.Location = new System.Drawing.Point(316, 94);
			this.lblPhong.Name = "lblPhong";
			this.lblPhong.Size = new System.Drawing.Size(80, 24);
			this.lblPhong.TabIndex = 1;
			this.lblPhong.Text = "Phòng ";
			// 
			// lblPhongHienTai
			// 
			this.lblPhongHienTai.AutoSize = true;
			this.lblPhongHienTai.Font = new System.Drawing.Font("Tahoma", 10F);
			this.lblPhongHienTai.Location = new System.Drawing.Point(168, 94);
			this.lblPhongHienTai.Name = "lblPhongHienTai";
			this.lblPhongHienTai.Size = new System.Drawing.Size(145, 24);
			this.lblPhongHienTai.TabIndex = 0;
			this.lblPhongHienTai.Text = "Phòng hiện tại:";
			// 
			// frmChuyenPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 317);
			this.Controls.Add(this.groupControl1);
			this.Name = "frmChuyenPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chuyển phòng";
			this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPhong.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.Label lblPhong;
		private System.Windows.Forms.Label lblPhongHienTai;
		private DevExpress.XtraEditors.SearchLookUpEdit searchPhong;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
		private DevExpress.XtraEditors.SimpleButton btnChuyenPhong;
		private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
		private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
	}
}