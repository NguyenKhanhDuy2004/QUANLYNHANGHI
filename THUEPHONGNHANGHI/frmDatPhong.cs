using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
	{
		private bool isFormLoading = true;
		private string _loaiHinhThue = "THEONGAY";

		public frmDatPhong()
		{
			InitializeComponent();
			// QUAN TRỌNG: Cập nhật câu lệnh SQL để lấy thêm DONGIA_GIO
			DataTable tb = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, C.DONGIATHEOGIO, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C WHERE A.IDTANG = B.IDTANG AND A.TRANGTHAI = 0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
			gcPhong.DataSource = tb;
			gcDatphong.DataSource = tb.Clone();

			// Cấu hình RadioGroup bằng code để đảm bảo chính xác
			radioG_LoaiHinhThue.Properties.Items.Clear();
			radioG_LoaiHinhThue.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem("THEONGAY", "Theo Ngày"));
			radioG_LoaiHinhThue.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem("THEOGIO", "Theo Giờ"));
			radioG_LoaiHinhThue.SelectedIndex = 0;
		}

		frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
		bool _them;
		int _idPhong = 0;
		string _tenPhong;
		string _macty;
		string _madvi;
		int _idDP = 0;
		int _rowDatPhong = 0;
		List<objDPSP> lstDPSP;

		DATPHONG _datphong;
		DATPHONGCHITIET _datphongchitiet;
		KHACHHANG _khachhang;
		SANPHAM _sanpham;
		DATPHONGSANPHAM _datphongsanpham;
		PHONG _phong;
		GridHitInfo downHitInfor = null;

		private void frmDatPhong_Load(object sender, EventArgs e)
		{
			isFormLoading = true;

			_khachhang = new KHACHHANG();
			_sanpham = new SANPHAM();
			_datphong = new DATPHONG();
			_phong = new PHONG();
			_datphongsanpham = new DATPHONGSANPHAM();
			_datphongchitiet = new DATPHONGCHITIET();
			lstDPSP = new List<objDPSP>();

			dtTungay.Value = myFunctions.GetFirstDayInMont(DateTime.Now.Year, DateTime.Now.Month);
			dtDenngay.Value = DateTime.Now;

			_macty = myFunctions._macty;
			_madvi = myFunctions._madvi;

			loadKH();
			loadSP();
			loadDanhSach();
			cboTrangthai.DataSource = TRANGTHAI.getList();
			cboTrangthai.ValueMember = "_value";
			cboTrangthai.DisplayMember = "_display";
			showHideControl(true);
			_enabled(false);
			tabDanhsach.SelectedTabPage = pageDanhsach;
			gvPhong.ExpandAllGroups();

			CapNhatGiaoDienTheoLoaiHinh();
			isFormLoading = false;
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

			// Luôn gọi UpdateTotalPrice để tính lại tiền
			UpdateTotalPrice();
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
			if (gioRa <= gioVao) return 1;
			return (int)Math.Ceiling((gioRa - gioVao).TotalHours);
		}

		void UpdateTotalPrice()
		{
			double tongTienPhong = 0;
			double tongTienSPDV = 0;

			if (_loaiHinhThue == "THEOGIO")
			{
				int soGio = TinhSoGio();
				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					double donGiaGio = Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIATHEOGIO") ?? 0);
					tongTienPhong += donGiaGio * soGio;
				}
			}
			else // THEONGAY
			{
				int soNgay = TinhSoNgay();
				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					double donGiaNgay = Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA") ?? 0);
					tongTienPhong += donGiaNgay * soNgay;
				}
			}

			if (lstDPSP != null)
			{
				tongTienSPDV = lstDPSP.Sum(item => item.THANHTIEN ?? 0);
			}

			double tongThanhTien = tongTienPhong + tongTienSPDV;
			txtThanhtien.Text = tongThanhTien.ToString("N0");
		}

		private void radioG_LoaiHinhThue_EditValueChanged(object sender, EventArgs e)
		{
			if (isFormLoading) return;
			CapNhatGiaoDienTheoLoaiHinh();
		}

		private void dtNgaydat_ValueChanged(object sender, EventArgs e)
		{
			if (isFormLoading) return;
			UpdateTotalPrice();
		}

		private void dtNgaytra_ValueChanged(object sender, EventArgs e)
		{
			if (isFormLoading) return;
			UpdateTotalPrice();
		}

		void loadDanhSach()

		{

			_datphong = new DATPHONG();

			gcDanhSach.DataSource = _datphong.getAll(dtTungay.Value, dtDenngay.Value, _macty, _madvi);

			gvDanhSach.OptionsBehavior.Editable = false;

		}

		public void loadKH()

		{

			_khachhang = new KHACHHANG();

			cboKhachhang.DataSource = _khachhang.getAll();

			cboKhachhang.DisplayMember = "HOTEN";

			cboKhachhang.ValueMember = "IDKH";

		}

		void loadSP()

		{

			gcSanpham.DataSource = _sanpham.getLish();

			gvSanpham.OptionsBehavior.Editable = false;



		}

		private void btnThem_Click(object sender, EventArgs e)

		{

			_them = true;

			showHideControl(false);

			_enabled(true);

			_reset();

			// Clear các GridControl khi thêm mới

			((DataTable)gcDatphong.DataSource).Clear();

			lstDPSP.Clear(); // Xóa danh sách SPDV trong bộ nhớ

			gcSPDV.DataSource = null; // Hoặc gcSPDV.DataSource = new List<objDPSP>();

			UpdateTotalPrice(); // Cập nhật tổng tiền về 0 khi thêm mới

			tabDanhsach.SelectedTabPage = pageChitiet;

		}

		private void btnSua_Click(object sender, EventArgs e)

		{

			if (_idDP == 0)

			{

				MessageBox.Show("Vui lòng chọn một đặt phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;

			}

			_them = false;

			_enabled(true);

			showHideControl(false);

			// Khi sửa, cần tải lại dữ liệu chi tiết của đặt phòng đã chọn

			// (Điều này đã được gọi trong gvDanhSach_Click/DoubleClick)

			// Ensure UpdateTotalPrice is called after loading data for editing

			UpdateTotalPrice();

		}



		private void btnXoa_Click(object sender, EventArgs e)

		{

			if (_idDP == 0)

			{

				MessageBox.Show("Vui lòng chọn một đặt phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;

			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa đặt phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

			{

				try

				{

					// Lấy danh sách các phòng trong đặt phòng bị xóa để cập nhật trạng thái

					var lstDPCT = _datphongchitiet.getAllByDatPhong(_idDP);



					// Xóa chi tiết sản phẩm dịch vụ trước

					_datphongsanpham.deleteAll(_idDP);

					// Xóa chi tiết đặt phòng

					_datphongchitiet.deleteAll(_idDP);

					// Xóa đặt phòng chính

					_datphong.delete(_idDP);



					// Cập nhật trạng thái các phòng về trống

					foreach (var item in lstDPCT)

					{

						_phong.updateStatus(item.IDPHONG, false);

					}



					MessageBox.Show("Xóa đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}

				catch (Exception ex)

				{

					MessageBox.Show("Lỗi khi xóa đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}

			loadDanhSach();

			// Đảm bảo objMain không null trước khi gọi

			if (objMain != null)

			{

				objMain.gControl.Gallery.Groups.Clear();

				objMain.showRoom();

			}

			_idDP = 0; // Reset ID đặt phòng hiện tại

			_reset(); // Reset form chi tiết

			((DataTable)gcDatphong.DataSource).Clear(); // Xóa dữ liệu trên lưới phòng đã đặt

			lstDPSP.Clear(); // Xóa danh sách SPDV trong bộ nhớ

			gcSPDV.DataSource = null; // Hoặc gcSPDV.DataSource = new List<objDPSP>();

			UpdateTotalPrice(); // Cập nhật tổng tiền về 0 sau khi xóa

		}





		private void btnLuu_Click(object sender, EventArgs e)

		{

			// Kiểm tra dữ liệu hợp lệ trước khi lưu

			if (cboKhachhang.SelectedValue == null)

			{

				MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;

			}

			if (gvDatphong.RowCount == 0)

			{

				MessageBox.Show("Vui lòng thêm ít nhất một phòng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;

			}


			if (dtNgaydat.Value.Date > dtNgaytra.Value.Date)
			{
				MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng.", "Lỗi dữ liệu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Dừng thực thi, không cho phép lưu
			}



			saveData();

			loadDanhSach();

			if (objMain != null)

			{

				objMain.gControl.Gallery.Groups.Clear();

				objMain.showRoom();

			}

			_them = false;

			_enabled(false);

			showHideControl(true);

			// Sau khi lưu, có thể cần tải lại chi tiết của đặt phòng vừa lưu để có IDDP mới (nếu là thêm mới)

			// hoặc để cập nhật UI nếu có thay đổi từ CSDL

			if (_idDP != 0)

			{

				// Tải lại chi tiết đặt phòng sau khi lưu thành công (quan trọng nếu có sửa đổi)

				var dpSaved = _datphong.getItem(_idDP);

				if (dpSaved != null)

				{

					txtThanhtien.Text = dpSaved.SOTIEN.Value.ToString("N0");

					// Cập nhật các trường UI khác nếu cần

					cboTrangthai.SelectedValue = dpSaved.STATUS;

				}

			}

		}

		void saveData()
		{
			if (cboKhachhang.SelectedValue == null)
			{
				MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (gvDatphong.RowCount == 0)
			{
				MessageBox.Show("Vui lòng thêm ít nhất một phòng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dtNgaydat.Value >= dtNgaytra.Value)
			{
				MessageBox.Show("Thời gian trả phòng phải sau thời gian đặt phòng.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<int> oldPhongIds = new List<int>();
			if (!_them)
			{
				var lstPhongCu = _datphongchitiet.getAllByDatPhong(_idDP);
				foreach (var item in lstPhongCu)
				{
					oldPhongIds.Add(item.IDPHONG);
				}
			}

			if (_them)
			{
				tb_DatPhong dp = new tb_DatPhong();
				dp.IDKH = Convert.ToInt32(cboKhachhang.SelectedValue);
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

				var _dpAdded = _datphong.add(dp);
				_idDP = _dpAdded.IDDP;

				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					tb_DatPhongCT dpct = new tb_DatPhongCT();
					dpct.IDDP = _dpAdded.IDDP;
					dpct.IDPHONG = Convert.ToInt32(gvDatphong.GetRowCellValue(i, "IDPHONG"));
					dpct.NGAY = DateTime.Now;
					dpct.LOAIHINHTHUE = _loaiHinhThue;

					if (_loaiHinhThue == "THEOGIO")
					{
						dpct.SONGAYO = TinhSoGio();
						// SỬA LỖI 1: Cần ép kiểu double sang int? hoặc kiểu dữ liệu tương ứng của DONGIA trong database.
						// Giả sử DONGIA trong database là int?
						dpct.DONGIA = (int?)Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA_GIO") ?? 0);
					}
					else
					{
						dpct.SONGAYO = TinhSoNgay();
						// SỬA LỖI 2: Cần ép kiểu double sang int? tương tự.
						dpct.DONGIA = (int?)Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA") ?? 0);
					}
					dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
					var _dpctAdded = _datphongchitiet.add(dpct);

					_phong.updateStatus(dpct.IDPHONG, true);

					var spdvForThisRoom = lstDPSP.Where(x => x.IDPHONG == dpct.IDPHONG).ToList();
					if (spdvForThisRoom.Any())
					{
						foreach (var dpspItem in spdvForThisRoom)
						{
							tb_DatPhongSanPham dpsp = new tb_DatPhongSanPham();
							dpsp.IDDP = _dpAdded.IDDP;
							dpsp.IDDPCT = _dpctAdded.IDDPCT;
							dpsp.IDPHONG = dpspItem.IDPHONG;
							dpsp.IDSP = dpspItem.IDSP;
							dpsp.SOLUONG = dpspItem.SOLUONG;
							// SỬA LỖI 3: Cần ép kiểu double? sang int?
							dpsp.DONGIA = (int?)dpspItem.DONGIA;
							dpsp.THANHTIEN = (int?)dpspItem.THANHTIEN;
							_datphongsanpham.add(dpsp);
						}
					}
				}
			}
			else // UPDATE
			{
				tb_DatPhong dp = _datphong.getItem(_idDP);
				dp.IDKH = Convert.ToInt32(cboKhachhang.SelectedValue);
				dp.NGAYDATPHONG = dtNgaydat.Value;
				dp.NGAYTRAPHONG = dtNgaytra.Value;
				dp.SONGUOIO = Convert.ToInt32(spSonguoio.Value);
				dp.STATUS = (bool)cboTrangthai.SelectedValue;
				dp.SOTIEN = double.Parse(txtThanhtien.Text.Replace(",", ""));
				dp.GHICHU = txtGhichu.Text;
				dp.UPDATE_BY = 1;
				dp.UPDATE_DATE = DateTime.Now;
				_datphong.update(dp);

				// Giải phóng các phòng cũ
				foreach (int phongId in oldPhongIds)
				{
					_phong.updateStatus(phongId, false);
				}

				// Xóa chi tiết cũ và thêm lại
				_datphongchitiet.deleteAll(_idDP);
				_datphongsanpham.deleteAll(_idDP);

				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					tb_DatPhongCT dpct = new tb_DatPhongCT();
					dpct.IDDP = _idDP;
					dpct.IDPHONG = Convert.ToInt32(gvDatphong.GetRowCellValue(i, "IDPHONG"));
					dpct.NGAY = DateTime.Now;
					dpct.LOAIHINHTHUE = _loaiHinhThue;

					if (_loaiHinhThue == "THEOGIO")
					{
						dpct.SONGAYO = TinhSoGio();
						dpct.DONGIA = (int?)Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA_GIO") ?? 0);
					}
					else
					{
						dpct.SONGAYO = TinhSoNgay();
						dpct.DONGIA = (int?)Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA") ?? 0);
					}
					dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
					var _dpctAdded = _datphongchitiet.add(dpct);

					_phong.updateStatus(dpct.IDPHONG, true);

					var spdvForThisRoom = lstDPSP.Where(x => x.IDPHONG == dpct.IDPHONG).ToList();
					if (spdvForThisRoom.Any())
					{
						foreach (var dpspItem in spdvForThisRoom)
						{
							tb_DatPhongSanPham dpsp = new tb_DatPhongSanPham();
							dpsp.IDDP = _idDP;
							dpsp.IDDPCT = _dpctAdded.IDDPCT;
							dpsp.IDPHONG = dpspItem.IDPHONG;
							dpsp.IDSP = dpspItem.IDSP;
							dpsp.SOLUONG = dpspItem.SOLUONG;
							dpsp.DONGIA = (int?)dpspItem.DONGIA;
							dpsp.THANHTIEN = (int?)dpspItem.THANHTIEN;
							_datphongsanpham.add(dpsp);
						}
					}
				}
			}
			MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra xem người dùng đã chọn một phiếu đặt phòng chưa
			if (_idDP == 0)
			{
				MessageBox.Show("Vui lòng chọn một đặt phòng để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dtNgaydat.Value.Date > dtNgaytra.Value.Date)
			{
				MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Dừng thực thi, không cho phép lưu
			}


			// 2. Chỉ gọi hàm xuất báo cáo.
			// Báo cáo sẽ in dữ liệu đang có trong cơ sở dữ liệu.
			// Hoàn toàn không gọi saveData() hay bất kỳ hàm cập nhật nào khác.
			XuatReport("PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
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



				try

				{

					doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @".rpt");

					Thongtin = doc.Database.Tables[0].LogOnInfo;

					Thongtin.ConnectionInfo.ServerName = myFunctions._srv;

					Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;

					Thongtin.ConnectionInfo.UserID = myFunctions._us;

					Thongtin.ConnectionInfo.Password = myFunctions._pw;

					doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);



					doc.SetParameterValue("@IDDP", _idDP.ToString());



					// Các lệnh làm mới báo cáo để đảm bảo lấy dữ liệu mới nhất

					// Điều này đôi khi là cần thiết với Crystal Reports để tránh cache

					foreach (Table tbl in doc.Database.Tables)

					{

						TableLogOnInfo tblLogOnInfo = tbl.LogOnInfo;

						tblLogOnInfo.ConnectionInfo.ServerName = myFunctions._srv;

						tblLogOnInfo.ConnectionInfo.DatabaseName = myFunctions._db;

						tblLogOnInfo.ConnectionInfo.UserID = myFunctions._us;

						tblLogOnInfo.ConnectionInfo.Password = myFunctions._pw;

						tbl.ApplyLogOnInfo(tblLogOnInfo);

						tbl.Location = tbl.Location; // Forced refresh, sometimes needed

					}

					doc.Refresh(); // Buộc refresh dữ liệu của ReportDocument



					Crv.Dock = DockStyle.Fill;

					Crv.ReportSource = doc;

					Crv.RefreshReport(); // Làm mới lại CrystalReportViewer



					frm.Controls.Add(Crv);

					frm.Text = _tieude;

					frm.WindowState = FormWindowState.Maximized;

					frm.ShowDialog();

				}

				catch (Exception ex)

				{

					MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}

			else

			{

				MessageBox.Show("Không có dữ liệu đặt phòng để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}


		}

		private void btnHuy_Click(object sender, EventArgs e)

		{

			_them = false;

			showHideControl(true);

			_enabled(false);

			tabDanhsach.SelectedTabPage = pageDanhsach;

		}



		private void btnThoat_Click(object sender, EventArgs e)

		{

			this.Close();

		}

		void showHideControl(bool t)

		{

			btnThem.Visible = t;

			btnSua.Visible = t;

			btnXoa.Visible = t;

			btnLuu.Visible = !t;

			btnHuy.Visible = !t;

			btnIn.Visible = t;

		}

		void _enabled(bool t)

		{

			cboKhachhang.Enabled = t;

			btnAddNew.Enabled = t;

			dtNgaydat.Enabled = t;

			dtNgaytra.Enabled = t;

			cboTrangthai.Enabled = t;

			spSonguoio.Enabled = t;

			txtGhichu.Enabled = t;

			gcPhong.Enabled = t;

			gcSanpham.Enabled = t;

			gcDatphong.Enabled = t;

			gcSPDV.Enabled = t;

			txtThanhtien.Enabled = t;

		}

		void _reset()

		{

			dtNgaydat.Value = DateTime.Now;

			dtNgaytra.Value = DateTime.Now.AddDays(1);

			spSonguoio.Text = "1";

			cboTrangthai.SelectedValue = false;

			txtGhichu.Text = "";

			txtThanhtien.Text = "0";

		}



		private void gvDatphong_MouseDown(object sender, MouseEventArgs e)

		{

			if (gvDatphong.GetFocusedRowCellValue("IDPHONG") != null)

			{

				_idPhong = int.Parse(gvDatphong.GetFocusedRowCellValue("IDPHONG").ToString());

				_tenPhong = gvDatphong.GetFocusedRowCellValue("TENPHONG").ToString();

			}



			GridView view = sender as GridView;

			downHitInfor = null;

			GridHitInfo hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));

			if (Control.ModifierKeys != Keys.None) return;

			if (e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)

			{

				downHitInfor = hitInfor;

			}



		}



		private void gvDatphong_MouseMove(object sender, MouseEventArgs e)

		{

			GridView view = sender as GridView;

			if (e.Button == MouseButtons.Left && downHitInfor != null)

			{

				Size dragSize = SystemInformation.DragSize;

				Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);

				if (!dragRect.Contains(new Point(e.X, e.Y)))

				{

					DataRow row = view.GetDataRow(downHitInfor.RowHandle);

					view.GridControl.DoDragDrop(row, DragDropEffects.Move);

					downHitInfor = null;

					DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;

				}

			}



		}

		private void gvPhong_MouseDown(object sender, MouseEventArgs e)

		{

			GridView view = sender as GridView;

			downHitInfor = null;

			GridHitInfo hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));

			if (Control.ModifierKeys != Keys.None) return;

			if (e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)

			{

				downHitInfor = hitInfor;

			}



		}



		private void gvPhong_MouseMove(object sender, MouseEventArgs e)

		{

			GridView view = sender as GridView;

			if (e.Button == MouseButtons.Left && downHitInfor != null)

			{

				Size dragSize = SystemInformation.DragSize;

				Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);

				if (!dragRect.Contains(new Point(e.X, e.Y)))

				{

					DataRow row = view.GetDataRow(downHitInfor.RowHandle);

					view.GridControl.DoDragDrop(row, DragDropEffects.Move);

					downHitInfor = null;

					DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;

				}

			}



		}



		private void gcPhong_DragDrop(object sender, DragEventArgs e)

		{

			GridControl grid = sender as GridControl;

			DataTable table = grid.DataSource as DataTable;

			DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;

			if (row != null && table != null && row.Table != table)

			{

				table.ImportRow(row);

				row.Delete();

			}



		}



		private void gcPhong_DragOver(object sender, DragEventArgs e)

		{

			if (e.Data.GetDataPresent(typeof(DataRow)))

			{

				e.Effect = DragDropEffects.Move;

			}

			else

			{

				e.Effect = DragDropEffects.None;

			}

		}

		bool cal(Int32 _Width, GridView _View)

		{

			_View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;

			return true;

		}



		private void gvPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvPhong.IsGroupRow(e.RowHandle)) // Nếu không phải là Group

			{

				if (e.Info.IsRowIndicator) // Nếu là dòng Indicator

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; // Không hiển thị hình

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); // Số thứ tự tăng dần

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); // Lấy kích thước của vùng hiển thị Text

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPhong); })); // Tăng kích thước nếu Text vượt quá

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); // Nhân -1 để đánh lại số thứ tự tăng dần

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPhong); }));

			}

		}



		private void gvPhong_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)

		{

			GridView view = sender as GridView;

			GridGroupRowInfo info = e.Info as GridGroupRowInfo;

			string caption = info.Column.Caption;

			if (info.Column.Caption == string.Empty)

				caption = info.Column.ToString();

			info.GroupText = string.Format("{0}: {1} ({2} phòng trống)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));

		}



		private void gcSanpham_DoubleClick(object sender, EventArgs e)

		{

			if (_idPhong == 0)

			{

				MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return;

			}

			if (bool.Parse(cboTrangthai.SelectedValue.ToString()) == true)

			{

				MessageBox.Show("Đã hoàn tất thanh toán không được chỉnh sửa.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return;

			}

			if (gvSanpham.GetFocusedRowCellValue("IDSP") != null)

			{

				objDPSP sp = new objDPSP();

				int idSP;

				if (int.TryParse(gvSanpham.GetFocusedRowCellValue("IDSP")?.ToString(), out idSP))

				{

					sp.IDSP = idSP;

				}

				else { return; }



				sp.TENSP = gvSanpham.GetFocusedRowCellValue("TENSP")?.ToString();

				sp.IDPHONG = _idPhong;

				sp.TENPHONG = _tenPhong;



				double donGia;

				if (double.TryParse(gvSanpham.GetFocusedRowCellValue("DONGIA")?.ToString(), out donGia))

				{

					sp.DONGIA = donGia;

				}

				else { return; }



				sp.SOLUONG = 1;

				sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;



				bool found = false;

				foreach (var item in lstDPSP)

				{

					if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)

					{

						item.SOLUONG = item.SOLUONG + 1;

						item.THANHTIEN = item.SOLUONG * item.DONGIA;

						found = true;

						break; // Thoát khỏi vòng lặp khi tìm thấy

					}

				}

				if (!found)

				{

					lstDPSP.Add(sp);

				}

			}

			loadDPSP();

			UpdateTotalPrice(); // Gọi hàm UpdateTotalPrice() duy nhất

		}



		void loadDPSP()

		{

			// Tạo một danh sách mới từ lstDPSP để gán cho DataSource.

			// Điều này giúp DevExpress GridControl cập nhật đúng cách khi lstDPSP thay đổi

			gcSPDV.DataSource = new List<objDPSP>(lstDPSP);

		}



		private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)

		{

			if (e.Column.FieldName == "SOLUONG")

			{

				int sl = 0;

				if (int.TryParse(e.Value?.ToString(), out sl))

				{

					double gia = 0;

					if (double.TryParse(gvSPDV.GetRowCellValue(e.RowHandle, "DONGIA")?.ToString(), out gia)) // Dùng e.RowHandle

					{

						gvSPDV.SetRowCellValue(e.RowHandle, "THANHTIEN", sl * gia); // Dùng e.RowHandle



						// Cập nhật giá trị trong lstDPSP

						if (e.RowHandle >= 0 && e.RowHandle < lstDPSP.Count)

						{

							lstDPSP[e.RowHandle].SOLUONG = sl;

							lstDPSP[e.RowHandle].THANHTIEN = sl * gia;

						}

					}

				}

			}

			gvSPDV.UpdateTotalSummary();

			UpdateTotalPrice();

		}



		private void gvDatphong_RowCountChanged(object sender, EventArgs e)
		{
			// Logic xóa và cập nhật trạng thái phòng ngay lập tức khi kéo thả là rất rủi ro.
			// Mọi thay đổi về phòng nên được xử lý trong hàm saveData() khi người dùng nhấn "Lưu".
			// Do đó, logic trong hàm này nên được vô hiệu hóa hoặc xóa bỏ.
			if (!isFormLoading)
			{
				UpdateTotalPrice(); // Chỉ nên gọi cập nhật tổng tiền
			}
		}

	



		



		private void gvSanpham_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvSanpham.IsGroupRow(e.RowHandle)) // Nếu không phải là Group

			{

				if (e.Info.IsRowIndicator) // Nếu là dòng Indicator

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; // Không hiển thị hình

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); // Số thứ tự tăng dần

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); // Lấy kích thước của vùng hiển thị Text

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanpham); })); // Tăng kích thước nếu Text vượt quá

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); // Nhân -1 để đánh lại số thứ tự tăng dần

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanpham); }));

			}

		}



		private void gvDatphong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvDatphong.IsGroupRow(e.RowHandle)) // Nếu không phải là Group

			{

				if (e.Info.IsRowIndicator) // Nếu là dòng Indicator

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; // Không hiển thị hình

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); // Số thứ tự tăng dần

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); // Lấy kích thước của vùng hiển thị Text

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatphong); })); // Tăng kích thước nếu Text vượt quá

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); // Nhân -1 để đánh lại số thứ tự tăng dần

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatphong); }));

			}

		}



		private void gvSPDV_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvSPDV.IsGroupRow(e.RowHandle)) // Nếu không phải là Group

			{

				if (e.Info.IsRowIndicator) // Nếu là dòng Indicator

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; // Không hiển thị hình

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); // Số thứ tự tăng dần

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); // Lấy kích thước của vùng hiển thị Text

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSPDV); })); // Tăng kích thước nếu Text vượt quá

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); // Nhân -1 để đánh lại số thứ tự tăng dần

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSPDV); }));

			}

		}



		private void btnAddNew_Click(object sender, EventArgs e)

		{

			frmKhachHang frm = new frmKhachHang();

			frm.ShowDialog();

		}

		public void setKhachHang(int idkh)

		{

			var _kh = _khachhang.getItem(idkh);

			cboKhachhang.SelectedValue = _kh.IDKH;

			cboKhachhang.Text = _kh.HOTEN;

		}



		private void gvDanhSach_Click(object sender, EventArgs e)
		{
			if (gvDanhSach.FocusedRowHandle < 0) return;

			isFormLoading = true; // Tạm dừng các sự kiện khác

			// Lấy IDDP từ dòng đang chọn
			_idDP = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDDP"));
			var dp = _datphong.getItem(_idDP);
			if (dp == null)
			{
				isFormLoading = false;
				return;
			}

			// BƯỚC 1: LẤY LOẠI HÌNH THUÊ TỪ DATABASE
			// Vì tất cả các phòng trong cùng 1 lần đặt đều có chung loại hình thuê,
			// nên chỉ cần lấy chi tiết của phòng đầu tiên là đủ.
			var lstDPCT = _datphongchitiet.getAllByDatPhong(_idDP);
			if (lstDPCT.Count > 0)
			{
				_loaiHinhThue = lstDPCT.First().LOAIHINHTHUE ?? "THEONGAY";
			}
			else
			{
				_loaiHinhThue = "THEONGAY"; // Mặc định nếu không có chi tiết
			}

			// BƯỚC 2: CẬP NHẬT GIAO DIỆN VÀ LOGIC THEO ĐÚNG LOẠI HÌNH THUÊ
			// Gán giá trị cho RadioGroup trước
			radioG_LoaiHinhThue.EditValue = _loaiHinhThue;
			// Sau đó gọi hàm cập nhật giao diện, hàm này sẽ tự động tính lại tổng tiền
			CapNhatGiaoDienTheoLoaiHinh();

			// BƯỚC 3: NẠP CÁC THÔNG TIN CÒN LẠI VÀ HIỂN THỊ ĐÚNG TỔNG TIỀN ĐÃ LƯU
			cboKhachhang.SelectedValue = dp.IDKH;
			dtNgaydat.Value = dp.NGAYDATPHONG ?? DateTime.Now;
			dtNgaytra.Value = dp.NGAYTRAPHONG ?? DateTime.Now.AddDays(1);
			spSonguoio.Text = dp.SONGUOIO.ToString();
			cboTrangthai.SelectedValue = dp.STATUS;
			txtGhichu.Text = dp.GHICHU;

			// Hiển thị lại đúng tổng tiền đã lưu trong database,
			// thay vì tổng tiền vừa bị tính lại sai ở trên.
			txtThanhtien.Text = dp.SOTIEN.Value.ToString("N0");

			loadDP();
			loadSPDVForEdit();

			isFormLoading = false; // Cho phép các sự kiện chạy lại bình thường
		}

		void loadDP()
		{
			// Sửa lỗi sai tên biến
			_rowDatPhong = 0;

			// Sửa lỗi thiếu cột DONGIATHEOGIO trong câu lệnh SQL
			string sql = $@"SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, C.DONGIATHEOGIO, A.IDTANG, B.TENTANG 
                    FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C, tb_DatPhongCT D 
                    WHERE A.IDTANG = B.IDTANG 
                    AND A.IDLOAIPHONG = C.IDLOAIPHONG 
                    AND A.IDPHONG = D.IDPHONG 
                    AND D.IDDP = {_idDP}";

			DataTable dtRooms = myFunctions.laydulieu(sql);
			gcDatphong.DataSource = dtRooms;

			// Sửa lỗi sai tên biến
			_rowDatPhong = gvDatphong.RowCount;
		}

		void loadSPDVForEdit()

		{

			lstDPSP.Clear(); // Xóa dữ liệu cũ

			var listFromDB = _datphongsanpham.getAllByDatPhong(_idDP);

			foreach (var item in listFromDB)

			{

				// Chỉ thêm vào danh sách nếu cả 2 ID đều không phải là null

				if (item.IDSP.HasValue && item.IDPHONG.HasValue)

				{

					lstDPSP.Add(new objDPSP

					{

						// Dùng .Value để lấy giá trị kiểu int từ int?

						IDSP = item.IDSP.Value,

						TENSP = _sanpham.getItem(item.IDSP.Value).TENSP,



						IDPHONG = item.IDPHONG.Value,

						TENPHONG = _phong.getItem(item.IDPHONG.Value).TENPHONG,



						DONGIA = item.DONGIA,

						SOLUONG = item.SOLUONG,

						THANHTIEN = item.THANHTIEN

					});

				}

			}

			gcSPDV.DataSource = new List<objDPSP>(lstDPSP); // Cập nhật GridControl

		}

		// ... (Các hàm dtTungay_ValueChanged, dtDenngay_ValueChanged, v.v. không thay đổi)



		void loadSPDV()

		{

			gcSPDV.DataSource = _datphongsanpham.getAllByDatPhong(_idDP);

		}



		private void dtTungay_ValueChanged(object sender, EventArgs e)

		{

			if (dtTungay.Value > dtDenngay.Value)

			{

				MessageBox.Show("Ngày không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			else

				loadDanhSach();

		}



		private void dtTungay_Leave(object sender, EventArgs e)

		{

			if (dtTungay.Value > dtDenngay.Value)

			{

				MessageBox.Show("Ngày không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			else

				loadDanhSach();

		}



		private void dtDenngay_ValueChanged(object sender, EventArgs e)

		{

			if (dtTungay.Value > dtDenngay.Value)

			{

				MessageBox.Show("Ngày không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			else

				loadDanhSach();

		}



		private void dtDenngay_Leave(object sender, EventArgs e)

		{

			if (dtTungay.Value > dtDenngay.Value)

			{

				MessageBox.Show("Ngày không hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			else

				loadDanhSach();



		}



		private void gvDanhSach_DoubleClick(object sender, EventArgs e)

		{

			// Tái sử dụng logic từ gvDanhSach_Click

			gvDanhSach_Click(sender, e);

			tabDanhsach.SelectedTabPage = pageChitiet;

		}



		

	
	}

}