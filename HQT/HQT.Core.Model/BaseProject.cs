using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public abstract class BaseProject:BaseModel
    {
        public string ProjectName { get; set; }
        public DateTime RegisterFrom { get; set; }
        public DateTime RegisterTo { get; set; }
        public DateTime Deadline { get; set; }
        public string SubjectName { get; set; }

        public List<Topic> ListTopics { get; set; }
        public int Limit { get; set; }
        public string ProjectType { get; set; }
        public bool IsRegister { get; set; }
        protected BaseProject()
        {
            ProjectName = string.Empty;
            RegisterFrom = DateTime.MinValue;
            RegisterTo = DateTime.MinValue;
            Deadline = DateTime.MinValue;
            ListTopics = new List<Topic>();
        }

        protected BaseProject(string projectName, string projectType,
            DateTime registerFrom, DateTime to, List<Topic> listTopics)
        {
            ProjectName = projectName;
            RegisterFrom = registerFrom;
            RegisterTo = to;
            ListTopics = listTopics;
            ProjectType = projectType;
        }
    }
}
