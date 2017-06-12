using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Service
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetListSubjectByUserAsync(Guid userId);
        Task<Tuple<int, List<Subject>>> GetListSubjectsAsync();
        Task<bool> CreateSubjectAsync(Subject subject);
    }
}
