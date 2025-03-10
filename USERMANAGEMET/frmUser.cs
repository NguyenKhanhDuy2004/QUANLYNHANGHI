﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLayer;
using DataLayer;

namespace USERMANAGEMET
{
	public partial class frmUser: DevExpress.XtraEditors.XtraForm
	{
        public frmUser()
		{
            InitializeComponent();
		}
		frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
		public string _macty;
		public string _madvi;
		public int _idUser;
		public string _username;
		public string _fullname;
		public bool _them;
		SYS_USER _sysUser;
		tb_SYS_USER _user;
		SYS_GROUP _sysGroup;
		VIEW_USER_IN_GROUP _vUserInGroup;

		private void frmUser_Load(object sender, EventArgs e)
		{
			_sysUser = new SYS_USER();
			_sysGroup = new SYS_GROUP();
			if (!_them)
			{
				var user = _sysUser.getItem(_idUser);
				txtUsername.Text = user.FULLNAME;
				_macty = user.MACTY;
				_madvi = user.MADVI;
				txtHoten.Text = user.FULLNAME;
				chkDisabled.Checked = user.DISABLED.Value;
				txtUsername.ReadOnly = true;
				txtPass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
				txtRePass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
				loadGroupByUser(_idUser);

			}
			else
			{
				txtHoten.Text = "";
				txtPass.Text = "";
				txtRePass.Text = "";
				chkDisabled.Checked = false;
			}
		}
		public void loadGroupByUser(int idUser)
		{
			_vUserInGroup = new VIEW_USER_IN_GROUP();
			gcThanhVien.DataSource = _vUserInGroup.getGroupByUser(_macty, _madvi, idUser);
			gvThanhVien.OptionsBehavior.Editable = false;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập tên người dùng. Tên nhóm nhập không dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtUsername.SelectAll();
				txtUsername.Focus();
				return;
			}
			if (!txtPass.Text.Equals(txtRePass.Text))
			{
				MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtUsername.SelectAll();
				txtUsername.Focus();
				return;
			}
			saveData();
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void saveData()
		{
			if (_them)
			{
				bool checkUser = _sysUser.checkUserExist(_macty, _madvi, txtUsername.Text.Trim());
				if (checkUser)
				{
					MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtUsername.SelectAll();
					txtUsername.Focus();
					return;
				}
				_user = new tb_SYS_USER();
				_user.USERNAME = txtUsername.Text.Trim();
				_user.FULLNAME = txtHoten.Text;
				_user.PASSWD= Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
				_user.ISGROUP = false;
				_user.DISABLED = false;
				_user.MACTY = _macty;
				_user.MADVI = _madvi;
				_sysUser.add(_user);
				objMain.loadUser(_macty, _madvi);

			}
			else
			{
				_user = _sysUser.getItem(_idUser);
				_user.FULLNAME = txtHoten.Text;
				_user.PASSWD = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
				_user.ISGROUP = false;
				_user.DISABLED = chkDisabled.Checked;
				_user.MACTY = _macty;
				_user.MADVI = _madvi;
				_sysUser.update(_user);
			}
			objMain.loadUser(_macty, _madvi);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

			frmShowGroups frm = new frmShowGroups();
			frm._idUser = _idUser;
			frm._macty = _macty;
			frm._madvi = _madvi;
			frm.ShowDialog();
		}

		private void btnBot_Click(object sender, EventArgs e)
		{
			_sysGroup.delGroup(_idUser,int.Parse( gvThanhVien.GetFocusedRowCellValue("IDUSER").ToString()));
			loadGroupByUser(_idUser);
		}
	}
}