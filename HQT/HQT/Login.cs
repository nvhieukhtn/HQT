using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Properties;

namespace HQT
{
    public partial class Login : Form
    {
        private bool _isLogin;
        public Login()
        {
            InitializeComponent();
            txtConfirmPassword.Visible = false;
            lbConfirmPassword.Visible = false;
            ckRemember.Visible = true;
            _isLogin = true;
        }

        private void btnAskRegister_Click(object sender, EventArgs e)
        {
            if (_isLogin)
            {
                ResetControl();
                grbLogin.Text = Resources.RegisterTitle;
                txtConfirmPassword.Visible = true;
                lbConfirmPassword.Visible = true;
                ckRemember.Visible = false;
                _isLogin = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_isLogin == false)
            {
                grbLogin.Text = Resources.LoginTitle;
                ResetControl();
                txtConfirmPassword.Visible = false;
                lbConfirmPassword.Visible = false;
                ckRemember.Visible = true;
                _isLogin = true;
            }
        }

        private void ResetControl()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            ckRemember.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Resources.TeamInformation, Resources.TeamName,
                MessageBoxButtons.OK);
        }
    }
}
