using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using HQT.Shared;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class TopicRegisterForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IProjectService _projectService;
        private readonly ITopicService _topicService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private bool _update;
        private readonly Guid _topicId;
        private readonly Guid _projectId;
        private readonly Guid _courseId;
        public TopicRegisterForm(Guid courseId, Guid projectId, Guid topicId, bool update = false)
        {
            InitializeComponent();
            _courseId = courseId;
            _projectId = projectId;
            _topicId = topicId;
            _update = update;
            _accountService = _container.Resolve<IAccountService>();
            _topicService = _container.Resolve<ITopicService>();
            _projectService = _container.Resolve<IProjectService>();
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

        private void TopicRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private async void TopicRegisterForm_Load(object sender, EventArgs e)
        {
            var listProjectType = await _projectService.GetListProjectTypeAsync();
            cbProjectType.DataSource = listProjectType;
            cbProjectType.DisplayMember = "ProjectTypeName";
            var projectDetail = await _projectService.GetProjectDetailAsync(_projectId);
            var topicDetail = await _topicService.GetTopicDetailAsync(_topicId);
            FillData(projectDetail);
            txtTitle.Text = topicDetail.Title;
            txtContent.Text = topicDetail.Detail;

            btnRegister.Visible = !_update;
            btnUpdate.Visible = _update;
            btnRemove.Visible = _update;

            if (projectDetail is ProjectForSingle)
                grbGroup.Visible = false;
            else
            {
                txtCountNumber.Text = ((ProjectForTeam) projectDetail).UpperThreshold.ToString();
                var listStudents = await _accountService.GetListStudentsBySubjectAsync(_courseId);
                var listStudentItems = listStudents.Where(x=>x.Id != ApplicationSetting.CurrentUser.Id).Select(x => new ListViewItem() { Text = x.FullName, Tag = x }).ToArray();
                lvStudent.Items.AddRange(listStudentItems);
            }

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            
            var remainder = 0;
            Int32.TryParse(txtCountRemainder.Text, out remainder);
            if (remainder < 0)
                MessageBox.Show(this, "Quá số người", "Cảnh cáo", MessageBoxButtons.OK);
            else
            {
                var group = GetGroup();
                var result = true;
                if (grbGroup.Visible)
                    result = await _topicService.CreateGroupAsync(group);
                else
                    result = await _topicService.RegisterTopicAsync(group);
                if (result)
                {
                    var act = MessageBox.Show(this, "Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                    if (act == DialogResult.OK)
                    {
                        IsClose = false;
                        var projectDetailForm = new ProjectDetailForm(_courseId, _projectId);
                        projectDetailForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    var act = MessageBox.Show(this, "Đăng ký thất bại\nThử lại!", "Thông báo", MessageBoxButtons.RetryCancel);
                    if (act == DialogResult.Cancel)
                    {
                        IsClose = false;
                        var projectDetailForm = new ProjectDetailForm(_courseId, _projectId);
                        projectDetailForm.Show();
                        this.Close();
                    }
                    else
                    {
                        IsClose = false;
                        var topicRegisterForm = new TopicRegisterForm(_courseId, _projectId, _topicId);
                        topicRegisterForm.Show();
                        this.Close();
                    }
                }
            }
        }

        private Group GetGroup()
        {
            var groupName = txtGroupName.Text;
            var capacity = 1;
            Int32.TryParse(txtCountNumber.Text, out capacity);
            var group = new Group
            {
                Capacity = capacity,
                GroupName = groupName,
                Leader = (Student) ApplicationSetting.CurrentUser,
                ProjectId = _projectId,
                TopicId = _topicId,
                Members =  new List<Student>()
            };

            if (grbGroup.Visible)
            {
                group.Members = lvStudent.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag).Cast<Student>().ToList();
            }
            return group;
        }

        private void lvStudent_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var totalMember = Int32.Parse(txtCountNumber.Text);
            var countChecked = lvStudent.CheckedItems.Count;
            var remainderMember = totalMember - countChecked - 1;
            txtCountRemainder.Text = remainderMember.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var projectDetailForm = new ProjectDetailForm(_courseId, _projectId);
            IsClose = false;
            projectDetailForm.Show();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
