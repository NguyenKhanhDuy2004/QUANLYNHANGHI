namespace USERMANAGEMET
{
	partial class frmUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
			this.tabUser = new DevExpress.XtraTab.XtraTabControl();
			this.pageUser = new DevExpress.XtraTab.XtraTabPage();
			this.chkDisabled = new System.Windows.Forms.CheckBox();
			this.txtRePass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pageGroup = new DevExpress.XtraTab.XtraTabPage();
			this.btnBot = new DevExpress.XtraEditors.SimpleButton();
			this.btnThem = new DevExpress.XtraEditors.SimpleButton();
			this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
			this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
			this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnDong = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.tabUser)).BeginInit();
			this.tabUser.SuspendLayout();
			this.pageUser.SuspendLayout();
			this.pageGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// tabUser
			// 
			this.tabUser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabUser.Location = new System.Drawing.Point(0, 0);
			this.tabUser.Name = "tabUser";
			this.tabUser.SelectedTabPage = this.pageUser;
			this.tabUser.Size = new System.Drawing.Size(823, 300);
			this.tabUser.TabIndex = 0;
			this.tabUser.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageUser,
            this.pageGroup});
			// 
			// pageUser
			// 
			this.pageUser.Controls.Add(this.chkDisabled);
			this.pageUser.Controls.Add(this.txtRePass);
			this.pageUser.Controls.Add(this.label3);
			this.pageUser.Controls.Add(this.txtPass);
			this.pageUser.Controls.Add(this.label4);
			this.pageUser.Controls.Add(this.txtHoten);
			this.pageUser.Controls.Add(this.label2);
			this.pageUser.Controls.Add(this.txtUsername);
			this.pageUser.Controls.Add(this.label1);
			this.pageUser.Name = "pageUser";
			this.pageUser.Size = new System.Drawing.Size(821, 265);
			this.pageUser.Text = "Thông tin";
			// 
			// chkDisabled
			// 
			this.chkDisabled.AutoSize = true;
			this.chkDisabled.Location = new System.Drawing.Point(299, 214);
			this.chkDisabled.Name = "chkDisabled";
			this.chkDisabled.Size = new System.Drawing.Size(120, 23);
			this.chkDisabled.TabIndex = 12;
			this.chkDisabled.Text = "Vô hiệu hoá";
			this.chkDisabled.UseVisualStyleBackColor = true;
			// 
			// txtRePass
			// 
			this.txtRePass.Font = new System.Drawing.Font("Tahoma", 8F);
			this.txtRePass.Location = new System.Drawing.Point(299, 162);
			this.txtRePass.Name = "txtRePass";
			this.txtRePass.Size = new System.Drawing.Size(311, 27);
			this.txtRePass.TabIndex = 11;
			this.txtRePass.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(126, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 19);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nhập lại Mật khẩu";
			// 
			// txtPass
			// 
			this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPass.Font = new System.Drawing.Font("Tahoma", 8F);
			this.txtPass.Location = new System.Drawing.Point(299, 119);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(311, 27);
			this.txtPass.TabIndex = 9;
			this.txtPass.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(198, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mật khẩu";
			// 
			// txtHoten
			// 
			this.txtHoten.Font = new System.Drawing.Font("Tahoma", 8F);
			this.txtHoten.Location = new System.Drawing.Point(299, 77);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(311, 27);
			this.txtHoten.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(220, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Họ tên";
			// 
			// txtUsername
			// 
			this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.txtUsername.Location = new System.Drawing.Point(299, 41);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(311, 27);
			this.txtUsername.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(153, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tên đăng nhập";
			// 
			// pageGroup
			// 
			this.pageGroup.Controls.Add(this.btnBot);
			this.pageGroup.Controls.Add(this.btnThem);
			this.pageGroup.Controls.Add(this.gcThanhVien);
			this.pageGroup.Name = "pageGroup";
			this.pageGroup.Size = new System.Drawing.Size(821, 265);
			this.pageGroup.Text = "Nhóm";
			// 
			// btnBot
			// 
			this.btnBot.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnBot.Appearance.Options.UseFont = true;
			this.btnBot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBot.ImageOptions.Image")));
			this.btnBot.Location = new System.Drawing.Point(635, 209);
			this.btnBot.Name = "btnBot";
			this.btnBot.Size = new System.Drawing.Size(137, 44);
			this.btnBot.TabIndex = 5;
			this.btnBot.Text = "Bớt";
			this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
			// 
			// btnThem
			// 
			this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnThem.Appearance.Options.UseFont = true;
			this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
			this.btnThem.Location = new System.Drawing.Point(463, 209);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(137, 44);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// gcThanhVien
			// 
			this.gcThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcThanhVien.Location = new System.Drawing.Point(0, 0);
			this.gcThanhVien.MainView = this.gvThanhVien;
			this.gcThanhVien.Name = "gcThanhVien";
			this.gcThanhVien.Size = new System.Drawing.Size(821, 203);
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
			// btnDong
			// 
			this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnDong.Appearance.Options.UseFont = true;
			this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
			this.btnDong.Location = new System.Drawing.Point(636, 320);
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
			this.btnLuu.Location = new System.Drawing.Point(464, 320);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(137, 57);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// frmUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 406);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.tabUser);
			this.Controls.Add(this.btnLuu);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Người";
			this.Load += new System.EventHandler(this.frmUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabUser)).EndInit();
			this.tabUser.ResumeLayout(false);
			this.pageUser.ResumeLayout(false);
			this.pageUser.PerformLayout();
			this.pageGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTab.XtraTabControl tabUser;
		private DevExpress.XtraTab.XtraTabPage pageUser;
		private DevExpress.XtraTab.XtraTabPage pageGroup;
		private DevExpress.XtraEditors.SimpleButton btnDong;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraGrid.GridControl gcThanhVien;
		private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
		private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
		private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
		private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
		private DevExpress.XtraEditors.SimpleButton btnBot;
		private DevExpress.XtraEditors.SimpleButton btnThem;
		private System.Windows.Forms.TextBox txtHoten;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRePass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkDisabled;
	}
}