using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Administrator:User
    {
        public Administrator()
        {
            UserName = string.Empty;
            Password = string.Empty;
            FullName = string.Empty;
        }

        public Administrator(string username, string fullname)
        {
            UserName = username;
            FullName = fullname;
        }

        public Administrator(Guid id, string username, string fullname)
        {
            Id = id;
            UserName = username;
            FullName = fullname;
        }

        public static Administrator Default => new Administrator();
    }
}
