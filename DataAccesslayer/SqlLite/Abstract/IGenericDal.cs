using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.SqlLite.Abstract
{
    public interface IGenericDal<S, Y>
    {
        void Insert(S s, Y y);
        //void Delete(T t);
        //void Update(T t);
        //List<T> GetListAll();
        //T GetById(int id);

    }
}
