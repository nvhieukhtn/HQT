﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public abstract class User:BaseModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
