using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Entities;
using ModelLayer.ProductsEntities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager productManager = new ProductManager(new ProductsRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model = await productManager.GetAllProducts();
            logManager.AddLogs(6, "Information", "MVC üzerinden product tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await productManager.GetByIdProduct(id);
            logManager.AddLogs(7, "Information", "MVC üzerinden id ye göre product verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await productManager.DeleteProduct(id);
            logManager.AddLogs(8, "Information", "MVC üzerinden product verisi silindi");
            return Json(true);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult UpdateProduct()
        {
            return View();
        }
        public async Task<JsonResult> Add(Products product)
        {
            await productManager.AddProduct(product);
            logManager.AddLogs(9, "Information", "MVC üzerinden product verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Products product, int id)
        {
            await productManager.UpdateProduct(product, product.Id);
            logManager.AddLogs(10, "Information", "MVC üzerinden product verisi güncellendi");
            return Json(true);
        }
    }
}
