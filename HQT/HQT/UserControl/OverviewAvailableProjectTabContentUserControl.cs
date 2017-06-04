using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class OverviewAvailableProjectTabContentUserControl : OverviewTabContentUserControl
    {
        public List<BaseProject> ListProjects { set; get; }

        public OverviewAvailableProjectTabContentUserControl()
        {
            InitializeComponent();
        }

        private void RenderListProject(List<BaseProject> listProjects)
        {
            listView.Items.Clear();
            txtNumber.Text = listProjects.Count.ToString();
            var index = 1;
            foreach (var project in listProjects)
            {
                var item = new ListViewItem(index.ToString());
                item.SubItems.Add(project.ProjectName);
                item.SubItems.Add(project.SubjectName);
                listView.Items.Add(item);
                index++;
            }
        }

        private void cbProjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var target = (ComboBox) sender;
            if (target == null || ListProjects == null) 
                return;
            
            if (target.SelectedItem.ToString().Equals("Cá nhân", StringComparison.CurrentCultureIgnoreCase))
            {
                var listProjects = ListProjects.Where(x => x is ProjectForSingle).ToList();
                RenderListProject(listProjects);
            }
            else
            {
                var listProjects = ListProjects.Where(x => x is ProjectForTeam).ToList();
                RenderListProject(listProjects);
            }
        }

        private void OverviewAvailableProjectTabContentUserControl_Load(object sender, EventArgs e)
        {
            cbProjectType.Items.AddRange(new object[]{"Nhóm" , "Cá nhân"});
            cbProjectType.SelectedItem = "Nhóm";
        }
    }
}
