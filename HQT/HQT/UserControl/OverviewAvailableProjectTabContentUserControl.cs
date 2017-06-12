using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class OverviewAvailableProjectTabContentUserControl : OverviewTabContentUserControl
    {
        public Tuple<int, List<BaseProject>> ListProjects
        {
            set => RenderListProject(value);
        }

        public OverviewAvailableProjectTabContentUserControl()
        {
            InitializeComponent();
        }

        private void RenderListProject(Tuple<int, List<BaseProject>> listProjects)
        {
            listView.Items.Clear();
            txtNumber.Text = listProjects.Item1.ToString();
            var index = 1;
            foreach (var project in listProjects.Item2)
            {
                var item = new ListViewItem(index.ToString());
                item.SubItems.Add(project.ProjectName);
                item.SubItems.Add(project.SubjectName);
                listView.Items.Add(item);
                index++;
            }
        }
    }
}
