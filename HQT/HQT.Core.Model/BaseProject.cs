using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public abstract class BaseProject:BaseModel
    {
        public DateTime Deadline { get; set; }
        public int Capacity { get; set; }
        public List<Topic> ListPractices { get; set; }
    }
}
