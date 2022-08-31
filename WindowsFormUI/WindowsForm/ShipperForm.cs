using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.CategoriesEntities;
using ModelLayer.ShippersEntities;
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
    public partial class ShipperForm : Form
    {
        private ShipperManager shipperManager = new ShipperManager(new ShipperRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());
        public ShipperForm()
        {
            InitializeComponent();
        }
        public async Task<List<Shippers>> GetAllListShipper()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden shipper verileri cekildi");
            return await shipperManager.GetAllShipper();
        }
        private async void GetAllShipperBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewShipper.DataSource = await GetAllListShipper();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden shipper verileri cekildi");
            loadingForm.Close();
        }

        private async void GetByIdShipperBtn_Click(object sender, EventArgs e)
        {
            if (IdGetByShipperTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetByShipperTxt.Text);
                Shippers mmodelshipper = await shipperManager.GetByIdShipper(id);
                List<Shippers> shipper = new List<Shippers>();
                shipper.Add(mmodelshipper);
                dataGridViewShipper.DataSource = shipper;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye shipper verisi cekildi");
                loadingForm.Close();
            }
        }

        private async void DeleteShipperBtn_Click(object sender, EventArgs e)
        {
            if (IdDeleteShipperTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteShipperTxt.Text);
                await shipperManager.DeleteShipperr(id);
                dataGridViewShipper.DataSource = await GetAllListShipper();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden shipper verisi silindi");
                loadingForm.Close();
            }
        }

        private async void AddShipperBtn_Click(object sender, EventArgs e)
        {
            var shipper = new Shippers();
            if (IdShipperTxt.Text != "")
            {
                shipper.Id = Convert.ToInt32(IdShipperTxt.Text);
            }
            if (companynameShipperTxt.Text != "")
            {
                shipper.CompanyName = companynameShipperTxt.Text;
            }
            if (phoneShipperTxt.Text != "")
            {
                shipper.Phone = phoneShipperTxt.Text;
            }
            if (IdShipperTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await shipperManager.AddShipper(shipper);
                dataGridViewShipper.DataSource = await GetAllListShipper();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden shipper verisi eklendi");
                loadingForm.Close();
            }
        }

        private async void UpdateShipperBtn_Click(object sender, EventArgs e)
        {
            var shipper = new Shippers();
            if (IdShipperTxt.Text != "")
            {
                shipper.Id = Convert.ToInt32(IdShipperTxt.Text);
            }
            if (companynameShipperTxt.Text != "")
            {
                shipper.CompanyName = companynameShipperTxt.Text;
            }
            if (phoneShipperTxt.Text != "")
            {
                shipper.Phone = phoneShipperTxt.Text;
            }
            if (IdShipperTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez.");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                await shipperManager.UpdateShipper(shipper,Convert.ToInt32(IdShipperTxt.Text));
                dataGridViewShipper.DataSource = await GetAllListShipper();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden shipper verisi güncellendi");
                loadingForm.Close();
            }
        }

        private void dataGridViewShipper_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridViewShipper.CurrentRow.Cells[0].Value.ToString();
            IdShipperTxt.Text = id;
            IdDeleteShipperTxt.Text = id;
        }
    }
}
