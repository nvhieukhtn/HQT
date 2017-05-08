using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class ProjectForSingle:BaseProject
    {
        public ProjectForSingle()
        {
            
        }
        public ProjectForSingle(string projectName, DateTime from, DateTime to,List<Topic> listTopics)
            :base(projectName, from, to, listTopics)
        {
            
        }

        public static ProjectForSingle Default => new ProjectForSingle();
        public static ProjectForSingle Test()
        {
            var listTopics = new List<Topic>
            {
                Topic.Test,
                Topic.Test,
                Topic.Test
            };
            var project = new ProjectForSingle("Project Test", DateTime.Now.AddDays(1), DateTime.Now.AddDays(5), listTopics);
            return project;
        }
    }
}
