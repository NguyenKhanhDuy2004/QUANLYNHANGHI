using BusinessLayer;
using DataLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
	{
		public frmCongTy()
		{
			InitializeComponent();
		}
		public frmCongTy(tb_SYS_USER user, int right)
		{
			InitializeComponent();
			this._user = user;
			this._right = right;
			
		}
		tb_SYS_USER _user;
		int _right;
		CONGTY _congty;
		bool _them;
		string _macty;
		private void frmCongTy_Load(object sender, EventArgs e)
		{
			_congty = new CONGTY();
			loadData();
			showHideControl(true);
			_enabled(false);
			txtMa.Enabled = false;

		}

		void showHideControl(bool t)
		{
			btnThem.Visible = t;
			btnSua.Visible = t;
			btnXoa.Visible = t;
			btnLuu.Visible = !t;
			btnHuy.Visible = !t;
		}
		void _enabled(bool t)
		{
			txtTen.Enabled = t;
			txtDienThoai.Enabled = t;
			txtFax.Enabled = t;
			txtEmail.Enabled = t;
			txtDiaChi.Enabled = t;
			chkDisabled.Enabled = t;
		}
		void _reset()
		{
			txtMa.Text = "";
			txtTen.Text = "";
			txtDienThoai.Text = "";
			txtFax.Text = "";
			txtEmail.Text = "";
			txtDiaChi.Text = "";
			chkDisabled.Checked = false;
		}

		void loadData()
		{
			gcDanhSach.DataSource = _congty.getAll();
			gvDanhSach.OptionsBehavior.Editable = false;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if(_right==1)
			{
				MessageBox.Show("Không có quyền thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}	
			_them = true;
			txtMa.Enabled = true;
			showHideControl(false);
			_enabled(true);
			_reset();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			_them = false;
			_enabled(true);
			txtMa.Enabled = false;
			showHideControl(false);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				_congty.delete(_macty);

			}
			loadData();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_CongTy cty = new tb_CongTy();
				cty.MACTY = txtMa.Text;
				cty.TENCTY = txtTen.Text;
				cty.DIACHI = txtDiaChi.Text;
				cty.DIENTHOAI = txtDienThoai.Text;
				cty.FAX = txtFax.Text;
				cty.EMAIL = txtEmail.Text;
				cty.DISABLED = chkDisabled.Checked;
				_congty.add(cty);
			}
			else
			{
				tb_CongTy cty = _congty.getItem(_macty);
				cty.TENCTY = txtTen.Text;
				cty.DIACHI = txtDiaChi.Text;
				cty.DIENTHOAI = txtDienThoai.Text;
				cty.FAX = txtFax.Text;
				cty.EMAIL = txtEmail.Text;
				cty.DISABLED = chkDisabled.Checked;
				_congty.update(cty);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
			txtMa.Enabled = false;
		}

		
		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.RowCount > 0)
			{
				_macty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
				txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
				txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
				txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
				txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
				txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
				txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
				chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());

			}

		}

		private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if (e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true)
			{
				Image img = Properties.Resources.delete1;
				e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
				e.Handled = true;
			}
		}


	}
}