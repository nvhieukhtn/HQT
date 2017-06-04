using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
using HQT.Core.Repository;
using HQT.Core.Service;
using Microsoft.Practices.Unity;

namespace HQT
{
    public class DependencyResolution
    {
        private static IUnityContainer _container;

        public static void Start()
        {
            _container = new UnityContainer();
            RegisterType(_container);
        }

        private static void RegisterType(IUnityContainer container)
        {
            container.RegisterType<IAccountRepository, AccountRepository>();
            container.RegisterType<ISubjectRepository, SubjectRepository>();
            container.RegisterType<ITopicRepository, TopicRepository>();
            container.RegisterType<IProjectRepository, ProjectRepository>();
            
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<ISubjectService, SubjectService>();
            container.RegisterType<IProjectService, ProjectService>();
            container.RegisterType<ITopicService, TopicService>();
        }

        public static IUnityContainer Container => _container;
    }
}
