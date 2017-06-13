using System;
using System.Windows.Forms;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT
{
    public partial class AccountUserControl : UserControl
    {
        public delegate void AccountClickedEventHandler(object sender, EventArgs e);

        public AccountClickedEventHandler DeleteAccountEvent;
        public AccountClickedEventHandler EditAccountEvent;
        public AccountClickedEventHandler SaveAccountEvent;
        public AccountClickedEventHandler DetailAccountEvent;
        private User _data;

        public User Data
        {
            get => _data;
            set
            {
                _data = value;
                if (_data != null)
                {
                    txtUsername.Text = _data.UserName;
                    txtFullname.Text = _data.FullName;
                    if (_data is Teacher)
                        cbRole.SelectedItem = "Teacher";
                    if (_data is Student)
                        cbRole.SelectedItem = "Student";
                    if (_data is Administrator)
                        cbRole.SelectedItem = "Administrator";
                }
            }
        }
        public AccountUserControl()
        {
            InitializeComponent();
            cbRole.Items.AddRange(new object[]{ "Teacher", "Student", "Administrator" });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteAccountEvent != null)
                DeleteAccountEvent(this, e);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (DetailAccountEvent != null)
                DetailAccountEvent(this, e);
        }

        private void AccountUserControl_Load(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Administrator)
                btnDelete.Visible = true;
            else
                btnDelete.Visible = false;
        }
    }
}
