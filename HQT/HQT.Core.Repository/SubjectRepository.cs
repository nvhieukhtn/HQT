using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Model;

namespace HQT.Core.Repository
{
    public class SubjectRepository:ISubjectRepository
    {
        public Task<List<Subject>> GetAllSubjectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetListSubjectByUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid sujbectId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BaseProject>> GetAllProjectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseProject> GetProjectDetailAsync(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
