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
        Task<List<User>> GetListAccountAsync();
        Task<User> GetAccountDetailAsync(Guid userId);
    }
}
