using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Repository
{
    public interface IAccountRepository
    {
        Task<User> LoginAsync(string username, string password);
        Task<Tuple<int,List<User>>> GetListAccountAsync();
        Task<User> GetAccountDetailAsync(Guid userId);
        Task<List<Teacher>> GetListTeachersBySubjectAsync(Guid subjectId);
        Task<List<Student>> GetListStudentsBySubjectAsync(Guid subjectId);
        Task<bool> UpdateAccountAsync(User user);
        Task<bool> CreateAccountAsync(User user);
        Task<List<Teacher>> GetListTeachersAsync();
        Task<List<Student>> GetListStudentsAsync();
    }
}
