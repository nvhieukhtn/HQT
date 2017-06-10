using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class AccountDetailForm : BaseForm
    {
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private readonly IAccountService _accountService;
        private readonly Guid _userId;
        private User _data;
        private bool _isRegister;

        public bool IsRegister
        {
            get => _isRegister;
            set
            {
                _isRegister = value;
                if (_isRegister)
                {
                    btnEditPhone.Visible = false;
                    btnEditAddress.Visible = false;
                    btnEditFullname.Visible = false;
                    btnChangePassword.Visible = false;
                    btnRegister.Visible = true;
                    btnChangePassword.Visible = false;
                    btnChangeAvatar.Visible = false;
                    cbAccountType.Enabled = true;
                    txtUsername.Enabled = true;
                    txtPhone.Enabled = true;
                    txtAddress.Enabled = true;
                    txtEmail.Enabled = true;
                    txtFullname.Enabled = true;
                    cbAccountType.SelectedItem = "Student";
                }
                else
                {
                    btnRegister.Visible = false;
                    lbPassword.Visible = false;
                    txtPassword.Visible = false;
                    txtRePassword.Visible = false;


                    txtUsername.Enabled = false;
                    txtPhone.Enabled = false;
                    txtAddress.Enabled = false;
                    txtEmail.Enabled = false;
                    txtFullname.Enabled = false;
                }
            }
        }
        public User Data
        {
            get => _data;
            set
            {
                _data = value;
                if (_data != null)
                {
                    txtFullname.Text = _data.FullName;
                    txtUsername.Text = _data.UserName;
                    txtAddress.Text = _data.Address;
                    txtPhone.Text = _data.Phone;
                    txtEmail.Text = _data.Email;
                }
            }
        }
        public AccountDetailForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
            IsRegister = false;
            _accountService = _container.Resolve<IAccountService>();
        }
        public AccountDetailForm()
        {
            InitializeComponent();
            IsRegister = true;
            _accountService = _container.Resolve<IAccountService>();
        }

        private void btnEditFullname_Click(object sender, EventArgs e)
        {
            txtFullname.Enabled = true;
            btnEditFullname.Visible = false;
            btnSaveFullname.Visible = true;
        }

        private void btnSaveFullname_Click(object sender, EventArgs e)
        {
            txtFullname.Enabled = false;
            btnEditFullname.Visible = true;
            btnSaveFullname.Visible = false;
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Enabled = true;
            btnEditPhone.Visible = false;
            btnSavePhone.Visible = true;
        }

        private void btnSavePhone_Click(object sender, EventArgs e)
        {
            txtPhone.Enabled = false;
            btnEditPhone.Visible = true;
            btnSavePhone.Visible = false;
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            btnEditAddress.Visible = false;
            btnSaveAddress.Visible = true;
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
            btnEditAddress.Visible = true;
            btnSaveAddress.Visible = false;
        }

        private async void statusBar_Load(object sender, EventArgs e)
        {
            if(!IsRegister)
                Data = await _accountService.GetUserDetailAsync(_userId);
            else 
                Data = new Student();
        }

        private void AccountDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsClose)
                LoginForm.Instance.Close();
        }

        private User GetUser()
        {
            var username = txtUsername.Text;
            var fullname = txtFullname.Text;
            var type = cbAccountType.SelectedItem.ToString();
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var password = txtPassword.Text;

            var user = UserFactory.CreateUser(username, fullname, type);
            user.Email = email;
            user.Phone = phone;
            user.Password = password;
            return user;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var user = GetUser();
            var result = await _accountService.CreateAccountAsync(user);
            if (result)
            {
                var react = MessageBox.Show(this, "Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                if (react == DialogResult.OK)
                {
                    var accountList = new AccountManagerForm();
                    IsClose = false;
                    accountList.Show();
                    Close();
                }
            }
            else
            {
                var react = MessageBox.Show(this, "Tạo tài khoản thất bại\n Thử lại!", "Thông báo", MessageBoxButtons.OKCancel);
                if (react == DialogResult.Cancel)
                {
                    var accountList = new AccountManagerForm();
                    IsClose = false;
                    accountList.Show();
                    Close();
                }
                else if (react == DialogResult.OK)
                {
                    var accountDetail = new AccountDetailForm();
                    IsClose = false;
                    accountDetail.Show();
                    Close();
                }
            }
        }
    }
}
