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
    public partial class SubjectFilterUserControl : UserControl
    {
        public delegate void SubjectFilterClickedEventHandler(object sender, EventArgs e);

        public event SubjectFilterClickedEventHandler AddSubjectClicked;
        public event SubjectFilterClickedEventHandler FilterSubjectStatus;

        public string FilterValue => comboBox1.SelectedItem.ToString();

        public SubjectFilterUserControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddSubjectClicked != null)
                AddSubjectClicked(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterSubjectStatus != null)
                FilterSubjectStatus(this, e);
        }
    }
}
