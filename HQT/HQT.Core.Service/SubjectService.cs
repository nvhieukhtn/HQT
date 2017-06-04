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
        private readonly IAccountRepository _accoutAccountRepository;
        private readonly IProjectRepository _projectRepository;

        public SubjectService(ISubjectRepository subjectRepository, IAccountRepository accountRepository, IProjectRepository projectRepository)
        {
            _subjectRepository = subjectRepository;
            _accoutAccountRepository = accountRepository;
            _projectRepository = projectRepository;
        }

        public async Task<List<Subject>> GetListSubjectByUserAsync(Guid userId)
        {
            var listSubjects = await _subjectRepository.GetListSubjectByUserAsync(userId);
            foreach (var subject in listSubjects)
            {
                subject.ListTeachers = await _accoutAccountRepository.GetListTeachersBySubjectAsync(subject.Id);
                subject.ListProjects = await _projectRepository.GetListProjectBySubjectAsync(subject.Id);
            }
            return listSubjects;
        }

        public async Task<List<Subject>> GetListSubjectsAsync()
        {
            var listSubjects = await _subjectRepository.GetListSubjectsAsync();
            return listSubjects;
        }
    }
}
