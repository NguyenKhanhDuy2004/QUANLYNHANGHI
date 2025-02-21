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
using System.Net.NetworkInformation;

namespace THUEPHONGNHANGHI
{
	public partial class frmPhong : DevExpress.XtraEditors.XtraForm
	{
		public frmPhong()
		{
			InitializeComponent();
		}
		PHONG _phong;
		LOAIPHONG _loaiphong;
		TANG _tang;
		int _idphong;
		bool _them;
		frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
		private void frmPhong_Load(object sender, EventArgs e)
		{
			_phong = new PHONG();
	        _loaiphong = new LOAIPHONG();
		    _tang = new TANG();
			showHideControl(true);
			_enabled(false);
			loadData();
			loadTang();
			loadLoaiphong();
			
		}
		void showHideControl(bool t)
		{
			btnThem.Visible = t;
			btnSua.Visible = t;
			btnXoa.Visible = t;
			btnThoat.Visible = t;
		
		}
		void _enabled(bool t)
		{
			txtTenphong.Enabled = t;
			cboLoaiphong.Enabled = t;
			cboTang.Enabled = t;
			chkDachothue.Enabled = t;
		

		}
		void loadData()
		{
			gcDanhSach.DataSource = _phong.getListFull();
			gvDanhSach.OptionsBehavior.Editable = false;
		}
		void _reset()
		{
			txtTenphong.Text = "";
			cboLoaiphong.Text = "";
			cboTang.Text = "";
			chkDachothue.Checked = false;
			
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
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				_phong.delete(_idphong);

			}
			loadData();
		}


	

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gcDanhSach_Click(object sender, EventArgs e)
		{
			_idphong = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString());
			txtTenphong.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONG").ToString();
			chkDachothue.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
			cboTang.SelectedValue = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTANG").ToString());
			cboLoaiphong.SelectedValue = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
			


		}

		void loadTang()
		{
			cboTang.DataSource = _tang.getAll();
			cboTang.DisplayMember = "TENTANG";
			cboTang.ValueMember = "IDTANG";
			
		}
		void loadLoaiphong()
		{
			cboLoaiphong.DataSource = _loaiphong.getAll();
			cboLoaiphong.DisplayMember = "TENLOAIPHONG";
			cboLoaiphong.ValueMember = "IDLOAIPHONG";
			
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{
			if (_them)
			{
				tb_Phong p = new tb_Phong();
				p.TENPHONG = txtTenphong.Text;
				p.TRANGTHAI = chkDachothue.Checked;
				p.IDTANG = int.Parse(cboTang.SelectedValue.ToString());
				p.IDLOAIPHONG = int.Parse(cboLoaiphong.SelectedValue.ToString());
				_phong.add(p);
			}
			else
			{
				tb_Phong p = _phong.getItem(_idphong);
				p.TENPHONG = txtTenphong.Text;
				p.TRANGTHAI = chkDachothue.Checked;
				p.IDTANG = int.Parse(cboTang.SelectedValue.ToString());
				p.IDLOAIPHONG = int.Parse(cboLoaiphong.SelectedValue.ToString());
				_phong.update(p);
			}
			_them = false;
			loadData();
			_enabled(false);
			showHideControl(true);
			objMain.gControl.Gallery.Groups.Clear();
			objMain.showRoom();
		}

		private void BtnHuy_Click_1(object sender, EventArgs e)
		{
			_them = false;
			showHideControl(true);
			_enabled(false);
		}
	}
}