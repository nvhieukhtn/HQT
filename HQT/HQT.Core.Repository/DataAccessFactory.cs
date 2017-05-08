using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Data;
using HQT.Core.Repository.MSSQL;

namespace HQT.Core.Repository
{
    public class DataAccessFactory
    {
        public static IDataAccess CreateDataAccess(string storeProcedure)
        {
            return new SqlDataAccess(storeProcedure);
        }
    }
}
