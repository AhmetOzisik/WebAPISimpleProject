namespace WindowsFormUI
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderFormOpen = new System.Windows.Forms.Button();
            this.ProductFormOpen = new System.Windows.Forms.Button();
            this.CategoryFormOpen = new System.Windows.Forms.Button();
            this.EmployeeFormOpen = new System.Windows.Forms.Button();
            this.ShipperFormOpen = new System.Windows.Forms.Button();
            this.SupplierFormOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderFormOpen
            // 
            this.OrderFormOpen.Location = new System.Drawing.Point(70, 116);
            this.OrderFormOpen.Name = "OrderFormOpen";
            this.OrderFormOpen.Size = new System.Drawing.Size(149, 43);
            this.OrderFormOpen.TabIndex = 1;
            this.OrderFormOpen.Text = "Order ";
            this.OrderFormOpen.UseVisualStyleBackColor = true;
            this.OrderFormOpen.Click += new System.EventHandler(this.OrderFormOpen_Click);
            // 
            // ProductFormOpen
            // 
            this.ProductFormOpen.Location = new System.Drawing.Point(258, 116);
            this.ProductFormOpen.Name = "ProductFormOpen";
            this.ProductFormOpen.Size = new System.Drawing.Size(149, 43);
            this.ProductFormOpen.TabIndex = 2;
            this.ProductFormOpen.Text = "Product";
            this.ProductFormOpen.UseVisualStyleBackColor = true;
            this.ProductFormOpen.Click += new System.EventHandler(this.ProductFormOpen_Click);
            // 
            // CategoryFormOpen
            // 
            this.CategoryFormOpen.Location = new System.Drawing.Point(445, 213);
            this.CategoryFormOpen.Name = "CategoryFormOpen";
            this.CategoryFormOpen.Size = new System.Drawing.Size(165, 43);
            this.CategoryFormOpen.TabIndex = 3;
            this.CategoryFormOpen.Text = "Category";
            this.CategoryFormOpen.UseVisualStyleBackColor = true;
            this.CategoryFormOpen.Click += new System.EventHandler(this.CategoryFormOpen_Click);
            // 
            // EmployeeFormOpen
            // 
            this.EmployeeFormOpen.Location = new System.Drawing.Point(445, 116);
            this.EmployeeFormOpen.Name = "EmployeeFormOpen";
            this.EmployeeFormOpen.Size = new System.Drawing.Size(165, 43);
            this.EmployeeFormOpen.TabIndex = 4;
            this.EmployeeFormOpen.Text = "Employee";
            this.EmployeeFormOpen.UseVisualStyleBackColor = true;
            this.EmployeeFormOpen.Click += new System.EventHandler(this.EmployeeFormOpen_Click);
            // 
            // ShipperFormOpen
            // 
            this.ShipperFormOpen.Location = new System.Drawing.Point(70, 213);
            this.ShipperFormOpen.Name = "ShipperFormOpen";
            this.ShipperFormOpen.Size = new System.Drawing.Size(149, 43);
            this.ShipperFormOpen.TabIndex = 5;
            this.ShipperFormOpen.Text = "Shipper";
            this.ShipperFormOpen.UseVisualStyleBackColor = true;
            this.ShipperFormOpen.Click += new System.EventHandler(this.ShipperFormOpen_Click);
            // 
            // SupplierFormOpen
            // 
            this.SupplierFormOpen.Location = new System.Drawing.Point(258, 213);
            this.SupplierFormOpen.Name = "SupplierFormOpen";
            this.SupplierFormOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SupplierFormOpen.Size = new System.Drawing.Size(149, 43);
            this.SupplierFormOpen.TabIndex = 6;
            this.SupplierFormOpen.Text = "Supplier";
            this.SupplierFormOpen.UseVisualStyleBackColor = true;
            this.SupplierFormOpen.Click += new System.EventHandler(this.SupplierFormOpen_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 384);
            this.Controls.Add(this.SupplierFormOpen);
            this.Controls.Add(this.ShipperFormOpen);
            this.Controls.Add(this.EmployeeFormOpen);
            this.Controls.Add(this.CategoryFormOpen);
            this.Controls.Add(this.ProductFormOpen);
            this.Controls.Add(this.OrderFormOpen);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsForm UI";
            this.ResumeLayout(false);

        }

        #endregion
        private Button OrderFormOpen;
        private Button ProductFormOpen;
        private Button CategoryFormOpen;
        private Button EmployeeFormOpen;
        private Button ShipperFormOpen;
        private Button SupplierFormOpen;
    }
}