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
	public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
	{
		public frmLoaiPhong()
		{
			InitializeComponent();
		}
		LOAIPHONG _loaiphong;
		bool _them;
		int _idloaiphong;

		private void frmLoaiPhong_Load(object sender, EventArgs e)
		{

			_loaiphong = new LOAIPHONG();
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
			txtTenloaiphong.Enabled = t;
			spDonGia.Enabled = t;
			spDonGiaTheoGio.Enabled = t;
			nUDSogiuong.Enabled = t;
			nUDSonguoio.Enabled = t;
		}
		void _reset()
		{
			txtTenloaiphong.Text = "";
			spDonGia.Value = 0;
			spDonGiaTheoGio.Value = 0;
			nUDSogiuong.Value = 0;
			nUDSonguoio.Value = 0;
		}
		void loadData()
		{
			gcDanhSach.DataSource = _loaiphong.getAll();
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
					_loaiphong.delete(_idloaiphong);

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

		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.RowCount > 0)
			{
				_idloaiphong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
				txtTenloaiphong.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
				spDonGia.Value = int.Parse(gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString());
				spDonGiaTheoGio.Value = int.Parse(gvDanhSach.GetFocusedRowCellValue("DONGIATHEOGIO").ToString());
				nUDSogiuong.Value = int.Parse(gvDanhSach.GetFocusedRowCellValue("SOGIUONG").ToString());
				var cellValue = gvDanhSach.GetFocusedRowCellValue("SONGUOIO");
				if (cellValue != null)
				{
					nUDSonguoio.Value = int.Parse(cellValue.ToString());
				}
				else
				{
					MessageBox.Show("Cột 'SONGUOI' không có dữ liệu hoặc dòng chưa được chọn.",
									"Lỗi",
									MessageBoxButtons.OK,
									MessageBoxIcon.Warning);
				}

			}
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{

			if (_them)
			{
				tb_LoaiPhong loaiphong = new tb_LoaiPhong();
				loaiphong.TENLOAIPHONG = txtTenloaiphong.Text;
				loaiphong.DONGIA = int.Parse(spDonGia.Value.ToString());
				loaiphong.DONGIATHEOGIO = int.Parse(spDonGiaTheoGio.Value.ToString());// Lấy giá trị từ NumericUpDown
				loaiphong.SOGIUONG = int.Parse(nUDSogiuong.Value.ToString()); // Nếu cần số giường
				loaiphong.SONGUOIO = int.Parse(nUDSonguoio.Value.ToString()); // Nếu cần số người

				_loaiphong.add(loaiphong); // Giả sử _loaiphong là lớp xử lý thêm mới
			}
			else
			{
				tb_LoaiPhong loaiphong = _loaiphong.getItem(_idloaiphong);
				loaiphong.TENLOAIPHONG = txtTenloaiphong.Text;
				loaiphong.DONGIA = int.Parse(spDonGia.Value.ToString());
				loaiphong.DONGIATHEOGIO = int.Parse(spDonGiaTheoGio.Value.ToString());
				loaiphong.SOGIUONG = int.Parse(nUDSogiuong.Value.ToString());
				loaiphong.SONGUOIO = int.Parse(nUDSonguoio.Value.ToString());
				_loaiphong.update(loaiphong);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
		}

		private void BtnHuy_Click_1(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
		}
	}
}