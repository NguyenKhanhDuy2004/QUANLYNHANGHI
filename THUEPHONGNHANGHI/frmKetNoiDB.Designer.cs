namespace THUEPHONGNHANGHI
{
	partial class frmKetNoiDB
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
			this.frmKetnoi = new DevExpress.XtraEditors.GroupControl();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnKiemtra = new System.Windows.Forms.Button();
			this.cboDatabase = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.frmKetnoi)).BeginInit();
			this.frmKetnoi.SuspendLayout();
			this.SuspendLayout();
			// 
			// frmKetnoi
			// 
			this.frmKetnoi.Controls.Add(this.btnThoat);
			this.frmKetnoi.Controls.Add(this.btnLuu);
			this.frmKetnoi.Controls.Add(this.btnKiemtra);
			this.frmKetnoi.Controls.Add(this.cboDatabase);
			this.frmKetnoi.Controls.Add(this.label4);
			this.frmKetnoi.Controls.Add(this.txtPassword);
			this.frmKetnoi.Controls.Add(this.label3);
			this.frmKetnoi.Controls.Add(this.txtUsername);
			this.frmKetnoi.Controls.Add(this.label2);
			this.frmKetnoi.Controls.Add(this.txtServer);
			this.frmKetnoi.Controls.Add(this.label1);
			this.frmKetnoi.Dock = System.Windows.Forms.DockStyle.Top;
			this.frmKetnoi.Location = new System.Drawing.Point(0, 0);
			this.frmKetnoi.Name = "frmKetnoi";
			this.frmKetnoi.Size = new System.Drawing.Size(993, 506);
			this.frmKetnoi.TabIndex = 0;
			this.frmKetnoi.Text = "Thông tin kết nối";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(455, 312);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(131, 46);
			this.btnThoat.TabIndex = 10;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(294, 312);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(131, 46);
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnKiemtra
			// 
			this.btnKiemtra.Location = new System.Drawing.Point(86, 312);
			this.btnKiemtra.Name = "btnKiemtra";
			this.btnKiemtra.Size = new System.Drawing.Size(131, 46);
			this.btnKiemtra.TabIndex = 8;
			this.btnKiemtra.Text = "Kiểm Tra";
			this.btnKiemtra.UseVisualStyleBackColor = true;
			this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
			// 
			// cboDatabase
			// 
			this.cboDatabase.Font = new System.Drawing.Font("Tahoma", 10F);
			this.cboDatabase.FormattingEnabled = true;
			this.cboDatabase.Location = new System.Drawing.Point(202, 231);
			this.cboDatabase.Name = "cboDatabase";
			this.cboDatabase.Size = new System.Drawing.Size(384, 32);
			this.cboDatabase.TabIndex = 7;	
			this.cboDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDatabase_MouseClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label4.Location = new System.Drawing.Point(82, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Database";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtPassword.Location = new System.Drawing.Point(202, 176);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(384, 32);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label3.Location = new System.Drawing.Point(82, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtUsername.Location = new System.Drawing.Point(202, 122);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(384, 32);
			this.txtUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label2.Location = new System.Drawing.Point(82, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username";
			// 
			// txtServer
			// 
			this.txtServer.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtServer.Location = new System.Drawing.Point(202, 72);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(384, 32);
			this.txtServer.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label1.Location = new System.Drawing.Point(82, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// frmKetNoiDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 600);
			this.Controls.Add(this.frmKetnoi);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKetNoiDB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kết nối cơ sở dữ liệu";
			this.Load += new System.EventHandler(this.frmKetNoiDB_Load);
			((System.ComponentModel.ISupportInitialize)(this.frmKetnoi)).EndInit();
			this.frmKetnoi.ResumeLayout(false);
			this.frmKetnoi.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl frmKetnoi;
		private System.Windows.Forms.ComboBox cboDatabase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnKiemtra;
	}
}