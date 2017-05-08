using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class HomeForm : Form
    {
        private bool _isClose = true;
        public HomeForm()
        {
            InitializeComponent();
           
            funcAccount.Avatar = Properties.Resources.account;
            funcAccount.Title = "Tài khoản";
            
            funcSubject.Avatar = Properties.Resources.subject;
            funcSubject.Title = "Môn học";
            
            funcHistory.Avatar = Properties.Resources.history;
            funcHistory.Title = "Nhật ký";
            
            funcLogout.Avatar = Properties.Resources.logout;
            funcLogout.Title = "Đăng xuất";
            

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClose)
                LoginForm.Instance.Close();
        }

        private void funcAccount_FunctionClicked(object sender, EventArgs e)
        {
            var subject = new AccountManagerForm();
            subject.Show();
            _isClose = false;
            Close();
        }

        private void funcSubject_FunctionClicked(object sender, EventArgs e)
        {
            var subject = new SubjectManagerForm();
            subject.Show();
            _isClose = false;
            Close();
        }

        private void funcHistory_FunctionClicked(object sender, EventArgs e)
        {
            var subject = new HistoryForm();
            subject.Show();
            _isClose = false;
            Close();
        }

        private void funcLogout_FunctionClicked(object sender, EventArgs e)
        {
            LoginForm.Instance.Show();
            _isClose = false;
            Close();
        }
    }
}
