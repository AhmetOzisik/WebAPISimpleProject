using ModelLayer.CategoriesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class CategoryManager
    {
        ICategoriesAPI categoriesAPI;
        public CategoryManager(ICategoriesAPI categoriesAPI)
        {
            this.categoriesAPI = categoriesAPI;
        }
        public async Task<List<Category>> GetAllCategory()
        {
            var model = await categoriesAPI.GetAll("api/categories");
            return model;
        }
        public async Task<Category> GetByIdCategory(int id)
        {
            var model = await categoriesAPI.GetById("api/categories", id);
            return model;
        }
        public async Task<string> AddCategory(Category category)
        {
            await categoriesAPI.Add("api/categories", category);
            return null;
        }
        public async Task<string> UpdateCategory(Category category,int id)
        {
            await categoriesAPI.Update("api/categories", id, category);
            return null;
        }
        public async Task<string> DeleteCategory(int id)
        {
            await categoriesAPI.Delete("api/categories", id);
            return null;
        }
    }
}
