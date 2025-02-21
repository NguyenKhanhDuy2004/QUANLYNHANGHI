using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
	public class PHONG
	{
		Entities db;
		public PHONG()
		{
			db = Entities.CreateEntities();
		}
		public tb_Phong getItem(int idphong)
		{
			return db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
		}
		public List<tb_Phong> getByTang(int idTang)
		{
			return db.tb_Phong.Where(x=>x.IDTANG==idTang).ToList();
		}
		public List<tb_Phong> getAll()
		{
			return db.tb_Phong.ToList();
		}
		public objPHONG getItemFull(int id)
		{
			var _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
			objPHONG phong = new objPHONG();
			phong.IDPHONG = _p.IDPHONG;
			phong.TENPHONG = _p.TENPHONG;
			phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
			phong.IDLOAIPHONG = _p.IDLOAIPHONG;
			phong.IDTANG = _p.IDTANG;
			var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
			phong.TENTANG = tang.TENTANG;
			var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
			phong.TENLOAIPHONG = lp.TENLOAIPHONG;
			phong.DONGIA = double.Parse(lp.DONGIA.ToString());
			return phong;
		}
		public objPHONGTHEOGIO getItemFullTheoGio(int id)
		{
			var _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == id);
			objPHONGTHEOGIO phong = new objPHONGTHEOGIO();
			phong.IDPHONG = _p.IDPHONG;
			phong.TENPHONG = _p.TENPHONG;
			phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
			phong.IDLOAIPHONG = _p.IDLOAIPHONG;
			phong.IDTANG = _p.IDTANG;
			var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
			phong.TENTANG = tang.TENTANG;
			var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
			phong.TENLOAIPHONG = lp.TENLOAIPHONG;
			phong.DONGIATHEOGIO = double.Parse(lp.DONGIATHEOGIO.ToString());
			return phong;
		}


		public List<objPHONG> getListFull()
		{
			var lsPhong = db.tb_Phong.ToList();
			List<objPHONG>lsPhongOBJ = new List<objPHONG>();
			objPHONG phong;
			foreach(var _p in lsPhong)
			{
				phong = new objPHONG();
				phong.IDPHONG = _p.IDPHONG;
				phong.TENPHONG = _p.TENPHONG;
				phong.TRANGTHAI = _p.TRANGTHAI;
				phong.IDLOAIPHONG = _p.IDLOAIPHONG;
				phong.IDTANG = _p.IDTANG;
				var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
				phong.TENTANG = tang.TENTANG;
				var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
				phong.TENLOAIPHONG= lp.TENLOAIPHONG;
				phong.DONGIA = double.Parse(lp.DONGIA.ToString());

				lsPhongOBJ.Add(phong);

			}	
			return lsPhongOBJ;
		}

		public void add(tb_Phong _phong)
		{   
			tb_Phong p = new tb_Phong();
			p.TENPHONG = _phong.TENPHONG;
			p.IDTANG = _phong.IDTANG;
			p.IDLOAIPHONG = _phong.IDLOAIPHONG;
			p.TRANGTHAI = _phong.TRANGTHAI;
			db.tb_Phong.Add(_phong);
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}

		}
		public void update(tb_Phong _phong)
		{
			tb_Phong p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == _phong.IDPHONG);
			p.TENPHONG = _phong.TENPHONG;
			p.IDTANG = _phong.IDTANG;
			p.IDLOAIPHONG = _phong.IDLOAIPHONG;
			p.TRANGTHAI = _phong.TRANGTHAI;

			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public List<objPHONG> getPhongTrongFull()
		{
			var lsPhong = db.tb_Phong.Where(x => x.TRANGTHAI == false).ToList();
			List<objPHONG> lsPhongOBJ = new List<objPHONG>();
			objPHONG phong;
			foreach (var _p in lsPhong)
			{
				phong = new objPHONG();
				phong.IDPHONG = _p.IDPHONG;
				phong.TENPHONG = _p.TENPHONG;
				phong.TRANGTHAI = bool.Parse(_p.TRANGTHAI.ToString());
				phong.IDLOAIPHONG = _p.IDLOAIPHONG;
				phong.IDTANG = _p.IDTANG;
				var tang = db.tb_Tang.FirstOrDefault(t => t.IDTANG == _p.IDTANG);
				phong.TENTANG = tang.TENTANG;
				var lp = db.tb_LoaiPhong.FirstOrDefault(l => l.IDLOAIPHONG == _p.IDLOAIPHONG);
				phong.TENLOAIPHONG = lp.TENLOAIPHONG;
				phong.DONGIA = double.Parse(lp.DONGIA.ToString());

				lsPhongOBJ.Add(phong);
			}

			return lsPhongOBJ;
		}


		public void updateStatus(int idphong, bool status)
		{
	         tb_Phong _phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
			_phong.TRANGTHAI = status;
			db.SaveChanges();
	

		}
		public void delete(int idphong)
		{
			tb_Phong phong = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
			if (phong != null) 
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_Phong.Remove(phong);

					// Lưu thay đổi vào cơ sở dữ liệu
					db.SaveChanges();
				}
				catch (Exception ex)
				{
					throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu: " + ex.Message);
				}
			}
			else
			{
				throw new Exception("Không tìm thấy khách hàng với ID: " + idphong);
			}
		}
		public bool checkEmpty(int idPhong)
		{
			var p = db.tb_Phong.FirstOrDefault(x=>x.IDPHONG==idPhong);
			if (p.TRANGTHAI == true)
				return true;
			else 
				return false;
		}
	}
}
