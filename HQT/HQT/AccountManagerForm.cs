using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class AccountManagerForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
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

        private AccountUserControl CreateAccountUsercontrol(User account, int index)
        {
            var userControl = new AccountUserControl
            {
                Data = account,
                Location = new Point(60, 90 + index * 30)
            };
            userControl.DeleteAccountEvent  += DeleteAccountEvent;
            userControl.DetailAccountEvent += DetailAccountEvent;
            return userControl;
        }

        public AccountManagerForm()
        {
            InitializeComponent();
            _accountService = _container.Resolve<IAccountService>();
        }

        private async Task RenderAccountToGuiAsync()
        {
            var accounts = await GetListAccountAsync();
            txtCount.Text = accounts.Item1.ToString();
            var index = 0;
            foreach (var account in accounts.Item2)
            {
                var accountControl = CreateAccountUsercontrol(account, index++);
                Controls.Add(accountControl);
            }
        }

        private async Task<Tuple<int,List<User>>> GetListAccountAsync()
        {
            var listAccounts = await _accountService.GetListAccountAsync();

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
            var register = new AccountDetailForm();
            IsClose = false;
            register.Show();
            Close();
        }
        
        private void DetailAccountEvent(object sender, EventArgs e)
        {
            var target = (AccountUserControl) sender;
            var user = target.Data;
            if (user != null)
            {
                IsClose = false;
                var detail = new AccountDetailForm(user.Id);
                detail.Show();
                Close();
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
        
    }
}
