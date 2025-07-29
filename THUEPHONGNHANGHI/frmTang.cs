using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmTang : DevExpress.XtraEditors.XtraForm
	{
		public frmTang()
		{
			InitializeComponent();
		}
		TANG _tang;
		bool _them;
		int _idtang;

		private void frmTang_Load(object sender, EventArgs e)
		{
			_tang = new TANG();
			loadData();
			showHideControl(true);
			_enabled(false);
		}
		void showHideControl(bool t)
		{
			btnThem.Visible = t;
			btnSua.Visible = t;
			btnXoa.Visible = t;
			
		}
		void _enabled(bool t)
		{
			txtTenTang.Enabled = t;
		}
		void _reset()
		{
			txtTenTang.Text = "";
		}
		void loadData()
		{
			gcDanhSach.DataSource = _tang.getAll();
			gvDanhSach.OptionsBehavior.Editable = false;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			_them = true;
			showHideControl(false);
			_enabled(true);
			_reset();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			_them = false;
			_enabled(true);
			showHideControl(false);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				try
				{
					// Gọi phương thức xóa
					_tang.delete(_idtang);

					// Tải lại dữ liệu sau khi xóa
					loadData();

					// Thông báo thành công
					MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					// Hiển thị lỗi nếu có vấn đề xảy ra
					MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_Tang tang = new tb_Tang();
				tang.TENTANG = txtTenTang.Text;
				_tang.add(tang);
			}
			else
			{
				tb_Tang tang = _tang.getItem(_idtang);
				tang.TENTANG = txtTenTang.Text;
				_tang.update(tang);
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
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.RowCount > 0)
			{
				_idtang = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString());
				txtTenTang.Text = gvDanhSach.GetFocusedRowCellValue("TENTANG").ToString();

			}
		}

		private void btnLuuKhachHang_Click(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_Tang tang = new tb_Tang();
				tang.TENTANG = txtTenTang.Text;
				_tang.add(tang);
			}
			else
			{
				tb_Tang tang = _tang.getItem(_idtang);
				tang.TENTANG = txtTenTang.Text;
				_tang.update(tang);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
		}

		private void BtnHuyKh_Click(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
		}
	}
}