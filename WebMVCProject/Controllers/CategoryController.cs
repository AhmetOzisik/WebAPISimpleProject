using DataAccesslayer.MSSQL.AdoNetRepository;
using LogLibrary.AdoNetManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.CategoriesEntities;
using ModelLayer.ProductsEntities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WebMVCProject.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager(new CategoryRepository());
        private LogManager logManager = new LogManager(new AdoLogRepository());
        public async Task<IActionResult> Index()
        {
            var model = await categoryManager.GetAllCategory();
            logManager.AddLogs(11, "Information", "MVC üzerinden category tüm verileri çekildi");
            return View(model);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var model = await categoryManager.GetByIdCategory(id);
            logManager.AddLogs(12, "Information", "MVC üzerinden id ye göre category verisi çekildi");
            return View(model);
        }
        public async Task<JsonResult> Delete(int id)
        {
            await categoryManager.DeleteCategory(id);
            logManager.AddLogs(13, "Information", "MVC üzerinden category verisi silindi");
            return Json(true);
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        public IActionResult UpdateCategory()
        {
            return View();
        }
        public async Task<JsonResult> Add(Category category)
        {
            await categoryManager.AddCategory(category);
            logManager.AddLogs(14, "Information", "MVC üzerinden category verisi eklendi");
            return Json(true);
        }
        public async Task<JsonResult> Update(Category category, int id)
        {
            await categoryManager.UpdateCategory(category,category.Id);
            logManager.AddLogs(15, "Information", "MVC üzerinden category verisi güncellendi");
            return Json(true);
        }
    }
}
