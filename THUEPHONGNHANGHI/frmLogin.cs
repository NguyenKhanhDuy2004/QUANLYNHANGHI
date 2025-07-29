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
	using DataLayer;
	using BusinessLayer;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.IO;

	namespace THUEPHONGNHANGHI
	{
		public partial class frmLogin: DevExpress.XtraEditors.XtraForm
		{
		    private string selectedAccount = ""; // << THÊM DÒNG NÀY
		    private Color defaultColor;

		    public frmLogin()
			{
				InitializeComponent();
			}
			SYS_PARAM _sysParam;
			SYS_USER _sysUser;
		private void btnLogin_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra xem người dùng đã chọn tài khoản chưa
			if (string.IsNullOrEmpty(selectedAccount))
			{
				MessageBox.Show("Vui lòng chọn một tài khoản để đăng nhập (Ca 1, Ca 2, hoặc Admin).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// 2. Kiểm tra tài khoản có tồn tại không (dùng selectedAccount)
			bool us = _sysUser.checkUserExist(_sysParam.macty, _sysParam.madvi, selectedAccount);
			if (!us)
			{
				// Thông báo này có thể không cần thiết nữa nếu các nút đã được cấu hình đúng
				MessageBox.Show("Tài khoản được chọn không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// 3. Mã hóa mật khẩu và xác thực (giữ nguyên logic của bạn)
			string pass = Encryptor.Encrypt(txtPass.Text, "qwert@123!poiuy", true);
			tb_SYS_USER user = _sysUser.getItem(selectedAccount, _sysParam.macty, _sysParam.madvi);

			if (user.PASSWD.Equals(pass))
			{
				// Đăng nhập thành công
				frmMain frm = new frmMain(user);
				this.Hide(); // Hide trước khi ShowDialog để mượt hơn
				frm.ShowDialog();
				this.Close(); // Đóng form login sau khi form main đóng
			}
			else
			{
				// Mật khẩu sai
				MessageBox.Show("Mật khẩu đăng nhập không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPass.SelectAll();
				txtPass.Focus();
				return;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
			{
				Application.Exit();
			}

			private void frmLogin_Load(object sender, EventArgs e)
			{

				_sysUser = new SYS_USER();
				BinaryFormatter bf = new BinaryFormatter();
				FileStream fs = File.Open("sysparam.ini", FileMode.Open, FileAccess.Read);
				_sysParam = (SYS_PARAM)bf.Deserialize(fs);
				fs.Close();
				myFunctions._macty = _sysParam.macty;
				myFunctions._madvi = _sysParam.madvi;
			    defaultColor = btnThoat.Appearance.BackColor;
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			selectedAccount = "ADMIN"; // << LƯU Ý: Dùng đúng tên đăng nhập trong CSDL
			btnAdmin.Appearance.BackColor = Color.DodgerBlue;
			btnCa1.Appearance.BackColor = defaultColor;
			btnCa2.Appearance.BackColor = defaultColor;
		}

		private void btnCa1_Click(object sender, EventArgs e)
		{
			selectedAccount = "CA01"; // << LƯU Ý: Dùng đúng tên đăng nhập trong CSDL
			btnCa1.Appearance.BackColor = Color.DodgerBlue;
			btnCa2.Appearance.BackColor = defaultColor;
			btnAdmin.Appearance.BackColor = defaultColor;
		}

		private void btnCa2_Click(object sender, EventArgs e)
		{
			selectedAccount = "CA02"; // << LƯU Ý: Dùng đúng tên đăng nhập trong CSDL
			btnCa2.Appearance.BackColor = Color.DodgerBlue;
			btnCa1.Appearance.BackColor = defaultColor;
			btnAdmin.Appearance.BackColor = defaultColor;
		}
	}
	}