using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Service;
using HQT.Core.Model;

namespace HQT.Core.Service
{
    public class SubjectService:ISubjectService
    {
        public Task<bool> CreateProjectAsync(BaseProject project, Subject subject)
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetListSubjectAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
