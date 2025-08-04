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
using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmDatPhongDon : DevExpress.XtraEditors.XtraForm
	{
		public frmDatPhongDon()
		{
			InitializeComponent();
			
		}

		frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
		public bool _them;
		public int _idPhong;
		int _idDP = 0;
		string _loaiHinhThue = "THEONGAY"; // Biến lưu loại hình thuê

		DATPHONG _datphong;
		DATPHONGCHITIET _datphongct;
		DATPHONGSANPHAM _datphongsp;
		objPHONG _phongHienTai;
		PHONG _phong;
		KHACHHANG _khachhang;
		SANPHAM _sanpham;
		List<objDPSP> lstDPSP;
		string _macty;
		string _madvi;

		private void frmDatPhongDon_Load(object sender, EventArgs e)
		{
			_datphong = new DATPHONG();
			_datphongsp = new DATPHONGSANPHAM();
			_datphongct = new DATPHONGCHITIET();
			_phong = new PHONG();
			_khachhang = new KHACHHANG();
			_sanpham = new SANPHAM();
			lstDPSP = new List<objDPSP>();

			_macty = myFunctions._macty;
			_madvi = myFunctions._madvi;
			_phongHienTai = _phong.getItemFull(_idPhong);

			// Xử lý giá trị null trước khi định dạng
			string giaNgay = _phongHienTai.DONGIA.HasValue ? _phongHienTai.DONGIA.Value.ToString("N0") : "N/A";
			string giaGio = _phongHienTai.DONGIATHEOGIO.HasValue ? _phongHienTai.DONGIATHEOGIO.Value.ToString("N0") : "N/A";
			lblPhong.Text = $"{_phongHienTai.TENPHONG} | Giá ngày: {giaNgay} | Giá giờ: {giaGio}";

			cboTrangthai.DataSource = TRANGTHAI.getList();
			cboTrangthai.ValueMember = "_value";
			cboTrangthai.DisplayMember = "_display";
			spSonguoio.Text = "1";

			loadKH();
			loadSP();

			if (!_them)
			{
				var dpct = _datphongct.getIDDPByPhong(_idPhong);
				if (dpct != null)
				{
					_idDP = dpct.IDDP;
					var dp = _datphong.getItem(_idDP);
					searchKH.EditValue = dp.IDKH;
					dtNgaydat.Value = dp.NGAYDATPHONG.Value;
					dtNgaytra.Value = dp.NGAYTRAPHONG.Value;
					cboTrangthai.SelectedValue = dp.STATUS;
					spSonguoio.Text = dp.SONGUOIO.ToString();
					txtGhichu.Text = dp.GHICHU;
					_loaiHinhThue = dpct.LOAIHINHTHUE ?? "THEONGAY";
					loadSPDV();
				}
			}

			// Mặc định chọn loại hình thuê và cập nhật giao diện
			radioG_LoaiHinhThue.EditValue = _loaiHinhThue;
			CapNhatGiaoDienTheoLoaiHinh();
		}

		private void CapNhatGiaoDienTheoLoaiHinh()
		{
			if (radioG_LoaiHinhThue.EditValue != null && radioG_LoaiHinhThue.EditValue.ToString() == "THEOGIO")
			{
				lblNgayDat.Text = "Giờ Vào";
				lblNgayTra.Text = "Giờ Ra";
				dtNgaydat.Format = DateTimePickerFormat.Custom;
				dtNgaydat.CustomFormat = "dd/MM/yyyy HH:mm";
				dtNgaytra.Format = DateTimePickerFormat.Custom;
				dtNgaytra.CustomFormat = "dd/MM/yyyy HH:mm";
				_loaiHinhThue = "THEOGIO";

				// Tự động đặt giờ ra sau giờ vào 1 tiếng
				dtNgaytra.Value = dtNgaydat.Value.AddHours(1);
			}
			else
			{
				lblNgayDat.Text = "Ngày Đặt";
				lblNgayTra.Text = "Ngày Trả";
				dtNgaydat.Format = DateTimePickerFormat.Custom;
				dtNgaydat.CustomFormat = "dd/MM/yyyy";
				dtNgaytra.Format = DateTimePickerFormat.Custom;
				dtNgaytra.CustomFormat = "dd/MM/yyyy";
				_loaiHinhThue = "THEONGAY";

				// Tự động đặt ngày trả sau ngày đặt 1 ngày
				dtNgaytra.Value = dtNgaydat.Value.AddDays(1);
			}

			// Luôn gọi UpdateTongTien sau khi cập nhật giao diện
			UpdateTongTien();
		}


		private int TinhSoNgay()
		{
			DateTime ngayDat = dtNgaydat.Value.Date;
			DateTime ngayTra = dtNgaytra.Value.Date;
			if (ngayTra <= ngayDat) return 1;
			return (ngayTra - ngayDat).Days;
		}

		private int TinhSoGio()
		{
			DateTime gioVao = dtNgaydat.Value;
			DateTime gioRa = dtNgaytra.Value;

			// Nếu giờ ra không hợp lệ (bằng hoặc trước giờ vào), tính là 1 giờ
			if (gioRa <= gioVao)
			{
				return 1;
			}

			// Tính tổng thời gian thuê
			TimeSpan duration = gioRa - gioVao;

			// Làm tròn lên giờ tiếp theo. Ví dụ: 1.2 giờ -> 2 giờ
			int totalHours = (int)Math.Ceiling(duration.TotalHours);

			// Đảm bảo rằng thời gian thuê tối thiểu luôn là 1 giờ
			return Math.Max(1, totalHours);
		}

		void UpdateTongTien()
		{
			double tongTienSPDV = lstDPSP.Sum(p => p.THANHTIEN) ?? 0;
			double tienPhong = 0;

			if (_loaiHinhThue == "THEOGIO")
			{
				tienPhong = (_phongHienTai.DONGIATHEOGIO ?? 0) * TinhSoGio();
			}
			else
			{
				tienPhong = (_phongHienTai.DONGIA ?? 0) * TinhSoNgay();
			}

			double tongCong = tienPhong + tongTienSPDV;
			txtThanhtien.Text = tongCong.ToString("N0");
		}


		void saveData()
		{
			if (searchKH.EditValue == null || searchKH.EditValue.ToString() == "")
			{
				MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (dtNgaydat.Value >= dtNgaytra.Value)
			{
				MessageBox.Show("Thời gian trả phòng phải sau thời gian đặt phòng.", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (_them)
			{
				tb_DatPhong dp = new tb_DatPhong();
				dp.IDKH = int.Parse(searchKH.EditValue.ToString());
				dp.NGAYDATPHONG = dtNgaydat.Value;
				dp.NGAYTRAPHONG = dtNgaytra.Value;
				dp.SONGUOIO = Convert.ToInt32(spSonguoio.Value);
				dp.STATUS = (bool)cboTrangthai.SelectedValue;
				dp.SOTIEN = double.Parse(txtThanhtien.Text.Replace(",", ""));
				dp.GHICHU = txtGhichu.Text;
				dp.IDUSER = 1;
				dp.MACTY = _macty;
				dp.MADVI = _madvi;
				dp.CREATED_DATE = DateTime.Now;

				var newDP = _datphong.add(dp);
				_idDP = newDP.IDDP;

				tb_DatPhongCT dpct = new tb_DatPhongCT();
				dpct.IDDP = newDP.IDDP;
				dpct.IDPHONG = _idPhong;
				dpct.NGAY = DateTime.Now;
				dpct.LOAIHINHTHUE = _loaiHinhThue;

				if (_loaiHinhThue == "THEOGIO")
				{
					dpct.SONGAYO = TinhSoGio();
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpct.DONGIA = (int?)(_phongHienTai.DONGIATHEOGIO ?? 0);
				}
				else
				{
					dpct.SONGAYO = TinhSoNgay();
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpct.DONGIA = (int?)(_phongHienTai.DONGIA ?? 0);
				}
				dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
				var newDPCT = _datphongct.add(dpct);

				_phong.updateStatus(_idPhong, true);

				foreach (var item in lstDPSP)
				{
					tb_DatPhongSanPham dpsp = new tb_DatPhongSanPham();
					dpsp.IDDP = newDP.IDDP;
					dpsp.IDDPCT = newDPCT.IDDPCT;
					dpsp.IDPHONG = _idPhong;
					dpsp.IDSP = item.IDSP;
					dpsp.SOLUONG = (int?)item.SOLUONG;
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpsp.DONGIA = (int?)item.DONGIA;
					dpsp.THANHTIEN = (int?)item.THANHTIEN;
					_datphongsp.add(dpsp);
				}
			}
			else // CẬP NHẬT
			{
				tb_DatPhong dp = _datphong.getItem(_idDP);
				dp.IDKH = int.Parse(searchKH.EditValue.ToString());
				dp.NGAYDATPHONG = dtNgaydat.Value;
				dp.NGAYTRAPHONG = dtNgaytra.Value;
				dp.SONGUOIO = Convert.ToInt32(spSonguoio.Value);
				dp.STATUS = (bool)cboTrangthai.SelectedValue;
				dp.SOTIEN = double.Parse(txtThanhtien.Text.Replace(",", ""));
				dp.GHICHU = txtGhichu.Text;
				dp.UPDATE_BY = 1;
				dp.UPDATE_DATE = DateTime.Now;
				_datphong.update(dp);

				tb_DatPhongCT dpct = _datphongct.getItem(_idDP, _idPhong);
				dpct.LOAIHINHTHUE = _loaiHinhThue;
				if (_loaiHinhThue == "THEOGIO")
				{
					dpct.SONGAYO = TinhSoGio();
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpct.DONGIA = (int?)(_phongHienTai.DONGIATHEOGIO ?? 0);
				}
				else
				{
					dpct.SONGAYO = TinhSoNgay();
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpct.DONGIA = (int?)(_phongHienTai.DONGIA ?? 0);
				}
				dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
				_datphongct.update(dpct);

				_datphongsp.deleteAllByPhong(_idDP, _idPhong);
				foreach (var item in lstDPSP)
				{
					tb_DatPhongSanPham dpsp = new tb_DatPhongSanPham();
					dpsp.IDDP = _idDP;
					dpsp.IDDPCT = dpct.IDDPCT;
					dpsp.IDPHONG = _idPhong;
					dpsp.IDSP = item.IDSP;
					dpsp.SOLUONG = (int?)item.SOLUONG;
					// 💡 SỬA LỖI: Ép kiểu double sang int?
					dpsp.DONGIA = (int?)item.DONGIA;
					dpsp.THANHTIEN = (int?)item.THANHTIEN;
					_datphongsp.add(dpsp);
				}
			}
		}


		private void btnLuu_Click(object sender, EventArgs e)
		{
			saveData();
			MessageBox.Show("Đã lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			_them = false;
			if (objMain != null)
			{
				objMain.gControl.Gallery.Groups.Clear();
				objMain.showRoom();
			}
		}

		//private void dtNgaydat_ValueChanged(object sender, EventArgs e)
		//{
		//	UpdateTongTien();
		//}
		//
		//private void dtNgaytra_ValueChanged(object sender, EventArgs e)
		//{
		//	UpdateTongTien();
		//}

		private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
		{
			if (_idDP == 0 && _them)
			{
				MessageBox.Show("Vui lòng lưu phiếu đặt phòng trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dtNgaydat.Value >= dtNgaytra.Value)
			{
				MessageBox.Show("Thời gian trả phòng phải sau thời gian đặt phòng.", "Lỗi dữ liệu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			cboTrangthai.SelectedValue = true;
			saveData();

			// 💡 SỬA LỖI 4: Kiểm tra lại tên phương thức trong lớp DATPHONG của bạn.
			// Có thể tên đúng là "UpdateStatus" hoặc một tên khác.
			_datphong.updateStuatus(_idDP);
			_phong.updateStatus(_idPhong, false);

			MessageBox.Show("Đã thanh toán và trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

			XuatReport("PHIEU_DATPHONG_DON", "Hóa đơn thanh toán");

			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
			this.Close();
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			if (_idDP == 0 && _them)
			{
				MessageBox.Show("Vui lòng lưu phiếu đặt phòng trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			saveData();
			XuatReport("PHIEU_DATPHONG_DON", "Chi tiết đặt phòng");
		}
		private void XuatReport(string _reportName, string _tieude)
		{
			if (_idDP != 0)
			{
				Form frm = new Form();
				CrystalReportViewer Crv = new CrystalReportViewer();
				Crv.ShowGroupTreeButton = false;
				Crv.ShowParameterPanelButton = false;
				Crv.ToolPanelView = ToolPanelViewType.None;
				TableLogOnInfo Thongtin;
				ReportDocument doc = new ReportDocument();
				doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @".rpt");
				Thongtin = doc.Database.Tables[0].LogOnInfo;
				Thongtin.ConnectionInfo.ServerName = myFunctions._srv;
				Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;
				Thongtin.ConnectionInfo.UserID = myFunctions._us;
				Thongtin.ConnectionInfo.Password = myFunctions._pw;
				doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
				try
				{
					doc.SetParameterValue("@IDDP", _idDP.ToString());
					Crv.Dock = DockStyle.Fill;
					Crv.ReportSource = doc;
					frm.Controls.Add(Crv);
					Crv.Refresh();
					frm.Text = _tieude;
					frm.WindowState = FormWindowState.Maximized;
					frm.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi : " + ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("Không có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void loadSPDV()
		{
			lstDPSP = _datphongsp.getAllByDatPhong(_idDP);
			loadDPSP();
		}
		void loadSP()
		{
			gcSanpham.DataSource = _sanpham.getAll();
			gvSanpham.OptionsBehavior.Editable = false;
		}
		public void loadKH()
		{
			searchKH.Properties.DataSource = _khachhang.getAll();
			searchKH.Properties.ValueMember = "IDKH";
			searchKH.Properties.DisplayMember = "HOTEN";
		}
		public void getKH(int _idKH)
		{
			var kh = _khachhang.getItem(_idKH);
			searchKH.EditValue = kh.IDKH;
			searchKH.Text = kh.HOTEN;
		}

		public void setKH(int idKH)
		{
			searchKH.EditValue = idKH;
		}
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmKhachHang frm = new frmKhachHang();
			frm.kh_dp = "datphongdon";
			frm.ShowDialog();
		}

		private void gvSanpham_DoubleClick(object sender, EventArgs e)
		{
			if (bool.Parse(cboTrangthai.SelectedValue.ToString()) == true)
			{
				MessageBox.Show("Phiếu đã thanh toán, không thể chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (gvSanpham.GetFocusedRowCellValue("IDSP") != null)
			{
				int idsp = int.Parse(gvSanpham.GetFocusedRowCellValue("IDSP").ToString());
				var sp_exist = lstDPSP.FirstOrDefault(x => x.IDSP == idsp);
				if (sp_exist != null)
				{
					sp_exist.SOLUONG++;
					sp_exist.THANHTIEN = sp_exist.SOLUONG * sp_exist.DONGIA;
				}
				else
				{
					objDPSP sp = new objDPSP();
					sp.IDSP = idsp;
					sp.TENSP = gvSanpham.GetFocusedRowCellValue("TENSP").ToString();
					sp.IDPHONG = _idPhong;
					sp.TENPHONG = _phongHienTai.TENPHONG;
					sp.DONGIA = float.Parse(gvSanpham.GetFocusedRowCellValue("DONGIA").ToString());
					sp.SOLUONG = 1;
					sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;
					lstDPSP.Add(sp);
				}
				loadDPSP();
				UpdateTongTien();
			}
		}
		void loadDPSP()
		{
			gcSPDV.DataSource = new BindingList<objDPSP>(lstDPSP);
			gvSPDV.RefreshData();
		}

		private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			if (e.Column.FieldName == "SOLUONG")
			{
				int sl = int.Parse(e.Value.ToString());
				if (sl > 0)
				{
					double gia = double.Parse(gvSPDV.GetRowCellValue(e.RowHandle, "DONGIA").ToString());
					gvSPDV.SetRowCellValue(e.RowHandle, "THANHTIEN", sl * gia);
					objDPSP sp = (objDPSP)gvSPDV.GetRow(e.RowHandle);
					sp.THANHTIEN = sl * gia;
				}
				else
				{
					objDPSP sp = (objDPSP)gvSPDV.GetRow(e.RowHandle);
					lstDPSP.Remove(sp);
				}
			}
			loadDPSP();
			UpdateTongTien();
		}

		private void gvSPDV_HiddenEditor(object sender, EventArgs e)
		{
			gvSPDV.UpdateCurrentRow();
		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if (_idDP == 0 && _them)
			{
				MessageBox.Show("Vui lòng lưu phiếu đặt phòng trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			saveData();
			XuatReport("PHIEU_DATPHONG_DON", "Hóa đơn thanh toán");
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
			this.Close();
		}

		private void radioG_LoaiHinhThue_EditValueChanged(object sender, EventArgs e)
		{
			CapNhatGiaoDienTheoLoaiHinh();
		}
		// Dùng cho các thay đổi tức thời (bấm mũi tên, chọn trên lịch)
		private void dtNgaydat_ValueChanged(object sender, EventArgs e)
		{
			UpdateTongTien();
		}

		private void dtNgaytra_ValueChanged(object sender, EventArgs e)
		{
			UpdateTongTien();
		}

		// Dùng để xác nhận thay đổi cuối cùng (khi gõ tay xong và chuyển đi)
		private void dtNgaydat_Validated(object sender, EventArgs e)
		{
			UpdateTongTien();
		}

		private void dtNgaytra_Validated(object sender, EventArgs e)
		{
			UpdateTongTien();
		}

		private void gvSPDV_KeyDown(object sender, KeyEventArgs e)
		{
			// Kiểm tra xem phím được nhấn có phải là phím Delete không
			if (e.KeyCode == Keys.Delete)
			{
				// Lấy dòng đang được chọn trong lưới gvSPDV
				var sp = gvSPDV.GetFocusedRow() as objDPSP;
				if (sp != null)
				{
					// Hiển thị hộp thoại xác nhận trước khi xóa
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa '" + sp.TENSP + "' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						// Xóa sản phẩm khỏi danh sách
						lstDPSP.Remove(sp);

						// Cập nhật lại GridView để hiển thị thay đổi
						gvSPDV.RefreshData();

						// Tính lại tổng tiền
						UpdateTongTien();
					}
				}
			}
		}
	}
}