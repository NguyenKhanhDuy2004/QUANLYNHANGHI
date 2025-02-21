namespace THUEPHONGNHANGHI
{
	partial class frmSetParam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetParam));
			this.label1 = new System.Windows.Forms.Label();
			this.cboCongTy = new System.Windows.Forms.ComboBox();
			this.cboDonVi = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(114, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Công ty - Chi nhánh";
			// 
			// cboCongTy
			// 
			this.cboCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboCongTy.FormattingEnabled = true;
			this.cboCongTy.Location = new System.Drawing.Point(118, 105);
			this.cboCongTy.Name = "cboCongTy";
			this.cboCongTy.Size = new System.Drawing.Size(712, 37);
			this.cboCongTy.TabIndex = 2;
			// 
			// cboDonVi
			// 
			this.cboDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboDonVi.FormattingEnabled = true;
			this.cboDonVi.Location = new System.Drawing.Point(118, 193);
			this.cboDonVi.Name = "cboDonVi";
			this.cboDonVi.Size = new System.Drawing.Size(712, 37);
			this.cboDonVi.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(114, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Đơn vị trực thuộc";
			// 
			// btnThoat
			// 
			this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
			this.btnThoat.Location = new System.Drawing.Point(658, 266);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(172, 65);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
			this.btnXacNhan.Location = new System.Drawing.Point(468, 266);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(172, 65);
			this.btnXacNhan.TabIndex = 5;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// frmSetParam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 393);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.cboDonVi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboCongTy);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetParam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xác lập đơn vị sử dụng";
			this.Load += new System.EventHandler(this.frmSetParam_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboCongTy;
		private System.Windows.Forms.ComboBox cboDonVi;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.SimpleButton btnXacNhan;
		private DevExpress.XtraEditors.SimpleButton btnThoat;
	}
}