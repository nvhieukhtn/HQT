﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Repository
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetListTopicsAsync();
    }
}
