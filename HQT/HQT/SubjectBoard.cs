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

        public int NumberOfProject
        {
            get
            {
                var count = 0;
                Int32.TryParse(txtProjectCount.Text, out count);
                return count;
            }
            set
            {
                if (value >= 0)
                {
                    var text = $"{value}";
                
                    txtProjectCount.Text = text;
                }
            }
        }

        public SubjectBoard()
        {
            InitializeComponent();
        }
    }
}
