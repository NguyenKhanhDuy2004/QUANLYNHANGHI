namespace THUEPHONGNHANGHI.MyControls
{
	partial class ucDonVi
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cboDonVi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboCongTy = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cboDonVi);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cboCongTy);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(766, 230);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.MediumBlue;
			this.label2.Location = new System.Drawing.Point(16, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 36);
			this.label2.TabIndex = 6;
			this.label2.Text = "Đơn vị";
			// 
			// cboDonVi
			// 
			this.cboDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboDonVi.FormattingEnabled = true;
			this.cboDonVi.Location = new System.Drawing.Point(16, 147);
			this.cboDonVi.Name = "cboDonVi";
			this.cboDonVi.Size = new System.Drawing.Size(628, 37);
			this.cboDonVi.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.MediumBlue;
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Công ty/Chi nhánh";
			// 
			// cboCongTy
			// 
			this.cboCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboCongTy.FormattingEnabled = true;
			this.cboCongTy.Location = new System.Drawing.Point(16, 58);
			this.cboCongTy.Name = "cboCongTy";
			this.cboCongTy.Size = new System.Drawing.Size(628, 37);
			this.cboCongTy.TabIndex = 3;
			// 
			// ucDonVi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ucDonVi";
			this.Size = new System.Drawing.Size(766, 230);
			this.Load += new System.EventHandler(this.ucDonVi_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox cboDonVi;
		public System.Windows.Forms.ComboBox cboCongTy;
	}
}
