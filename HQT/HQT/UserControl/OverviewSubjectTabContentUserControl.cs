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
    public partial class OverviewSubjectTabContentUserControl : OverviewTabContentUserControl
    {
        public List<Subject> ListSubject
        {
            set
            {
                txtNumber.Text = value.Count.ToString();
                var index = 1;
                foreach (var subject in value)
                {
                    var item = new ListViewItem(index.ToString());
                    item.SubItems.Add(subject.SubjectName);
                    listView.Items.Add(item);
                    index++;
                }
            }
        }
        public OverviewSubjectTabContentUserControl()
        {
            InitializeComponent();
        }
    }
}
