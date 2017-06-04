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
            DateTime deadline, ProjectTypes projectType , string subjectName,
            int upperThreshold)
        {
            switch (projectType)
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
                        UpperThreshold = upperThreshold
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
                        SubjectName = subjectName
                    };
                default:
                    return null;
            }
        }
    }
}
