using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.CategoriesEntities;
using ModelLayer.ProductsEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WindowsFormUI
{
    public partial class CategoryForm : Form
    {
        private CategoryManager categoryManager = new CategoryManager(new CategoryRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());
        public CategoryForm()
        {
            InitializeComponent();
        }
        public async Task<List<Category>> GetAllListCategory()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden category verileri cekildi");
            return await categoryManager.GetAllCategory();
        }
        private async void GetAllCategoryBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewCategory.DataSource = await GetAllListCategory();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden category verileri cekildi");
            loadingForm.Close();
        }

        private async void GetByIdCategoryBtn_Click(object sender, EventArgs e)
        {
            if (IdGetByCategoryTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetByCategoryTxt.Text);
                Category modelcategory = await categoryManager.GetByIdCategory(id);
                List<Category> category = new List<Category>();
                category.Add(modelcategory);
                dataGridViewCategory.DataSource = category;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye category verisi cekildi");
                loadingForm.Close();
            }
        }

        private async void CategoryDeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdDeleteCategoryTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteCategoryTxt.Text);
                await categoryManager.DeleteCategory(id);
                dataGridViewCategory.DataSource = await GetAllListCategory();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden category verisi silindi");
                loadingForm.Close();
            }
        }

        private async void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var category= new Category();
            if (IdCategoryTxt.Text != "")
            {
                category.Id = Convert.ToInt32(IdCategoryTxt.Text);
            }
            if (nameCategoryTxt.Text != "")
            {
                category.Name=nameCategoryTxt.Text;
            }
            if (descriptionCategoryTxt.Text != "")
            {
                category.Description=descriptionCategoryTxt.Text;
            }
            if (IdCategoryTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await categoryManager.AddCategory(category);
                dataGridViewCategory.DataSource = await GetAllListCategory();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden category verisi eklendi");
                loadingForm.Close();
            }
        }

        private async void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            var category = new Category();
            if (IdCategoryTxt.Text != "")
            {
                category.Id = Convert.ToInt32(IdCategoryTxt.Text);
            }
            if (nameCategoryTxt.Text != "")
            {
                category.Name = nameCategoryTxt.Text;
            }
            if (descriptionCategoryTxt.Text != "")
            {
                category.Description = descriptionCategoryTxt.Text;
            }
            if (IdCategoryTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await categoryManager.UpdateCategory(category,Convert.ToInt32(IdCategoryTxt.Text));
                dataGridViewCategory.DataSource = await GetAllListCategory();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden category verisi güncellendi");
                loadingForm.Close();
            }
        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridViewCategory.CurrentRow.Cells[0].Value.ToString();
            IdCategoryTxt.Text = id;
            IdDeleteCategoryTxt.Text = id;

        }
    }
}
