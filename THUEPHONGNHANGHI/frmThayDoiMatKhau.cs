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

namespace THUEPHONGNHANGHI
{
	public partial class frmThayDoiMatKhau: DevExpress.XtraEditors.XtraForm
	{
        public frmThayDoiMatKhau()
		{
            InitializeComponent();
		}
		public frmThayDoiMatKhau(tb_SYS_USER user)
		{
			InitializeComponent();
			this._user = user;
		}
		tb_SYS_USER _user;
		SYS_USER _sysUser;
		private void frmThayDoiMatKhau_Load(object sender, EventArgs e)
		{
			_sysUser = new SYS_USER();
		
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if(!txtMKMoi.Text.Equals(txtGolaiMKMoi.Text))
			{
				MessageBox.Show("Gõ lại mật khẩu không trùng khớp.","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			var us = _sysUser.getItem(_user.IDUSER);
			if(us.PASSWD== Encryptor.Encrypt(txtMKCu.Text, "qwert@123!poiuy", true))
			{
				us.PASSWD = Encryptor.Encrypt(txtMKMoi.Text, "qwert@123!poiuy", true);
				_sysUser.update(us);
				MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Restart();
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}