﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Service
{
    public interface IProjectService
    {
        Task<List<BaseProject>> GetListProjectsAsync();
        Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid subjectId);
        Task<bool> CreateProjectAsync(BaseProject project, Guid subjectId);
        Task<BaseProject> GetProjectDetailAsync(Guid projectId);
        Task<List<BaseProject>> GetListProjectCanRegisterAsync(Guid courseId);
        Task<List<BaseProject>> GetListProjectCanNotRegisterAsync(Guid courseId);
        Task<List<ProjectType>> GetListProjectTypeAsync();
        Task<bool> SaveProjectInformationAsync(BaseProject project);
        Task<bool> RemoveTopicAsync(Guid topicId, Guid projectId);
        Task<List<BaseProject>> GetListPraceticeProjectAsync();
    }
}