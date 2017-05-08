using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Shared
{
    public class ApplicationSetting
    {
        public static string ConnectionString { get; set; }

        public static void Load(NameValueCollection collection)
        {
            ConnectionString = collection["ConnectionString"];
        }
    }
}
