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
using Microsoft.Practices.ObjectBuilder2;
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

        private async Task RenderAccountToGuiAsync()
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
            var listAccounts = await _accountService.GetListAccountAsync();

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
            await RenderAccountToGuiAsync();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var account = Student.Default;
            var accountControl = CreateAccountUsercontrol(account);
            accountControl.IsEdit = true;
            ListAccountUserControls.Where(x => x.Data.Id != accountControl.Data.Id).ForEach(x => x.Editable = false);
            Controls.Add(accountControl);
            ListAccountUserControls.Add(accountControl);
            IsEditing = true;
        }

        private async void SaveAccountEvent(object sender, EventArgs e)
        {
            IsEditing = false;
            var target = (AccountUserControl)sender;
            ListAccountUserControls.Where(x => x.Data.Id != target.Data.Id).ForEach(x => x.Editable = true);
            var user = target.Data;
            if (user != null)
            {
                var userId = user.Id;
                var result = await _accountService.UpdateAccountAsync(user);
            }
        }

        private async void DeleteAccountEvent(object sender, EventArgs e)
        {
            var target = (AccountUserControl) sender;
            var user = target.Data;
            if (user != null)
            {
                var userId = user.Id;
                var result = await _accountService.DeleteAccountAsync(userId);
            }
        }

        private void EditAccountEvent(object sender, EventArgs e)
        {
            IsEditing = true;
            var target = (AccountUserControl) sender;
            ListAccountUserControls.Where(x=>x.Data.Id != target.Data.Id).ForEach(x=>x.Editable = false);
        }
    }
}
