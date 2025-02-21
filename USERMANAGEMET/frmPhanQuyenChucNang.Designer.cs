namespace USERMANAGEMET
{
	partial class frmPhanQuyenChucNang
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
			this.gcChucNang = new DevExpress.XtraGrid.GridControl();
			this.gvChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.FUNC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
			this.QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcUser = new DevExpress.XtraGrid.GridControl();
			this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnCamQuyen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnChiXem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnToanQuyen = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
			this.splitContainerControl1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
			this.splitContainerControl1.Panel2.SuspendLayout();
			this.splitContainerControl1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gcChucNang
			// 
			this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcChucNang.Location = new System.Drawing.Point(0, 0);
			this.gcChucNang.MainView = this.gvChucNang;
			this.gcChucNang.Name = "gcChucNang";
			this.gcChucNang.Size = new System.Drawing.Size(698, 724);
			this.gcChucNang.TabIndex = 0;
			this.gcChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChucNang,
            this.gridView1});
			// 
			// gvChucNang
			// 
			this.gvChucNang.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
			this.gvChucNang.Appearance.Row.Options.UseFont = true;
			this.gvChucNang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FUNC_CODE,
            this.DESCRIPTION,
            this.QUYEN,
            this.cISGROUP});
			this.gvChucNang.GridControl = this.gcChucNang;
			this.gvChucNang.Name = "gvChucNang";
			this.gvChucNang.OptionsSelection.MultiSelect = true;
			this.gvChucNang.OptionsView.ShowGroupPanel = false;
			this.gvChucNang.RowHeight = 35;
			// 
			// FUNC_CODE
			// 
			this.FUNC_CODE.Caption = "FUNC_CODE";
			this.FUNC_CODE.FieldName = "FUNC_CODE";
			this.FUNC_CODE.MinWidth = 30;
			this.FUNC_CODE.Name = "FUNC_CODE";
			this.FUNC_CODE.Width = 112;
			// 
			// DESCRIPTION
			// 
			this.DESCRIPTION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DESCRIPTION.AppearanceHeader.Options.UseFont = true;
			this.DESCRIPTION.Caption = "CHỨC NĂNG";
			this.DESCRIPTION.FieldName = "DESCRIPTION";
			this.DESCRIPTION.MaxWidth = 300;
			this.DESCRIPTION.MinWidth = 350;
			this.DESCRIPTION.Name = "DESCRIPTION";
			this.DESCRIPTION.Visible = true;
			this.DESCRIPTION.VisibleIndex = 0;
			this.DESCRIPTION.Width = 350;
			// 
			// QUYEN
			// 
			this.QUYEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.QUYEN.AppearanceHeader.Options.UseFont = true;
			this.QUYEN.Caption = "QUYỀN";
			this.QUYEN.FieldName = "QUYEN";
			this.QUYEN.MaxWidth = 100;
			this.QUYEN.MinWidth = 150;
			this.QUYEN.Name = "QUYEN";
			this.QUYEN.Visible = true;
			this.QUYEN.VisibleIndex = 1;
			this.QUYEN.Width = 150;
			// 
			// cISGROUP
			// 
			this.cISGROUP.Caption = "GROUP";
			this.cISGROUP.FieldName = "ISGROUP";
			this.cISGROUP.MinWidth = 30;
			this.cISGROUP.Name = "cISGROUP";
			this.cISGROUP.Width = 112;
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gcChucNang;
			this.gridView1.Name = "gridView1";
			// 
			// gcUser
			// 
			this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcUser.Location = new System.Drawing.Point(0, 0);
			this.gcUser.MainView = this.gvUser;
			this.gcUser.Name = "gcUser";
			this.gcUser.Size = new System.Drawing.Size(435, 724);
			this.gcUser.TabIndex = 0;
			this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser,
            this.gridView2});
			// 
			// gvUser
			// 
			this.gvUser.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
			this.gvUser.Appearance.Row.Options.UseFont = true;
			this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ISGROUP,
            this.USERNAME,
            this.FULLNAME,
            this.IDUSER});
			this.gvUser.GridControl = this.gcUser;
			this.gvUser.Name = "gvUser";
			this.gvUser.OptionsView.ShowGroupPanel = false;
			this.gvUser.RowHeight = 35;
			this.gvUser.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvUser_CustomDrawCell);
			this.gvUser.Click += new System.EventHandler(this.gvUser_Click);
			// 
			// ISGROUP
			// 
			this.ISGROUP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.ISGROUP.AppearanceHeader.Options.UseFont = true;
			this.ISGROUP.FieldName = "ISGROUP";
			this.ISGROUP.MaxWidth = 40;
			this.ISGROUP.MinWidth = 40;
			this.ISGROUP.Name = "ISGROUP";
			this.ISGROUP.Visible = true;
			this.ISGROUP.VisibleIndex = 0;
			this.ISGROUP.Width = 40;
			// 
			// USERNAME
			// 
			this.USERNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.USERNAME.AppearanceHeader.Options.UseFont = true;
			this.USERNAME.Caption = "USERNAME";
			this.USERNAME.FieldName = "USERNAME";
			this.USERNAME.MaxWidth = 80;
			this.USERNAME.MinWidth = 100;
			this.USERNAME.Name = "USERNAME";
			this.USERNAME.Visible = true;
			this.USERNAME.VisibleIndex = 1;
			this.USERNAME.Width = 100;
			// 
			// FULLNAME
			// 
			this.FULLNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.FULLNAME.AppearanceHeader.Options.UseFont = true;
			this.FULLNAME.Caption = "FULLNAME";
			this.FULLNAME.FieldName = "FULLNAME";
			this.FULLNAME.MaxWidth = 200;
			this.FULLNAME.MinWidth = 150;
			this.FULLNAME.Name = "FULLNAME";
			this.FULLNAME.Visible = true;
			this.FULLNAME.VisibleIndex = 2;
			this.FULLNAME.Width = 150;
			// 
			// IDUSER
			// 
			this.IDUSER.Caption = "ID";
			this.IDUSER.FieldName = "IDUSER";
			this.IDUSER.MinWidth = 30;
			this.IDUSER.Name = "IDUSER";
			this.IDUSER.Width = 112;
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gcUser;
			this.gridView2.Name = "gridView2";
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			// 
			// splitContainerControl1.Panel1
			// 
			this.splitContainerControl1.Panel1.Controls.Add(this.gcUser);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			// 
			// splitContainerControl1.Panel2
			// 
			this.splitContainerControl1.Panel2.Controls.Add(this.gcChucNang);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1148, 724);
			this.splitContainerControl1.SplitterPosition = 435;
			this.splitContainerControl1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCamQuyen,
            this.toolStripSeparator1,
            this.mnChiXem,
            this.toolStripSeparator2,
            this.mnToanQuyen});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(187, 112);
			// 
			// mnCamQuyen
			// 
			this.mnCamQuyen.Image = global::USERMANAGEMET.Properties.Resources.BOPermission_32x32;
			this.mnCamQuyen.Name = "mnCamQuyen";
			this.mnCamQuyen.Size = new System.Drawing.Size(186, 32);
			this.mnCamQuyen.Text = "Khoá quyền";
			this.mnCamQuyen.Click += new System.EventHandler(this.mnCamQuyen_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
			// 
			// mnChiXem
			// 
			this.mnChiXem.Image = global::USERMANAGEMET.Properties.Resources.User_32x32;
			this.mnChiXem.Name = "mnChiXem";
			this.mnChiXem.Size = new System.Drawing.Size(186, 32);
			this.mnChiXem.Text = "Chỉ xem";
			this.mnChiXem.Click += new System.EventHandler(this.mnChiXem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
			// 
			// mnToanQuyen
			// 
			this.mnToanQuyen.Image = global::USERMANAGEMET.Properties.Resources.BOUser_32x32;
			this.mnToanQuyen.Name = "mnToanQuyen";
			this.mnToanQuyen.Size = new System.Drawing.Size(186, 32);
			this.mnToanQuyen.Text = "Toàn quyền";
			this.mnToanQuyen.Click += new System.EventHandler(this.mnToanQuyen_Click);
			// 
			// frmPhanQuyenChucNang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 724);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "frmPhanQuyenChucNang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phân quyền chức năng";
			this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
			((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
			this.splitContainerControl1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
			this.splitContainerControl1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcChucNang;
		private DevExpress.XtraGrid.Views.Grid.GridView gvChucNang;
		private DevExpress.XtraGrid.Columns.GridColumn FUNC_CODE;
		private DevExpress.XtraGrid.Columns.GridColumn DESCRIPTION;
		private DevExpress.XtraGrid.Columns.GridColumn QUYEN;
		private DevExpress.XtraGrid.Columns.GridColumn cISGROUP;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gcUser;
		private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
		private DevExpress.XtraGrid.Columns.GridColumn ISGROUP;
		private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
		private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
		private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnCamQuyen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnChiXem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnToanQuyen;
	}
}