using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Service
{
    public interface IAccountService
    {
        Task<User> LoginAsync(string username, string password);
        Task<List<User>> GetListAccountAsync(Guid userId);
        Task<bool> CreateAccountAsync(User account);
        Task<bool> DeleteAccountAsync(Guid userId);
        Task<bool> UpdateAccountAsync(User account);
    }
}
