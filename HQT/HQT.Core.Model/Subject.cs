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
        public List<Student> ListStudents { get; set; }

        public List<BaseProject> ListProjects { get; set; }
    }
}
