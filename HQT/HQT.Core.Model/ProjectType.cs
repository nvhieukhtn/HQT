using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class ProjectType:BaseModel
    {
        public string ProjectTypeName { get; set; }

        public ProjectType(string projectTypeName , Guid id)
        {
            Id = id;
            ProjectTypeName = projectTypeName;
        }
    }
}
