using ModelLayer.ShippersEntities;
using ModelLayer.SuppliersEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class ShipperManager
    {
        IShippersAPI shippersAPI;
        public ShipperManager(IShippersAPI shippersAPI)
        {
            this.shippersAPI = shippersAPI;
        }
        public async Task<List<Shippers>> GetAllShipper()
        {
            var model = await shippersAPI.GetAll("api/shippers");
            return model;
        }
        public async Task<Shippers> GetByIdShipper(int id)
        {
            var model = await shippersAPI.GetById("api/shippers", id);
            return model;
        }
        public async Task<string> DeleteShipperr(int id)
        {
            await shippersAPI.Delete("api/shippers", id);
            return null;
        }
        public async Task<string> AddShipper(Shippers shipper)
        {
            await shippersAPI.Add("api/shippers", shipper);
            return null;
        }
        public async Task<string> UpdateShipper(Shippers shipper, int id)
        {
            await shippersAPI.Update("api/shippers", id, shipper);
            return null;
        }
    }
}
