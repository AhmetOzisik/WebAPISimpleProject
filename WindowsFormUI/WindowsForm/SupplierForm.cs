using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.CategoriesEntities;
using ModelLayer.EmployessEntities;
using ModelLayer.ProductsEntities;
using ModelLayer.SuppliersEntities;
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
    public partial class SupplierForm : Form
    {
        private SupplierManager supplierManager = new SupplierManager(new SupplierRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());
        public SupplierForm()
        {
            InitializeComponent();
        }
        public async Task<List<Suppliers>> GetAllListSupplier()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden supplier verileri cekildi");
            return await supplierManager.GetAllSupplier();
        }
        private async void GetAllSupplierBtn_Click(object sender, EventArgs e)
        {

            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewSupplier.DataSource = await GetAllListSupplier();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden supplier verileri cekildi");
            loadingForm.Close();
        }

        private async void GetByIdSupplierBtn_Click(object sender, EventArgs e)
        {
            if (IdGetBySupplierTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetBySupplierTxt.Text);
                Suppliers modelsupplier = await supplierManager.GetByIdSupplier(id);
                List<Suppliers> supplier = new List<Suppliers>();
                supplier.Add(modelsupplier);
                dataGridViewSupplier.DataSource = supplier;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye supplier verisi cekildi");
                loadingForm.Close();
            }
        }

        private async void DeleteSupplierBtn_Click(object sender, EventArgs e)
        {
            if (IdDeleteSupplierTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteSupplierTxt.Text);
                await supplierManager.DeleteSupplier(id);
                dataGridViewSupplier.DataSource = await GetAllListSupplier();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden supplier verisi silindi");
                loadingForm.Close();
            }
        }

        private async void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            var supplier = new Suppliers();
            if (IdSupplierTxt.Text != "")
            {
                supplier.Id = Convert.ToInt32(IdSupplierTxt.Text);
            }
            if (companynameSupplierTxt.Text != "")
            {
                supplier.CompanyName = companynameSupplierTxt.Text;
            }
            if (contactnameSupplierTxt.Text != "")
            {
                supplier.ContactName = contactnameSupplierTxt.Text;
            }
            if (contacttitleSupplierTxt.Text != "")
            {
                supplier.ContactTitle = contacttitleSupplierTxt.Text;
            }
            if (IdSupplierTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            var adres = new Address();
            if (StreetSupplierTxt.Text != "")
            {
                adres.Street = StreetSupplierTxt.Text;
            }
            if (CitySupplierTxt.Text != "")
            {
                adres.City = CitySupplierTxt.Text;
            }
            if (RegionSupplierTxt.Text != "")
            {
                adres.Region = RegionSupplierTxt.Text;
            }
            if (CountrySupplierTxt.Text != "")
            {
                adres.Country = CountrySupplierTxt.Text;
            }
            if (phoneSupplierTxt.Text != "")
            {
                adres.Phone = phoneSupplierTxt.Text;
            }
            if (adres != null)
            {
                supplier.Address = adres;
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await supplierManager.AddSupplier(supplier);
                dataGridViewSupplier.DataSource = await GetAllListSupplier();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden supplier verisi eklendi");
                loadingForm.Close();
            }
        }

        private async void UpdateSupplierBtn_Click(object sender, EventArgs e)
        {
            var supplier = new Suppliers();
            if (IdSupplierTxt.Text != "")
            {
                supplier.Id = Convert.ToInt32(IdSupplierTxt.Text);
            }
            if (companynameSupplierTxt.Text != "")
            {
                supplier.CompanyName = companynameSupplierTxt.Text;
            }
            if (contactnameSupplierTxt.Text != "")
            {
                supplier.ContactName = contactnameSupplierTxt.Text;
            }
            if (contacttitleSupplierTxt.Text != "")
            {
                supplier.ContactTitle = contacttitleSupplierTxt.Text;
            }
            if (IdSupplierTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await supplierManager.UpdateSupplier(supplier,Convert.ToInt32(IdSupplierTxt.Text));
                dataGridViewSupplier.DataSource = await GetAllListSupplier();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden supplier verisi güncellendi");
                loadingForm.Close();
            }
        }

        private void dataGridViewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridViewSupplier.CurrentRow.Cells[0].Value.ToString();
            IdSupplierTxt.Text = id;
            IdDeleteSupplierTxt.Text = id;
        }
    }
}
