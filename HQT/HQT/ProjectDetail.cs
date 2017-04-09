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
    public partial class ProjectDetail : Form
    {
        public List<string> ListPractices;
        public ProjectDetail()
        {
            ListPractices = new List<string>
            {
                "Đây là đề bài demo",
                "Đây là đề bài demo",
                "Đây là đề bài demo",
                "Đây là đề bài demo"
            };
            InitializeComponent();
            UpdateSubjects();
        }
        private void UpdateSubjects()
        {
            var index = 0;
            foreach (var practice in ListPractices)
            {
                var practiceBoard = new Practice()
                {
                    Title = practice
                };
                practiceBoard.Location = new Point(2, 30 + index * practiceBoard.Height);
                index++;
                practiceBoard.Click += (render, e) =>
                {
                    MessageBox.Show("Hello world", "Test", MessageBoxButtons.OK);
                };
                Controls.Add(practiceBoard);
            }
        }

    }
}
