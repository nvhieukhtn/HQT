using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class StatusBarUserControl : UserControl
    {
        public delegate void StatusBarClickedEventHandler(object sender, EventArgs e);

        public event StatusBarClickedEventHandler HomeClicked;
        public event StatusBarClickedEventHandler PreviousClicked;
        public event StatusBarClickedEventHandler NextClicked;
        public event StatusBarClickedEventHandler LogoutClicked;

        public StatusBarUserControl()
        {
            InitializeComponent();
            picHome.Click += new EventHandler(Home_OnClicked);
            picPrevious.Click += new EventHandler(Previous_OnClicked);
            picNext.Click += new EventHandler(Next_OnClicked);
            picLogout.Click += new EventHandler(Logout_OnClicked);
        }

        public void DisablePrevious()
        {
            picPrevious.Visible = false;
        }

        public void EnablePrevious()
        {
            picPrevious.Visible = true;
        }

        public void DisableNext()
        {
            picNext.Visible = false;
        }

        public void EnableNext()
        {
            picNext.Visible = true;
        }

        private void Home_OnClicked(object sender, EventArgs e)
        {
            if (HomeClicked != null)
            {
                HomeClicked(this, e);
            }
        }
        private void Previous_OnClicked(object sender, EventArgs e)
        {
            if (PreviousClicked != null)
            {
                PreviousClicked(this, e);
            }
        }
        private void Next_OnClicked(object sender, EventArgs e)
        {
            if (NextClicked != null)
            {
                NextClicked(this, e);
            }
        }
        private void Logout_OnClicked(object sender, EventArgs e)
        {
            if (LogoutClicked != null)
            {
                LogoutClicked(this, e);
            }
        }
    }
}
