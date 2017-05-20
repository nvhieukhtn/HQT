using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class SubjectManagerForm : BaseForm
    {
        public static SubjectManagerForm Instance { get; private set; }
        public List<Subject> ListSubject { get; set; }
        private List<SubjectBoardUserControl> _listSubjectControls { get; set; }
        
        public SubjectManagerForm()
        {
            InitializeComponent();
            Instance = this;
            ListSubject = PrepareData();
        }

        
        private void SubjectManager_Load(object sender, EventArgs e)
        {
            InitSubjects();
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
        private void InitSubjects()
        {
            var index = 0;
            _listSubjectControls = new List<SubjectBoardUserControl>();
            
            foreach (var subject in ListSubject)
            {
                var subjectBoard = new SubjectBoardUserControl {Data = subject};
                subjectBoard.Location = new Point(10,55 + index * subjectBoard.Height);
                subjectBoard.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                index++;
                subjectBoard.SubjectBoardProjectDetailClicked += 
                    new SubjectBoardUserControl.SubjectBoardProjectDetailClickedEventHandler(ShowProjectDetail);
                subjectBoard.SubjectBoardCreateProject += new SubjectBoardUserControl.SubjectBoardProjectDetailClickedEventHandler(CreateProjectEvent);
                _listSubjectControls.Add(subjectBoard);
                Controls.Add(subjectBoard);
            }
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
