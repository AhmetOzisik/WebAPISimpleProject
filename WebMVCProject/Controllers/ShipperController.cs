using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.ShippersEntities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    public class ShipperController : Controller
    {
        private ShipperManager shipperManager = new ShipperManager(new ShipperRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model = await shipperManager.GetAllShipper();
            logManager.AddLogs(21, "Information", "MVC üzerinden shipper tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await shipperManager.GetByIdShipper(id);
            logManager.AddLogs(22, "Information", "MVC üzerinden id ye göre shipper verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await shipperManager.DeleteShipperr(id);
            logManager.AddLogs(23, "Information", "MVC üzerinden shipper verisi silindi");
            return Json(true);
        }
        public IActionResult AddShipper()
        {
            return View();
        }
        public IActionResult UpdateShipper()
        {
            return View();
        }
        public async Task<JsonResult> Add(Shippers shipper)
        {
            await shipperManager.AddShipper(shipper);
            logManager.AddLogs(24, "Information", "MVC üzerinden shipper verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Shippers shipper, int id)
        {
            await shipperManager.UpdateShipper(shipper, id);
            logManager.AddLogs(25, "Information", "MVC üzerinden shipper verisi güncellendi");
            return Json(true);
        }
    }
}
