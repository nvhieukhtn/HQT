using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public List<Teacher> ListTeachers { get; set; }
        public List<BaseProject> ListProjects { get; set; }

        public static Subject Test()
        {
            var listTeachers = new List<Teacher>
            {
                Teacher.Test, 
                Teacher.Test,
                Teacher.Test
            };

            var listProjects = new List<BaseProject>
            {
                ProjectForSingle.Test(),
                ProjectForTeam.Test(),
                ProjectForSingle.Test(),
                ProjectForTeam.Test()
            };

            var subject = new Subject
            {
                SubjectName = "Subject name",
                ListTeachers = listTeachers,
                ListProjects = listProjects
            };
            return subject;
        }
    }
}
