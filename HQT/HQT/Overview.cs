using System;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class Overview : BaseForm
    {
        private readonly ISubjectService _subjectService;
        private readonly IProjectService _projectService;
        private readonly ITopicService _topicService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public Overview()
        {
            InitializeComponent();
            _subjectService = _container.Resolve<ISubjectService>();
            _projectService = _container.Resolve<IProjectService>();
            _topicService = _container.Resolve<ITopicService>();
        }

        private async void Overview_Load(object sender, EventArgs e)
        {
            var listSubjects = await _subjectService.GetListSubjectsAsync();
            overviewSubjectTabContentUserControl.ListSubject = listSubjects;
            var listPractices = await _projectService.GetListPraceticeProjectAsync();
            overviewPracetice.ListProjects = listPractices;
            var listTopics = await _topicService.GetListTopicsAsync();
            overviewAvailableTopicTabContentUserControl1.ListTopics = listTopics;
        }
        
        private void Overview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsClose)
                LoginForm.Instance.Close();
        }
    }
}
