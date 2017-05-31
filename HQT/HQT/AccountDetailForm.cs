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
                    txtCode.Text = _data.Code;
                }
            }
        }
        public AccountDetailForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
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
            Data = await _accountService.GetUserDetailAsync(_userId);
        }
    }
}
