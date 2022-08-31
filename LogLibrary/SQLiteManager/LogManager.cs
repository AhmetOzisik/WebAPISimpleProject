using DataAccesslayer.SqlLite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibrary.SQLiteManager
{
    public class LogManager
    {
        ILogDal logDal;
        public LogManager(ILogDal logDal)
        {
            this.logDal = logDal;
        }
        public void AddLogs(string loglevel, string logmessage)
        {
            logDal.Insert(loglevel, logmessage);
        }
    }
}
