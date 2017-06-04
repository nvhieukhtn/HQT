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
        public ProjectForSingle(string projectName, DateTime registerFrom, DateTime to,List<Topic> listTopics)
            :base(projectName, registerFrom, to, listTopics)
        {
            
        }

        public static ProjectForSingle Default => new ProjectForSingle();
    }
}
