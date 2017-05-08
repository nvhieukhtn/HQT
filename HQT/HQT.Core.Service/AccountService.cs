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

        public async Task<List<User>> GetListAccountAsync(Guid userId)
        {
            var result = await _accountRepository.GetListAccountAsync(userId);
            return result;
        }
    }
}
