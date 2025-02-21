using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class THIETBI
	{
		Entities db;
		public THIETBI()
		{
			db = Entities.CreateEntities();
		}
		public tb_ThietBi getItem(int idTB)
		{
			return db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idTB);
		}
		public List<tb_ThietBi> getAll()
		{
			return db.tb_ThietBi.ToList();
		}
		public void add(tb_ThietBi thietbi)
		{
			try
			{
				db.tb_ThietBi.Add(thietbi);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_ThietBi thietbi)
		{
			tb_ThietBi _thietbi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == thietbi.IDTB);
			_thietbi.TENTB = thietbi.TENTB;
			_thietbi.DONGIA = thietbi.DONGIA;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idTB)
		{
			tb_ThietBi thietbi = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idTB);
			if (thietbi != null)
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_ThietBi.Remove(thietbi);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + idTB);
			}
		}
	}
}
