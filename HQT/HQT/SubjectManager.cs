using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class SubjectManager : BaseForm
    {
        public static SubjectManager Instance { get; private set; }
        public List<string> ListSubject { get; set; }
        private List<SubjectBoard> _listSubjectControls { get; set; }
        public SubjectManager()
        {
            InitializeComponent();
            Instance = this;
            ListSubject = new List<string>
            {
                "HQT",
                "Data mining",
                "Algorithms",
                "Tư tưởng",
                "Kỹ thuật lập trình"
            };
        }

        
        private void SubjectManager_Load(object sender, EventArgs e)
        {
            InitSubjects();
        }

        private void InitSubjects()
        {
            var index = 0;
            _listSubjectControls = new List<SubjectBoard>();
            var listTeacher = new List<string>
            {
                "Mr. Triết",
                "Mr. Quân"
            };
            var listProject = new List<string>
            {
                "HQT",
                "Data Mining",
                "Algorithms"
            };
            foreach (var subject in ListSubject)
            {
                var subjectBoard = new SubjectBoard
                {
                    SubjectName = subject,
                    ListTeacher = listTeacher,
                    ListProjects = listProject
                };
                subjectBoard.Location = new Point(10,55 + index * subjectBoard.Height);
                subjectBoard.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                index++;
                subjectBoard.SubjectBoardProjectDetailClicked += 
                    new SubjectBoard.SubjectBoardProjectDetailClickedEventHandler(ShowProjectDetail);
                _listSubjectControls.Add(subjectBoard);
                Controls.Add(subjectBoard);
            }
        }

        private void ShowProjectDetail(object sender, EventArgs e)
        {
            var projectDetail = new ProjectDetail();
            projectDetail.Show();
            _isClose = false;
            Close();
        }

        private void SubjectManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClose)
                Login.Instance.Close();
        }
    }
}
