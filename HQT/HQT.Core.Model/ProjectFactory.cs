using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class ProjectFactory
    {
        public static BaseProject CreateProject(Guid id, string projectName, 
            DateTime registerFrom, DateTime registerTo, int limit, 
            DateTime deadline, ProjectTypes type , string subjectName,
            int upperThreshold, string projectType)
        {
            switch (type)
            {
                case ProjectTypes.Team:
                    return new ProjectForTeam()
                    {
                        Id = id,
                        ProjectName = projectName,
                        RegisterFrom = registerFrom,
                        RegisterTo = registerTo,
                        Deadline = deadline,
                        Limit = limit,
                        SubjectName = subjectName,
                        UpperThreshold = upperThreshold,
                        ProjectType =  projectType
                    };
                case ProjectTypes.Person:
                    return new ProjectForSingle()
                    {
                        Id = id,
                        ProjectName = projectName,
                        RegisterFrom = registerFrom,
                        RegisterTo = registerTo,
                        Deadline = deadline,
                        Limit = limit,
                        SubjectName = subjectName,
                        ProjectType =  projectType
                    };
                default:
                    return null;
            }
        }
    }
}
