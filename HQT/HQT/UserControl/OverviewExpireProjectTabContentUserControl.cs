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
    public partial class OverviewExpireProjectTabContentUserControl : OverviewTabContentUserControl
    {
        public List<BaseProject> ListProjects
        {
            set
            {
                txtNumber.Text = value.Count.ToString();
                var index = 1;
                foreach (var project in value)
                {
                    var item = new ListViewItem(index.ToString());
                    item.SubItems.Add(project.ProjectName);
                    item.SubItems.Add(project.SubjectName);
                    listView.Items.Add(item);
                    index++;
                }
            }
        }
        public OverviewExpireProjectTabContentUserControl()
        {
            InitializeComponent();
        }
    }
}
