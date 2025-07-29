using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using BusinessLayer;

namespace THUEPHONGNHANGHI
{
	public partial class frmBCao: DevExpress.XtraEditors.XtraForm
	{
        public frmBCao()
		{
            InitializeComponent();
		}
		DATPHONG _datphong;
		DATPHONGCHITIET _datphongct;
		DATPHONGSANPHAM _datphongsp;
		objPHONG _phongHienTai;
		PHONG _phong;
		KHACHHANG _khachhang;
		SANPHAM _sanpham;
		private void frmBCao_Load(object sender, EventArgs e)
		{
			try
			{
				// Window/c/
				reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp_SQLSever.Report1.rdlc";
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Name = "DataSet1";
				reportDataSource.Value = _datphongct.getAll();
				reportViewer1.LocalReport.DataSources.Add(reportDataSource);
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		
	}
}