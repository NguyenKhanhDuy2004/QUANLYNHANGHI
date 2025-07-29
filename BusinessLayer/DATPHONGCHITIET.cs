using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class DATPHONGCHITIET
	{
		Entities db;
		public DATPHONGCHITIET()
		{
			db = Entities.CreateEntities();
		}
		public tb_DatPhongCT getItem(int _idDPCT)
		{
			return db.tb_DatPhongCT.FirstOrDefault(x => x.IDDPCT == _idDPCT);
		}
		public tb_DatPhongCT getItem(int idDP, int idPhong)
		{
			return db.tb_DatPhongCT.FirstOrDefault(x => x.IDDP == idDP && x.IDPHONG==idPhong);
		}
		public List<tb_DatPhongCT> getAllByDatPhong(int _idDP)
		{
			
			return db.tb_DatPhongCT.Where(x => x.IDDP == _idDP).ToList();
		}
		public tb_DatPhongCT getIDDPByPhong(int idPhong)
		{
			return db.tb_DatPhongCT.OrderByDescending(x => x.NGAY).FirstOrDefault(x=>x.IDPHONG==idPhong);
		}

		public List<tb_DatPhongCT> getAll()
		{
			return db.tb_DatPhongCT.ToList();
		}
		public tb_DatPhongCT add(tb_DatPhongCT _dpct)
		{
			try
			{
				db.tb_DatPhongCT.Add(_dpct);
				db.SaveChanges();
				return _dpct;
					
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_DatPhongCT dpct)
		{
			tb_DatPhongCT _dpct = db.tb_DatPhongCT.FirstOrDefault(x => x.IDDPCT == dpct.IDDPCT);
			_dpct.IDDP = dpct.IDDP;
			_dpct.IDPHONG = dpct.IDPHONG;
			_dpct.IDDPCT = dpct.IDDPCT;
			_dpct.SONGAYO = dpct.SONGAYO;
			_dpct.DONGIA = dpct.DONGIA;
			_dpct.THANHTIEN = dpct.THANHTIEN;
			_dpct.NGAY = dpct.NGAY;
			_dpct.LOAIHINHTHUE = dpct.LOAIHINHTHUE;
			
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}

		}
		public void delete(int _idDP, int _idPhong)
		{
			tb_DatPhongCT dpct = db.tb_DatPhongCT.FirstOrDefault(x => x.IDDP == _idDP && x.IDPHONG==_idPhong);
			if (dpct != null)
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_DatPhongCT.Remove(dpct);

					// Lưu thay đổi vào cơ sở dữ liệu
					db.SaveChanges();
				}
				catch (Exception ex)
				{
					throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu: " + ex.Message);
				}
			}
			

		}
		public void deleteAll(int idDP)
		{
			List<tb_DatPhongCT> lstDPCT = db.tb_DatPhongCT.Where(x => x.IDDP == idDP).ToList();
			try
			{

				db.tb_DatPhongCT.RemoveRange(lstDPCT);
				db.SaveChanges();


			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
			}



		}

	}
}
