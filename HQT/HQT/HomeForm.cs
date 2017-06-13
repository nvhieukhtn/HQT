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
using HQT.Core.Model;
using HQT.Shared;
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

            funcStatistics.Avatar = Properties.Resources.statistic;
            funcStatistics.Title = "Thống kê";

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClose)
                LoginForm.Instance.Close();
        }

        private void funcAccount_FunctionClicked(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Administrator)
            {
                var accountManagerForm = new AccountManagerForm();
                accountManagerForm.Show();
                _isClose = false;
                Close();
            }
            else 
            {
                var accountDetail = new AccountDetailForm(ApplicationSetting.CurrentUser.Id);
                accountDetail.Show();
                _isClose = false;
                Close();
            }
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

        private void funcStatistics_Click(object sender, EventArgs e)
        {
            var statistic = new Overview();
            statistic.Show();
            _isClose = false;
            Close();
        }
    }
}
