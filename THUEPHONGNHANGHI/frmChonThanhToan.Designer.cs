namespace THUEPHONGNHANGHI
{
	partial class frmChonThanhToan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonThanhToan));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.spTienMat = new DevExpress.XtraEditors.SimpleButton();
			this.spChuyenKhoan = new DevExpress.XtraEditors.SimpleButton();
			this.spVisa = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(40, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(470, 97);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Thanh Toán";
			// 
			// spTienMat
			// 
			this.spTienMat.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			this.spTienMat.Appearance.Options.UseFont = true;
			this.spTienMat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spTienMat.ImageOptions.Image")));
			this.spTienMat.Location = new System.Drawing.Point(59, 144);
			this.spTienMat.Name = "spTienMat";
			this.spTienMat.Size = new System.Drawing.Size(433, 98);
			this.spTienMat.TabIndex = 1;
			this.spTienMat.Text = "TIỀN MẶT";
			this.spTienMat.Click += new System.EventHandler(this.btnTienMat_Click);
			// 
			// spChuyenKhoan
			// 
			this.spChuyenKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			this.spChuyenKhoan.Appearance.Options.UseFont = true;
			this.spChuyenKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spChuyenKhoan.ImageOptions.Image")));
			this.spChuyenKhoan.Location = new System.Drawing.Point(59, 301);
			this.spChuyenKhoan.Name = "spChuyenKhoan";
			this.spChuyenKhoan.Size = new System.Drawing.Size(433, 98);
			this.spChuyenKhoan.TabIndex = 2;
			this.spChuyenKhoan.Text = "ATM";
			this.spChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click);
			// 
			// spVisa
			// 
			this.spVisa.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			this.spVisa.Appearance.Options.UseFont = true;
			this.spVisa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spVisa.ImageOptions.Image")));
			this.spVisa.Location = new System.Drawing.Point(59, 468);
			this.spVisa.Name = "spVisa";
			this.spVisa.Size = new System.Drawing.Size(433, 98);
			this.spVisa.TabIndex = 3;
			this.spVisa.Text = "VISA";
			this.spVisa.Click += new System.EventHandler(this.btnVisa_Click);
			// 
			// frmChonThanhToan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 637);
			this.Controls.Add(this.spVisa);
			this.Controls.Add(this.spChuyenKhoan);
			this.Controls.Add(this.spTienMat);
			this.Controls.Add(this.labelControl1);
			this.MinimizeBox = false;
			this.Name = "frmChonThanhToan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChonThanhToan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton spTienMat;
		private DevExpress.XtraEditors.SimpleButton spChuyenKhoan;
		private DevExpress.XtraEditors.SimpleButton spVisa;
	}
}