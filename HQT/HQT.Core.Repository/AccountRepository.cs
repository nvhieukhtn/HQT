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
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_Login"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(username), username},
                    {nameof(password), password}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var role = result["UserType"].GetString();
                    var usernameResult = result["UserName"].GetString();
                    var fullname = result["FullName"].GetString();
                    var id = result["UserId"].GetGuid();
                    if (string.Equals(role, Role.Teacher, StringComparison.CurrentCultureIgnoreCase))
                        return new Teacher(id, usernameResult, fullname);
                    if (string.Equals(role, Role.Administrator, StringComparison.CurrentCultureIgnoreCase))
                        return new Administrator(id, usernameResult, fullname);
                    return new Student(id, usernameResult, fullname);
                }
                return null;
            }
        }



        public async Task<List<User>> GetListAccountAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetAll"))
            {
                var listAccounts = new List<User>();
                var listParams = new Dictionary<string, object>();
                var result = await db.ExecuteReaderAsync(listParams);
                while (result.Read())
                {
                    var role = result["UserType"].GetString();
                    var usernameResult = result["UserName"].GetString();
                    var fullname = result["FullName"].GetString();
                    var id = result["UserId"].GetGuid();

                    if (string.Equals(role, Role.Teacher, StringComparison.CurrentCultureIgnoreCase))
                        listAccounts.Add(new Teacher(id, usernameResult, fullname)); 
                    else if (string.Equals(role, Role.Administrator, StringComparison.CurrentCultureIgnoreCase))
                        listAccounts.Add(new Administrator(id, usernameResult, fullname));
                    else
                        listAccounts.Add(new Student(id, usernameResult, fullname));
                }

                return listAccounts;
            }
        }

        public Task<User> GetAccountDetailAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Teacher>> GetListTeachersBySubjectAsync(Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Teacher_GetListBySubject"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(subjectId), subjectId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listTeachers = new List<Teacher>();
                while (result.Read())
                {
                    var id = result["UserId"].GetGuid();
                    var fullname = result["FullName"].GetString();
                    var username = result["UserName"].GetString();
                    var email = result["Email"].GetString();
                    var phone = result["Phone"].GetString();
                    var address = result["Address"].GetString();

                    var teacher = new Teacher()
                    {
                        Id = id,
                        FullName = fullname,
                        UserName = username,
                        Email = email,
                        Phone = phone,
                        Address = address
                    };
                    listTeachers.Add(teacher);
                }
                return listTeachers;
            }
        }
    }
}
