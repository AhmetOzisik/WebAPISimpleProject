using DataAccesslayer.MSSQL.AdoNetRepository;
using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.CategoriesEntities;
using ModelLayer.Entities;
using ModelLayer.OrderEntities;
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
    public partial class OrderForm : Form
    {
        private OrderManager ordermanager = new OrderManager(new OrderRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());
        public OrderForm()
        {
            InitializeComponent();
        }
        public async Task<List<Orders>> GetAllListOrder()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden order verileri cekildi");
            return await ordermanager.GetAllOrders();
        }
        private async void GetAllOrderBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewOrder.DataSource = await GetAllListOrder();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden order verileri cekildi");
            loadingForm.Close();
        }

        private async void GetByIdOrderBtn_Click(object sender, EventArgs e)
        {
           
            if(IdGetByOrderTxt.Text =="")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetByOrderTxt.Text);
                Orders modelorder = await ordermanager.GetByIdOrder(id);
                List<Orders> order = new List<Orders>();
                order.Add(modelorder);
                dataGridViewOrder.DataSource = order;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye order verisi cekildi");
                loadingForm.Close();
            } 
        }

        private async void OrderDeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdDeleteOrderTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteOrderTxt.Text);
                await ordermanager.DeleteOrder(id);
                dataGridViewOrder.DataSource = await GetAllListOrder();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden order verisi silindi");
                loadingForm.Close();
            }
        }

        private void dataGridViewOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id=dataGridViewOrder.CurrentRow.Cells[0].Value.ToString();
            IdOrderTxt.Text = id;
            IdDeleteOrderTxt.Text = id;
        }

        private async void AddOrderBtn_Click(object sender, EventArgs e)
        {
            var order = new Orders();
            if(EmployeeOrderTxt.Text != "")
            {
                order.EmployeeId = Convert.ToInt32(EmployeeOrderTxt.Text);
            }
            if(customerOrderTxt.Text != ""){
                order.CustomerId = customerOrderTxt.Text;
            }
            if(OrderDateOrderTxt.Text != "")
            {
                order.OrderDate = OrderDateOrderTxt.Text;
            }
            if(RequiredDateOrderTxt.Text != "")
            {
                order.RequiredDate = RequiredDateOrderTxt.Text;
            }
            if(ShippedDateOrderTxt.Text != "")
            {
                order.ShippedDate= ShippedDateOrderTxt.Text;
            }
            if(ShipViaOrderTxt.Text != "")
            {
                order.ShipVia = Convert.ToInt32(ShipViaOrderTxt.Text);
            }
            if(FreightOrderTxt.Text != "")
            {
                order.Freight = Convert.ToDouble(FreightOrderTxt.Text);
            }
            if(ShipNameOrderTxt.Text != "")
            {
                order.ShipName = ShipNameOrderTxt.Text;
            }
            var shippadress = new ShipAddress();
            if(StreetOrderTxt.Text != "")
            {
                shippadress.Street = StreetOrderTxt.Text;
            }
            if(CityOrderTxt.Text != "")
            {
                shippadress.City = CityOrderTxt.Text;
            }
            if (RegionOrderTxt.Text != "")
            {
                shippadress.Region = RegionOrderTxt.Text;
            }
            if (CountryOrderTxt.Text != "")
            {
                shippadress.Country= CountryOrderTxt.Text;
            }
            if (shippadress != null)
            {
                order.ShipAddress = shippadress;
            }
            if (IdOrderTxt.Text == "")
            {
                MessageBox.Show("Id Boş Olamaz");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                order.Id = Convert.ToInt32(IdOrderTxt.Text);
                await ordermanager.AddOrder(order);
                dataGridViewOrder.DataSource = await GetAllListOrder();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden order verisi eklendi");
                loadingForm.Close();
            }
        }

        private async void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            var order = new Orders();
            if (EmployeeOrderTxt.Text != "")
            {
                order.EmployeeId = Convert.ToInt32(EmployeeOrderTxt.Text);
            }
            if (customerOrderTxt.Text != "")
            {
                order.CustomerId = customerOrderTxt.Text;
            }
            if (OrderDateOrderTxt.Text != "")
            {
                order.OrderDate = OrderDateOrderTxt.Text;
            }
            if (RequiredDateOrderTxt.Text != "")
            {
                order.RequiredDate = RequiredDateOrderTxt.Text;
            }
            if (ShippedDateOrderTxt.Text != "")
            {
                order.ShippedDate = ShippedDateOrderTxt.Text;
            }
            if (ShipViaOrderTxt.Text != "")
            {
                order.ShipVia = Convert.ToInt32(ShipViaOrderTxt.Text);
            }
            if (FreightOrderTxt.Text != "")
            {
                order.Freight = Convert.ToDouble(FreightOrderTxt.Text);
            }
            if (ShipNameOrderTxt.Text != "")
            {
                order.ShipName = ShipNameOrderTxt.Text;
            }
            var shippadress = new ShipAddress();
            if (StreetOrderTxt.Text != "")
            {
                shippadress.Street = StreetOrderTxt.Text;
            }
            if (CityOrderTxt.Text != "")
            {
                shippadress.City = CityOrderTxt.Text;
            }
            if (RegionOrderTxt.Text != "")
            {
                shippadress.Region = RegionOrderTxt.Text;
            }
            if (CountryOrderTxt.Text != "")
            {
                shippadress.Country = CountryOrderTxt.Text;
            }
            if (shippadress != null)
            {
                order.ShipAddress = shippadress;
            }
            if (IdOrderTxt.Text == "")
            {
                MessageBox.Show("Id Boş Olamaz");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                order.Id = Convert.ToInt32(IdOrderTxt.Text);
                await ordermanager.UpdateOrder(order, Convert.ToInt32(IdOrderTxt.Text));
                dataGridViewOrder.DataSource = await GetAllListOrder();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden order verisi güncellendi");
                loadingForm.Close();
            }
        }
    }
}
