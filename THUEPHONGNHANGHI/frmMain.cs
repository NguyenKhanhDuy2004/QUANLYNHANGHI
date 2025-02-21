﻿using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THUEPHONGNHANGHI
{
	public partial class frmMain : DevExpress.XtraEditors.XtraForm
	{
		public frmMain()
		{
			InitializeComponent();
	
		}
		public frmMain(tb_SYS_USER user )
		{
			InitializeComponent();
			this._user = user;
			this.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN - " + _user.FULLNAME;
		}
		tb_SYS_USER _user;
		TANG _tang;
		PHONG _phong;
		SYS_FUNC _func;
		GalleryItem item = null;
		SYS_GROUP _sysGroup;
		SYS_RIGHT _sysRight;
		private void frmMain_Load(object sender, EventArgs e)
		{
			_tang = new TANG();	
			_phong = new PHONG();
			_func = new SYS_FUNC();
			_sysGroup = new SYS_GROUP();
			_sysRight = new SYS_RIGHT();
			leftMenu(); 
			showRoom();
		}
		void leftMenu()
		{
			int i = 0;
			var _lsParent = _func.getParent();
			foreach (var _pr in _lsParent)
			{
				NavBarGroup navGruop = new NavBarGroup(_pr.DESCRIPTION);
				navGruop.Tag = _pr.FUNC_CODE;
				navGruop.Name = _pr.FUNC_CODE;
				navGruop.ImageOptions.LargeImageIndex = i;
				i++;
				navMain.Groups.Add(navGruop);

				var _lsChild = _func.getChild(_pr.FUNC_CODE);
				foreach (var _ch in _lsChild)
				{
					NavBarItem navItem = new NavBarItem(_ch.DESCRIPTION);
					navItem.Tag = _ch.FUNC_CODE;
					navItem.Name = _ch.FUNC_CODE;
					navItem.ImageOptions.SmallImageIndex = 0;
					navGruop.ItemLinks.Add(navItem);
				}
				navMain.Groups[navGruop.Name].Expanded = true;
			}
		}
		public void showRoom()
		{
			_tang = new TANG();
			_phong = new PHONG();
			var lsTang = _tang.getAll();
			gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
			gControl.Gallery.ImageSize = new Size(128, 128);
			gControl.Gallery.ShowItemText = true;
			gControl.Gallery.ShowGroupCaption = true;
			foreach (var t in lsTang)
			{
				var galleryItem = new GalleryItemGroup();
				galleryItem.Caption = t.TENTANG;
				galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
				List<tb_Phong> lsPhong = _phong.getByTang(t.IDTANG);
				foreach (var p in lsPhong)
				{
					var gc_item = new GalleryItem();
					gc_item.Caption = p.TENPHONG;
					gc_item.Value = p.IDPHONG;
					if (p.TRANGTHAI == true)
						gc_item.ImageOptions.Image = imageList3.Images[1];
					else
						gc_item.ImageOptions.Image = imageList3.Images[0];

					galleryItem.Items.Add(gc_item);
				}
				gControl.Gallery.Groups.Add(galleryItem);
			}


		}

		private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			string func_code=e.Link.Item.Tag.ToString();

			var _group = _sysGroup.getGroupByMember(_user.IDUSER);
			var _uRight = _sysRight.getRight(_user.IDUSER, func_code);

			if(_group!=null)
			{
				var _groupRight = _sysRight.getRight(_group.GROUP, func_code);
				if (_uRight.USER_RIGHT < _groupRight.USER_RIGHT)
					_uRight.USER_RIGHT = _groupRight.USER_RIGHT;
			
			}
			if (_uRight.USER_RIGHT==0)
			{
				MessageBox.Show("Không có quyền thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else 
			{
				switch (func_code)
				{
					case "CONGTY":
						{
							frmCongTy frm = new frmCongTy(_user, _uRight.USER_RIGHT.Value);
							frm.ShowDialog();
							break;
						}
					case "DONVI":
						{
							frmDonVi frm = new frmDonVi();
							frm.ShowDialog();
							break;
						}

					case "KHACHHANG":
						{
							frmKhachHang frm = new frmKhachHang();
							frm.ShowDialog();
							break;
						}

					case "TANG":
						{
							frmTang frm = new frmTang();
							frm.ShowDialog();
							break;
						}

					case "LOAIPHONG":
						{
							frmLoaiPhong frm = new frmLoaiPhong();
							frm.ShowDialog();
							break;
						}
					case "PHONG":
						{
							frmPhong frm = new frmPhong();
							frm.ShowDialog();
							break;
						}
					case "SANPHAM":
						{
							frmSanPham frm = new frmSanPham();
							frm.ShowDialog();
							break;
						}
					case "THIETBI":
						{
							frmThietBi frm = new frmThietBi();
							frm.ShowDialog();
							break;
						}
					case "DATPHONG":
						{
							frmDatPhong frm = new frmDatPhong();
							frm.ShowDialog();
							break;
						}
					case "DATPHONGDON":
						{
							frmDatPhongDon frm = new frmDatPhongDon();
							frm.ShowDialog();
							break;
						}
					case "PHONGTHIETBI":
						{
							frmPhongThietBi frm = new frmPhongThietBi();
							frm.ShowDialog();
							break;
						}
					case "DOIMK":
						{
							frmThayDoiMatKhau frm = new frmThayDoiMatKhau(_user);
							frm.ShowDialog();
							break;
						}


				}
			}
			


		}


		private void btnBaoCao_Click(object sender, EventArgs e)
		{
			frmBaoCao frm = new frmBaoCao(_user);
			frm.ShowDialog();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void popupMenu1_Popup(object sender, EventArgs e)
		{
			Point point = gControl.PointToClient(Control.MousePosition);
			RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
			if (hitInfo.InGalleryItem || hitInfo.HitTest==RibbonHitTest.GalleryImage)
					item=hitInfo.GalleryItem;


		}

		

	

		private void btnSPDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng chưa được đặt.Vui lòng chọn phòng đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmDatPhongDon frm = new frmDatPhongDon();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm._them = false;
			frm.ShowDialog();
			
		}

		private void btnChuyenPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng không được chuyển.Vui lòng chọn phòng đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmChuyenPhong frm = new frmChuyenPhong();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm.ShowDialog();
			
		}

		private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng chưa được đặt.Nên chưa thể thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmDatPhongDon frm = new frmDatPhongDon();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm._them = false;
			frm.ShowDialog();
			

		}

		private void btnDatPhong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
	        if(_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng đã được đặt.Vui lòng chọn phòng khác.", "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}	
			frmDatPhongDon frm = new frmDatPhongDon();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm._them = true;
			frm.ShowDialog();



		}

		private void btnDatPhongTheoGio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng đã được đặt.Vui lòng chọn phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmDatPhongTheoGio frm = new frmDatPhongTheoGio();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm._them = true;
			frm.ShowDialog();
		}

		private void btnThanhtoantheogio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng chưa được đặt.Nên chưa thể thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmDatPhongTheoGio frmTheoGio = new frmDatPhongTheoGio();
			frmTheoGio._idPhong = int.Parse(item.Value.ToString());
			frmTheoGio._them = false;
			frmTheoGio.ShowDialog();
		}

		private void btnCapnhattheogio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
			{
				MessageBox.Show("Phòng chưa được đặt.Vui lòng chọn phòng đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			frmDatPhongTheoGio frm = new frmDatPhongTheoGio();
			frm._idPhong = int.Parse(item.Value.ToString());
			frm._them = false;
			frm.ShowDialog();

		}
	}
}
