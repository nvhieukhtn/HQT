using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class SubjectBoardUserControl : UserControl
    {
        private readonly IProjectService _projectService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public delegate void SubjectBoardProjectDetailClickedEventHandler(object sender, EventArgs e);

        public BaseProject CurrentProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardProjectDetailClicked;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardCreateProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardDeleteProject;
        private void SubjectBoardProjectDetail_OnClick(object sender, EventArgs e)
        {
            if (SubjectBoardProjectDetailClicked != null)
            {
                var target = (ProjectItemUserControl) sender;
                CurrentProject = target.Data;
                SubjectBoardProjectDetailClicked(this, e);
            }
        }

        private Subject _data;

        public Subject Data
        {
            get => _data;
            set
            {
                _data = value;
                txtSubjectName.Text = _data.SubjectName;
                var firstTeacher = _data.ListTeachers.FirstOrDefault();
                if (firstTeacher != null)
                    txtTeacher.Text = firstTeacher.FullName;
                UpdateProjects();
            }
        }

        private void UpdateProjects()
        {
            grbProjects.Controls.Clear();
            var height = Math.Max(90, 45 * _data.ListProjects.Count);
            Height = height;
            if(grbSubject != null)
                grbSubject.Height = height;
            if (grbProjects != null)
                grbProjects.Height = height - 12;

            var index = 0;
            _data.ListProjects.ForEach(x =>
            {
                var project = new ProjectItemUserControl()
                {
                    Name = $"{index}",
                    Data = x,
                    Location = new Point(10, 19 + 35 * index)
                };
                project.ProjectItemClicked += SubjectBoardProjectDetail_OnClick;
                project.ProjectDeleteEvent += DeleteProject_Click;
                index++;
                grbProjects?.Controls.Add(project);
            });
        }
        public SubjectBoardUserControl()
        {
            InitializeComponent();
            _projectService = _container.Resolve<IProjectService>();
            CurrentProject = null;
        }

        private void btnTeacherMore_Click(object sender, EventArgs e)
        {
            if (Data.ListTeachers.Any())
            {
                var content = $"Danh sách giáo viên : \n" +
                              $"    - Giảng viên chính : {Data.ListTeachers.FirstOrDefault().FullName}\n";
                if (Data.ListTeachers.Count >= 2)
                {
                    for (var i = 2; i < Data.ListTeachers.Count; i++)
                        content += $"    - Giảng viên phụ {i - 1} : {Data.ListTeachers[i].FullName}\n";
                }
                MessageBox.Show(content, "Giáo viên");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (SubjectBoardCreateProject != null)
            {
                SubjectBoardCreateProject(this, e);
            }
        }

        private async void DeleteProject_Click(object sender, EventArgs e)
        {
            var target = (ProjectItemUserControl) sender;
            var projectId = target.Data.Id;
            var result = await _projectService.DeleteProjectAsync(projectId, Data.Id);
            if (result)
                Data.ListProjects.RemoveAll(x => x.Id == projectId);
        }
    }
}
