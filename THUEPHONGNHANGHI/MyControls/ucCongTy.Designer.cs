namespace THUEPHONGNHANGHI.MyControls
{
	partial class ucCongTy
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
			this.label1 = new System.Windows.Forms.Label();
			this.cboCongTy = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.MediumBlue;
			this.label1.Location = new System.Drawing.Point(14, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 36);
			this.label1.TabIndex = 6;
			this.label1.Text = "Công ty/Chi nhánh";
			// 
			// cboCongTy
			// 
			this.cboCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboCongTy.FormattingEnabled = true;
			this.cboCongTy.Location = new System.Drawing.Point(14, 61);
			this.cboCongTy.Name = "cboCongTy";
			this.cboCongTy.Size = new System.Drawing.Size(628, 37);
			this.cboCongTy.TabIndex = 5;
			// 
			// ucCongTy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboCongTy);
			this.Name = "ucCongTy";
			this.Size = new System.Drawing.Size(766, 127);
			this.Load += new System.EventHandler(this.ucCongTy_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox cboCongTy;
	}
}
