using DataAccesslayer.MSSQL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibrary.AdoNetManager
{
    public class LogManager
    {
        ILogDal logDal;
        public LogManager(ILogDal logDal)
        {
                this.logDal = logDal;
        }
        public void AddLogs(int id,string loglevel,string logmessage)
        {
            logDal.Insert(id,loglevel,logmessage);
        }
    }
}
