using System;
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
                Hide();
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Resources.TeamInformation, Resources.TeamName,
                MessageBoxButtons.OK);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
