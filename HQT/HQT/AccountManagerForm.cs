﻿using System;
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
            userControl.DeleteAccountEvent  += DeleteAccountEvent;
            userControl.DetailAccountEvent += DetailAccountEvent;
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
