using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class CreateProjectForm : BaseForm
    {
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private bool _isPersonalProject;
        private ISubjectService _subjectService;
        public bool IsPersonalProject
        {
            get => _isPersonalProject;
            set
            {
                _isPersonalProject = value;
                lbNumberPeopleMin.Visible = !_isPersonalProject;
                numberPeopleMax.Visible = !_isPersonalProject;
            }
        }
        public Subject Data { get; set; }

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

        private List<TabTopicContentUserControl> ListTabPageTopics { get; set; }
        public CreateProjectForm()
        {
            InitializeComponent();
            _subjectService = _container.Resolve<ISubjectService>();
            radioGroup.Checked = true;
            ckLimit.Checked = true;
            ListTabPageTopics  = new List<TabTopicContentUserControl>();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            var tabContent = new TabTopicContentUserControl {Location = new Point(0, 0)};
            var tab = new TabPage($"Đề bài {ListTabPageTopics.Count + 1}");
            tab.Controls.Add(tabContent);
            ListTabPageTopics.Add(tabContent);
            tabTopic.Controls.Add(tab);
        }

        private void radioGroup_CheckedChanged(object sender, EventArgs e)
        {
            var target = (RadioButton) sender;
            IsPersonalProject = !(target.Checked);
        }

        private void radioPersonal_CheckedChanged(object sender, EventArgs e)
        {
            var target = (RadioButton)sender;
            IsPersonalProject = target.Checked;
        }

        private void ckLimit_CheckedChanged(object sender, EventArgs e)
        {
            var target = (CheckBox) sender;
            IsLimit = target.Checked;
        }

        private void CreateProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private List<Topic> GetListTopics()
        {
            var listTopics = new List<Topic>();
            foreach (var tabPageTopic in ListTabPageTopics)
            {
                var title = tabPageTopic.Title;
                var content = tabPageTopic.Content;

                var topic = new Topic(title, content);
                listTopics.Add(topic);
            }
            return listTopics;
        }

        private BaseProject GetProjectFromUI()
        {
            var projectName = txtProjectName.Text;
            var projectType = radioGroup.Checked ? ProjectTypes.Team : ProjectTypes.Person;
            var dateFrom = dtFrom.Value;
            var dateTo = dtTo.Value;
            var listTopics = GetListTopics();
            var limit = ckLimit.Checked ? (int)numberGroup.Value : -1;
            if (projectType == ProjectTypes.Person)
            {
                var project = new ProjectForSingle
                {
                    From = dateFrom,
                    ListTopics = listTopics,
                    To = dateTo,
                    ProjectName = projectName,
                    Limit = limit
                };
                return project;
            }
            else
            {
                var numberMaxPerson = (int) numberPeopleMax.Value;
                var project = new ProjectForTeam
                {
                    From = dateFrom,
                    ListTopics = listTopics,
                    To = dateTo,
                    ProjectName = projectName,
                    Limit = limit,
                    UpperThreshold =  numberMaxPerson
                };
                return project;
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var project = GetProjectFromUI();
#if !DEBUG
            var result = await _subjectService.CreateProjectAsync(project, Data);
#else
            var result = false;
#endif
            if (result)
            {
                var act = MessageBox.Show(this, "Thêm đồ án thành công", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    IsClose = false;
                    var subject = new SubjectManagerForm();
                    subject.Show();
                    this.Close();
                }
            }
            else
            {
                var act = MessageBox.Show(this, "Thêm đồ án thất bại\nThử lại!", "Thông báo", MessageBoxButtons.RetryCancel);
                if (act == DialogResult.Cancel)
                {
                    IsClose = false;
                    var subject = new SubjectManagerForm();
                    subject.Show();
                    this.Close();
                }
                else
                {
                    IsClose = false;
                    var createProjectForm = new CreateProjectForm();
                    createProjectForm.Show();
                    this.Close();
                }
            }
                    
        }
    }
}
