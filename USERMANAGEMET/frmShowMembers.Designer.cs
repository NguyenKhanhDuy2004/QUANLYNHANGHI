﻿namespace USERMANAGEMET
{
	partial class frmShowMembers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowMembers));
			this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
			this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
			this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnDong = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// gcThanhVien
			// 
			this.gcThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcThanhVien.Location = new System.Drawing.Point(0, 0);
			this.gcThanhVien.MainView = this.gvThanhVien;
			this.gcThanhVien.Name = "gcThanhVien";
			this.gcThanhVien.Size = new System.Drawing.Size(832, 304);
			this.gcThanhVien.TabIndex = 1;
			this.gcThanhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThanhVien});
			// 
			// gvThanhVien
			// 
			this.gvThanhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
			this.gvThanhVien.GridControl = this.gcThanhVien;
			this.gvThanhVien.Name = "gvThanhVien";
			// 
			// IDUSER
			// 
			this.IDUSER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.IDUSER.AppearanceHeader.Options.UseFont = true;
			this.IDUSER.Caption = "ID";
			this.IDUSER.FieldName = "IDUSER";
			this.IDUSER.MaxWidth = 50;
			this.IDUSER.MinWidth = 30;
			this.IDUSER.Name = "IDUSER";
			this.IDUSER.Width = 50;
			// 
			// USERNAME
			// 
			this.USERNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.USERNAME.AppearanceHeader.Options.UseFont = true;
			this.USERNAME.Caption = "USERNAME";
			this.USERNAME.FieldName = "USERNAME";
			this.USERNAME.MaxWidth = 150;
			this.USERNAME.MinWidth = 100;
			this.USERNAME.Name = "USERNAME";
			this.USERNAME.Visible = true;
			this.USERNAME.VisibleIndex = 0;
			this.USERNAME.Width = 112;
			// 
			// FULLNAME
			// 
			this.FULLNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.FULLNAME.AppearanceHeader.Options.UseFont = true;
			this.FULLNAME.Caption = "FULLNAME";
			this.FULLNAME.FieldName = "FULLNAME";
			this.FULLNAME.MaxWidth = 250;
			this.FULLNAME.MinWidth = 200;
			this.FULLNAME.Name = "FULLNAME";
			this.FULLNAME.Visible = true;
			this.FULLNAME.VisibleIndex = 1;
			this.FULLNAME.Width = 200;
			// 
			// btnDong
			// 
			this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnDong.Appearance.Options.UseFont = true;
			this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
			this.btnDong.Location = new System.Drawing.Point(635, 318);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(137, 57);
			this.btnDong.TabIndex = 4;
			this.btnDong.Text = "Thoát";
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(463, 318);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(137, 57);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// frmShowMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 387);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.gcThanhVien);
			this.Name = "frmShowMembers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách thành viên";
			this.Load += new System.EventHandler(this.frmShowMembers_Load);
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcThanhVien;
		private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
		private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
		private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
		private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
		private DevExpress.XtraEditors.SimpleButton btnDong;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
	}
}