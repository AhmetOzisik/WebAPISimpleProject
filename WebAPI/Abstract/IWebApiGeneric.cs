using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Abstract
{
    public interface IWebApiGeneric<T> where T : class
    {
        public Task<List<T>> GetAll(string urlParameters);

        public Task<T> GetById(string urlParameters, int id);
        public Task<string> Delete(string urlParameters, int id);
        public Task<string> Update(string urlParameters,int id,T t);
        public Task<string> Add(string urlParameters,T t);   

    }
}
