namespace USERMANAGEMET
{
	partial class frmGroup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
			this.tabGroup = new DevExpress.XtraTab.XtraTabControl();
			this.pageNhom = new DevExpress.XtraTab.XtraTabPage();
			this.txtMota = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenNhom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pageThanhVien = new DevExpress.XtraTab.XtraTabPage();
			this.btnBot = new DevExpress.XtraEditors.SimpleButton();
			this.btnThem = new DevExpress.XtraEditors.SimpleButton();
			this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
			this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
			this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.btnDong = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.tabGroup)).BeginInit();
			this.tabGroup.SuspendLayout();
			this.pageNhom.SuspendLayout();
			this.pageThanhVien.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// tabGroup
			// 
			this.tabGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabGroup.Location = new System.Drawing.Point(0, 0);
			this.tabGroup.Name = "tabGroup";
			this.tabGroup.SelectedTabPage = this.pageNhom;
			this.tabGroup.Size = new System.Drawing.Size(876, 435);
			this.tabGroup.TabIndex = 0;
			this.tabGroup.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageNhom,
            this.pageThanhVien});
			// 
			// pageNhom
			// 
			this.pageNhom.Controls.Add(this.txtMota);
			this.pageNhom.Controls.Add(this.label2);
			this.pageNhom.Controls.Add(this.txtTenNhom);
			this.pageNhom.Controls.Add(this.label1);
			this.pageNhom.Name = "pageNhom";
			this.pageNhom.Size = new System.Drawing.Size(874, 400);
			this.pageNhom.Text = "Thông tin nhóm";
			// 
			// txtMota
			// 
			this.txtMota.Font = new System.Drawing.Font("Tahoma", 8F);
			this.txtMota.Location = new System.Drawing.Point(301, 190);
			this.txtMota.Name = "txtMota";
			this.txtMota.Size = new System.Drawing.Size(311, 27);
			this.txtMota.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(240, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mô tả";
			// 
			// txtTenNhom
			// 
			this.txtTenNhom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTenNhom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.txtTenNhom.Location = new System.Drawing.Point(301, 143);
			this.txtTenNhom.Name = "txtTenNhom";
			this.txtTenNhom.Size = new System.Drawing.Size(311, 27);
			this.txtTenNhom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(205, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên nhóm";
			// 
			// pageThanhVien
			// 
			this.pageThanhVien.Controls.Add(this.btnBot);
			this.pageThanhVien.Controls.Add(this.btnThem);
			this.pageThanhVien.Controls.Add(this.gcThanhVien);
			this.pageThanhVien.Name = "pageThanhVien";
			this.pageThanhVien.Size = new System.Drawing.Size(874, 400);
			this.pageThanhVien.Text = "Thành viên";
			// 
			// btnBot
			// 
			this.btnBot.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnBot.Appearance.Options.UseFont = true;
			this.btnBot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBot.ImageOptions.Image")));
			this.btnBot.Location = new System.Drawing.Point(682, 324);
			this.btnBot.Name = "btnBot";
			this.btnBot.Size = new System.Drawing.Size(137, 44);
			this.btnBot.TabIndex = 3;
			this.btnBot.Text = "Bớt";
			this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
			// 
			// btnThem
			// 
			this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnThem.Appearance.Options.UseFont = true;
			this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
			this.btnThem.Location = new System.Drawing.Point(510, 324);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(137, 44);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// gcThanhVien
			// 
			this.gcThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcThanhVien.Location = new System.Drawing.Point(0, 0);
			this.gcThanhVien.MainView = this.gvThanhVien;
			this.gcThanhVien.Name = "gcThanhVien";
			this.gcThanhVien.Size = new System.Drawing.Size(874, 304);
			this.gcThanhVien.TabIndex = 0;
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
			this.IDUSER.Visible = true;
			this.IDUSER.VisibleIndex = 0;
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
			this.USERNAME.VisibleIndex = 1;
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
			this.FULLNAME.VisibleIndex = 2;
			this.FULLNAME.Width = 200;
			// 
			// btnLuu
			// 
			this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnLuu.Appearance.Options.UseFont = true;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(511, 462);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(137, 57);
			this.btnLuu.TabIndex = 1;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnDong
			// 
			this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnDong.Appearance.Options.UseFont = true;
			this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
			this.btnDong.Location = new System.Drawing.Point(683, 462);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(137, 57);
			this.btnDong.TabIndex = 2;
			this.btnDong.Text = "Thoát";
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// frmGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 531);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.tabGroup);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhóm người dùng";
			this.Load += new System.EventHandler(this.frmGroup_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabGroup)).EndInit();
			this.tabGroup.ResumeLayout(false);
			this.pageNhom.ResumeLayout(false);
			this.pageNhom.PerformLayout();
			this.pageThanhVien.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTab.XtraTabControl tabGroup;
		private DevExpress.XtraTab.XtraTabPage pageNhom;
		private DevExpress.XtraTab.XtraTabPage pageThanhVien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMota;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenNhom;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraEditors.SimpleButton btnDong;
		private DevExpress.XtraEditors.SimpleButton btnBot;
		private DevExpress.XtraEditors.SimpleButton btnThem;
		private DevExpress.XtraGrid.GridControl gcThanhVien;
		private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
		private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
		private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
		private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
	}
}