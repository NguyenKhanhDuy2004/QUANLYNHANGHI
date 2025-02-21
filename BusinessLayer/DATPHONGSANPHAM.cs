using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class DATPHONGSANPHAM
	{
		Entities db;
		public DATPHONGSANPHAM()
		{
			db = Entities.CreateEntities();
		}
		public List<objDPSP> getAllByDatPhong(int idDP)
		{
			var lst = db.tb_DatPhongSanPham.Where(x=>x.IDDP == idDP).ToList();
			List<objDPSP>lstDPSP = new List<objDPSP>();
			objDPSP sp;
			foreach (var item in lst)
			{ 
			    sp = new objDPSP();
				sp.IDDPSP = item.IDDPSP;
				sp.IDDP = item.IDDP;
				sp.IDPHONG = item.IDPHONG;
				var p = db.tb_Phong.FirstOrDefault(x=>x.IDPHONG == item.IDPHONG);
				sp.TENPHONG = p.TENPHONG;
				sp.IDSP = item.IDSP;
				var s = db.tb_SanPham.FirstOrDefault(x => x.IDSP == item.IDSP);
				sp.TENSP = s.TENSP;
				sp.SOLUONG = item.SOLUONG;
				sp.DONGIA = item.DONGIA;
				sp.THANHTIEN = item.THANHTIEN;
				lstDPSP.Add(sp);
			}
			return lstDPSP;
		}
		public List<tb_DatPhongSanPham> getAllByPhong(int idDP, int idDPCT)
		{
			return db.tb_DatPhongSanPham.Where(x => x.IDDP == idDP && x.IDDPCT==idDPCT).ToList();
			
		}
		public void add(tb_DatPhongSanPham dpsp)
		{
			try
			{
				db.tb_DatPhongSanPham.Add(dpsp);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
			}

		}
		public void update(tb_DatPhongSanPham dpsp)
		{
			tb_DatPhongSanPham sp = db.tb_DatPhongSanPham.FirstOrDefault(x=>x.IDDPSP==dpsp.IDDPSP);
			sp.IDDP=dpsp.IDDP;
			sp.IDPHONG=dpsp.IDPHONG;
			sp.SOLUONG=dpsp.SOLUONG;
			sp.NGAY=dpsp.NGAY;
			sp.DONGIA=dpsp.DONGIA;
			sp.THANHTIEN=dpsp.THANHTIEN;
			try
			{
				db.SaveChanges();
			}
			catch (Exception)
			{ 
			   throw;
			}
		
		}
		public void deleteAll(int idDP)
		{
			List<tb_DatPhongSanPham> lstSP = db.tb_DatPhongSanPham.Where(x => x.IDDP == idDP).ToList();
			try
			{

				db.tb_DatPhongSanPham.RemoveRange(lstSP);
				db.SaveChanges();


			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
			}
		
			
			
		}
		public void deleteAllByPhong(int idDP, int _idPhong)
		{
			List<tb_DatPhongSanPham> lstSP = db.tb_DatPhongSanPham.Where(x => x.IDDP == idDP && x.IDPHONG==_idPhong).ToList();
			try
			{

				db.tb_DatPhongSanPham.RemoveRange(lstSP);
				db.SaveChanges();


			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
			}



		}


	}
}