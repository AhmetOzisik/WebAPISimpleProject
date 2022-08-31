using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.CategoriesEntities;
using ModelLayer.EmployessEntities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model = await employeeManager.GetAllEmployee();
            logManager.AddLogs(16, "Information", "MVC üzerinden employee tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await employeeManager.GetByIdEmployee(id);
            logManager.AddLogs(17, "Information", "MVC üzerinden id ye göre employee verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await employeeManager.DeleteEmployee(id);
            logManager.AddLogs(18, "Information", "MVC üzerinden employee verisi silindi");
            return Json(true);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        public IActionResult UpdateEmployee()
        {
            return View();
        }
        public async Task<JsonResult> Add(Employess employee)
        {
            await employeeManager.AddEmployee(employee);
            logManager.AddLogs(19, "Information", "MVC üzerinden employee verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Employess employee, int id)
        {
            await employeeManager.UpdateEmployee(employee,id);
            logManager.AddLogs(20, "Information", "MVC üzerinden employee verisi güncellendi");
            return Json(true);
        }
    }
}
