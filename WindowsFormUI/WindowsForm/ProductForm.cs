using DataAccesslayer.MSSQL.AdoNetRepository;
using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.CategoriesEntities;
using ModelLayer.Entities;
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
    public partial class ProductForm : Form
    {
        private ProductManager productmanager = new ProductManager(new ProductsRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());
        public ProductForm()
        {
            InitializeComponent();
        }
        public async Task<List<Products>> GetAllListProduct()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden product verileri cekildi");
            return await productmanager.GetAllProducts();
        }
        private async void GetAllProductBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewProduct.DataSource = await GetAllListProduct();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden product verileri cekildi");
            loadingForm.Close();    
        }

        private async void GetByIdProductBtn_Click(object sender, EventArgs e)
        {
            if(IdGetByProductTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetByProductTxt.Text);
                Products modelproduct = await productmanager.GetByIdProduct(id);
                List<Products> product = new List<Products>();
                product.Add(modelproduct);
                dataGridViewProduct.DataSource = product;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye product verisi cekildi");
                loadingForm.Close();
            }
           
        }

        private async void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if(IdDeleteProductTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteProductTxt.Text);
                await productmanager.DeleteProduct(id);
                dataGridViewProduct.DataSource = await GetAllListProduct();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden product verisi silindi");
                loadingForm.Close();
            }
        }

        private async void AddProductBtn_Click(object sender, EventArgs e)
        {
            var products = new Products();
            if (IdProductTxt.Text != "")
            {
                products.Id = Convert.ToInt32(IdProductTxt.Text);
            }
            if (supplierIdProductTxt.Text != "")
            {
                products.SupplierId= Convert.ToInt32(supplierIdProductTxt.Text);
            }
            if(categoryIdProductTxt.Text != "")
            {
                products.CategoryId= Convert.ToInt32(categoryIdProductTxt.Text);
            }
            if(quantityperunitProductTxt.Text != "")
            {
                products.QuantityPerUnit = quantityperunitProductTxt.Text;
            }
            if(unitpriceProductTxt.Text != "")
            {
                products.UnitPrice = Convert.ToDouble(unitpriceProductTxt.Text);
            }
            if (unitinstockProductTxt.Text != "")
            {
                products.UnitsInStock= Convert.ToInt32(unitinstockProductTxt.Text);
            }
            if (unitsonorderProductTxt.Text != "")
            {
                products.UnitsOnOrder= Convert.ToInt32(unitsonorderProductTxt.Text);    
            }
            if (reorderlevelProductTxt.Text != "")
            {
                products.ReorderLevel= Convert.ToInt32(reorderlevelProductTxt.Text);    
            }
            if (discontinuedcheckBoxProduct.Checked)
            {
                products.Discontinued = true;
            }
            if (nameProductTxt.Text != "")
            {
                products.Name= nameProductTxt.Text;
            }
            var supplier = new Supplier();
            if (IdsupplierProductTxt.Text != "")
            {
                supplier.Id = Convert.ToInt32(IdsupplierProductTxt.Text);
            }
            if (companynameProductTxt.Text != "")
            {
                supplier.CompanyName= companynameProductTxt.Text;   
            }
            if (contactnameProductTxt.Text != "")
            {
                supplier.ContactName= contactnameProductTxt.Text;   
            }
            if (contacttitleProductTxt.Text != "")
            {
                supplier.ContactTitle= contacttitleProductTxt.Text; 
            }
            var adres = new Address();
            if (streetProductTxt.Text != "")
            {
                adres.Street= streetProductTxt.Text;    
            }
            if(cityProductTxt.Text != "")
            {
                adres.City= cityProductTxt.Text;    
            }
            if (regionProductTxt.Text != "")
            {
                adres.Region= regionProductTxt.Text;    
            }
            if (countryProductTxt.Text != "")
            {
                adres.Country= countryProductTxt.Text;  
            }
            if (phoneProductTxt.Text != "")
            {
                adres.Phone= phoneProductTxt.Text;
            }
            if (adres != null)
            {
                supplier.Address = adres;
            }
            if (supplier != null)
            {
                products.Supplier = supplier;
            }
         
            var category = new Category();
            if (IdProductCategoryTxt.Text != "")
            {
                category.Id= Convert.ToInt32(IdProductCategoryTxt.Text);
            }
            if (nameProductCategoryTxt.Text != "")
            {
                category.Name= nameProductCategoryTxt.Text; 
            }
            if (descriptionProductCategoryTxt.Text != "")
            {
                category.Description= descriptionProductCategoryTxt.Text;
            }
            if (category != null)
            {
                products.Category = category;
            }


            if (IdProductTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await productmanager.AddProduct(products);
                dataGridViewProduct.DataSource = await GetAllListProduct();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden product verisi eklendi");
                loadingForm.Close();
            }
        }

        private async void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            var products = new Products();
            if (IdProductTxt.Text != "")
            {
                products.Id = Convert.ToInt32(IdProductTxt.Text);
            }
            if (supplierIdProductTxt.Text != "")
            {
                products.SupplierId = Convert.ToInt32(supplierIdProductTxt.Text);
            }
            if (categoryIdProductTxt.Text != "")
            {
                products.CategoryId = Convert.ToInt32(categoryIdProductTxt.Text);
            }
            if (quantityperunitProductTxt.Text != "")
            {
                products.QuantityPerUnit = quantityperunitProductTxt.Text;
            }
            if (unitpriceProductTxt.Text != "")
            {
                products.UnitPrice = Convert.ToDouble(unitpriceProductTxt.Text);
            }
            if (unitinstockProductTxt.Text != "")
            {
                products.UnitsInStock = Convert.ToInt32(unitinstockProductTxt.Text);
            }
            if (unitsonorderProductTxt.Text != "")
            {
                products.UnitsOnOrder = Convert.ToInt32(unitsonorderProductTxt.Text);
            }
            if (reorderlevelProductTxt.Text != "")
            {
                products.ReorderLevel = Convert.ToInt32(reorderlevelProductTxt.Text);
            }
            if (discontinuedcheckBoxProduct.Checked)
            {
                products.Discontinued = true;
            }
            if (nameProductTxt.Text != "")
            {
                products.Name = nameProductTxt.Text;
            }
            var supplier = new Supplier();
            if (IdsupplierProductTxt.Text != "")
            {
                supplier.Id = Convert.ToInt32(IdsupplierProductTxt.Text);
            }
            if (companynameProductTxt.Text != "")
            {
                supplier.CompanyName = companynameProductTxt.Text;
            }
            if (contactnameProductTxt.Text != "")
            {
                supplier.ContactName = contactnameProductTxt.Text;
            }
            if (contacttitleProductTxt.Text != "")
            {
                supplier.ContactTitle = contacttitleProductTxt.Text;
            }
            var adres = new Address();
            if (streetProductTxt.Text != "")
            {
                adres.Street = streetProductTxt.Text;
            }
            if (cityProductTxt.Text != "")
            {
                adres.City = cityProductTxt.Text;
            }
            if (regionProductTxt.Text != "")
            {
                adres.Region = regionProductTxt.Text;
            }
            if (countryProductTxt.Text != "")
            {
                adres.Country = countryProductTxt.Text;
            }
            if (phoneProductTxt.Text != "")
            {
                adres.Phone = phoneProductTxt.Text;
            }
            if (adres != null)
            {
                supplier.Address = adres;
            }
            if (supplier != null)
            {
                products.Supplier = supplier;
            }
            var category = new Category();
            if (IdProductCategoryTxt.Text != "")
            {
                category.Id = Convert.ToInt32(IdProductCategoryTxt.Text);
            }
            if (nameProductCategoryTxt.Text != "")
            {
                category.Name = nameProductCategoryTxt.Text;
            }
            if (descriptionProductCategoryTxt.Text != "")
            {
                category.Description = descriptionProductCategoryTxt.Text;
            }
            if (category != null)
            {
                products.Category = category;
            }

            if (IdProductTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await productmanager.UpdateProduct(products,Convert.ToInt32(IdProductTxt.Text));
                dataGridViewProduct.DataSource = await GetAllListProduct();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden product verisi güncellendi");
                loadingForm.Close();
            }
        }

        private async void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            var id = dataGridViewProduct.CurrentRow.Cells[0].Value.ToString();
            IdProductTxt.Text = id;
            IdDeleteProductTxt.Text = dataGridViewProduct.CurrentRow.Cells[0].Value.ToString();
            Products product=await productmanager.GetByIdProduct(Convert.ToInt32(id));
            if(product.Category != null)
            {
                IdProductCategoryTxt.Text = product.Category.Id.ToString();
                nameProductCategoryTxt.Text = product.Category.Name;
                descriptionProductCategoryTxt.Text = product.Category.Description;
            }
            loadingForm.Close();
        }
    }
}
