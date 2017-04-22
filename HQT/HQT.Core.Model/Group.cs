using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Group:BaseModel
    {
        public string GroupName { get; set; }
        public List<Student> Members { get; set; }
        public int Leader { get; set; }
    }
}
