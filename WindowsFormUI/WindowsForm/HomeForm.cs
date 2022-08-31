using ModelLayer.Entities;
using WebAPI.Manager;
using WebAPI.WebApiRepository;

namespace WindowsFormUI
{
    public partial class HomeForm : Form
    {
       
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OrderFormOpen_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            
        }
        private void ProductFormOpen_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void CategoryFormOpen_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void EmployeeFormOpen_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();  
        }

        private void SupplierFormOpen_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void ShipperFormOpen_Click(object sender, EventArgs e)
        {
            ShipperForm shipperForm = new ShipperForm();
            shipperForm.ShowDialog();
        }
    }
}