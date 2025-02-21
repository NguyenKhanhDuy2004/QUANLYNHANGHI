﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLayer;
using DataLayer;
using DevExpress.XtraGrid.Views.Grid;
namespace USERMANAGEMET
{
	public partial class frmPhanQuyenChucNang : DevExpress.XtraEditors.XtraForm
	{
		public frmPhanQuyenChucNang()
		{
			InitializeComponent();
		}
		public int _idUser;
		public string _macty;
		public string _madvi;
		SYS_USER _sysUser;
		SYS_RIGHT _sysRight;

		private void frmPhanQuyenChucNang_Load(object sender, EventArgs e)
		{
			_sysRight = new SYS_RIGHT();
			_sysUser = new SYS_USER();
			loadUsers();
			loadFuncByUser();
			gvChucNang.RowStyle += GvChucNang_RowStyle;
		}

		private void GvChucNang_RowStyle(object sender, RowStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isRed = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["ISGROUP"]));
				if (isRed)
				{
					e.Appearance.BackColor = Color.DarkBlue;
					e.Appearance.ForeColor = Color.White;
					e.Appearance.Font = new Font("Tahoma", 12, FontStyle.Bold);
				}
			}
		}

		void loadUsers()
		{
			if (_macty == null && _madvi == null)
			{
				gcUser.DataSource = _sysUser.getUserByDViFunc("CTCT", "~");
				gvUser.OptionsBehavior.Editable = false;

			}
			else
			{
				gcUser.DataSource = _sysUser.getUserByDViFunc(_macty, _madvi);
				gvUser.OptionsBehavior.Editable = false;
			}

		}
		void loadFuncByUser()
		{
			View_FUNC_SYS_RIGHT _vFuncRight = new View_FUNC_SYS_RIGHT();
			gcChucNang.DataSource = _vFuncRight.getFuncByUser(_idUser);
			gvChucNang.OptionsBehavior.Editable = false;
			for (int i = 0; i < gvUser.RowCount; i++)
			{
				if (int.Parse(gvUser.GetRowCellValue(i, "IDUSER").ToString()) == _idUser)
				{
					gvUser.ClearSelection();
					gvUser.FocusedRowHandle = i;

				}
				gvChucNang.ClearSelection();

			}
		}

		private void gvUser_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == false)
			{
				Image img = Properties.Resources.user1;
				e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
				e.Handled = true;
			}
			if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == true)
			{
				Image img = Properties.Resources.group1;
				e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
				e.Handled = true;
			}
		}

		private void mnCamQuyen_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < gvChucNang.RowCount; i++)
			{
				if (gvChucNang.IsRowSelected(i))
				{
					_sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 0);
				}
			}
			loadFuncByUser();
		}


		private void mnChiXem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < gvChucNang.RowCount; i++)
			{
				if (gvChucNang.IsRowSelected(i))
				{
					_sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 1);
				}
			}
			loadFuncByUser();

		}

		private void mnToanQuyen_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < gvChucNang.RowCount; i++)
			{
				if (gvChucNang.IsRowSelected(i))
				{
					_sysRight.update(_idUser, gvChucNang.GetRowCellValue(i, "FUNC_CODE").ToString(), 2);
				}
			}
			loadFuncByUser();
		}

		private void gvUser_Click(object sender, EventArgs e)
		{
			_idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
			loadFuncByUser();
		}
	}
}