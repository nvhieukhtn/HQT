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
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
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
                }

                return listAccounts;
            }
        }

        public async Task<User> GetAccountDetailAsync(Guid userId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetDetail"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(userId), userId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var id = result["UserId"].GetGuid();
                    var fullname = result["FullName"].GetString();
                    var username = result["UserName"].GetString();
                    var role = result["UserType"].GetString();
                    var email = result["Email"].GetString();
                    var phone = result["Phone"].GetString();
                    var address = result["Address"].GetString();
                    if (string.Equals(role, Role.Teacher, StringComparison.CurrentCultureIgnoreCase))
                        return new Teacher(id, username, fullname){Address = address, Email = email, Phone = phone};
                    if (string.Equals(role, Role.Administrator, StringComparison.CurrentCultureIgnoreCase))
                        return new Administrator(id, username, fullname) { Address = address, Email = email, Phone = phone };
                    return new Student(id, username, fullname) { Address = address, Email = email, Phone = phone };
                }
                return null;
            }
        }
        public async Task<List<Teacher>> GetListTeachersBySubjectAsync(Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetListBySubject"))
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

        public async Task<List<Student>> GetListStudentsBySubjectAsync(Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetListStudentsBySubject"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(subjectId), subjectId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listStudents = new List<Student>();
                while (result.Read())
                {
                    var id = result["UserId"].GetGuid();
                    var fullname = result["FullName"].GetString();
                    var username = result["UserName"].GetString();
                    var email = result["Email"].GetString();
                    var phone = result["Phone"].GetString();
                    var address = result["Address"].GetString();

                    var student = new Student()
                    {
                        Id = id,
                        FullName = fullname,
                        UserName = username,
                        Email = email,
                        Phone = phone,
                        Address = address
                    };
                    listStudents.Add(student);
                }
                return listStudents;
            }
        }

        public async Task<bool> UpdateAccountAsync(User user)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_Update"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {"UserId", user.Id},
                    {"Username", user.UserName },
                    {"Fullname", user.FullName }
                };
                if(user is Student)
                    listParams.Add("UserType", "Student");
                else if (user is Teacher)
                    listParams.Add("UserType", "Teacher");
                else listParams.Add("UserType", "Administrator");
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> CreateAccountAsync(User user)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_Add"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {"UserId", user.Id },
                    {"Username", user.UserName },
                    {"Fullname", user.FullName },
                    {"Password", user.Password },
                    {"Email", user.Email },
                    {"Address", user.Address },
                    {"Phone", user.Phone }
                };
                if (user is Student)
                    listParams.Add("UserType", "Student");
                else if (user is Teacher)
                    listParams.Add("UserType", "Teacher");
                else listParams.Add("UserType", "Administrator");
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<List<Teacher>> GetListTeachersAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetListTeachers"))
            {
                var listParams = new Dictionary<string, object>();
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

        public async Task<List<Student>> GetListStudentsAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_User_GetListStudents"))
            {
                var listParams = new Dictionary<string, object>();
                var result = await db.ExecuteReaderAsync(listParams);
                var listStudents = new List<Student>();
                while (result.Read())
                {
                    var id = result["UserId"].GetGuid();
                    var fullname = result["FullName"].GetString();
                    var username = result["UserName"].GetString();
                    var email = result["Email"].GetString();
                    var phone = result["Phone"].GetString();
                    var address = result["Address"].GetString();

                    var teacher = new Student()
                    {
                        Id = id,
                        FullName = fullname,
                        UserName = username,
                        Email = email,
                        Phone = phone,
                        Address = address
                    };
                    listStudents.Add(teacher);
                }
                return listStudents;
            }
        }
    }
}
