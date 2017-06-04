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
        public ProjectForTeam()
        {
            UpperThreshold = -1;
        }
        public ProjectForTeam(string projectName, DateTime registerFrom, DateTime to, int upperThreshold,
            List<Topic> listTopics):base(projectName, registerFrom, to, listTopics)
        {
            UpperThreshold = upperThreshold;
        }
        public static ProjectForTeam Default => new ProjectForTeam();
    }
}
