using ModelLayer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.GenericRepository
{
    public class GenericRepository<T> : IWebApiGeneric<T> where T : class
    {
        public async Task<string> Add(string urlParameters, T t)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            var serializeobject = JsonConvert.SerializeObject(t);
            StringContent stringContent = new StringContent(serializeobject, Encoding.UTF8, "application/json");
            await client.PostAsync(urlParameters, stringContent);
            return null;
        }

        public async Task<string> Delete(string urlParameters,int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            await client.DeleteAsync(urlParameters + "/" + id);
            return null;
        }

        public async Task<List<T>> GetAll(string urlParameters)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response =await client.GetAsync(urlParameters);
            string result =await  response.Content.ReadAsStringAsync();
            List<T>? resultcontent = JsonConvert.DeserializeObject<List<T>>(result);
            return resultcontent;
        }

        public async Task<T> GetById(string urlParameters,int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            HttpResponseMessage response = await client.GetAsync(urlParameters +"/"+ id);
            string result = await response.Content.ReadAsStringAsync();
            T? resultcontent = JsonConvert.DeserializeObject<T>(result);
            return resultcontent;
        }

        public async Task<string> Update(string urlParameters, int id, T t)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.now.sh/");
            var serializeobject=JsonConvert.SerializeObject(t);
            StringContent stringContent = new StringContent(serializeobject,Encoding.UTF8,"application/json");
            await client.PutAsync(urlParameters +"/"+id, stringContent);
            return null;
        }
    }
}
