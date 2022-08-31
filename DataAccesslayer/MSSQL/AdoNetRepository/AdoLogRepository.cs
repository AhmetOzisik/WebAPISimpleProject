using DataAccesslayer.MSSQL.Abstract;
using DataAccesslayer.MSSQL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.MSSQL.AdoNetRepository
{
    public class AdoLogRepository:GenericRepository<int,string,string>, ILogDal
    {
    }
}
