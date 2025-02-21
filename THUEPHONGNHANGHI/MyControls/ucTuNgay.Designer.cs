namespace THUEPHONGNHANGHI.MyControls
{
	partial class ucTuNgay
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.label1 = new System.Windows.Forms.Label();
			this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
			this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.groupControl1.AppearanceCaption.Options.UseFont = true;
			this.groupControl1.Controls.Add(this.dtDenNgay);
			this.groupControl1.Controls.Add(this.label2);
			this.groupControl1.Controls.Add(this.dtTuNgay);
			this.groupControl1.Controls.Add(this.label1);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(742, 116);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Chọn khoảng thời gian";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label1.Location = new System.Drawing.Point(45, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày";
			// 
			// dtTuNgay
			// 
			this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
			this.dtTuNgay.Font = new System.Drawing.Font("Tahoma", 10F);
			this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtTuNgay.Location = new System.Drawing.Point(134, 58);
			this.dtTuNgay.Name = "dtTuNgay";
			this.dtTuNgay.Size = new System.Drawing.Size(184, 32);
			this.dtTuNgay.TabIndex = 1;
			this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
			this.dtTuNgay.Leave += new System.EventHandler(this.dtTuNgay_Leave);
			// 
			// dtDenNgay
			// 
			this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
			this.dtDenNgay.Font = new System.Drawing.Font("Tahoma", 10F);
			this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDenNgay.Location = new System.Drawing.Point(469, 58);
			this.dtDenNgay.Name = "dtDenNgay";
			this.dtDenNgay.Size = new System.Drawing.Size(184, 32);
			this.dtDenNgay.TabIndex = 3;
			this.dtDenNgay.ValueChanged += new System.EventHandler(this.dtDenNgay_ValueChanged);
			this.dtDenNgay.Leave += new System.EventHandler(this.dtDenNgay_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
			this.label2.Location = new System.Drawing.Point(368, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đến ngày";
			// 
			// ucTuNgay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupControl1);
			this.Name = "ucTuNgay";
			this.Size = new System.Drawing.Size(742, 116);
			this.Load += new System.EventHandler(this.ucTuNgay_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		public System.Windows.Forms.DateTimePicker dtDenNgay;
		public System.Windows.Forms.DateTimePicker dtTuNgay;
	}
}
