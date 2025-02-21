using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class PHONGTHIETBI
	{
		Entities db;
		public PHONGTHIETBI()
		{
			db = Entities.CreateEntities();
		}
		public tb_PhongThietBi getItem(int idphong, int idTB)
		{
			return db.tb_PhongThietBi.FirstOrDefault(x => x.IDPHONG == idphong && x.IDTB == idTB);
		}
		public List<objPHONGTHIETBI> getList(int idPhong)
		{
			List<tb_PhongThietBi> lstPTB = db.tb_PhongThietBi.Where(x => x.IDPHONG == idPhong).ToList();
			List<objPHONGTHIETBI> lstPhongTB = new List<objPHONGTHIETBI>();
			objPHONGTHIETBI _ptb;
			foreach (var item in lstPTB)
			{
				_ptb = new objPHONGTHIETBI();
				_ptb.IDPHONG = item.IDPHONG;
				_ptb.IDTB = item.IDTB;
				_ptb.SOLUONG = item.SOLUONG;
				tb_Phong _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
				if (_p != null)
				{
					_ptb.TENPHONG = _p.TENPHONG;
				}
				tb_ThietBi _t = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == item.IDTB);
				if (_t != null)
				{
					_ptb.TENTB = _t.TENTB;
				}
				lstPhongTB.Add(_ptb);



			}
			return lstPhongTB;
		}
		public List<objPHONGTHIETBI> getAll()
		{
			List<tb_PhongThietBi> lstPTB = db.tb_PhongThietBi.ToList();
			List<objPHONGTHIETBI> lstPhongTB = new List<objPHONGTHIETBI>();
			objPHONGTHIETBI _ptb;
			foreach (var item in lstPTB)
			{
				_ptb = new objPHONGTHIETBI();
				_ptb.IDPHONG = item.IDPHONG;
				_ptb.IDTB = item.IDTB;
				_ptb.SOLUONG = item.SOLUONG;
				tb_Phong _p = db.tb_Phong.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
				if (_p != null)
				{
					_ptb.TENPHONG = _p.TENPHONG;
				}
				tb_ThietBi _t = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == item.IDTB);
				if (_t != null)
				{
					_ptb.TENTB = _t.TENTB;
				}
				lstPhongTB.Add(_ptb);



			}
			return lstPhongTB;

		}
		public void add(tb_PhongThietBi ptb)
		{
			try
			{
				db.tb_PhongThietBi.Add(ptb);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_PhongThietBi ptb)
		{
			tb_PhongThietBi tb = db.tb_PhongThietBi.FirstOrDefault(x => x.IDPHONG == ptb.IDPHONG && x.IDTB == ptb.IDTB);
			tb.IDTB = ptb.IDTB;
			tb.SOLUONG = ptb.SOLUONG;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(int idTB, int idPhong)
		{
			tb_PhongThietBi tb = db.tb_PhongThietBi.FirstOrDefault(x => x.IDPHONG == idPhong && x.IDTB == idTB);
			if (tb != null)
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_PhongThietBi.Remove(tb);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + tb);
			}
		}
	}
}
