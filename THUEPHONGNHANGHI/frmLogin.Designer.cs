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
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.btnCa1 = new DevExpress.XtraEditors.SimpleButton();
			this.btnCa2 = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtPass.Location = new System.Drawing.Point(150, 288);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(314, 36);
			this.txtPass.TabIndex = 4;
			this.txtPass.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.btnLogin.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLogin.Appearance.Options.UseFont = true;
			this.btnLogin.Appearance.Options.UseForeColor = true;
			this.btnLogin.BackgroundImage = global::THUEPHONGNHANGHI.Properties.Resources.Hotel_đăng_nhập;
			this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLogin.Location = new System.Drawing.Point(27, 357);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(437, 73);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseForeColor = true;
			this.labelControl3.Location = new System.Drawing.Point(27, 295);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(108, 24);
			this.labelControl3.TabIndex = 9;
			this.labelControl3.Text = "MẬT KHẨU";
			// 
			// btnCa1
			// 
			this.btnCa1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnCa1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCa1.Appearance.Options.UseFont = true;
			this.btnCa1.Appearance.Options.UseForeColor = true;
			this.btnCa1.BackgroundImage = global::THUEPHONGNHANGHI.Properties.Resources.Hotel_đăng_nhập2;
			this.btnCa1.Location = new System.Drawing.Point(178, 188);
			this.btnCa1.Name = "btnCa1";
			this.btnCa1.Size = new System.Drawing.Size(146, 71);
			this.btnCa1.TabIndex = 11;
			this.btnCa1.Text = "CA 1";
			this.btnCa1.Click += new System.EventHandler(this.btnCa1_Click);
			// 
			// btnCa2
			// 
			this.btnCa2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnCa2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCa2.Appearance.Options.UseFont = true;
			this.btnCa2.Appearance.Options.UseForeColor = true;
			this.btnCa2.BackgroundImage = global::THUEPHONGNHANGHI.Properties.Resources.Hotel_đăng_nhập3;
			this.btnCa2.Location = new System.Drawing.Point(330, 188);
			this.btnCa2.Name = "btnCa2";
			this.btnCa2.Size = new System.Drawing.Size(134, 71);
			this.btnCa2.TabIndex = 12;
			this.btnCa2.Text = "CA 2";
			this.btnCa2.Click += new System.EventHandler(this.btnCa2_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.btnAdmin.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAdmin.Appearance.Options.UseFont = true;
			this.btnAdmin.Appearance.Options.UseForeColor = true;
			this.btnAdmin.BackgroundImage = global::THUEPHONGNHANGHI.Properties.Resources.Hotel_đăng_nhập1;
			this.btnAdmin.Location = new System.Drawing.Point(27, 188);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(145, 71);
			this.btnAdmin.TabIndex = 10;
			this.btnAdmin.Text = "ADMIN";
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.btnThoat.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThoat.Appearance.Options.UseBackColor = true;
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.Appearance.Options.UseForeColor = true;
			this.btnThoat.BackgroundImage = global::THUEPHONGNHANGHI.Properties.Resources._3231313;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
			this.btnThoat.Location = new System.Drawing.Point(930, 1);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			this.btnThoat.Size = new System.Drawing.Size(70, 73);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
			this.BackgroundImageStore = global::THUEPHONGNHANGHI.Properties.Resources.Hotel2;
			this.ClientSize = new System.Drawing.Size(999, 498);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnCa2);
			this.Controls.Add(this.btnCa1);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.Image")));
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập hệ thống";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtPass;
		private DevExpress.XtraEditors.SimpleButton btnLogin;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.SimpleButton btnCa1;
		private DevExpress.XtraEditors.SimpleButton btnCa2;
		private DevExpress.XtraEditors.SimpleButton btnAdmin;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
	}
}