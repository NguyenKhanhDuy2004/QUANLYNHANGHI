using BusinessLayer;
using DataLayer;
using DevExpress.XtraCharts.Sankey;
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
	public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
	{
		public frmSanPham()
		{
			InitializeComponent();
		}
		SANPHAM _sanpham;
		bool _them;
		int _idsp;
		private void frmSanPham_Load(object sender, EventArgs e)
		{
			_sanpham = new SANPHAM();
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
			txtTensp.Enabled = t;
			nUDDongia.Enabled = t;
		}
		void _reset()
		{
			txtTensp.Text = "";
			nUDDongia.Value = 0;
		}
		void loadData()
		{
			gcDanhSach.DataSource = _sanpham.getAll();
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
					_sanpham.delete(_idsp);

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
				_idsp = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDSP").ToString());
				txtTensp.Text = gvDanhSach.GetFocusedRowCellValue("TENSP").ToString();
				nUDDongia.Value = int.Parse(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
			}
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_SanPham sanpham = new tb_SanPham();
				sanpham.TENSP = txtTensp.Text;
				sanpham.DONGIA = int.Parse(nUDDongia.Value.ToString()); // Lấy giá trị từ NumericUpDown

				_sanpham.add(sanpham); // Giả sử _loaiphong là lớp xử lý thêm mới
			}
			else
			{
				tb_SanPham sanpham = _sanpham.getItem(_idsp);
				sanpham.TENSP = txtTensp.Text;
				sanpham.DONGIA = int.Parse(nUDDongia.Value.ToString());
				_sanpham.update(sanpham);
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