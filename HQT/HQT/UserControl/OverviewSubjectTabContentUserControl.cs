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
        public Tuple<int, List<Subject>> ListSubject
        {
            set
            {
                txtNumber.Text = value.Item1.ToString();
                var index = 1;
                foreach (var subject in value.Item2)
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
