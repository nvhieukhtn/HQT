using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT
{
    public partial class ProjectItemUserControl : UserControl
    {
        public delegate void ProjectItemClickedEventHandler(object sender, EventArgs e);
        public event ProjectItemClickedEventHandler ProjectItemClicked;
        public event ProjectItemClickedEventHandler RenewProjectItemClicked;
        public ProjectItemUserControl()
        {
            InitializeComponent();
        }

        private BaseProject _data;

        public BaseProject Data
        {
            get => _data;
            set
            {
                _data = value;
                txtTitle.Text = _data.ProjectName;
                if (_data is ProjectForSingle)
                    picAvatar.Image = Properties.Resources.single;
                else
                    picAvatar.Image = Properties.Resources.group;
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            if (ProjectItemClicked != null)
                ProjectItemClicked(this, e);
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {
            if (ProjectItemClicked != null)
                ProjectItemClicked(this, e);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (RenewProjectItemClicked != null)
                RenewProjectItemClicked(this, e);
        }

        private void ProjectItemUserControl_Load(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Student)
                btnRenew.Visible = false;
            else
                btnRenew.Visible = true;
        }
    }
}
