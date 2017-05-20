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
using HQT.Shared;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class AccountManagerForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public List<AccountUserControl> ListAccountUserControls;
        private bool _isEditing;

        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                _isEditing = value;
                btnAddAccount.Visible = !_isEditing;
            }
        }

        private AccountUserControl CreateAccountUsercontrol(User account)
        {
            var index = ListAccountUserControls.Count;
            var userControl = new AccountUserControl
            {
                Data = account,
                Location = new Point(60, 60 + index * 30)
            };
            userControl.SaveAccountEvent += new AccountUserControl.AccountClickedEventHandler(SaveAccountEvent);
            userControl.DeleteAccountEvent  += new AccountUserControl.AccountClickedEventHandler(DeleteAccountEvent);
            userControl.EditAccountEvent += new AccountUserControl.AccountClickedEventHandler(EditAccountEvent);
            return userControl;
        }

        public AccountManagerForm()
        {
            InitializeComponent();
            _accountService = _container.Resolve<IAccountService>();
            ListAccountUserControls = new List<AccountUserControl>();
        }

        private async Task RenderAccountToGUIAsync()
        {
            var listAccounts = await GetListAccountAsync();
            foreach (var account in listAccounts)
            {
                var accountControl = CreateAccountUsercontrol(account);
                Controls.Add(accountControl);
                ListAccountUserControls.Add(accountControl);
            }
        }

        private async Task<List<User>> GetListAccountAsync()
        {
            var listAccounts = await _accountService.GetListAccountAsync(ApplicationSetting.CurrentUser.Id);

            if(listAccounts == null)
                listAccounts = new List<User>();

            return listAccounts;
        }

        private void AccountManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private async void AccountManagerForm_Load(object sender, EventArgs e)
        {
            await RenderAccountToGUIAsync();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var account = Student.Default;
            var accountControl = CreateAccountUsercontrol(account);
            accountControl.IsEdit = true;
            Controls.Add(accountControl);
            ListAccountUserControls.Add(accountControl);
            IsEditing = true;
        }

        private void SaveAccountEvent(object sender, EventArgs e)
        {
            IsEditing = false;
        }

        private async void DeleteAccountEvent(object sender, EventArgs e)
        {
            var target = (AccountUserControl) sender;
            var user = target.Data;
            if (user != null)
            {
                var userId = user.Id;
#if !DEBUG
                var result = await _accountService.DeleteAccountAsync(userId);
#else
                var result = true;
#endif
                if (result)
                {
                    var act = MessageBox.Show(this, "Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    if (act == DialogResult.OK)
                    {
                        IsClose = false;
                        var accountManagerForm = new AccountManagerForm();
                        accountManagerForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    var act = MessageBox.Show(this, "Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void EditAccountEvent(object sender, EventArgs e)
        {
            IsEditing = true;
        }
    }
}
