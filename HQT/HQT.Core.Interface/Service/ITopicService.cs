﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Service
{
    public interface ITopicService
    {
        Task<List<Topic>> GetListTopicsAsync();
    }
}
