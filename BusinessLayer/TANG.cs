using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class TANG
	{
		Entities db;
		public TANG()
		{
			db = Entities.CreateEntities();
		}
		public tb_Tang getItem(int idtang)
		{
			return db.tb_Tang.FirstOrDefault(x => x.IDTANG == idtang);
		}
		public List<tb_Tang> getAll()
		{
			return db.tb_Tang.ToList();
		}
		public void add(tb_Tang tang)
		{
			try
			{
				db.tb_Tang.Add(tang);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_Tang tang)
		{
			tb_Tang _tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == tang.IDTANG);
			_tang.TENTANG = tang.TENTANG;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idtang)
		{
			// Tìm khách hàng cần xóa dựa trên ID
			tb_Tang tang = db.tb_Tang.FirstOrDefault(x => x.IDTANG == idtang);

			if (tang != null) // Kiểm tra nếu tìm thấy khách hàng
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_Tang.Remove(tang);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + idtang);
			}
		}
	}
}
