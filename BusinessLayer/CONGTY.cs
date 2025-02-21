﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class CONGTY
	{
		Entities db;
		public CONGTY()
		{
			db = Entities.CreateEntities();
		}
		public tb_CongTy getItem(string macty)
		{
			return db.tb_CongTy.FirstOrDefault(x => x.MACTY == macty);
		}
		public List<tb_CongTy> getAll()
		{
			return db.tb_CongTy.ToList();
		}
		public void add(tb_CongTy cty)
		{
			try
			{
				db.tb_CongTy.Add(cty);
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
			}


		}
		public void update(tb_CongTy cty)
		{
			tb_CongTy _cty = db.tb_CongTy.FirstOrDefault(x => x.MACTY == cty.MACTY);
			_cty.TENCTY = cty.MACTY;
			_cty.DIENTHOAI = cty.DIENTHOAI;
			_cty.FAX = cty.FAX;
			_cty.EMAIL = cty.EMAIL;
			_cty.DIACHI = cty.DIACHI;
			_cty.DISABLED = cty.DISABLED;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

			}
		}
		public void delete(string macty)	
		{
			tb_CongTy cty = db.tb_CongTy.FirstOrDefault(x=>x.MACTY==macty);
			cty.DISABLED = true;
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
			}
		}
	}
}
