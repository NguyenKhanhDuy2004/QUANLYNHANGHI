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
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
	{
		public frmDatPhong()
		{
			InitializeComponent();
			DataTable tb = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C WHERE A.IDTANG = B.IDTANG AND A.TRANGTHAI = 0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
			gcPhong.DataSource = tb;
			gcDatphong.DataSource = tb.Clone();
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
		SYS_PARAM _param;
		DATPHONG _datphong;
		DATPHONGCHITIET _datphongchitiet;
		KHACHHANG _khachhang;
		SANPHAM _sanpham;
		DATPHONGSANPHAM _datphongsanpham;
		PHONG _phong;
		GridHitInfo downHitInfor = null;
		private void frmDatPhong_Load(object sender, EventArgs e)
		{
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
			_enabled(true);
			tabDanhsach.SelectedTabPage = pageDanhsach;
			gvPhong.ExpandAllGroups();
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
			tabDanhsach.SelectedTabPage = pageChitiet;

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
				_datphong.delete(_idDP);
				var lstDPCT = _datphongchitiet.getAllByDatPhong(_idDP);
				foreach (var item in lstDPCT)
				{
					_phong.updateStatus(item.IDPHONG, false);
				}
			}
			loadDanhSach();
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			saveData();
			loadDanhSach();
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
			_them = false;
			_enabled(false);
			showHideControl(true);

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
				dp.IDKH = int.Parse(cboKhachhang.SelectedValue.ToString());
				dp.SOTIEN = double.Parse(txtThanhtien.Text);
				dp.GHICHU = txtGhichu.Text;
				dp.IDUSER = 1;
				dp.MACTY = _macty;
				dp.MADVI = _madvi;
				dp.CREATED_DATE = DateTime.Now;
				var _dp = _datphong.add(dp);
				_idDP = _dp.IDDP;

				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					dpct = new tb_DatPhongCT();
					dpct.IDDP = _dp.IDDP;
					dpct.IDPHONG = int.Parse(gvDatphong.GetRowCellValue(i, "IDPHONG").ToString());
					dpct.SONGAYO = dtNgaytra.Value.Day - dtNgaydat.Value.Day;
					dpct.DONGIA = int.Parse(gvDatphong.GetRowCellValue(i, "DONGIA").ToString());
					dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
					dpct.NGAY = DateTime.Now;
					var _dpct = _datphongchitiet.add(dpct);
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
								_datphongsanpham.add(dpsp);
							}

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
				dp.IDKH = int.Parse(cboKhachhang.SelectedValue.ToString());
				dp.SOTIEN = double.Parse(txtThanhtien.Text);
				dp.GHICHU = txtGhichu.Text;
				dp.IDUSER = 1;
				dp.UPDATE_BY = 1;
				dp.UPDATE_DATE = DateTime.Now;
				var _dp = _datphong.update(dp);
				_idDP = _dp.IDDP;
				_datphongchitiet.deleteAll(_dp.IDDP);
				_datphongsanpham.deleteAll(_dp.IDDP);


				for (int i = 0; i < gvDatphong.RowCount; i++)
				{
					dpct = new tb_DatPhongCT();
					dpct.IDDP = dp.IDDP;
					dpct.IDPHONG = int.Parse(gvDatphong.GetRowCellValue(i, "IDPHONG").ToString());
					dpct.SONGAYO = dtNgaytra.Value.Day - dtNgaydat.Value.Day;
					dpct.DONGIA = int.Parse(gvDatphong.GetRowCellValue(i, "DONGIA").ToString());
					dpct.THANHTIEN = dpct.SONGAYO * dpct.DONGIA;
					dpct.NGAY = DateTime.Now;
					var _dpct = _datphongchitiet.add(dpct);
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
								_datphongsanpham.add(dpsp);
							}

						}
					}

				}
			}
		}
		private void btnIn_Click(object sender, EventArgs e)
		{
			saveData();
			_datphong.updateStuatus(_idDP);
			XuatReport("PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
			cboTrangthai.SelectedValue = true;
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
			btnThoat.Visible = t;
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
				sp.IDSP = int.Parse(gvSanpham.GetFocusedRowCellValue("IDSP").ToString());
				sp.TENSP = gvSanpham.GetFocusedRowCellValue("TENSP").ToString();
				sp.IDPHONG = _idPhong;
				sp.TENPHONG = _tenPhong;
				sp.DONGIA = double.Parse(gvSanpham.GetFocusedRowCellValue("DONGIA").ToString());
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
			// Lấy giá trị từ các cột "THANHTIEN" và "DONGIA" và chuyển đổi sang kiểu double
			double thanhtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString() ?? "0");
			double dongia = double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString() ?? "0");

			// Tính số ngày ở giữa ngày trả và ngày đặt
			int soNgay = (dtNgaytra.Value.Day - dtNgaydat.Value.Day);

			// Tính tổng tiền
			double tongTien = thanhtien + (dongia * soNgay);

			// Hiển thị kết quả lên TextBox
			txtThanhtien.Text = tongTien.ToString("N0"); // Định dạng số với dấu phẩy (nếu cần)

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

		private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
			// Lấy giá trị từ các cột "THANHTIEN" và "DONGIA" và chuyển đổi sang kiểu double
			double thanhtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString() ?? "0");
			double dongia = double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString() ?? "0");

			// Tính số ngày ở giữa ngày trả và ngày đặt
			int soNgay = (dtNgaytra.Value.Day - dtNgaydat.Value.Day);

			// Tính tổng tiền
			double tongTien = thanhtien + (dongia * soNgay);

			// Hiển thị kết quả lên TextBox
			txtThanhtien.Text = tongTien.ToString("N0"); // Định dạng số với dấu phẩy (nếu cần)
			if (e.Column.FieldName == "TENPHONG")
			{
				int sl = int.Parse(e.Value.ToString());

			}
			gvSPDV.UpdateTotalSummary();

		}

		private void gvDatphong_RowCountChanged(object sender, EventArgs e)
		{
			if (gvDatphong.RowCount < _rowDatPhong && _them == false)
			{
				_phong.updateStatus(_idPhong, false);
				_datphongchitiet.delete(_idDP, _idPhong);
				_datphongsanpham.deleteAllByPhong(_idDP, _idPhong);
				objMain.gControl.Gallery.Groups.Clear();
				objMain.showRoom();
			}


			double t = 0;
			if (gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
				t = 0;
			else
				t = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
			txtThanhtien.Text = (double.Parse(gvDatphong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) + t).ToString("N0");
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
			if (gvDanhSach.RowCount > 0)
			{
				_idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
				var dp = _datphong.getItem(_idDP);
				cboKhachhang.SelectedValue = dp.IDKH;
				dtNgaydat.Value = dp.NGAYDATPHONG.Value;
				if (dp.NGAYDATPHONG.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
					dtNgaytra.Value = dp.NGAYDATPHONG.Value.AddDays(1);
				else
					dtNgaytra.Value = DateTime.Now;
				spSonguoio.Text = dp.SONGUOIO.ToString();
				cboTrangthai.SelectedValue = dp.STATUS;
				txtGhichu.Text = dp.GHICHU;
				txtThanhtien.Text = dp.SOTIEN.Value.ToString("N0");
				loadDP();
				loadSPDV();

			}
		}
		void loadDP()
		{
			_rowDatPhong = 0;
			gcDatphong.DataSource = myFunctions.laydulieu("SELECT A.IDPHONG, A.TENPHONG, C.DONGIA, A.IDTANG, B.TENTANG FROM tb_Phong A, tb_Tang B, tb_LoaiPhong C, tb_DatPhongCT D WHERE A.IDTANG = B.IDTANG  AND A.IDLOAIPHONG = C.IDLOAIPHONG AND A.IDPHONG = D.IDPHONG AND D.IDDP ='" + _idDP + "'");
			_rowDatPhong = gvDatphong.RowCount;
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
			if (gvDanhSach.RowCount > 0)
			{
				_idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDP").ToString());
				var dp = _datphong.getItem(_idDP);
				cboKhachhang.SelectedValue = dp.IDKH;
				dtNgaydat.Value = dp.NGAYDATPHONG.Value;
				if (dp.NGAYDATPHONG.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
					dtNgaytra.Value = dp.NGAYDATPHONG.Value.AddDays(1);
				else
					dtNgaytra.Value = DateTime.Now;
				spSonguoio.Text = dp.SONGUOIO.ToString();
				cboTrangthai.SelectedValue = dp.STATUS;
				txtGhichu.Text = dp.GHICHU;
				txtThanhtien.Text = dp.SOTIEN.Value.ToString("N0");
				loadDP();
				loadSPDV();

			}
			tabDanhsach.SelectedTabPage = pageChitiet;
		}

		
	}

}


