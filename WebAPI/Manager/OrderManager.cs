using ModelLayer.CategoriesEntities;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class OrderManager
    {
        IOrderAPI orderAPI;
        public OrderManager(IOrderAPI orderAPI)
        {
            this.orderAPI = orderAPI;   
        }
        public async Task<List<Orders>> GetAllOrders()
        {
            var model = await orderAPI.GetAll("api/orders");
            return model;
        }
        public async Task<Orders> GetByIdOrder(int id)
        {
            var model = await orderAPI.GetById("api/orders",id);
            return model;
        }
        public async Task<string> DeleteOrder(int id)
        {
            await orderAPI.Delete("api/orders", id);
            return null;
        }
        public async Task<string> AddOrder(Orders order)
        {
            await orderAPI.Add("api/orders", order);
            return null;
        }
        public async Task<string> UpdateOrder(Orders order,int id)
        {
            await orderAPI.Update("api/orders", id, order);
            return null;
        }
    }
}
