using DataAccesslayer.SqlLite.Abstract;
using DataAccesslayer.SqlLite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.SqlLite.SQLiteRepository
{
    public class SQLiteLogRepository : GenericRepository<string, string>, ILogDal
    {
    }
}
