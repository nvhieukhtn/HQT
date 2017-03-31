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
    public partial class SubjectManager : Form
    {
        public List<string> ListSubject { get; set; }
        public SubjectManager()
        {
            InitializeComponent();
            ListSubject = new List<string>
            {
                "HQT",
                "Data mining",
                "Algorithms",
                "Tư tưởng",
                "Kỹ thuật lập trình"
            };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectManager_Load(object sender, EventArgs e)
        {
            var listTeacher = new List<string>
            {
                "Mr. Triết",
                "Mr. Quân"
            };
            var index = 0;
            foreach (var subject in ListSubject)
            {
                var subjectBoard = new SubjectBoard
                {
                    SubjectName = subject,
                    ListTeacher = listTeacher,
                    NumberOfProject = 0
                };
                subjectBoard.Location = new Point(2, 30 + index * subjectBoard.Height);
                index++;
                Controls.Add(subjectBoard);
            }
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
