using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Repository
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetAllSubjectAsync();
        Task<List<Subject>> GetListSubjectByUserAsync(Guid userId);
        Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid sujbectId);
        Task<List<BaseProject>> GetAllProjectAsync();
        Task<BaseProject> GetProjectDetailAsync(Guid projectId);
    }
}
