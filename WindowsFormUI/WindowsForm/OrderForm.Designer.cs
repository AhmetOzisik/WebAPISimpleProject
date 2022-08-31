namespace WindowsFormUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetAllOrderBtn = new System.Windows.Forms.Button();
            this.GetByIdOrderBtn = new System.Windows.Forms.Button();
            this.IdGetByOrderTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.OrderDeleteBtn = new System.Windows.Forms.Button();
            this.IdDeleteOrderTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdOrderTxt = new System.Windows.Forms.TextBox();
            this.customerOrderTxt = new System.Windows.Forms.TextBox();
            this.OrderDateOrderTxt = new System.Windows.Forms.TextBox();
            this.ShipViaOrderTxt = new System.Windows.Forms.TextBox();
            this.ShippedDateOrderTxt = new System.Windows.Forms.TextBox();
            this.RequiredDateOrderTxt = new System.Windows.Forms.TextBox();
            this.ShipNameOrderTxt = new System.Windows.Forms.TextBox();
            this.EmployeeOrderTxt = new System.Windows.Forms.TextBox();
            this.FreightOrderTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.StreetOrderTxt = new System.Windows.Forms.TextBox();
            this.CityOrderTxt = new System.Windows.Forms.TextBox();
            this.RegionOrderTxt = new System.Windows.Forms.TextBox();
            this.CountryOrderTxt = new System.Windows.Forms.TextBox();
            this.UpdateOrderBtn = new System.Windows.Forms.Button();
            this.AddOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAllOrderBtn
            // 
            this.GetAllOrderBtn.Location = new System.Drawing.Point(53, 23);
            this.GetAllOrderBtn.Name = "GetAllOrderBtn";
            this.GetAllOrderBtn.Size = new System.Drawing.Size(171, 52);
            this.GetAllOrderBtn.TabIndex = 0;
            this.GetAllOrderBtn.Text = "Tüm Verileri Getir";
            this.GetAllOrderBtn.UseVisualStyleBackColor = true;
            this.GetAllOrderBtn.Click += new System.EventHandler(this.GetAllOrderBtn_Click);
            // 
            // GetByIdOrderBtn
            // 
            this.GetByIdOrderBtn.Location = new System.Drawing.Point(451, 31);
            this.GetByIdOrderBtn.Name = "GetByIdOrderBtn";
            this.GetByIdOrderBtn.Size = new System.Drawing.Size(184, 36);
            this.GetByIdOrderBtn.TabIndex = 1;
            this.GetByIdOrderBtn.Text = "ID ye Göre Siparişi Getir";
            this.GetByIdOrderBtn.UseVisualStyleBackColor = true;
            this.GetByIdOrderBtn.Click += new System.EventHandler(this.GetByIdOrderBtn_Click);
            // 
            // IdGetByOrderTxt
            // 
            this.IdGetByOrderTxt.Location = new System.Drawing.Point(301, 36);
            this.IdGetByOrderTxt.Name = "IdGetByOrderTxt";
            this.IdGetByOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.IdGetByOrderTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id : ";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 240);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 29;
            this.dataGridViewOrder.Size = new System.Drawing.Size(1165, 322);
            this.dataGridViewOrder.TabIndex = 4;
            this.dataGridViewOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellDoubleClick);
            // 
            // OrderDeleteBtn
            // 
            this.OrderDeleteBtn.Location = new System.Drawing.Point(1019, 31);
            this.OrderDeleteBtn.Name = "OrderDeleteBtn";
            this.OrderDeleteBtn.Size = new System.Drawing.Size(114, 36);
            this.OrderDeleteBtn.TabIndex = 5;
            this.OrderDeleteBtn.Text = "Sil";
            this.OrderDeleteBtn.UseVisualStyleBackColor = true;
            this.OrderDeleteBtn.Click += new System.EventHandler(this.OrderDeleteBtn_Click);
            // 
            // IdDeleteOrderTxt
            // 
            this.IdDeleteOrderTxt.Location = new System.Drawing.Point(865, 36);
            this.IdDeleteOrderTxt.Name = "IdDeleteOrderTxt";
            this.IdDeleteOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.IdDeleteOrderTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Silenecek Verinin Id si :";
            // 
            // IdOrderTxt
            // 
            this.IdOrderTxt.Location = new System.Drawing.Point(114, 101);
            this.IdOrderTxt.Name = "IdOrderTxt";
            this.IdOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.IdOrderTxt.TabIndex = 8;
            // 
            // customerOrderTxt
            // 
            this.customerOrderTxt.Location = new System.Drawing.Point(114, 142);
            this.customerOrderTxt.Name = "customerOrderTxt";
            this.customerOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.customerOrderTxt.TabIndex = 9;
            // 
            // OrderDateOrderTxt
            // 
            this.OrderDateOrderTxt.Location = new System.Drawing.Point(386, 98);
            this.OrderDateOrderTxt.Name = "OrderDateOrderTxt";
            this.OrderDateOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.OrderDateOrderTxt.TabIndex = 10;
            // 
            // ShipViaOrderTxt
            // 
            this.ShipViaOrderTxt.Location = new System.Drawing.Point(633, 97);
            this.ShipViaOrderTxt.Name = "ShipViaOrderTxt";
            this.ShipViaOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.ShipViaOrderTxt.TabIndex = 11;
            // 
            // ShippedDateOrderTxt
            // 
            this.ShippedDateOrderTxt.Location = new System.Drawing.Point(386, 185);
            this.ShippedDateOrderTxt.Name = "ShippedDateOrderTxt";
            this.ShippedDateOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.ShippedDateOrderTxt.TabIndex = 12;
            // 
            // RequiredDateOrderTxt
            // 
            this.RequiredDateOrderTxt.Location = new System.Drawing.Point(386, 138);
            this.RequiredDateOrderTxt.Name = "RequiredDateOrderTxt";
            this.RequiredDateOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.RequiredDateOrderTxt.TabIndex = 13;
            // 
            // ShipNameOrderTxt
            // 
            this.ShipNameOrderTxt.Location = new System.Drawing.Point(633, 188);
            this.ShipNameOrderTxt.Name = "ShipNameOrderTxt";
            this.ShipNameOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.ShipNameOrderTxt.TabIndex = 14;
            // 
            // EmployeeOrderTxt
            // 
            this.EmployeeOrderTxt.Location = new System.Drawing.Point(114, 192);
            this.EmployeeOrderTxt.Name = "EmployeeOrderTxt";
            this.EmployeeOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.EmployeeOrderTxt.TabIndex = 15;
            // 
            // FreightOrderTxt
            // 
            this.FreightOrderTxt.Location = new System.Drawing.Point(633, 141);
            this.FreightOrderTxt.Name = "FreightOrderTxt";
            this.FreightOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.FreightOrderTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "CustomerId :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "EmployeeId :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Order Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ship Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Freight :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ship Via :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Shipped Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Required Date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(956, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ship Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(995, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Country :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(780, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Region :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(802, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "City :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(788, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Street :";
            // 
            // StreetOrderTxt
            // 
            this.StreetOrderTxt.Location = new System.Drawing.Point(849, 116);
            this.StreetOrderTxt.Name = "StreetOrderTxt";
            this.StreetOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.StreetOrderTxt.TabIndex = 32;
            // 
            // CityOrderTxt
            // 
            this.CityOrderTxt.Location = new System.Drawing.Point(849, 158);
            this.CityOrderTxt.Name = "CityOrderTxt";
            this.CityOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.CityOrderTxt.TabIndex = 33;
            // 
            // RegionOrderTxt
            // 
            this.RegionOrderTxt.Location = new System.Drawing.Point(849, 199);
            this.RegionOrderTxt.Name = "RegionOrderTxt";
            this.RegionOrderTxt.Size = new System.Drawing.Size(125, 27);
            this.RegionOrderTxt.TabIndex = 34;
            // 
            // CountryOrderTxt
            // 
            this.CountryOrderTxt.Location = new System.Drawing.Point(1068, 120);
            this.CountryOrderTxt.Name = "CountryOrderTxt";
            this.CountryOrderTxt.Size = new System.Drawing.Size(98, 27);
            this.CountryOrderTxt.TabIndex = 36;
            // 
            // UpdateOrderBtn
            // 
            this.UpdateOrderBtn.Location = new System.Drawing.Point(995, 158);
            this.UpdateOrderBtn.Name = "UpdateOrderBtn";
            this.UpdateOrderBtn.Size = new System.Drawing.Size(171, 35);
            this.UpdateOrderBtn.TabIndex = 37;
            this.UpdateOrderBtn.Text = "Güncelle";
            this.UpdateOrderBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.Location = new System.Drawing.Point(995, 199);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(171, 35);
            this.AddOrderBtn.TabIndex = 38;
            this.AddOrderBtn.Text = "Ekle";
            this.AddOrderBtn.UseVisualStyleBackColor = true;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 574);
            this.Controls.Add(this.AddOrderBtn);
            this.Controls.Add(this.UpdateOrderBtn);
            this.Controls.Add(this.CountryOrderTxt);
            this.Controls.Add(this.RegionOrderTxt);
            this.Controls.Add(this.CityOrderTxt);
            this.Controls.Add(this.StreetOrderTxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FreightOrderTxt);
            this.Controls.Add(this.EmployeeOrderTxt);
            this.Controls.Add(this.ShipNameOrderTxt);
            this.Controls.Add(this.RequiredDateOrderTxt);
            this.Controls.Add(this.ShippedDateOrderTxt);
            this.Controls.Add(this.ShipViaOrderTxt);
            this.Controls.Add(this.OrderDateOrderTxt);
            this.Controls.Add(this.customerOrderTxt);
            this.Controls.Add(this.IdOrderTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdDeleteOrderTxt);
            this.Controls.Add(this.OrderDeleteBtn);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdGetByOrderTxt);
            this.Controls.Add(this.GetByIdOrderBtn);
            this.Controls.Add(this.GetAllOrderBtn);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetAllOrderBtn;
        private Button GetByIdOrderBtn;
        private TextBox IdGetByOrderTxt;
        private Label label1;
        private DataGridView dataGridViewOrder;
        private Button OrderDeleteBtn;
        private TextBox IdDeleteOrderTxt;
        private Label label2;
        private TextBox IdOrderTxt;
        private TextBox customerOrderTxt;
        private TextBox OrderDateOrderTxt;
        private TextBox ShipViaOrderTxt;
        private TextBox ShippedDateOrderTxt;
        private TextBox RequiredDateOrderTxt;
        private TextBox ShipNameOrderTxt;
        private TextBox EmployeeOrderTxt;
        private TextBox FreightOrderTxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox StreetOrderTxt;
        private TextBox CityOrderTxt;
        private TextBox RegionOrderTxt;
        private TextBox CountryOrderTxt;
        private Button UpdateOrderBtn;
        private Button AddOrderBtn;
    }
}