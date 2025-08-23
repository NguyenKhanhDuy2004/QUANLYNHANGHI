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

		// 💡 VIẾT LẠI CÁC HÀM FULL DÙNG JOIN
		public objPHONG getItemFull(int id)
		{
			var phong = (from p in db.tb_Phong
						 join t in db.tb_Tang on p.IDTANG equals t.IDTANG
						 join lp in db.tb_LoaiPhong on p.IDLOAIPHONG equals lp.IDLOAIPHONG
						 where p.IDPHONG == id
						 select new objPHONG
						 {
							 IDPHONG = p.IDPHONG,
							 TENPHONG = p.TENPHONG,
							 TRANGTHAI = p.TRANGTHAI,
							 IDTANG = p.IDTANG,
							 TENTANG = t.TENTANG, // Lấy từ bảng join
							 IDLOAIPHONG = p.IDLOAIPHONG,
							 TENLOAIPHONG = lp.TENLOAIPHONG, // Lấy từ bảng join
							 DONGIA = lp.DONGIA,
							 DONGIATHEOGIO = lp.DONGIATHEOGIO,
							 SONGUOIO = lp.SONGUOIO,
							 SOGIUONG = lp.SOGIUONG
						 }).FirstOrDefault();
			return phong;
		}

		public List<objPHONG> getListFull()
		{
			var lsPhongOBJ = (from p in db.tb_Phong
							  join t in db.tb_Tang on p.IDTANG equals t.IDTANG
							  join lp in db.tb_LoaiPhong on p.IDLOAIPHONG equals lp.IDLOAIPHONG
							  select new objPHONG
							  {
								  IDPHONG = p.IDPHONG,
								  TENPHONG = p.TENPHONG,
								  TRANGTHAI = p.TRANGTHAI,
								  IDTANG = p.IDTANG,
								  TENTANG = t.TENTANG,
								  IDLOAIPHONG = p.IDLOAIPHONG,
								  TENLOAIPHONG = lp.TENLOAIPHONG,
								  DONGIA = lp.DONGIA,
								  DONGIATHEOGIO = lp.DONGIATHEOGIO,
								  SONGUOIO = lp.SONGUOIO,
								  SOGIUONG = lp.SOGIUONG
							  }).ToList();
			return lsPhongOBJ;
		}

		public List<objPHONG> getPhongTrongFull()
		{
			var lsPhongOBJ = (from p in db.tb_Phong
							  join t in db.tb_Tang on p.IDTANG equals t.IDTANG
							  join lp in db.tb_LoaiPhong on p.IDLOAIPHONG equals lp.IDLOAIPHONG
							  where p.TRANGTHAI == false
							  select new objPHONG
							  {
								  IDPHONG = p.IDPHONG,
								  TENPHONG = p.TENPHONG,
								  TRANGTHAI = p.TRANGTHAI,
								  IDTANG = p.IDTANG,
								  TENTANG = t.TENTANG,
								  IDLOAIPHONG = p.IDLOAIPHONG,
								  TENLOAIPHONG = lp.TENLOAIPHONG,
								  DONGIA = lp.DONGIA,
								  DONGIATHEOGIO = lp.DONGIATHEOGIO,
								  SONGUOIO = lp.SONGUOIO,
								  SOGIUONG = lp.SOGIUONG
							  }).ToList();
			return lsPhongOBJ;
		}

		// --- CÁC HÀM KHÁC GIỮ NGUYÊN ---
		public tb_Phong getItem(int idphong)
		{
			return db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idphong);
		}
		public List<tb_Phong> getByTang(int idTang)
		{
			return db.tb_Phong.Where(x => x.IDTANG == idTang).ToList();
		}
		public List<tb_Phong> getAll()
		{
			return db.tb_Phong.ToList();
		}
		public void add(tb_Phong _phong)
		{
			try
			{
				db.tb_Phong.Add(_phong);
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
					db.tb_Phong.Remove(phong);
					db.SaveChanges();
				}
				catch (Exception ex)
				{
					throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu: " + ex.Message);
				}
			}
			else
			{
				throw new Exception("Không tìm thấy phòng với ID: " + idphong);
			}
		}
		public bool checkEmpty(int idPhong)
		{
			var p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == idPhong);
			if (p.TRANGTHAI == true)
				return true;
			else
				return false;
		}
	}
}