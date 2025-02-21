using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class LOAIPHONG
	{
		Entities db;
		public LOAIPHONG()
		{
			db = Entities.CreateEntities();
		}
		public tb_LoaiPhong getItem(int idloaiphong)
		{
			return db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idloaiphong);
		}
		public List<tb_LoaiPhong> getAll()
		{
			return db.tb_LoaiPhong.ToList();
		}
	
		public void add(tb_LoaiPhong loaiphong)
		{
			try
			{
				db.tb_LoaiPhong.Add(loaiphong);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_LoaiPhong loaiphong)
		{
			tb_LoaiPhong _loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == loaiphong.IDLOAIPHONG );
			_loaiphong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
			_loaiphong.DONGIA = loaiphong.DONGIA;
			_loaiphong.DONGIATHEOGIO = loaiphong.DONGIATHEOGIO;
			_loaiphong.SONGUOIO = loaiphong.SONGUOIO;
			_loaiphong.SOGIUONG = loaiphong.SOGIUONG;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idloaiphong)
		{
			tb_LoaiPhong loaiphong = db.tb_LoaiPhong.FirstOrDefault(x => x.IDLOAIPHONG == idloaiphong);
			if (loaiphong != null) 
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_LoaiPhong.Remove(loaiphong);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + idloaiphong);
			}
		}
	}



}

