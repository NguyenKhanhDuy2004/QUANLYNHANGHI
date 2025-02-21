using BusinessLayer;
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
using DataLayer;
using System.Data.SqlClient;

namespace THUEPHONGNHANGHI
{
	public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
	{
		public frmKhachHang()
		{
			InitializeComponent();
		}
		frmDatPhong objDP =(frmDatPhong) Application.OpenForms["frmDatPhong"];
		frmDatPhongDon objDPDon = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];
		KHACHHANG _kh;
		bool _them;
		int _idkh;
		public string kh_dp;
		
		private void frmKhachHang_Load(object sender, EventArgs e)
		{
			_kh = new KHACHHANG();
			loadData();
			showHideControl(true);
			_enabled(false);
		}
		void showHideControl(bool t)
		{
			btnThem.Visible = t;
			btnSua.Visible = t;
			btnXoa.Visible = t;
			btnThoat.Visible = t;
			btnLuu.Visible = !t;
			BtnHuy.Visible = !t;
		}
		void _enabled(bool t)
		{
			txtHoten.Enabled = t;
			txtCCCD.Enabled = t;
			txtDiaChi.Enabled = t;
			txtGioitinh.Enabled = t;
		}
		void _reset()
		{
			txtHoten.Text = "";
			txtCCCD.Text = "";
			txtDiaChi.Text = "";
			txtGioitinh.Text = "";
		}
		void loadData()
		{
			gcDanhSach.DataSource = _kh.getAll();
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
					_kh.delete(_idkh);

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



		//private void btnHuy_Click(object sender, EventArgs e)
		//{
		//	_them = false;
		//	showHideControl(true);
		//	_enabled(false);
		//}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.RowCount > 0)
			{
				_idkh = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString());
				txtHoten.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
				txtCCCD.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
				txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
				txtGioitinh.Text = gvDanhSach.GetFocusedRowCellValue("PHAI").ToString();
			}
		}


		//private void btnLuu_Click(object sender, EventArgs e)
		//{
		//	if (_them)
		//	{
		//		tb_KhachHang kh = new tb_KhachHang();
		//		kh.HOTEN = txtHoten.Text;
		//		kh.CCCD = txtCCCD.Text;
		//		kh.DIENTHOAI = txtDienThoai.Text;
		//		kh.EMAIL = txtEmail.Text;
		//		kh.DIACHI = txtDiaChi.Text;
		//		kh.PHAI = txtGioitinh.Text;
		//		_kh.add(kh);
		//	}
		//	else
		//	{
		//		tb_KhachHang kh = _kh.getItem(_idkh);
		//		kh.HOTEN = txtHoten.Text;
		//		kh.CCCD = txtCCCD.Text;
		//		kh.DIENTHOAI = txtDienThoai.Text;
		//		kh.EMAIL = txtEmail.Text;
		//		kh.DIACHI = txtDiaChi.Text;
		//		kh.PHAI = txtGioitinh.Text;
		//		_kh.update(kh);
		//	}
		//	_them = false;
		//	loadData();
		//	_enabled(false);
		//	showHideControl(true);
		//}

		private void gvDanhSach_DoubleClick(object sender, EventArgs e)
		{
			if(gvDanhSach.GetFocusedRowCellValue("IDKH")!=null)
			{
				if (kh_dp =="datphongdon")
				{
					objDPDon.loadKH();
					objDPDon.getKH(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
				}	
				else
				{
					objDP.loadKH();
					objDP.setKhachHang(int.Parse(gvDanhSach.GetFocusedRowCellValue("IDKH").ToString()));
				}	
				this.Close();
			}	
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{

			if (_them)
			{
				tb_KhachHang kh = new tb_KhachHang();
				kh.HOTEN = txtHoten.Text;
				kh.CCCD = txtCCCD.Text;
				kh.DIACHI = txtDiaChi.Text;
				kh.PHAI = txtGioitinh.Text;
				_kh.add(kh);
			}
			else
			{
				tb_KhachHang kh = _kh.getItem(_idkh);
				kh.HOTEN = txtHoten.Text;
				kh.CCCD = txtCCCD.Text;
				kh.DIACHI = txtDiaChi.Text;
				kh.PHAI = txtGioitinh.Text;
				_kh.update(kh);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
		}

		private void BtnHuy_Click(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
		
        }
    }
}