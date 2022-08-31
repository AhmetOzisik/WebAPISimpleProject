using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.EmployessEntities;
using ModelLayer.SuppliersEntities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    
    public class SupplierController : Controller
    {
        private SupplierManager supplierManager = new SupplierManager(new SupplierRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model = await supplierManager.GetAllSupplier();
            logManager.AddLogs(26, "Information", "MVC üzerinden supplier tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await supplierManager.GetByIdSupplier(id);
            logManager.AddLogs(27, "Information", "MVC üzerinden id ye göre supplier verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await supplierManager.DeleteSupplier(id);
            logManager.AddLogs(28, "Information", "MVC üzerinden supplier verisi silindi");
            return Json(true);
        }
        public IActionResult AddSupplier()
        {
            return View();
        }
        public IActionResult UpdateSupplier()
        {
            return View();
        }
        public async Task<JsonResult> Add(Suppliers supplier)
        {
            await supplierManager.AddSupplier(supplier);
            logManager.AddLogs(29, "Information", "MVC üzerinden supplier verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Suppliers supplier, int id)
        {
            await supplierManager.UpdateSupplier(supplier, id);
            logManager.AddLogs(30, "Information", "MVC üzerinden supplier verisi güncellendi");
            return Json(true);
        }
    }
}
