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
			DataTable tb = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.TENLOAIPHONG, C.DONGIA, C.DONGIATHEOGIO, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C WHERE A.IDTANG = B.IDTANG AND A.TRANGTHAI = 0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
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
			// Lấy tổng tiền dịch vụ từ danh sách
			double tongTienSPDV = lstDPSP.Sum(item => item.THANHTIEN ?? 0);

			// Kiểm tra nếu loại hình thuê là THEOGIO
			if (_loaiHinhThue == "THEOGIO")
			{
				int soGio = TinhSoGio();
				// Định nghĩa giá cho mỗi giờ phát sinh thêm
				double giaMoiGioThem = 50000;

				// Duyệt qua từng phòng trong lưới gcDatphong
				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					// Lấy giá giờ đầu của phòng hiện tại
					double giaGioDau = Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIATHEOGIO") ?? 0);
					double tienPhongChoMotPhong = 0;

					if (soGio <= 1)
					{
						// Nếu chỉ thuê 1 giờ hoặc ít hơn, chỉ tính giá giờ đầu
						tienPhongChoMotPhong = giaGioDau;
					}
					else
					{
						// Nếu thuê nhiều hơn 1 giờ:
						// Tiền phòng = (Giá giờ đầu) + (Số giờ còn lại * Giá mỗi giờ thêm)
						tienPhongChoMotPhong = giaGioDau + (soGio - 1) * giaMoiGioThem;
					}
					// Cộng tiền của phòng vừa tính vào tổng tiền phòng
					tongTienPhong += tienPhongChoMotPhong;
				}
			}
			else // Nếu loại hình thuê là THEONGAY
			{
				int soNgay = TinhSoNgay();
				// Duyệt qua từng phòng và tính tiền theo ngày như cũ
				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					double donGiaNgay = Convert.ToDouble(gvDatphong.GetRowCellValue(i, "DONGIA") ?? 0);
					tongTienPhong += donGiaNgay * soNgay;
				}
			}

			// Tính tổng cộng tiền phòng và tiền dịch vụ
			double tongThanhTien = tongTienPhong + tongTienSPDV;
			// Hiển thị tổng tiền đã được định dạng
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

		

			((DataTable)gcDatphong.DataSource).Clear();

			lstDPSP.Clear(); 

			gcSPDV.DataSource = null; 
			UpdateTotalPrice();

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

			tabDanhsach.SelectedTabPage = pageChitiet;

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

		

			if (objMain != null)

			{

				objMain.gControl.Gallery.Groups.Clear();

				objMain.showRoom();

			}

			_idDP = 0; 

			_reset(); 

			((DataTable)gcDatphong.DataSource).Clear();

			lstDPSP.Clear(); 

			gcSPDV.DataSource = null;

			UpdateTotalPrice(); 

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


					cboTrangthai.SelectedValue = dpSaved.STATUS;

				}

			}

		}

		void saveData(string hinhThucThanhToan = null)
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
				dp.HINHTHUCTHANHTOAN = hinhThucThanhToan;

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
							dpsp.IDDP = _dpAdded.IDDP;
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
			else 
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

			
				if (!string.IsNullOrEmpty(hinhThucThanhToan))
				{
					dp.HINHTHUCTHANHTOAN = hinhThucThanhToan;
				}

				_datphong.update(dp);

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
				return; 
			}


			XuatReport("PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
		}



		private void XuatReport(string _reportName, string _tieude)
		{
			
			if (_idDP == 0)
			{
				MessageBox.Show("Vui lòng chọn một đặt phòng để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}

			ReportDocument doc = new ReportDocument();
			try
			{
				
				string reportPath = System.IO.Path.Combine(Application.StartupPath, "Reports", _reportName + ".rpt");

				if (!System.IO.File.Exists(reportPath))
				{
					MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				doc.Load(reportPath);

				
				foreach (Table tbl in doc.Database.Tables)
				{
					TableLogOnInfo tblLogOnInfo = tbl.LogOnInfo;
					tblLogOnInfo.ConnectionInfo.ServerName = myFunctions._srv;
					tblLogOnInfo.ConnectionInfo.DatabaseName = myFunctions._db;
					tblLogOnInfo.ConnectionInfo.UserID = myFunctions._us;
					tblLogOnInfo.ConnectionInfo.Password = myFunctions._pw;
					tbl.ApplyLogOnInfo(tblLogOnInfo);
				}

				
				doc.SetParameterValue("@IDDP", _idDP);

				Form frm = new Form();
				CrystalReportViewer Crv = new CrystalReportViewer();

				Crv.ShowGroupTreeButton = false;
				Crv.ShowParameterPanelButton = false; 
				Crv.ToolPanelView = ToolPanelViewType.None;
				Crv.Dock = DockStyle.Fill;
				Crv.ReportSource = doc; 
				Crv.Refresh(); 

				frm.Controls.Add(Crv);
				frm.Text = _tieude;
				frm.WindowState = FormWindowState.Maximized;
				frm.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (doc != null)
				{
					doc.Close();
					doc.Dispose();
				}
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

			btnThanhToanHoaDon.Visible = t;

			if (t && myFunctions._vaitro != null && myFunctions._vaitro.Equals("ADMIN1", StringComparison.OrdinalIgnoreCase))
			{
				// Nếu người đăng nhập là "ADMIN1", hiện nút
				btnSuaThanhToan.Visible = true;
			}
			else
			{
				// Nếu là người khác, ẩn nút
				btnSuaThanhToan.Visible = false;
			}

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

			if (!gvPhong.IsGroupRow(e.RowHandle)) 

			{

				if (e.Info.IsRowIndicator) 
				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1;

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); 

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); 

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPhong); })); 

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); 

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

						break; 

					}

				}

				if (!found)

				{

					lstDPSP.Add(sp);

				}

			}

			loadDPSP();

			UpdateTotalPrice(); 

		}



		void loadDPSP()

		{

			

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

					if (double.TryParse(gvSPDV.GetRowCellValue(e.RowHandle, "DONGIA")?.ToString(), out gia)) 

					{

						gvSPDV.SetRowCellValue(e.RowHandle, "THANHTIEN", sl * gia);



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
			
			if (!isFormLoading)
			{
				UpdateTotalPrice(); 
			}
		}

	



		



		private void gvSanpham_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvSanpham.IsGroupRow(e.RowHandle))

			{

				if (e.Info.IsRowIndicator) 

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; 

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); 

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); 

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanpham); })); 
				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSanpham); }));

			}

		}



		private void gvDatphong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvDatphong.IsGroupRow(e.RowHandle)) 

			{

				if (e.Info.IsRowIndicator) 

				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; 

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); 

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); 

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatphong); })); 

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); 

				SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);

				Int32 _Width = Convert.ToInt32(Size.Width) + 20;

				BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDatphong); }));

			}

		}



		private void gvSPDV_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)

		{

			if (!gvSPDV.IsGroupRow(e.RowHandle)) 

			{

				if (e.Info.IsRowIndicator) 
				{

					if (e.RowHandle < 0)

					{

						e.Info.ImageIndex = 0;

						e.Info.DisplayText = string.Empty;

					}

					else

					{

						e.Info.ImageIndex = -1; 

						e.Info.DisplayText = (e.RowHandle + 1).ToString(); 

					}



					SizeF Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); 

					Int32 _Width = Convert.ToInt32(Size.Width) + 20;

					BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvSPDV); })); 

				}

			}

			else

			{

				e.Info.ImageIndex = -1;

				e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); 

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

			isFormLoading = true; 
		
			_idDP = Convert.ToInt32(gvDanhSach.GetFocusedRowCellValue("IDDP"));
			var dp = _datphong.getItem(_idDP);
			if (dp == null)
			{
				isFormLoading = false;
				return;
			}

			
			var lstDPCT = _datphongchitiet.getAllByDatPhong(_idDP);
			if (lstDPCT.Count > 0)
			{
				_loaiHinhThue = lstDPCT.First().LOAIHINHTHUE ?? "THEONGAY";
			}
			else
			{
				_loaiHinhThue = "THEONGAY"; 
			}

			
			radioG_LoaiHinhThue.EditValue = _loaiHinhThue;
			
			CapNhatGiaoDienTheoLoaiHinh();

		
			cboKhachhang.SelectedValue = dp.IDKH;
			dtNgaydat.Value = dp.NGAYDATPHONG ?? DateTime.Now;
			dtNgaytra.Value = dp.NGAYTRAPHONG ?? DateTime.Now.AddDays(1);
			spSonguoio.Text = dp.SONGUOIO.ToString();
			cboTrangthai.SelectedValue = dp.STATUS;
			txtGhichu.Text = dp.GHICHU;

			
			txtThanhtien.Text = dp.SOTIEN.Value.ToString("N0");

			loadDP();
			loadSPDVForEdit();

			isFormLoading = false; 
		}

		void loadDP()
		{
			
			_rowDatPhong = 0;

			
			string sql = $@"SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, C.DONGIATHEOGIO, A.IDTANG, B.TENTANG 
                    FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C, tb_DatPhongCT D 
                    WHERE A.IDTANG = B.IDTANG 
                    AND A.IDLOAIPHONG = C.IDLOAIPHONG 
                    AND A.IDPHONG = D.IDPHONG 
                    AND D.IDDP = {_idDP}";

			DataTable dtRooms = myFunctions.laydulieu(sql);
			gcDatphong.DataSource = dtRooms;

			
			_rowDatPhong = gvDatphong.RowCount;
		}

		void loadSPDVForEdit()

		{

			lstDPSP.Clear(); 

			var listFromDB = _datphongsanpham.getAllByDatPhong(_idDP);

			foreach (var item in listFromDB)

			{

				

				if (item.IDSP.HasValue && item.IDPHONG.HasValue)

				{

					lstDPSP.Add(new objDPSP

					{

						

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

			gcSPDV.DataSource = new List<objDPSP>(lstDPSP); 

		}

		



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

			

			gvDanhSach_Click(sender, e);

			tabDanhsach.SelectedTabPage = pageChitiet;

		}

		private void gvSPDV_KeyDown(object sender, KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Delete)
			{
				
				var sp = gvSPDV.GetFocusedRow() as objDPSP;
				if (sp != null)
				{
					
					if (MessageBox.Show("Bạn có chắc chắn muốn xóa '" + sp.TENSP + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						
						lstDPSP.Remove(sp);

						
						loadDPSP();

						
						UpdateTotalPrice();
					}
				}
			}
		}

		private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
		{
			 
			if (_idDP == 0)
			{
				MessageBox.Show("Vui lòng chọn một đặt phòng từ danh sách để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			
			var dpHienTai = _datphong.getItem(_idDP);
			if (dpHienTai != null && dpHienTai.STATUS == true)
			{
				MessageBox.Show("Phiếu này đã được thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			
			frmChonThanhToan frmChon = new frmChonThanhToan();
			if (frmChon.ShowDialog() == DialogResult.OK)
			{
				
				string paymentMethod = frmChon.SelectedPaymentMethod;

				
				cboTrangthai.SelectedValue = true; 
				saveData(paymentMethod); 

				
				var lstPhongTrongDP = _datphongchitiet.getAllByDatPhong(_idDP);
				foreach (var p in lstPhongTrongDP)
				{
					_phong.updateStatus(p.IDPHONG, false); 
				}

				MessageBox.Show($"Đã thanh toán bằng [{paymentMethod}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				
				XuatReport("PHIEU_DATPHONG", "Hóa đơn thanh toán");

				loadDanhSach(); 
				if (objMain != null)
				{
					objMain.gControl.Gallery.Groups.Clear();
					objMain.showRoom(); 
				}

				_enabled(false);
				showHideControl(true);
				tabDanhsach.SelectedTabPage = pageDanhsach; 
			}
			
		}

		private void btnSuaThanhToan_Click(object sender, EventArgs e)
		{
			
			if (_idDP == 0)
			{
				MessageBox.Show("Vui lòng chọn một phiếu đã thanh toán để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			
			var dpHienTai = _datphong.getItem(_idDP);
			if (dpHienTai == null || dpHienTai.STATUS == false)
			{
				MessageBox.Show("Chức năng này chỉ dùng để sửa hình thức thanh toán cho các phiếu ĐÃ THANH TOÁN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			
			frmChonThanhToan frmChon = new frmChonThanhToan();
			if (frmChon.ShowDialog() == DialogResult.OK)
			{
				string newPaymentMethod = frmChon.SelectedPaymentMethod;

				
				if (newPaymentMethod == dpHienTai.HINHTHUCTHANHTOAN)
				{
					MessageBox.Show("Bạn đã chọn lại hình thức thanh toán cũ. Không có gì thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				try
				{
					
					dpHienTai.HINHTHUCTHANHTOAN = newPaymentMethod;
					_datphong.update(dpHienTai); 

					MessageBox.Show($"Đã cập nhật hình thức thanh toán thành công thành [{newPaymentMethod}].", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

					
					loadDanhSach();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Đã xảy ra lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}

} 