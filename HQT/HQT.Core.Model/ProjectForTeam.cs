using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class ProjectForTeam:BaseProject
    {
        public int UpperThreshold { get; set; }
        public int LowerThreshold { get; set; }
        public ProjectForTeam()
        {
            UpperThreshold = -1;
            LowerThreshold = -1;
        }
        public ProjectForTeam(string projectName, DateTime from, DateTime to, int upperThreshold, int lowerThreshold,
            List<Topic> listTopics):base(projectName, from, to, listTopics)
        {
            UpperThreshold = upperThreshold;
            LowerThreshold = lowerThreshold;
        }
        public static ProjectForTeam Default => new ProjectForTeam();
        public static ProjectForTeam Test()
        {
            var listTopics = new List<Topic>
            {
                Topic.Test,
                Topic.Test,
                Topic.Test
            };
            var project = new ProjectForTeam("Project Test", DateTime.Now, DateTime.Now.AddDays(5),1,5, listTopics);
            return project;
        }
    }
}
