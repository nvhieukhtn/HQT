using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using HQT.Shared;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class ProjectDetailForm : BaseForm
    {
        private readonly IProjectService _projectService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private List<TopicUserControl> _listPracticeControl;
        private readonly Guid _projectId;
        private bool _editing;
        private bool Editing
        {
            set
            {
                _editing = value;
                btnEdit.Visible = !_editing;
                btnSave.Visible = _editing;
            }
        }
        public ProjectDetailForm(Guid projectId)
        {
            _projectId = projectId;
            InitializeComponent();
            _projectService = _container.Resolve<IProjectService>();
        }

        private void Init(BaseProject project)
        {
            FillData(project);
            RenderToGui(project);
        }

        private void FillData(BaseProject data)
        {
            dtFrom.Value = data.RegisterFrom;
            dtTo.Value = data.RegisterTo;
            var team = data as ProjectForTeam;
            numberTo.Value = team?.UpperThreshold ?? 1;
            numberGroup.Value = data.Limit;
            dtDeadline.Value = data.Deadline;
            cbProjectType.SelectedIndex = cbProjectType.FindString(data.ProjectType);
        }
        private void ShowDetail(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)UpdateSubjects);
        }

        private void Register(object sender, EventArgs e)
        {
            var target = (TopicUserControl) sender;
            if (target != null)
            {
                var topicRegister = new TopicRegisterForm(_projectId, target.Data.Id);
                IsClose = false;
                topicRegister.Show();
                Close();
            }
        }

        private async void DeleteTopic(object sender, EventArgs e)
        {
            var target = (TopicUserControl) sender;
            var topicId = target.Data.Id;
            var result = await _projectService.RemoveTopicAsync(topicId, _projectId);
            if (result)
            {
                var act = MessageBox.Show(this, "Xóa đề tài thành công", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    IsClose = false;
                    var subjectForm = new ProjectDetailForm(_projectId);
                    subjectForm.Show();
                    Close();
                }
            }
            else
            {
                var act = MessageBox.Show(this, "Xóa đề tài thất bại", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    IsClose = false;
                    var subjectForm = new ProjectDetailForm(_projectId);
                    subjectForm.Show();
                    Close();
                }
            }
        }

        private void DisplayMember(object sender, EventArgs e)
        {
            
        }

        private void UpdateSubjects()
        {
            var marginTop = 140;
            foreach (var practiceControl in _listPracticeControl)
            {
                practiceControl.Location = new Point(5, marginTop);
                marginTop += practiceControl.Height;
            }
        }
        
        private void RenderToGui(BaseProject data)
        {
            var index = 0;
            _listPracticeControl = new List<TopicUserControl>();
            var positionY = 140;
            foreach (var topic in data.ListTopics)
            {
                var topicControl = new TopicUserControl
                {
                    Data = topic,
                    Index = index + 1,
                    Location = new Point(10, positionY)
                };
                positionY += topicControl.Height;
                topicControl.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                topicControl.TopicClicked += ShowDetail;
                topicControl.TopicRegister += Register;
                topicControl.TopicDelete += DeleteTopic;
                topicControl.DisplayMember += DisplayMember;

                _listPracticeControl.Add(topicControl);
                Controls.Add(topicControl);
            }
        }

        private void ProjectDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private async void ProjectDetailForm_Load(object sender, EventArgs e)
        {
            var listProjectType = await _projectService.GetListProjectTypeAsync();
            cbProjectType.DataSource = listProjectType;
            cbProjectType.DisplayMember = "ProjectTypeName";
            var project = await _projectService.GetProjectDetailAsync(_projectId);
            Init(project);
        }

        private async void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            await SaveProject();
        }

        private void btnEdit_MouseClick(object sender, MouseEventArgs e)
        {
            EditProject();
        }

        private void EditProject()
        {
            Editing = true;
            dtDeadline.Enabled = true;
            dtFrom.Enabled = true;
            dtTo.Enabled = true;
            numberGroup.Enabled = true;
            numberTo.Enabled = true;
            cbProjectType.Enabled = true;
        }

        private async Task SaveProject()
        {
            Editing = false;
            dtDeadline.Enabled = false ;
            dtFrom.Enabled = false;
            dtTo.Enabled = false;
            numberGroup.Enabled = false;
            numberTo.Enabled = false;
            cbProjectType.Enabled = false;
            var project = GetDataFromGui();
            var result = await _projectService.SaveProjectInformationAsync(project);
        }

        private BaseProject GetDataFromGui()
        {
            var registerFrom = dtFrom.Value;
            var registerTo = dtTo.Value;
            var deadline = dtDeadline.Value;
            var limit = numberGroup.Text.GetInt32();
            var studentMax = numberTo.Text.GetInt32();
            var id = _projectId;
            var type = ProjectTypes.Team;
            var projectType = ((ProjectType) cbProjectType.SelectedItem).ProjectTypeName;
            var project = ProjectFactory.CreateProject(id, "", registerFrom, registerTo, limit, deadline, type, "",
                studentMax,projectType);
            return project;
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            var addTopic = new CreateTopicForm(_projectId);
            IsClose = false;
            addTopic.Show();
            Close();
        }
    }
}
