namespace THUEPHONGNHANGHI
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.gControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
			this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
			this.navMain = new DevExpress.XtraNavBar.NavBarControl();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
			this.btnDatPhong = new DevExpress.XtraBars.BarButtonItem();
			this.btnSPDV = new DevExpress.XtraBars.BarButtonItem();
			this.btnChuyenPhong = new DevExpress.XtraBars.BarButtonItem();
			this.btnThanhToan = new DevExpress.XtraBars.BarButtonItem();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
			this.splitContainerControl1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
			this.splitContainerControl1.Panel2.SuspendLayout();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
			this.gControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(56, 56);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1320, 90);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::THUEPHONGNHANGHI.Properties.Resources.icons8_sales_performance_100;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(166, 85);
			this.toolStripButton1.Text = "Báo cáo doanh thu";
			this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton1.Click += new System.EventHandler(this.btnBaoCao_Click);
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 90);
			this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainerControl1.Name = "splitContainerControl1";
			// 
			// splitContainerControl1.Panel1
			// 
			this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White;
			this.splitContainerControl1.Panel1.Appearance.BorderColor = System.Drawing.Color.White;
			this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
			this.splitContainerControl1.Panel1.Appearance.Options.UseBorderColor = true;
			this.splitContainerControl1.Panel1.Controls.Add(this.gControl);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			// 
			// splitContainerControl1.Panel2
			// 
			this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.White;
			this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
			this.splitContainerControl1.Panel2.Controls.Add(this.navMain);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1320, 764);
			this.splitContainerControl1.SplitterPosition = 394;
			this.splitContainerControl1.TabIndex = 1;
			// 
			// gControl
			// 
			this.gControl.Controls.Add(this.galleryControlClient1);
			this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gControl.Location = new System.Drawing.Point(0, 0);
			this.gControl.Margin = new System.Windows.Forms.Padding(4);
			this.gControl.Name = "gControl";
			this.barManager1.SetPopupContextMenu(this.gControl, this.popupMenu1);
			this.gControl.Size = new System.Drawing.Size(911, 764);
			this.gControl.TabIndex = 0;
			this.gControl.Text = "galleryControl1";
			// 
			// galleryControlClient1
			// 
			this.galleryControlClient1.GalleryControl = this.gControl;
			this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
			this.galleryControlClient1.Margin = new System.Windows.Forms.Padding(4);
			this.galleryControlClient1.Size = new System.Drawing.Size(881, 760);
			// 
			// navMain
			// 
			this.navMain.Appearance.Button.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.Button.Options.UseFont = true;
			this.navMain.Appearance.ButtonDisabled.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.ButtonDisabled.Options.UseFont = true;
			this.navMain.Appearance.ButtonHotTracked.Font = new System.Drawing.Font("Tahoma", 10F);
			this.navMain.Appearance.ButtonHotTracked.Options.UseFont = true;
			this.navMain.Appearance.ButtonPressed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.ButtonPressed.Options.UseFont = true;
			this.navMain.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.GroupHeader.Options.UseFont = true;
			this.navMain.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 10F);
			this.navMain.Appearance.Item.Options.UseFont = true;
			this.navMain.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.ItemActive.Options.UseFont = true;
			this.navMain.Appearance.ItemHotTracked.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.navMain.Appearance.ItemHotTracked.Options.UseFont = true;
			this.navMain.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("Tahoma", 10F);
			this.navMain.Appearance.NavigationPaneHeader.Options.UseFont = true;
			this.navMain.BackColor = System.Drawing.Color.White;
			this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navMain.Font = new System.Drawing.Font("Tahoma", 20F);
			this.navMain.ForeColor = System.Drawing.Color.White;
			this.navMain.LargeImages = this.imageList1;
			this.navMain.Location = new System.Drawing.Point(0, 0);
			this.navMain.Margin = new System.Windows.Forms.Padding(4);
			this.navMain.Name = "navMain";
			this.navMain.OptionsNavPane.ExpandedWidth = 394;
			this.navMain.Size = new System.Drawing.Size(394, 764);
			this.navMain.SmallImages = this.imageList2;
			this.navMain.TabIndex = 0;
			this.navMain.Text = "navBarControl1";
			this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-system-100.png");
			this.imageList1.Images.SetKeyName(1, "icons8-hotel-100.png");
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "520561_seo_communication_network_connection_internet_icon.png");
			// 
			// imageList3
			// 
			this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList3.Images.SetKeyName(0, "nha nghi mau xanh nhat.png");
			this.imageList3.Images.SetKeyName(1, "nha nghi mau xanh nhat 1.png");
			this.imageList3.Images.SetKeyName(2, "nha nghi mau xanh la.png");
			this.imageList3.Images.SetKeyName(3, "nha nghi mau xanh .png");
			this.imageList3.Images.SetKeyName(4, "nha nghi mau cam.png");
			// 
			// popupMenu1
			// 
			this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDatPhong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSPDV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenPhong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThanhToan)});
			this.popupMenu1.Manager = this.barManager1;
			this.popupMenu1.Name = "popupMenu1";
			this.popupMenu1.Popup += new System.EventHandler(this.popupMenu1_Popup);
			// 
			// btnDatPhong
			// 
			this.btnDatPhong.Caption = "Đặt phòng";
			this.btnDatPhong.Id = 0;
			this.btnDatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.Image")));
			this.btnDatPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.LargeImage")));
			this.btnDatPhong.Name = "btnDatPhong";
			this.btnDatPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatPhong_ItemClick_1);
			// 
			// btnSPDV
			// 
			this.btnSPDV.Caption = "Cập nhật Sản phẩm - Dịch vụ";
			this.btnSPDV.Id = 1;
			this.btnSPDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSPDV.ImageOptions.Image")));
			this.btnSPDV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSPDV.ImageOptions.LargeImage")));
			this.btnSPDV.Name = "btnSPDV";
			this.btnSPDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSPDV_ItemClick);
			// 
			// btnChuyenPhong
			// 
			this.btnChuyenPhong.Caption = "Chuyển phòng";
			this.btnChuyenPhong.Id = 3;
			this.btnChuyenPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.ImageOptions.Image")));
			this.btnChuyenPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.ImageOptions.LargeImage")));
			this.btnChuyenPhong.Name = "btnChuyenPhong";
			this.btnChuyenPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenPhong_ItemClick);
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Caption = "Thanh toán";
			this.btnThanhToan.Id = 2;
			this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
			this.btnThanhToan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.LargeImage")));
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhToan_ItemClick);
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDatPhong,
            this.btnSPDV,
            this.btnThanhToan,
            this.btnChuyenPhong});
			this.barManager1.MaxItemId = 9;
			this.barManager1.StatusBar = this.bar2;
			// 
			// bar2
			// 
			this.bar2.BarName = "Custom 3";
			this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar2.OptionsBar.AllowQuickCustomization = false;
			this.bar2.OptionsBar.DrawDragBorder = false;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Custom 3";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlTop.Size = new System.Drawing.Size(1320, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 854);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlBottom.Size = new System.Drawing.Size(1320, 20);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 854);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1320, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 854);
			// 
			// frmMain
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1320, 874);
			this.Controls.Add(this.splitContainerControl1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhà nghỉ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
			this.splitContainerControl1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
			this.splitContainerControl1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
			this.gControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraNavBar.NavBarControl navMain;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList3;
		private DevExpress.XtraBars.PopupMenu popupMenu1;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnDatPhong;
		private DevExpress.XtraBars.BarButtonItem btnSPDV;
		private DevExpress.XtraBars.BarButtonItem btnThanhToan;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnChuyenPhong;
		public DevExpress.XtraBars.Ribbon.GalleryControl gControl;
		private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}

