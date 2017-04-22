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

namespace HQT
{
    public partial class Home : Form
    {
        private bool _isClose = true;
        public Home()
        {
            InitializeComponent();
            funcAccount.Avatar = Properties.Resources.account;
            funcAccount.Title = "Tài khoản";

            funcSubject.Avatar = Properties.Resources.subject;
            funcSubject.Title = "Môn học";
            funcSubject.FunctionClicked += (sender, args) =>
            {
                var subject  = new SubjectManager();
                subject.Show();
                _isClose = false;
                Close();
            };

            funcHistory.Avatar = Properties.Resources.history;
            funcHistory.Title = "Nhật ký";
            funcHistory.FunctionClicked += (sender, args) =>
            {
                var subject = new History();
                subject.Show();
                _isClose = false;
                Close();
            };


            funcLogout.Avatar = Properties.Resources.logout;
            funcLogout.Title = "Đăng xuất";
            funcLogout.FunctionClicked += (sender, args) =>
            {
                Login.Instance.Show();
                _isClose = false;
                Close();
            };

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClose)
                Login.Instance.Close();
        }
    }
}
