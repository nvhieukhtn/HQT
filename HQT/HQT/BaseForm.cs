using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Shared;

namespace HQT
{
    public partial class BaseForm : Form
    {
        public bool IsClose = true;
        public BaseForm()
        {
            InitializeComponent();
            //statusBar.FullName = ApplicationSetting.CurrentUser.FullName;
            statusBar.HomeClicked += new StatusBarUserControl.StatusBarClickedEventHandler(GoHome);
            statusBar.NextClicked += new StatusBarUserControl.StatusBarClickedEventHandler(Next);
            statusBar.PreviousClicked += new StatusBarUserControl.StatusBarClickedEventHandler(Previous);
            statusBar.LogoutClicked += new StatusBarUserControl.StatusBarClickedEventHandler(Logout);
        }

        public void Next(object sender, EventArgs e)
        {
            
        }

        public void Previous(object sender, EventArgs e)
        {
            
        }

        public void Logout(object sender, EventArgs e)
        {
            IsClose = false;
            var login = LoginForm.Instance;
            login.Show();
            Close();
        }

        public void GoHome(object sender, EventArgs e)
        {
            IsClose = false;
            var home = new HomeForm();
            home.Show();
            Close();
        }
    }
}
