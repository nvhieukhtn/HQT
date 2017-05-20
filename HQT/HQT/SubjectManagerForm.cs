using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        
        public SubjectManagerForm()
        {
            InitializeComponent();
            Instance = this;
            _subjectService = _container.Resolve<ISubjectService>();
            ListSubjectControls = new List<SubjectBoardUserControl>();
        }

        
        private void SubjectManager_Load(object sender, EventArgs e)
        {
            RenderSubjectToGUIAsync();
        }

        private List<Subject> PrepareData()
        {
            var listSubjects = new List<Subject>
            {
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test(),
                Subject.Test()
            };
            
            return listSubjects;
        }

        private async Task<List<Subject>> GetListSubjects()
        {
            var userId = ApplicationSetting.CurrentUser.Id;
#if !DEBUG
            var listSubjects = await _subjectService.GetListSubjectAsync(userId);
#else
            var listSubjects = PrepareData();
#endif

            if(listSubjects == null)
                listSubjects = new List<Subject>();

            return listSubjects;
        }


        private async Task RenderSubjectToGUIAsync()
        {
            var listSubjects = await GetListSubjects();
            
            foreach (var subject in listSubjects)
            {
                var subjectBoard = CreateSubjectBoardUserControl(subject);
                ListSubjectControls.Add(subjectBoard);
                Controls.Add(subjectBoard);
            }
        }

        private SubjectBoardUserControl CreateSubjectBoardUserControl(Subject subject)
        {
            var index = ListSubjectControls.Count;
            var subjectBoard = new SubjectBoardUserControl { Data = subject };
            subjectBoard.Location = new Point(10, 55 + index * subjectBoard.Height);
            subjectBoard.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            subjectBoard.SubjectBoardProjectDetailClicked +=
                new SubjectBoardUserControl.SubjectBoardProjectDetailClickedEventHandler(ShowProjectDetail);
            subjectBoard.SubjectBoardCreateProject += new SubjectBoardUserControl.SubjectBoardProjectDetailClickedEventHandler(CreateProjectEvent);
            return subjectBoard;
        }

        private void ShowProjectDetail(object sender, EventArgs e)
        {
            var target = (SubjectBoardUserControl) sender;
            var currentProject = target.CurrentProject;
            var projectDetail = new ProjectDetailForm(currentProject);
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
            var createProjectForm = new CreateProjectForm();
            var target = (SubjectBoardUserControl)sender;
            createProjectForm.Data = target.Data;
            createProjectForm.Show();
            IsClose = false;
            Close();
        }
    }
}
