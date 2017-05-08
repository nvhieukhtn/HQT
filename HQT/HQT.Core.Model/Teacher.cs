using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Teacher:User
    {
        public Teacher()
        {
            FullName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
        }

        public Teacher(string username, string fullname)
        {
            UserName = username;
            FullName = fullname;
        }

        public static Teacher Default => new Teacher();
        public static Teacher Test => new Teacher("hieu.nguyen","Hiếu Nguyễn");
    }
}
