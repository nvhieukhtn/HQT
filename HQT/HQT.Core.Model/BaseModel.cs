using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public abstract class BaseModel
    {
        public Guid Id;

        public BaseModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
