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

namespace THUEPHONGNHANGHI
{
	public partial class frmChonThanhToan : DevExpress.XtraEditors.XtraForm
	{
		// Thuộc tính này sẽ lưu lựa chọn của người dùng.
		// Form cha (frmDatPhong) sẽ đọc giá trị từ đây sau khi form này đóng.
		public string SelectedPaymentMethod { get; private set; }

		public frmChonThanhToan()
		{
			InitializeComponent();
		}

		// Sự kiện Click cho nút TIỀN MẶT
		private void btnTienMat_Click(object sender, EventArgs e)
		{
			// 1. Gán giá trị được chọn
			SelectedPaymentMethod = "Tiền mặt";
			// 2. Đặt kết quả của Dialog là OK
			this.DialogResult = DialogResult.OK;
			// 3. Đóng form lại
			this.Close();
		}

		// Sự kiện Click cho nút CHUYỂN KHOẢN
		private void btnChuyenKhoan_Click(object sender, EventArgs e)
		{
			SelectedPaymentMethod = "Chuyển khoản";
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Sự kiện Click cho nút VISA
		private void btnVisa_Click(object sender, EventArgs e)
		{
			SelectedPaymentMethod = "VISA";
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}