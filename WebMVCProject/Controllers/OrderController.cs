using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Entities;
using Newtonsoft.Json;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    public class OrderController : Controller
    {
        private OrderManager ordermanager = new OrderManager(new OrderRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model =await ordermanager.GetAllOrders();
            logManager.AddLogs(1, "Information", "MVC üzerinden order tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await ordermanager.GetByIdOrder(id);
            logManager.AddLogs(2, "Information", "MVC üzerinden id ye göre order verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await ordermanager.DeleteOrder(id);
            logManager.AddLogs(3, "Information", "MVC üzerinden order verisi silindi");
            return Json(true);
        }
        public IActionResult AddOrder()
        {
            return View();
        }
        public IActionResult UpdateOrder()
        {
            return View();
        }
        public async Task<JsonResult> Add(Orders order)
        {
            await ordermanager.AddOrder(order);
            logManager.AddLogs(4, "Information", "MVC üzerinden order verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Orders order,int id)
        {
            await ordermanager.UpdateOrder(order,order.Id);
            logManager.AddLogs(5, "Information", "MVC üzerinden order verisi güncellendi");
            return Json(true);
        }
    }
}
