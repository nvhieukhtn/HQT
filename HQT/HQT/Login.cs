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
        public static Login Instance { get; private set; }
        public Login()
        {
            InitializeComponent();
            Instance = this;
            ckRemember.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var dashboard = new Home();
            dashboard.Show();
            this.Hide();
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
