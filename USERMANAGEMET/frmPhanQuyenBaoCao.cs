using System;
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

namespace USERMANAGEMET
{
	public partial class frmPhanQuyenBaoCao : DevExpress.XtraEditors.XtraForm
	{
		public frmPhanQuyenBaoCao()
		{
			InitializeComponent();
		}
		public int _idUser;
		public string _macty;
		public string _madvi;
		SYS_USER _sysUser;
		SYS_RIGHT_REP _sysRightRep;

		private void FrmPhanQuyenBaoCao_Load(object sender, EventArgs e)
		{
			_sysUser = new SYS_USER();
			_sysRightRep = new SYS_RIGHT_REP();
			loadUsers();
			loadRepByUser();
		}
		void loadUsers()
		{
			if (_macty == null && _madvi == null)
			{
				gcUser.DataSource = _sysUser.getUserByDVI("CTCT", "~");
				gvUser.OptionsBehavior.Editable = false;

			}
			else
			{
				gcUser.DataSource = _sysUser.getUserByDViFunc(_macty, _madvi);
				gvUser.OptionsBehavior.Editable = false;
			}

		}
		void loadRepByUser()
		{
			View_REP_SYS_RIGHT_REP _vFuncRight = new View_REP_SYS_RIGHT_REP();
			gcChucNang.DataSource = _vFuncRight.getRepByUser(_idUser);
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
					_sysRightRep.update(_idUser, int.Parse(gvChucNang.GetRowCellValue(i, "REP_CODE").ToString()), false);
				}
			}
			loadRepByUser();

		}

		private void mnToanQuyen_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < gvChucNang.RowCount; i++)
			{
				if (gvChucNang.IsRowSelected(i))
				{
					_sysRightRep.update(_idUser, int.Parse(gvChucNang.GetRowCellValue(i, "REP_CODE").ToString()), true);
				}
			}
			loadRepByUser();
		}

		private void gvUser_Click(object sender, EventArgs e)
		{
			_idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
			loadRepByUser();
		}
	}
}