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
    public partial class CreateProjectForm : BaseForm
    {
        private bool _isPersonalProject;

        public bool IsPersonalProject
        {
            get => _isPersonalProject;
            set
            {
                _isPersonalProject = value;
                lbNumberPeopleMax.Visible = !_isPersonalProject;
                lbNumberPeopleMin.Visible = !_isPersonalProject;
                numberPeopleMax.Visible = !_isPersonalProject;
                numberPeopleMin.Visible = !_isPersonalProject;
            }
        }

        private bool _isLimit;

        public bool IsLimit
        {
            get => _isLimit;
            set
            {
                _isLimit = value;
                lbGroupNumber.Visible = _isLimit;
                numberGroup.Visible = _isLimit;
            }
        }

        private List<TabPage> ListTabPageTopics { get; set; }
        public CreateProjectForm()
        {
            InitializeComponent();
            radioGroup.Checked = true;
            ckLimit.Checked = true;
            ListTabPageTopics  = new List<TabPage>();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            var tabContent = new TabTopicContentUserControl {Location = new Point(0, 0)};
            var tab = new TabPage($"Đề bài {ListTabPageTopics.Count + 1}");
            tab.Controls.Add(tabContent);
            ListTabPageTopics.Add(tab);
            tabTopic.Controls.Add(tab);
        }

        private void radioGroup_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (RadioButton) sender;
            IsPersonalProject = !(obj.Checked);
        }

        private void radioPersonal_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (RadioButton)sender;
            IsPersonalProject = obj.Checked;
        }

        private void ckLimit_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (CheckBox) sender;
            IsLimit = obj.Checked;
        }

        private void CreateProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }
    }
}
