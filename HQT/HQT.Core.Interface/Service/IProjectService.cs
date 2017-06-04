using System;
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
        Task<bool> DeleteProjectAsync(Guid projectId, Guid subjectId);
    }
}
