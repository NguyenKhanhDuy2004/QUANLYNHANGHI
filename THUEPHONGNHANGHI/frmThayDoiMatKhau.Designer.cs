namespace THUEPHONGNHANGHI
{
	partial class frmThayDoiMatKhau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiMatKhau));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.txtGolaiMKMoi = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMKMoi = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtMKCu = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
			this.btnDong = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
			this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.groupControl1.Controls.Add(this.txtGolaiMKMoi);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtMKMoi);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.txtMKCu);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(771, 263);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Thông tin đổi mật khẩu";
			// 
			// txtGolaiMKMoi
			// 
			this.txtGolaiMKMoi.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtGolaiMKMoi.Location = new System.Drawing.Point(243, 182);
			this.txtGolaiMKMoi.Name = "txtGolaiMKMoi";
			this.txtGolaiMKMoi.Size = new System.Drawing.Size(379, 32);
			this.txtGolaiMKMoi.TabIndex = 5;
			this.txtGolaiMKMoi.UseSystemPasswordChar = true;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(35, 190);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(202, 24);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Nhập lại mật khẩu mới";
			// 
			// txtMKMoi
			// 
			this.txtMKMoi.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtMKMoi.Location = new System.Drawing.Point(243, 129);
			this.txtMKMoi.Name = "txtMKMoi";
			this.txtMKMoi.Size = new System.Drawing.Size(379, 32);
			this.txtMKMoi.TabIndex = 3;
			this.txtMKMoi.UseSystemPasswordChar = true;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(116, 132);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(121, 24);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Mật khẩu mới";
			// 
			// txtMKCu
			// 
			this.txtMKCu.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtMKCu.Location = new System.Drawing.Point(243, 68);
			this.txtMKCu.Name = "txtMKCu";
			this.txtMKCu.Size = new System.Drawing.Size(379, 32);
			this.txtMKCu.TabIndex = 1;
			this.txtMKCu.UseSystemPasswordChar = true;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(120, 71);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(108, 24);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Mật khẩu cũ";
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
			this.btnCapNhat.Location = new System.Drawing.Point(212, 283);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(172, 61);
			this.btnCapNhat.TabIndex = 1;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnDong
			// 
			this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
			this.btnDong.Location = new System.Drawing.Point(406, 283);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(172, 61);
			this.btnDong.TabIndex = 2;
			this.btnDong.Text = "Huỷ";
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// frmThayDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 369);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.groupControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmThayDoiMatKhau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi mật khẩu";
			this.Load += new System.EventHandler(this.frmThayDoiMatKhau_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.TextBox txtGolaiMKMoi;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.TextBox txtMKMoi;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtMKCu;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton btnCapNhat;
		private DevExpress.XtraEditors.SimpleButton btnDong;
	}
}