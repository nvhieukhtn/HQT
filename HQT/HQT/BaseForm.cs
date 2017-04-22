using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class BaseForm : Form
    {
        public bool _isClose = true;
        public BaseForm()
        {
            InitializeComponent();
            statusBar.HomeClicked += new StatusBar.StatusBarClickedEventHandler(GoHome);
            statusBar.NextClicked += new StatusBar.StatusBarClickedEventHandler(Next);
            statusBar.PreviousClicked += new StatusBar.StatusBarClickedEventHandler(Previous);
            statusBar.LogoutClicked += new StatusBar.StatusBarClickedEventHandler(Logout);
        }

        public void Next(object sender, EventArgs e)
        {
            
        }

        public void Previous(object sender, EventArgs e)
        {
            
        }

        public void Logout(object sender, EventArgs e)
        {
            
        }

        public void GoHome(object sender, EventArgs e)
        {
            _isClose = false;
            var home = new Home();
            home.Show();
            Close();
        }
    }
}
