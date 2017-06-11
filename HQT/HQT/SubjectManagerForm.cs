using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using HQT.Shared;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class SubjectManagerForm : BaseForm
    {
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private readonly ISubjectService _subjectService;
        public static SubjectManagerForm Instance { get; private set; }
        public List<SubjectBoardUserControl> ListSubjectControls { get; set; }
        private int _position;
        public SubjectManagerForm()
        {
            InitializeComponent();
            subjectFilter.AddSubjectClicked += AddSubject;
            subjectFilter.FilterSubjectStatus += FilterSubject;
            Instance = this;
            _subjectService = _container.Resolve<ISubjectService>();
            ListSubjectControls = new List<SubjectBoardUserControl>();
        }

        
        private async void SubjectManager_Load(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Student)
            {
                subjectFilter.Visible = false;
                _position = 55;
            }
            else
            {
                subjectFilter.Visible = true;
                _position = 90;
            }
            await RenderSubjectToGuiAsync();
        }


        private async Task<List<Subject>> GetListSubjectsAsync()
        {
            var userId = ApplicationSetting.CurrentUser.Id;
            var listSubjects = await _subjectService.GetListSubjectByUserAsync(userId);

            if(listSubjects == null)
                listSubjects = new List<Subject>();

            return listSubjects;
        }


        private async Task RenderSubjectToGuiAsync()
        {
            var listSubjects = await GetListSubjectsAsync();
            var position = _position;
            foreach (var subject in listSubjects)
            {
                var subjectBoard = CreateSubjectBoardUserControl(subject, position);
                position += subjectBoard.Height;
                ListSubjectControls.Add(subjectBoard);
                Controls.Add(subjectBoard);
            }
        }

        private SubjectBoardUserControl CreateSubjectBoardUserControl(Subject subject, int position)
        {
            var subjectBoard = new SubjectBoardUserControl
            {
                Data = subject,
                Location = new Point(10, position),
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)
            };
            subjectBoard.SubjectBoardProjectDetailClicked +=
                ShowProjectDetail;
            subjectBoard.SubjectBoardCreateProject += CreateProjectEvent;
            return subjectBoard;
        }

        private void AddSubject(object sender, EventArgs e)
        {
            var addSubject = new CreateSubjectForm();
            IsClose = false;
            addSubject.Show();
            Close();
        }

        private void FilterSubject(object sender, EventArgs e)
        {
            
        }

        private void ShowProjectDetail(object sender, EventArgs e)
        {
            var target = (SubjectBoardUserControl) sender;
            var currentProject = target.CurrentProject;
            var subject = target.Data;
            var projectDetail = new ProjectDetailForm(subject.Id, currentProject.Id);
            projectDetail.Show();
            IsClose = false;
            Close();
        }

        private void SubjectManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private void CreateProjectEvent(object sender, EventArgs e)
        {
            var target = (SubjectBoardUserControl)sender;
            var createProjectForm = new CreateProjectForm(target.Data.Id);
            createProjectForm.Show();
            IsClose = false;
            Close();
        }
    }
}
