using ModelLayer.EmployessEntities;
using ModelLayer.SuppliersEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class SupplierManager
    {
        ISuppliersAPI suppliersAPI;
        public SupplierManager(ISuppliersAPI suppliersAPI)
        {
            this.suppliersAPI = suppliersAPI;
        }
        public async Task<List<Suppliers>> GetAllSupplier()
        {
            var model = await suppliersAPI.GetAll("api/suppliers");
            return model;
        }
        public async Task<Suppliers> GetByIdSupplier(int id)
        {
            var model = await suppliersAPI.GetById("api/suppliers", id);
            return model;
        }
        public async Task<string> DeleteSupplier(int id)
        {
            await suppliersAPI.Delete("api/suppliers", id);
            return null;
        }
        public async Task<string> AddSupplier(Suppliers supplier)
        {
            await suppliersAPI.Add("api/suppliers", supplier);
            return null;
        }
        public async Task<string> UpdateSupplier(Suppliers supplier, int id)
        {
            await suppliersAPI.Update("api/suppliers", id, supplier);
            return null;
        }
    }
}
