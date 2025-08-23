using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrystalDecisions.Windows.Forms;
//using CrystalDecisions.Shared;
//using CrystalDecisions.CrystalReports.Engine;
using System.Linq.Expressions;



namespace THUEPHONGNHANGHI
{
	public class myFunctions
	{
		public static string _macty;
		public static string _madvi;
		public static string _vaitro;
		public static string _srv;
		public static string _us;
		public static string _pw;
		public static string _db;
		static SqlConnection con = new SqlConnection();

		public static void taoketnoi()
		{
			con.ConnectionString = Program.connoi;
			try
			{
				con.Open();
			}
			catch (Exception)
			{

			}
		}
		public static void dongketnoi()
		{
			con.Close();
		}
		public static DataTable laydulieu(string qr)
		{
			taoketnoi();
			DataTable datab1 = new DataTable();
			SqlDataAdapter dap = new SqlDataAdapter();
			dap.SelectCommand = new SqlCommand(qr, con);
			dap.Fill(datab1);
			dongketnoi();
			return datab1;
		}
		public static DateTime GetFirstDayInMont(int year, int month)
		{
			return new DateTime(year, month, 1);
		}
		/*public static void XuatReport(string _khoa, string _reportName, string _tieude)
		{
			if (_khoa != null)
			{
				Form frm = new Form();
				CrystalReportViewer Crv = new CrystalReportViewer();
				Crv.ShowGroupTreeButton = false;
				Crv.ShowParameterPanelButton = false;
				Crv.ToolPanelView = ToolPanelViewType.None;
				TableLogOnInfo Thongtin;
				ReportDocument doc = new ReportDocument();
				doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @"");
				Thongtin = doc.Database.Tables[0].LogOnInfo;
				Thongtin.ConnectionInfo.ServerName = myFunctions._srv;
				Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;
				Thongtin.ConnectionInfo.UserID = myFunctions._us;
				Thongtin.ConnectionInfo.Password = myFunctions._pw;
				doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
				try
				{
					doc.SetParameterValue("pkhoa", _khoa.ToString());
					Crv.Dock = DockStyle.Fill;
					Crv.ReportSource = doc;
					frm.Controls.Add(Crv);
					Crv.Refresh();
					frm.Text = _tieude;
					frm.WindowState = FormWindowState.Maximized;
					frm.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi : " + ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("Không có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
				
		}*/

	}
}
