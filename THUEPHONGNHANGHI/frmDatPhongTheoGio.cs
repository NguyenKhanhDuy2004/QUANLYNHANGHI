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
using static DevExpress.XtraPrinting.Export.Pdf.PdfImageCache;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmDatPhongTheoGio : DevExpress.XtraEditors.XtraForm
	{
		public frmDatPhongTheoGio()
		{
			InitializeComponent();
		}
		frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
		public bool _them;
		public int _idPhong;
		int _idDP = 0;
		DATPHONG _datphong;
		DATPHONGCHITIET _datphongct;
		DATPHONGSANPHAM _datphongsp;
		objPHONGTHEOGIO _phongHienTai;
		PHONG _phong;
		KHACHHANG _khachhang;
		SANPHAM _sanpham;
		List<objDPSP> lstDPSP;
		double _tongtien = 0;
		string _macty;
		string _madvi;
		

		
		
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
			gcSPDV.DataSource = _datphongsp.getAllByDatPhong(_idDP);
			lstDPSP = _datphongsp.getAllByDatPhong(_idDP);
		}
		void loadSP()
		{
			gcSanpham.DataSource = _sanpham.getAll();
			gvSanpham.OptionsBehavior.Editable = false;
		}
		public void loadKH()
		{
			KHACHHANG _khachhang = new KHACHHANG();
			searchKH.Properties.DataSource = _khachhang.getAll();
			searchKH.Properties.ValueMember = "IDKH";
			searchKH.Properties.DisplayMember = "HOTEN";
		}
		public void getKH(int _idKH)
		{
			KHACHHANG _khachhang = new KHACHHANG();
			var kh = _khachhang.getItem(_idKH);
			searchKH.EditValue = kh.IDKH;
			searchKH.Text = kh.HOTEN;
		}

		public void setKH(int idKH)
		{
			searchKH.EditValue = idKH;
		}
		

		
		void loadDPSP()
		{
			List<objDPSP> lsDP = new List<objDPSP>();
			foreach (var item in lstDPSP)
			{
				lsDP.Add(item);
			}

			gcSPDV.DataSource = lsDP;
		}

	
		void saveData()
		{
			if (_them)
			{
				tb_DatPhong dp = new tb_DatPhong();
				tb_DatPhongCT dpct;
				tb_DatPhongSanPham dpsp;
				dp.NGAYDATPHONG = dtNgaydat.Value;
				dp.NGAYTRAPHONG = dtNgaytra.Value;
				dp.SONGUOIO = int.Parse(spSonguoio.EditValue.ToString());
				dp.STATUS = bool.Parse(cboTrangthai.SelectedValue.ToString());
				dp.IDKH = int.Parse(searchKH.EditValue.ToString());
				dp.SOTIEN = double.Parse(txtThanhtien.Text);
				dp.GHICHU = txtGhichu.Text;
				dp.IDUSER = 1;
				dp.MACTY = _macty;
				dp.MADVI = _madvi;
				dp.CREATED_DATE = DateTime.Now;
				var _dp = _datphong.add(dp);
				_idDP = _dp.IDDP;


				dpct = new tb_DatPhongCT();
				dpct.IDDP = _dp.IDDP;
				dpct.IDPHONG = _idPhong;
				dpct.SONGAYO = dtNgaytra.Value.Day - dtNgaydat.Value.Day;
				dpct.DONGIA = int.Parse(_phongHienTai.DONGIATHEOGIO.ToString());
				dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
				dpct.NGAY = DateTime.Now;
				var _dpct = _datphongct.add(dpct);
				_phong.updateStatus(int.Parse(dpct.IDPHONG.ToString()), true);
				if (gvSPDV.RowCount > 0)
				{
					for (int j = 0; j < gvSPDV.RowCount; j++)
					{
						if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
						{
							dpsp = new tb_DatPhongSanPham();
							dpsp.IDDP = _dp.IDDP;
							dpsp.IDDPCT = _dpct.IDDPCT;
							dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
							dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
							dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
							dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
							dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
							_datphongsp.add(dpsp);
						}

					}
				}


			}
			else
			{
				//UPDATE
				tb_DatPhong dp = _datphong.getItem(_idDP);
				tb_DatPhongCT dpct;
				tb_DatPhongSanPham dpsp;
				dp.NGAYDATPHONG = dtNgaydat.Value;
				dp.NGAYTRAPHONG = dtNgaytra.Value;
				dp.SONGUOIO = int.Parse(spSonguoio.EditValue.ToString());
				dp.STATUS = bool.Parse(cboTrangthai.SelectedValue.ToString());
				dp.IDKH = int.Parse(searchKH.EditValue.ToString());
				dp.SOTIEN = double.Parse(txtThanhtien.Text.ToString());
				dp.GHICHU = txtGhichu.Text;
				dp.IDUSER = 1;
				dp.UPDATE_BY = 1;
				dp.UPDATE_DATE = DateTime.Now;
				var _dp = _datphong.update(dp);
				_idDP = _dp.IDDP;
				_datphongct.deleteAll(_dp.IDDP);
				_datphongsp.deleteAll(_dp.IDDP);



				dpct = new tb_DatPhongCT();
				dpct.IDDP = dp.IDDP;
				dpct.IDPHONG = _idPhong;
				dpct.SONGAYO = dtNgaytra.Value.Day - dtNgaydat.Value.Day;
				dpct.DONGIA = int.Parse(_phongHienTai.DONGIATHEOGIO.ToString());
				dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
				dpct.NGAY = DateTime.Now;
				var _dpct = _datphongct.add(dpct);
				_phong.updateStatus(dpct.IDPHONG, true);
				if (gvSPDV.RowCount > 0)
				{
					for (int j = 0; j < gvSPDV.RowCount; j++)
					{
						if (dpct.IDPHONG == int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
						{
							dpsp = new tb_DatPhongSanPham();
							dpsp.IDDP = dp.IDDP;
							dpsp.IDDPCT = _dpct.IDDPCT;
							dpsp.IDPHONG = int.Parse(gvSPDV.GetRowCellValue(j, "IDPHONG").ToString());
							dpsp.IDSP = int.Parse(gvSPDV.GetRowCellValue(j, "IDSP").ToString());
							dpsp.SOLUONG = int.Parse(gvSPDV.GetRowCellValue(j, "SOLUONG").ToString());
							dpsp.DONGIA = int.Parse(gvSPDV.GetRowCellValue(j, "DONGIA").ToString());
							dpsp.THANHTIEN = dpsp.SOLUONG * dpsp.DONGIA;
							_datphongsp.add(dpsp);
						}

					}
				}


			}
		}

		private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
		{
			if (bool.Parse(cboTrangthai.SelectedValue.ToString()) == false)
			{
				MessageBox.Show("Vui lòng chọn đã hoàn tất để thanh toán.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!_them)
			{
				saveData();
				_tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phong.getItemFull(_idPhong).DONGIA * (dtNgaytra.Value.Day - dtNgaydat.Value.Day);
				var dp = _datphong.getItem(_idDP);
				dp.SOTIEN = _tongtien;
				_datphong.update(dp);
				_datphong.updateStuatus(_idDP);
				_phong.updateStatus(_idPhong, false);
				XuatReport("PHIEU_DATPHONG_DON", "Chi tiết đặt phòng");
				cboTrangthai.SelectedValue = true;
				objMain.gControl.Gallery.Groups.Clear();
				objMain.showRoom();
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gvSPDV_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			if (e.Column.FieldName == "SOLUONG")
			{
				int sl = int.Parse(e.Value.ToString());
				if (sl != 0)
				{
					double gia = double.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle, "DONGIA").ToString());
					gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", sl * gia);

				}
				else
				{
					gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "THANHTIEN", 0);
				}
			}
			gvSPDV.UpdateTotalSummary();
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO).ToString("N0");
		}

		private void gvSanpham_DoubleClick_1(object sender, EventArgs e)
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
				sp.IDSP = int.Parse(gvSanpham.GetFocusedRowCellValue("IDSP").ToString());
				sp.TENSP = gvSanpham.GetFocusedRowCellValue("TENSP").ToString();
				sp.IDPHONG = _idPhong;
				sp.TENPHONG = _phongHienTai.TENPHONG;
				sp.DONGIA = float.Parse(gvSanpham.GetFocusedRowCellValue("DONGIA").ToString());
				sp.SOLUONG = 1;
				sp.THANHTIEN = sp.DONGIA * sp.SOLUONG;
				foreach (var item in lstDPSP)
				{
					if (item.IDSP == sp.IDSP && item.IDPHONG == sp.IDPHONG)
					{
						item.SOLUONG = item.SOLUONG + 1;
						item.THANHTIEN = item.SOLUONG * item.DONGIA;
						loadDPSP();
						return;
					}
				}
				lstDPSP.Add(sp);
			}
			loadDPSP();
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO).ToString("N0");
		}

		private void btnAddNew_Click_1(object sender, EventArgs e)
		{
			frmKhachHang frm = new frmKhachHang();
			frm.kh_dp = "datphongdon";
			frm.ShowDialog();
		}

		private void frmDatPhongTheoGio_Load(object sender, EventArgs e)
		{
			_datphong = new DATPHONG();
			_datphongsp = new DATPHONGSANPHAM();
			_datphongct = new DATPHONGCHITIET();
			_phong = new PHONG();
			_khachhang = new KHACHHANG();
			_sanpham = new SANPHAM();
			lstDPSP = new List<objDPSP>();

			_phongHienTai = _phong.getItemFullTheoGio(_idPhong);
			lblPhong.Text = _phongHienTai.TENPHONG + "- Đơn giá: " + _phongHienTai.DONGIATHEOGIO.ToString("N0") + "VND";
			txtThanhtien.Text = _phongHienTai.DONGIATHEOGIO.ToString("N0");
			dtNgaydat.Value = DateTime.Now;
			dtNgaytra.Value = DateTime.Now.AddDays(1);

			cboTrangthai.DataSource = TRANGTHAI.getList();
			cboTrangthai.ValueMember = "_value";
			cboTrangthai.DisplayMember = "_display";
			spSonguoio.Text = "1";
			loadKH();
			loadSP();
			_macty = myFunctions._macty;
			_madvi = myFunctions._madvi;
			var dpct = _datphongct.getIDDPByPhong(_idPhong);
			if (!_them && dpct != null)
			{
				_idDP = dpct.IDDP;
				var dp = _datphong.getItem(_idDP);
				searchKH.EditValue = dp.IDKH;
				dtNgaydat.Value = dp.NGAYDATPHONG.Value;
				if (dp.NGAYDATPHONG.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
					dtNgaytra.Value = dp.NGAYDATPHONG.Value.AddDays(1);
				else
					dtNgaytra.Value = DateTime.Now;

				cboTrangthai.SelectedValue = dp.STATUS;
				spSonguoio.Text = dp.SONGUOIO.ToString();
				txtGhichu.Text = dp.GHICHU.ToString();
				txtThanhtien.Text = dp.SOTIEN.Value.ToString("N0");


			}
			loadSPDV();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (searchKH.EditValue == null || searchKH.EditValue.ToString() == "")
			{
				MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			MessageBox.Show("Đã đặt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			saveData();


			_tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phong.getItemFull(_idPhong).DONGIA;
			var dp = _datphong.getItem(_idDP);
			dp.SOTIEN = _tongtien;
			_datphong.update(dp);
			this.Close();
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
		}

		private void btnIn_Click_1(object sender, EventArgs e)
		{
			if (!_them)
			{
				saveData();
				_tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phong.getItemFull(_idPhong).DONGIA ;
				var dp = _datphong.getItem(_idDP);
				dp.SOTIEN = _tongtien;
				_datphong.update(dp);
				_datphong.updateStuatus(_idDP);
				_phong.updateStatus(_idPhong, false);
				XuatReport("PHIEU_DATPHONG_DON", "Chi tiết đặt phòng");
				cboTrangthai.SelectedValue = true;
				objMain.gControl.Gallery.Groups.Clear();
				objMain.showRoom();
			}
		}

		private void gvSPDV_HiddenEditor_1(object sender, EventArgs e)
		{
			gvSPDV.UpdateCurrentRow();
		}

		private void btn1Gio_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text=(double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 10000).ToString("N0");
		}

		private void btn2GIO_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 20000).ToString("N0");
		}

		private void btn3GIO_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 30000).ToString("N0");
		}

		private void btn4GIO_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 40000).ToString("N0");
		}

		private void btn5GIO_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 50000).ToString("N0");
		}

		private void btn6GIO_Click(object sender, EventArgs e)
		{
			txtThanhtien.Text = (double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + _phongHienTai.DONGIATHEOGIO + 60000).ToString("N0");
		}
	}
	
}