using DataAccesslayer.SqlLite.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.SqlLite.Repository
{
    public class GenericRepository< S, Y> :IGenericDal<S,Y>
    {
        SQLiteConnection sQLiteConnection = new SQLiteConnection("Data source=C:\\Users\\aozis\\source\\repos\\WebAPISimpleProject\\DataAccesslayer\\bin\\Debug\\LogDatabase.db;Integrated Security=True");
        public void Insert(S s, Y y)
        {
            SQLiteCommand sQLiteCommand = new SQLiteCommand("Insert Into Log(LogLevel,LogMessage) Values('" + s + "','" + y + "')", sQLiteConnection);
            sQLiteConnection.Open();
            sQLiteCommand.ExecuteNonQuery();
            sQLiteConnection.Close();
        }
    }
}
