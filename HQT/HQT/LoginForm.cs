﻿using System;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Properties;
using HQT.Shared;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class LoginForm : Form
    {
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private readonly IAccountService _accountService;
        public static LoginForm Instance { get; private set; }
        public LoginForm()
        {
            _accountService = _container.Resolve<IAccountService>();
            InitializeComponent();
            Instance = this;
            ckRemember.Visible = true;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var result = await _accountService.LoginAsync(username, password);
            if (result != null)
            {
                ApplicationSetting.CurrentUser = result;
                var dashboard = new HomeForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void ResetControl()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            ckRemember.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Resources.TeamInformation, Resources.TeamName,
                MessageBoxButtons.OK);
        }
    }
}
