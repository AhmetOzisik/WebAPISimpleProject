using ModelLayer.Entities;
using ModelLayer.ProductsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class ProductManager
    {
        IProductAPI productAPI;
        public ProductManager(IProductAPI productAPI)
        {
            this.productAPI = productAPI;
        }
        public async Task<List<Products>> GetAllProducts()
        {
            var model = await productAPI.GetAll("api/products");
            return model;
        }
        public async Task<Products> GetByIdProduct(int id)
        {
            var model = await productAPI.GetById("api/products", id);
            return model;
        }
        public async Task<string> DeleteProduct(int id)
        {
            await productAPI.Delete("/api/products",id);
            return null;
        }
        public async Task<string> AddProduct(Products product)
        {
            await productAPI.Add("api/products", product);
            return null;
        }
        public async Task<string> UpdateProduct(Products product, int id)
        {
            await productAPI.Update("api/products", id, product);
            return null;
        }
    }
}
