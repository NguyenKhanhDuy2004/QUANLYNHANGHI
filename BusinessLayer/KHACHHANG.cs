using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class KHACHHANG
	{
		Entities db;
		public KHACHHANG()
		{
			db = Entities.CreateEntities();
		}
		public tb_KhachHang getItem(int idkh)
		{
			return db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idkh);
		}
		public List<tb_KhachHang> getAll()
		{
			return db.tb_KhachHang.ToList();
		}
		public void add(tb_KhachHang kh)
		{
			try
			{
				db.tb_KhachHang.Add(kh);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_KhachHang kh)
		{
			tb_KhachHang _kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == kh.IDKH);
			_kh.IDKH = kh.IDKH;
			_kh.HOTEN = kh.HOTEN;
			_kh.CCCD = kh.CCCD;
			_kh.DIENTHOAI = kh.DIENTHOAI;
			_kh.EMAIL = kh.EMAIL;
			_kh.DIACHI = kh.DIACHI;
			_kh.PHAI = kh.PHAI;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idkh)
		{
			// Tìm khách hàng cần xóa dựa trên ID
			tb_KhachHang kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH == idkh);

			if (kh != null) // Kiểm tra nếu tìm thấy khách hàng
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_KhachHang.Remove(kh);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + idkh);
			}
		}


	}
}
