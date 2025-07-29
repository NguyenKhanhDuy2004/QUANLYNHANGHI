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
	public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
	{
		public frmThietBi()
		{
			InitializeComponent();
		}
		THIETBI _thietbi;
		bool _them;
		int _idtb;
		private void frmThietBi_Load(object sender, EventArgs e)
		{
			_thietbi = new THIETBI();
			loadData();
			showHideControl(true);
			_enabled(false);
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
			txtTentb.Enabled = t;
			nUDDongia.Enabled = t;
		}
		void _reset()
		{
			txtTentb.Text = "";
			nUDDongia.Value = 0;
		}
		void loadData()
		{
			gcDanhSach.DataSource = _thietbi.getAll();
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
					_thietbi.delete(_idtb);

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

		private void gcDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.RowCount > 0)
			{
				_idtb = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTB").ToString());
				txtTentb.Text = gvDanhSach.GetFocusedRowCellValue("TENTB").ToString();
				nUDDongia.Value = int.Parse(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
			}
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_ThietBi thietbi = new tb_ThietBi();
				thietbi.TENTB = txtTentb.Text;
				thietbi.DONGIA = int.Parse(nUDDongia.Value.ToString()); // Lấy giá trị từ NumericUpDown

				_thietbi.add(thietbi); // Giả sử _loaiphong là lớp xử lý thêm mới
			}
			else
			{
				tb_ThietBi thietbi = _thietbi.getItem(_idtb);
				thietbi.TENTB = txtTentb.Text;
				thietbi.DONGIA = int.Parse(nUDDongia.Value.ToString());
				_thietbi.update(thietbi);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
		}

		private void btnHuy_Click_1(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
		}
	}
}