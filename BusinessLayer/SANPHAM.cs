using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class SANPHAM
	{
		Entities db;
		public SANPHAM()
		{
			db = Entities.CreateEntities();
		}
		public tb_SanPham getItem(int idsp)
		{
			return db.tb_SanPham.FirstOrDefault(x => x.IDSP == idsp);
		}
		public List<tb_SanPham> getAll()
		{
			return db.tb_SanPham.ToList();
		}
		public List<tb_SanPham> getLish()
		{
			return db.tb_SanPham.ToList();
		}
		public void add(tb_SanPham sanpham)
		{
			try
			{
				db.tb_SanPham.Add(sanpham);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_SanPham sanpham)
		{
			tb_SanPham _sanpham = db.tb_SanPham.FirstOrDefault(x => x.IDSP == sanpham.IDSP);
			_sanpham.TENSP = sanpham.TENSP;
			_sanpham.DONGIA = sanpham.DONGIA;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idsp)
		{
			tb_SanPham sanpham = db.tb_SanPham.FirstOrDefault(x => x.IDSP == idsp);
			if (sanpham != null)
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_SanPham.Remove(sanpham);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + idsp);
			}
		}
	}
}
