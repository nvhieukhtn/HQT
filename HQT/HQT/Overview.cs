using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class Overview : BaseForm
    {
        private readonly ISubjectService _subjectService;
        private readonly IProjectService _projectService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public Overview()
        {
            InitializeComponent();
            _subjectService = _container.Resolve<ISubjectService>();
            _projectService = _container.Resolve<IProjectService>();
        }

        private async void Overview_Load(object sender, EventArgs e)
        {
            var listSubjects = await _subjectService.GetListSubjectsAsync();
            overviewSubjectTabContentUserControl.ListSubject = listSubjects;
            var listProjects = await _projectService.GetListProjectsAsync();
            overviewAvailableProjectTabContentUserControl1.ListProjects = listProjects;
            overviewExpireProjectTabContentUserControl1.ListProjects = listProjects;
        }
    }
}
