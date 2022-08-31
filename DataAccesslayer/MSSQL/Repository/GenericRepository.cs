
using DataAccesslayer.MSSQL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.MSSQL.Repository
{
    public class GenericRepository<T,S, Y> : IGenericDal<T,S,Y>
    {
        SqlConnection db = new SqlConnection("Data Source=localhost;Initial Catalog=WebAPILoggerProject;Integrated Security=true");
        public void Insert(T t,S s,Y y)
        {
            db.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into logs (LogLevel,LogMessage) values('" + t + "','" + s + "','" + y + "')", db);
            sqlCommand.ExecuteNonQuery();
            db.Close();
        }
    }
}
