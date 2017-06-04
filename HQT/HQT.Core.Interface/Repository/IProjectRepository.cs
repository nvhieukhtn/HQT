﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Repository
{
    public interface IProjectRepository
    {
        Task<List<BaseProject>> GetListProjectsAsync();
        Task<BaseProject> GetProjectDetailAsync(Guid projectId);
        Task<List<BaseProject>> GetListProjectBySubject(Guid subjectId);
    }
}
