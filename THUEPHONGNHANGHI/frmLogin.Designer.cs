namespace THUEPHONGNHANGHI
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtUsername.Location = new System.Drawing.Point(249, 126);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(302, 36);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtPass.Location = new System.Drawing.Point(249, 177);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(302, 36);
			this.txtPass.TabIndex = 4;
			this.txtPass.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnLogin.Appearance.Options.UseFont = true;
			this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
			this.btnLogin.Location = new System.Drawing.Point(187, 248);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(168, 56);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
			this.btnThoat.Location = new System.Drawing.Point(383, 248);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(168, 56);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(249, 50);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(246, 48);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "ĐĂNG NHẬP";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(83, 133);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(160, 24);
			this.labelControl2.TabIndex = 8;
			this.labelControl2.Text = "TÊN TÀI KHOẢN";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseForeColor = true;
			this.labelControl3.Location = new System.Drawing.Point(135, 184);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(108, 24);
			this.labelControl3.TabIndex = 9;
			this.labelControl3.Text = "MẬT KHẨU";
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
			this.BackgroundImageStore = global::THUEPHONGNHANGHI.Properties.Resources.nhanghi1;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(728, 361);
			this.ControlBox = false;
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập hệ thống";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPass;
		private DevExpress.XtraEditors.SimpleButton btnLogin;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
	}
}