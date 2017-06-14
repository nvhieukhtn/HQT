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
            var user = await _accoutAccountRepository.GetAccountDetailAsync(userId);
            var listSubjects = await _subjectRepository.GetListSubjectByUserAsync(userId);
            foreach (var subject in listSubjects)
            {
                subject.ListTeachers = await _accoutAccountRepository.GetListTeachersBySubjectAsync(subject.Id);
                if(user is Student)
                    subject.ListProjects = await _projectRepository.GetListProjectCanRegisterAsync(subject.Id);
                else 
                    subject.ListProjects = await _projectRepository.GetListProjectBySubjectAsync(subject.Id);
            }
            return listSubjects;
        }

        public async Task<Tuple<int, List<Subject>>> GetListSubjectsAsync()
        {
            var listSubjects = await _subjectRepository.GetListSubjectsAsync();
            return listSubjects;
        }

        public async Task<bool> CreateSubjectAsync(Subject subject)
        {
            var result = await _subjectRepository.CreateSubjectAsync(subject);
            if (result)
            {
                foreach (var student in subject.ListStudents)
                {
                    result &= await _subjectRepository.AddUserIntoSubjectAsync(student.Id, subject.Id);
                }
                foreach (var teacher in subject.ListTeachers)
                {
                    result &= await _subjectRepository.AddUserIntoSubjectAsync(teacher.Id, subject.Id);
                }
            }
            return result;
        }

        public async Task<bool> LockSubjectAsync(Guid courseId)
        {
            var result = await _subjectRepository.LockSubjectAsync(courseId);
            return result;
        }
    }
}
