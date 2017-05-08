using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class UserFactory
    {
        public static User CreateUser(string username, string fullname, string role)
        {
            switch (role)
            {
                case Role.Teacher:
                    return new Teacher(username, fullname);
                case Role.Administrator:
                    return new Administrator(username, fullname);
                default:
                    return new Student(username, fullname);
            }
        }
    }
}
