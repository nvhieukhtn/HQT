using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Subject:BaseModel
    {
        public string SubjectName { get; set; }
        public List<Teacher> ListTeachers { get; set; }
        public int Status { get; set; }
        public List<BaseProject> ListProjects { get; set; }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }
    }
}
