using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.MSSQL.Abstract
{
    public interface IGenericDal<T,S,Y> 
    {
        void Insert(T t,S s,Y y);
        //void Delete(T t);
        //void Update(T t);
        //List<T> GetListAll();
        //T GetById(int id);

    }
}
