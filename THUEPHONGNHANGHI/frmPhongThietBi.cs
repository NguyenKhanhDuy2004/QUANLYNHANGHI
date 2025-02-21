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
	public partial class frmPhongThietBi : DevExpress.XtraEditors.XtraForm
	{
		public frmPhongThietBi()
		{
			InitializeComponent();
		}
		PHONGTHIETBI _phongtb;
		PHONG _phong;
		THIETBI _thietbi;
		bool _them;
		int _idPhong;
		int _idTB;

		private void frmPhongThietBi_Load(object sender, EventArgs e)
		{
			_phongtb = new PHONGTHIETBI();
			_phong = new PHONG();
			_thietbi = new THIETBI();
			loadData();
			loadPhong();
			loadThietBi();
			showHideControl(true);
			_enabled(false);
			cboPhong.Enabled = false;
		}
		void showHideControl(bool t)
		{
			btnThem.Visible = t;
			btnSua.Visible = t;
			btnXoa.Visible = t;
			btnThoat.Visible = t;
			btnLuu.Visible = !t;
			btnHuy.Visible = !t;
		}
		void _enabled(bool t)
		{
			cboThietbi.Enabled = t;
			spSoluong.Enabled = t;
		}
		void _reset()
		{

			spSoluong.EditValue = 0;
		}
		void loadData()
		{
			gcDanhSach.DataSource = _phongtb.getAll();
			gvDanhSach.OptionsBehavior.Editable = false;
		}
		void loadThietBi()
		{
			cboThietbi.DataSource = _thietbi.getAll();
			cboThietbi.DisplayMember = "TENTB";
			cboThietbi.ValueMember = "IDTB";
		}
		void loadPhong()
		{
			cboPhong.DataSource = _phong.getAll();
			cboPhong.DisplayMember = "TENPHONG";
			cboPhong.ValueMember = "IDPHONG";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			_them = true;
			showHideControl(false);
			_enabled(true);
			_reset();
			cboPhong.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(false);
			_enabled(true);
			_reset();
			cboPhong.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				try
				{
					// Gọi phương thức xóa
					_phongtb.delete(_idTB,	_idPhong);

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

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		

		private void btnHuy_Click(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
			_reset();
			cboPhong.Enabled = false;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_PhongThietBi tb = new tb_PhongThietBi();
				tb.IDPHONG = int.Parse(cboPhong.SelectedValue.ToString());
				tb.SOLUONG = int.Parse(spSoluong.EditValue.ToString());
				tb.IDTB = int.Parse(cboThietbi.SelectedValue.ToString());
				_phongtb.add(tb); 
			}
			else
			{
				tb_PhongThietBi tb = _phongtb.getItem(_idPhong, _idTB);

				tb.SOLUONG = int.Parse(spSoluong.EditValue.ToString());
				tb.IDTB = int.Parse(cboThietbi.SelectedValue.ToString());
				_phongtb.update(tb);
			}
			_them = false;
			loadData();
			showHideControl(true);
			_enabled(false);
			cboPhong.Enabled = false;
		}
		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			_idPhong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
			_idTB = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
			spSoluong.Text = gvDanhSach.GetFocusedRowCellValue("SOLUONG").ToString();
			cboPhong.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPHONG");
			cboThietbi.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDTB");
		}
	}
}