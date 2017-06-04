using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
using HQT.Core.Model;

namespace HQT.Core.Service
{
    public class SubjectService:ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public Task<bool> CreateProjectAsync(BaseProject project, Subject subject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Subject>> GetListSubjectByUserAsync(Guid userId)
        {
            var listSubjects = await _subjectRepository.GetListSubjectByUserAsync(userId);
            return listSubjects;
        }

        public async Task<List<Subject>> GetListSubjectsAsync()
        {
            var listSubjects = await _subjectRepository.GetListSubjectsAsync();
            return listSubjects;
        }
    }
}
