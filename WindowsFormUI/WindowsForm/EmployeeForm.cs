using DataAccesslayer.SqlLite.SQLiteRepository;
using LogLibrary.SQLiteManager;
using ModelLayer.EmployessEntities;
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
    public partial class EmployeeForm : Form
    {
        private EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());
        private LogManager logManager = new LogManager(new SQLiteLogRepository());

        public EmployeeForm()
        {
            InitializeComponent();
        }
        public async Task<List<Employess>> GetAllListEmployee()
        {
            logManager.AddLogs("İnfo", "WindowsForm üzerinden employee verileri cekildi");
            return await employeeManager.GetAllEmployee();
        }

        private async void GetAllEmployeeBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            dataGridViewEmployee.DataSource = await GetAllListEmployee();
            logManager.AddLogs("İnfo", "WindowsForm üzerinden employee verileri cekildi");
            loadingForm.Close();
        }

        private async void GetByIdEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (IdGetByEmployeeTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdGetByEmployeeTxt.Text);
                Employess modelemployee = await employeeManager.GetByIdEmployee(id);
                List<Employess> employee = new List<Employess>();
                employee.Add(modelemployee);
                dataGridViewEmployee.DataSource = employee;
                logManager.AddLogs("İnfo", "WindowsForm üzerinden id ye employee verisi cekildi");
                loadingForm.Close();
            }
        }

        private async void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (IdDeleteEmployeeTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                int id = Convert.ToInt32(IdDeleteEmployeeTxt.Text);
                await employeeManager.DeleteEmployee(id);
                dataGridViewEmployee.DataSource = await GetAllListEmployee();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden employee verisi silindi");
                loadingForm.Close();
            }
        }

        private async void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var employee = new Employess();
            if (IdEmployeeTxt.Text != "")
            {
                employee.Id = Convert.ToInt32(IdEmployeeTxt.Text);
            }
            if (lastnameEmployeeTxt.Text != "")
            {
                employee.LastName = lastnameEmployeeTxt.Text;
            }
            if (firstnameEmployeeTxt.Text != "")
            {
                employee.FirstName = firstnameEmployeeTxt.Text;
            }
            if (titleEmployeeTxt.Text != "")
            {
                employee.Title = titleEmployeeTxt.Text;
            }
            if (titleofcourtesyEmployeeTxt.Text != "")
            {
                employee.TitleOfCourtesy = titleofcourtesyEmployeeTxt.Text;
            }
            if (birthdateEmployeeTxt.Text != "")
            {
                employee.BirthDate = birthdateEmployeeTxt.Text;
            }
            if (hiredateEmployeeTxt.Text != "")
            {
                employee.HireDate = hiredateEmployeeTxt.Text;
            }
            if (notesEmployeeTxt.Text != "")
            {
                employee.Notes = notesEmployeeTxt.Text;
            }
            var adres = new Address();
            if (StreetEmployeeTxt.Text != "")
            {
                adres.Street = StreetEmployeeTxt.Text;
            }
            if (CityEmployeeTxt.Text != "")
            {
                adres.City = CityEmployeeTxt.Text;
            }
            if (RegionEmployeeTxt.Text != "")
            {
                adres.Region = RegionEmployeeTxt.Text;
            }
            if (CountryEmployeeTxt.Text != "")
            {
                adres.Country = CountryEmployeeTxt.Text;
            }
            if (phoneEmployeeTxt.Text != "")
            {
                adres.Phone = phoneEmployeeTxt.Text;
            }
            if (adres != null)
            {
                employee.Address = adres;
            }
            if (IdEmployeeTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                employee.Id = Convert.ToInt32(IdEmployeeTxt.Text);
                await employeeManager.AddEmployee(employee);
                dataGridViewEmployee.DataSource = await GetAllListEmployee();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden employee verisi eklendi");
                loadingForm.Close();
            } 
        }

        private async void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            var employee = new Employess();
            if (IdEmployeeTxt.Text != "")
            {
                employee.Id = Convert.ToInt32(IdEmployeeTxt.Text);
            }
            if (lastnameEmployeeTxt.Text != "")
            {
                employee.LastName = lastnameEmployeeTxt.Text;
            }
            if (firstnameEmployeeTxt.Text != "")
            {
                employee.FirstName = firstnameEmployeeTxt.Text;
            }
            if (titleEmployeeTxt.Text != "")
            {
                employee.Title = titleEmployeeTxt.Text;
            }
            if (titleofcourtesyEmployeeTxt.Text != "")
            {
                employee.TitleOfCourtesy = titleofcourtesyEmployeeTxt.Text;
            }
            if (birthdateEmployeeTxt.Text != "")
            {
                employee.BirthDate = birthdateEmployeeTxt.Text;
            }
            if (hiredateEmployeeTxt.Text != "")
            {
                employee.HireDate = hiredateEmployeeTxt.Text;
            }
            if (notesEmployeeTxt.Text != "")
            {
                employee.Notes = notesEmployeeTxt.Text;
            }
            var adres = new Address();
            if (StreetEmployeeTxt.Text != "")
            {
                adres.Street = StreetEmployeeTxt.Text;
            }
            if (CityEmployeeTxt.Text != "")
            {
                adres.City = CityEmployeeTxt.Text;
            }
            if (RegionEmployeeTxt.Text != "")
            {
                adres.Region = RegionEmployeeTxt.Text;
            }
            if (CountryEmployeeTxt.Text != "")
            {
                adres.Country = CountryEmployeeTxt.Text;
            }
            if (phoneEmployeeTxt.Text != "")
            {
                adres.Phone = phoneEmployeeTxt.Text;
            }
            if (adres != null)
            {
                employee.Address = adres;
            }
            if (IdEmployeeTxt.Text == "")
            {
                MessageBox.Show("Id Boş Geçilemez");
            }
            else
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                employee.Id = Convert.ToInt32(IdEmployeeTxt.Text);
                await employeeManager.UpdateEmployee(employee, Convert.ToInt32(IdEmployeeTxt.Text));
                dataGridViewEmployee.DataSource = await GetAllListEmployee();
                logManager.AddLogs("İnfo", "WindowsForm üzerinden employee verisi güncellendi");
                loadingForm.Close();
            }
        }

        private void dataGridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id= dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            IdEmployeeTxt.Text = id;
            IdDeleteEmployeeTxt.Text = id;
        }
    }
}
