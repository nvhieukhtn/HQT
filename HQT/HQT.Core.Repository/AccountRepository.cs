using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT.Core.Repository
{
    public class AccountRepository:IAccountRepository
    {
        public async Task<User> LoginAsync(string username, string password)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Account_Login"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(username), username},
                    {nameof(password), password}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var role = result["Role"].GetString();
                    var usernameResult = result["UserName"].GetString();
                    //var passwordResult = result["Password"].GetString();
#if DEBUG
                    return Student.Test;
#endif
                    if (string.Equals(role, Role.Teacher, StringComparison.CurrentCultureIgnoreCase))
                        return Teacher.Default;
                    if (string.Equals(role, Role.Administrator, StringComparison.CurrentCultureIgnoreCase))
                        return Administrator.Default;
                    return Student.Default;
                }
#if DEBUG
                return Student.Test;
#endif
                return Student.Default;
            }
        }

        public async Task<List<User>> GetListAccountAsync(Guid userId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Account_Login"))
            {
                var listAccounts = new List<User>();
                var listParams = new Dictionary<string, object>
                {
#if DEBUG
                    {"username", ""},
                    {"password", ""},
#else
                    {nameof(userId), userId}
#endif
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var role = result["Role"].GetString();
                    var usernameResult = result["UserName"].GetString();
                    //var passwordResult = result["Password"].GetString();

                    if (string.Equals(role, Role.Teacher, StringComparison.CurrentCultureIgnoreCase))
                        listAccounts.Add(new Teacher()); 
                    if (string.Equals(role, Role.Administrator, StringComparison.CurrentCultureIgnoreCase))
                        listAccounts.Add(new Administrator());
                    listAccounts.Add(new Student());

                }

#if DEBUG
                listAccounts.Add (Student.Test);
                listAccounts.Add(Administrator.Test);
                listAccounts.Add(Teacher.Test);
#endif
                return listAccounts;
            }
        }
    }
}
