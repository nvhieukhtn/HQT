using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT
{
    public partial class SubjectBoardUserControl : UserControl
    {
        public delegate void SubjectBoardProjectDetailClickedEventHandler(object sender, EventArgs e);

        public BaseProject CurrentProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardProjectDetailClicked;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardCreateProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectRenewProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectLock;
        private void SubjectBoardProjectDetail_OnClick(object sender, EventArgs e)
        {
            if (SubjectBoardProjectDetailClicked != null)
            {
                var target = (ProjectItemUserControl) sender;
                CurrentProject = target.Data;
                SubjectBoardProjectDetailClicked(this, e);
            }
        }

        private void SubjectBoardRenewProject(object sender, EventArgs e)
        {
            if (SubjectRenewProject != null)
            {
                var target = (ProjectItemUserControl)sender;
                CurrentProject = target.Data;
                SubjectRenewProject(this, e);
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
            var height = Math.Max(90, 50 * _data.ListProjects.Count);
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
                project.RenewProjectItemClicked += SubjectBoardRenewProject;
                index++;
                grbProjects?.Controls.Add(project);
            });
        }
        public SubjectBoardUserControl()
        {
            InitializeComponent();
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
                    for (var i = 1; i < Data.ListTeachers.Count; i++)
                        content += $"    - Giảng viên phụ {i} : {Data.ListTeachers[i].FullName}\n";
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

        private void SubjectBoardUserControl_Load(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Student)
            {
                btnAddProject.Visible = false;
                btnLock.Visible = false;
            }
            else
            {
                btnAddProject.Visible = true;
                btnLock.Visible = true;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (SubjectLock != null)
            {
                SubjectLock(this, e);
            }
        }
    }
}
