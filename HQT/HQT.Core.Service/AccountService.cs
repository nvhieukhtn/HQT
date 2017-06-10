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
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<User> LoginAsync(string username, string password)
        {
            var result = await _accountRepository.LoginAsync(username, password);
            return result;
        }

        public async Task<User> GetUserDetailAsync(Guid userId)
        {
            var account = await _accountRepository.GetAccountDetailAsync(userId);
            return account;
        }

        public async Task<List<User>> GetListAccountAsync()
        {
            var result = await _accountRepository.GetListAccountAsync();
            return result;
        }

        public async Task<List<Teacher>> GetListTeacherBySubjectAsync(Guid subjectId)
        {
            var result = await _accountRepository.GetListTeachersBySubjectAsync(subjectId);
            return result;
        }

        public async Task<bool> CreateAccountAsync(User account)
        {
            var result = await _accountRepository.CreateAccountAsync(account);
            return result;
        }

        public Task<bool> DeleteAccountAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAccountAsync(User account)
        {
            var result = await _accountRepository.UpdateAccountAsync(account);
            return result;
        }

        public async Task<List<Teacher>> GetListTeachersAsync()
        {
            var listTeachers = await _accountRepository.GetListTeachersAsync();
            return listTeachers;
        }

        public async Task<List<Student>> GetListStudentsAsync()
        {
            var listStudents = await _accountRepository.GetListStudentsAsync();
            return listStudents;
        }
    }
}
