using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class AccountUserControl : UserControl
    {
        public delegate void AccountClickedEventHandler(object sender, EventArgs e);

        public AccountClickedEventHandler DeleteAccountEvent;
        public AccountClickedEventHandler EditAccountEvent;
        public AccountClickedEventHandler SaveAccountEvent;

        private bool _isEdit = false;

        public bool IsEdit
        {
            get => _isEdit;
            set
            {
                _isEdit = value;
                if (_isEdit)
                {
                    txtUsername.ReadOnly = false;
                    txtFullname.ReadOnly = false;
                    cbRole.Enabled = true;
                    btnSave.Visible = true;
                    btnEdit.Visible = false;
                }
                else
                {
                    txtUsername.ReadOnly = true;
                    txtFullname.ReadOnly = true;
                    cbRole.Enabled = false;
                    btnSave.Visible = false;
                    btnEdit.Visible = true;
                }
            }
        }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            if (EditAccountEvent != null)
            {                
                EditAccountEvent(this, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsEdit = false;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            Data = UserFactory.CreateUser(txtUsername.Text, txtFullname.Text, cbRole.SelectedItem.ToString());
            if (SaveAccountEvent != null)
            {
                SaveAccountEvent(this, e);
            }
        }
    }
}
