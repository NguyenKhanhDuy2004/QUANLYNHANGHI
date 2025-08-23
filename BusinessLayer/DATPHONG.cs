using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class DATPHONG
	{
		Entities db;
		public DATPHONG()
		{
			db = Entities.CreateEntities();
		}
		public tb_DatPhong getItem(int id)
		{
			return db.tb_DatPhong.FirstOrDefault(x => x.IDDP == id);
		}
		public List<tb_DatPhong> getAll()
		{
			return db.tb_DatPhong.ToList();
		}

		public List<objDATPHONG> getAll(DateTime tungay, DateTime denngay, string macty, string madvi)
		{
			var listDP=db.tb_DatPhong.Where(x=>x.NGAYDATPHONG>=tungay && x.NGAYDATPHONG<denngay && x.MACTY==macty && x.MADVI==madvi).ToList();
		    List<objDATPHONG> lstDP = new List<objDATPHONG>();
			objDATPHONG dp;
			foreach (var item in listDP)
			{
				dp = new objDATPHONG();
				dp.IDDP = item.IDDP;
				dp.IDKH = item.IDKH;
				var kh = db.tb_KhachHang.FirstOrDefault(x => x.IDKH==item.IDKH);
				dp.HOTEN = kh.HOTEN; 
				dp.IDUSER = item.IDUSER;
				dp.NGAYDATPHONG = item.NGAYDATPHONG;
				dp.NGAYTRAPHONG = item.NGAYTRAPHONG;
				dp.MACTY = item.MACTY;
				dp.MADVI = item.MADVI;
				dp.SONGUOIO = item.SONGUOIO;
				dp.SOTIEN = item.SOTIEN;
				dp.STATUS = item.STATUS;
				dp.GHICHI = item.GHICHU;
				dp.HINHTHUCTHANHTOAN = item.HINHTHUCTHANHTOAN;
				lstDP.Add(dp);
			}
			return lstDP;

		}
		public tb_DatPhong add(tb_DatPhong _dp)
		{
			try
			{
				db.tb_DatPhong.Add(_dp);
				db.SaveChanges();
				return _dp;

			}
			catch (DbEntityValidationException ex)
			{
				var errorMessages = ex.EntityValidationErrors
					.SelectMany(e => e.ValidationErrors)
					.Select(e => $"Property: {e.PropertyName} Error: {e.ErrorMessage}");

				var fullErrorMessage = string.Join("; ", errorMessages);
				var exceptionMessage = $"Có lỗi xảy ra trong quá trình xử lý dữ liệu: {fullErrorMessage}";

				throw new Exception(exceptionMessage);
			}



		}
		public void  updateStuatus(int idDP)
		{
			tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == idDP);
			dp.STATUS=true;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public tb_DatPhong update(tb_DatPhong _dp)
		{
			tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _dp.IDDP);
			dp.IDKH = _dp.IDKH;
			dp.NGAYDATPHONG = _dp.NGAYDATPHONG;
			dp.NGAYTRAPHONG = _dp.NGAYTRAPHONG;
			dp.SONGUOIO = _dp.SONGUOIO;
			dp.SOTIEN = _dp.SOTIEN;
			dp.MACTY = _dp.MACTY;
			dp.MADVI = _dp.MADVI;
			dp.STATUS = _dp.STATUS;
			dp.GHICHU = _dp.GHICHU;
			dp.CREATED_DATE = _dp.CREATED_DATE;
			dp.HINHTHUCTHANHTOAN = _dp.HINHTHUCTHANHTOAN;
			try
			{
				db.SaveChanges();
				return dp;
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}

		}
		public void delete(int _id)
		{
			tb_DatPhong dp = db.tb_DatPhong.FirstOrDefault(x => x.IDDP == _id);
			if (dp != null)
			{
				try
				{
					// Xóa khách hàng khỏi context
					db.tb_DatPhong.Remove(dp);

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
				throw new Exception("Không tìm thấy khách hàng với ID: " + _id);
			}
		}

	}
}
