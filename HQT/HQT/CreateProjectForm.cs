using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private readonly IProjectService _projectService;
        public bool IsPersonalProject
        {
            get => _isPersonalProject;
            set
            {
                _isPersonalProject = value;
                lbNumberPeopleMin.Visible = !_isPersonalProject;
                numberStudentMax.Visible = !_isPersonalProject;
            }
        }


        private readonly Guid _subjectId;
        private List<TabTopicContentUserControl> ListTabPageTopics { get; set; }
        public CreateProjectForm(Guid subjectId)
        {
            _subjectId = subjectId;
            InitializeComponent();
            _projectService = _container.Resolve<IProjectService>();
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
                var topic = tabPageTopic.GetTopic();
                listTopics.Add(topic);
            }
            return listTopics;
        }

        private bool CheckValidation()
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                return false;
            if (!ListTabPageTopics.Any())
                return false;
            foreach (var tabPageTopic in ListTabPageTopics)
            {
                var title = tabPageTopic.Title;
                var content = tabPageTopic.Content;
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
                    return false;
            }
            return true;
        }
        private BaseProject GetProjectFromUi()
        {
            var projectName = txtProjectName.Text;
            var studentMax = (int)numberStudentMax.Value;
            var type = studentMax > 1 ? ProjectTypes.Team : ProjectTypes.Person;
            var dateFrom = dtFrom.Value;
            var dateTo = dtTo.Value;
            var deadline = dtDeadline.Value;
            var listTopics = GetListTopics();
            var limit = (int) numberGroup.Value;
            var projectType = ((ProjectType)cbProjectType.SelectedItem).ProjectTypeName;
            if (type == ProjectTypes.Person)
            {
                var project = new ProjectForSingle
                {
                    RegisterFrom = dateFrom,
                    ListTopics = listTopics,
                    RegisterTo = dateTo,
                    ProjectName = projectName,
                    Limit = limit,
                    Deadline =  deadline,
                    ProjectType =  projectType,
                    
                };
                return project;
            }
            else
            {
                var project = new ProjectForTeam
                {
                    RegisterFrom = dateFrom,
                    ListTopics = listTopics,
                    RegisterTo = dateTo,
                    ProjectName = projectName,
                    Limit = limit,
                    Deadline =  deadline,
                    UpperThreshold = studentMax,
                    ProjectType = projectType
                };
                return project;
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
            {
                var act = MessageBox.Show(this,"Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                    return;
            }
            var project = GetProjectFromUi();
            var result = await _projectService.CreateProjectAsync(project, _subjectId);
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
                    var createProjectForm = new CreateProjectForm(_subjectId);
                    createProjectForm.Show();
                    this.Close();
                }
            }
                    
        }

        private async void statusBar_Load(object sender, EventArgs e)
        {
            var listProjectType = await _projectService.GetListProjectTypeAsync();
            cbProjectType.DataSource = listProjectType;
            cbProjectType.DisplayMember = "ProjectTypeName";
        }
    }
}
