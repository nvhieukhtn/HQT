using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Group:BaseModel
    {
        public int Capacity { get; set; }
        public Guid ProjectId { get; set; }
        public Guid TopicId { get; set; }
        public string GroupName { get; set; }
        public List<Student> Members { get; set; }
        public Student Leader { get; set; }
    }
}
