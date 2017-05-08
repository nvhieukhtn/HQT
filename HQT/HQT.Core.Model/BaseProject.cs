using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public abstract class BaseProject:BaseModel
    {
        public string ProjectName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public List<Topic> ListTopics { get; set; }
        public int Limit { get; set; }
        protected BaseProject()
        {
            ProjectName = string.Empty;
            From = DateTime.Now;
            To = DateTime.Now;
            ListTopics = new List<Topic>();
        }

        protected BaseProject(string projectName, DateTime from, DateTime to, List<Topic> listTopics)
        {
            ProjectName = projectName;
            From = from;
            To = to;
            ListTopics = listTopics;
        }
    }
}
