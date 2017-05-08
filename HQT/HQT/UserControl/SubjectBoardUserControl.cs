using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class SubjectBoardUserControl : UserControl
    {
        public delegate void SubjectBoardProjectDetailClickedEventHandler(object sender, EventArgs e);

        public BaseProject CurrentProject;
        public event SubjectBoardProjectDetailClickedEventHandler SubjectBoardProjectDetailClicked;
        private void SubjectBoardProjectDetail_OnClick(object sender, EventArgs e)
        {
            if (SubjectBoardProjectDetailClicked != null)
            {
                var obj = (ProjectItemUserControl) sender;
                CurrentProject = obj.Data;
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
                project.ProjectItemClicked += new ProjectItemUserControl.ProjectItemClickedEventHandler(SubjectBoardProjectDetail_OnClick);
                index++;
                if (grbProjects != null)
                {
                    grbProjects.Controls.Add(project);
                }
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
                    for (var i = 2; i < Data.ListTeachers.Count; i++)
                        content += $"    - Giảng viên phụ {i - 1} : {Data.ListTeachers[i].FullName}\n";
                }
                MessageBox.Show(content, "Giáo viên");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {

        }
    }
}
