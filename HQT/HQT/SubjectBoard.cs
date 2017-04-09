using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class SubjectBoard : UserControl
    {
        public string SubjectName
        {
            get { return txtSubjectName.Text; }
            set { txtSubjectName.Text = value; }
        }

        public List<string> ListTeacher
        {
            get { return cbColleage.Items.Cast<string>().ToList(); }
            set { cbColleage.DataSource = value; }
        }

        private List<string> _listProjects;
        public List<string> ListProjects {
            get { return _listProjects; }
            set
            {
                _listProjects = value;
                UpdateProjects();
            }
        }

        private void UpdateProjects()
        {
            var height = Math.Max(90, 45 * ListProjects.Count);
            Height = height;
            if(grbSubject != null)
                grbSubject.Height = height;
            if (grbProjects != null)
                grbProjects.Height = height - 12;

            var index = 0;
            ListProjects.ForEach(x =>
            {
                var projectName = new Label
                {
                    Text = x,
                    Location = new Point(10 , 19 + 35 * index),
                    Cursor =  Cursors.Hand
                };
                index++;
                if (grbProjects != null)
                {
                    grbProjects.Controls.Add(projectName);
                }
            });
        }
        public SubjectBoard()
        {
            ListProjects = new List<string>();
            InitializeComponent();
        }
    }
}
