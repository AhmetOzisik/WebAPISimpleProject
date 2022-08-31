namespace WindowsFormUI
{
    partial class ProductForm
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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reorderlevelProductTxt = new System.Windows.Forms.TextBox();
            this.categoryIdProductTxt = new System.Windows.Forms.TextBox();
            this.unitpriceProductTxt = new System.Windows.Forms.TextBox();
            this.unitinstockProductTxt = new System.Windows.Forms.TextBox();
            this.unitsonorderProductTxt = new System.Windows.Forms.TextBox();
            this.quantityperunitProductTxt = new System.Windows.Forms.TextBox();
            this.supplierIdProductTxt = new System.Windows.Forms.TextBox();
            this.IdProductTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdDeleteProductTxt = new System.Windows.Forms.TextBox();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdGetByProductTxt = new System.Windows.Forms.TextBox();
            this.GetByIdProductBtn = new System.Windows.Forms.Button();
            this.GetAllProductBtn = new System.Windows.Forms.Button();
            this.discontinuedcheckBoxProduct = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nameProductTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IdsupplierProductTxt = new System.Windows.Forms.TextBox();
            this.streetProductTxt = new System.Windows.Forms.TextBox();
            this.contacttitleProductTxt = new System.Windows.Forms.TextBox();
            this.contactnameProductTxt = new System.Windows.Forms.TextBox();
            this.companynameProductTxt = new System.Windows.Forms.TextBox();
            this.regionProductTxt = new System.Windows.Forms.TextBox();
            this.cityProductTxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.phoneProductTxt = new System.Windows.Forms.TextBox();
            this.countryProductTxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.IdProductCategoryTxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.descriptionProductCategoryTxt = new System.Windows.Forms.TextBox();
            this.nameProductCategoryTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(694, 307);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(171, 35);
            this.AddProductBtn.TabIndex = 75;
            this.AddProductBtn.Text = "Ekle";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(881, 307);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(171, 35);
            this.UpdateProductBtn.TabIndex = 74;
            this.UpdateProductBtn.Text = "Güncelle";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "Unit Price :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Units In Stock :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Units On Order :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Reorder Level :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Discontinued :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Quantity Per Unit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "CategoryId :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "SupplierId :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Id :";
            // 
            // reorderlevelProductTxt
            // 
            this.reorderlevelProductTxt.Location = new System.Drawing.Point(646, 144);
            this.reorderlevelProductTxt.Name = "reorderlevelProductTxt";
            this.reorderlevelProductTxt.Size = new System.Drawing.Size(125, 27);
            this.reorderlevelProductTxt.TabIndex = 55;
            // 
            // categoryIdProductTxt
            // 
            this.categoryIdProductTxt.Location = new System.Drawing.Point(127, 195);
            this.categoryIdProductTxt.Name = "categoryIdProductTxt";
            this.categoryIdProductTxt.Size = new System.Drawing.Size(125, 27);
            this.categoryIdProductTxt.TabIndex = 54;
            // 
            // unitpriceProductTxt
            // 
            this.unitpriceProductTxt.Location = new System.Drawing.Point(399, 141);
            this.unitpriceProductTxt.Name = "unitpriceProductTxt";
            this.unitpriceProductTxt.Size = new System.Drawing.Size(125, 27);
            this.unitpriceProductTxt.TabIndex = 52;
            // 
            // unitinstockProductTxt
            // 
            this.unitinstockProductTxt.Location = new System.Drawing.Point(399, 188);
            this.unitinstockProductTxt.Name = "unitinstockProductTxt";
            this.unitinstockProductTxt.Size = new System.Drawing.Size(125, 27);
            this.unitinstockProductTxt.TabIndex = 51;
            // 
            // unitsonorderProductTxt
            // 
            this.unitsonorderProductTxt.Location = new System.Drawing.Point(646, 100);
            this.unitsonorderProductTxt.Name = "unitsonorderProductTxt";
            this.unitsonorderProductTxt.Size = new System.Drawing.Size(125, 27);
            this.unitsonorderProductTxt.TabIndex = 50;
            // 
            // quantityperunitProductTxt
            // 
            this.quantityperunitProductTxt.Location = new System.Drawing.Point(399, 101);
            this.quantityperunitProductTxt.Name = "quantityperunitProductTxt";
            this.quantityperunitProductTxt.Size = new System.Drawing.Size(125, 27);
            this.quantityperunitProductTxt.TabIndex = 49;
            // 
            // supplierIdProductTxt
            // 
            this.supplierIdProductTxt.Location = new System.Drawing.Point(127, 145);
            this.supplierIdProductTxt.Name = "supplierIdProductTxt";
            this.supplierIdProductTxt.Size = new System.Drawing.Size(125, 27);
            this.supplierIdProductTxt.TabIndex = 48;
            // 
            // IdProductTxt
            // 
            this.IdProductTxt.Location = new System.Drawing.Point(127, 104);
            this.IdProductTxt.Name = "IdProductTxt";
            this.IdProductTxt.Size = new System.Drawing.Size(125, 27);
            this.IdProductTxt.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Silenecek Verinin Id si :";
            // 
            // IdDeleteProductTxt
            // 
            this.IdDeleteProductTxt.Location = new System.Drawing.Point(1008, 37);
            this.IdDeleteProductTxt.Name = "IdDeleteProductTxt";
            this.IdDeleteProductTxt.Size = new System.Drawing.Size(125, 27);
            this.IdDeleteProductTxt.TabIndex = 45;
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.Location = new System.Drawing.Point(1155, 34);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(114, 36);
            this.ProductDeleteBtn.TabIndex = 44;
            this.ProductDeleteBtn.Text = "Sil";
            this.ProductDeleteBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 348);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 29;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1413, 378);
            this.dataGridViewProduct.TabIndex = 43;
            this.dataGridViewProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id : ";
            // 
            // IdGetByProductTxt
            // 
            this.IdGetByProductTxt.Location = new System.Drawing.Point(448, 38);
            this.IdGetByProductTxt.Name = "IdGetByProductTxt";
            this.IdGetByProductTxt.Size = new System.Drawing.Size(125, 27);
            this.IdGetByProductTxt.TabIndex = 41;
            // 
            // GetByIdProductBtn
            // 
            this.GetByIdProductBtn.Location = new System.Drawing.Point(598, 32);
            this.GetByIdProductBtn.Name = "GetByIdProductBtn";
            this.GetByIdProductBtn.Size = new System.Drawing.Size(184, 36);
            this.GetByIdProductBtn.TabIndex = 40;
            this.GetByIdProductBtn.Text = "ID ye Göre Siparişi Getir";
            this.GetByIdProductBtn.UseVisualStyleBackColor = true;
            this.GetByIdProductBtn.Click += new System.EventHandler(this.GetByIdProductBtn_Click);
            // 
            // GetAllProductBtn
            // 
            this.GetAllProductBtn.Location = new System.Drawing.Point(142, 24);
            this.GetAllProductBtn.Name = "GetAllProductBtn";
            this.GetAllProductBtn.Size = new System.Drawing.Size(171, 52);
            this.GetAllProductBtn.TabIndex = 39;
            this.GetAllProductBtn.Text = "Tüm Verileri Getir";
            this.GetAllProductBtn.UseVisualStyleBackColor = true;
            this.GetAllProductBtn.Click += new System.EventHandler(this.GetAllProductBtn_Click);
            // 
            // discontinuedcheckBoxProduct
            // 
            this.discontinuedcheckBoxProduct.AutoSize = true;
            this.discontinuedcheckBoxProduct.Location = new System.Drawing.Point(646, 230);
            this.discontinuedcheckBoxProduct.Name = "discontinuedcheckBoxProduct";
            this.discontinuedcheckBoxProduct.Size = new System.Drawing.Size(18, 17);
            this.discontinuedcheckBoxProduct.TabIndex = 76;
            this.discontinuedcheckBoxProduct.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(881, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 77;
            this.label12.Text = "Id :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1031, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 78;
            this.label13.Text = "Supplier and Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(581, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 79;
            this.label14.Text = "Name :";
            // 
            // nameProductTxt
            // 
            this.nameProductTxt.Location = new System.Drawing.Point(646, 188);
            this.nameProductTxt.Name = "nameProductTxt";
            this.nameProductTxt.Size = new System.Drawing.Size(125, 27);
            this.nameProductTxt.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1131, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 81;
            this.label15.Text = "Region :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1153, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 82;
            this.label16.Text = "City :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1139, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 83;
            this.label17.Text = "Street :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(807, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.TabIndex = 84;
            this.label18.Text = "Contact Title :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(799, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 20);
            this.label19.TabIndex = 85;
            this.label19.Text = "Contact Name :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(787, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 20);
            this.label20.TabIndex = 86;
            this.label20.Text = "Company Name :";
            // 
            // IdsupplierProductTxt
            // 
            this.IdsupplierProductTxt.Location = new System.Drawing.Point(916, 118);
            this.IdsupplierProductTxt.Name = "IdsupplierProductTxt";
            this.IdsupplierProductTxt.Size = new System.Drawing.Size(125, 27);
            this.IdsupplierProductTxt.TabIndex = 87;
            // 
            // streetProductTxt
            // 
            this.streetProductTxt.Location = new System.Drawing.Point(1200, 118);
            this.streetProductTxt.Name = "streetProductTxt";
            this.streetProductTxt.Size = new System.Drawing.Size(125, 27);
            this.streetProductTxt.TabIndex = 88;
            // 
            // contacttitleProductTxt
            // 
            this.contacttitleProductTxt.Location = new System.Drawing.Point(916, 242);
            this.contacttitleProductTxt.Name = "contacttitleProductTxt";
            this.contacttitleProductTxt.Size = new System.Drawing.Size(125, 27);
            this.contacttitleProductTxt.TabIndex = 89;
            // 
            // contactnameProductTxt
            // 
            this.contactnameProductTxt.Location = new System.Drawing.Point(916, 195);
            this.contactnameProductTxt.Name = "contactnameProductTxt";
            this.contactnameProductTxt.Size = new System.Drawing.Size(125, 27);
            this.contactnameProductTxt.TabIndex = 90;
            // 
            // companynameProductTxt
            // 
            this.companynameProductTxt.Location = new System.Drawing.Point(916, 155);
            this.companynameProductTxt.Name = "companynameProductTxt";
            this.companynameProductTxt.Size = new System.Drawing.Size(125, 27);
            this.companynameProductTxt.TabIndex = 91;
            // 
            // regionProductTxt
            // 
            this.regionProductTxt.Location = new System.Drawing.Point(1200, 198);
            this.regionProductTxt.Name = "regionProductTxt";
            this.regionProductTxt.Size = new System.Drawing.Size(125, 27);
            this.regionProductTxt.TabIndex = 92;
            // 
            // cityProductTxt
            // 
            this.cityProductTxt.Location = new System.Drawing.Point(1200, 158);
            this.cityProductTxt.Name = "cityProductTxt";
            this.cityProductTxt.Size = new System.Drawing.Size(125, 27);
            this.cityProductTxt.TabIndex = 93;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1131, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 20);
            this.label21.TabIndex = 94;
            this.label21.Text = "Phone :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1127, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 20);
            this.label22.TabIndex = 95;
            this.label22.Text = "Country :";
            // 
            // phoneProductTxt
            // 
            this.phoneProductTxt.Location = new System.Drawing.Point(1200, 285);
            this.phoneProductTxt.Name = "phoneProductTxt";
            this.phoneProductTxt.Size = new System.Drawing.Size(125, 27);
            this.phoneProductTxt.TabIndex = 96;
            // 
            // countryProductTxt
            // 
            this.countryProductTxt.Location = new System.Drawing.Point(1200, 242);
            this.countryProductTxt.Name = "countryProductTxt";
            this.countryProductTxt.Size = new System.Drawing.Size(125, 27);
            this.countryProductTxt.TabIndex = 97;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(53, 271);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 20);
            this.label23.TabIndex = 98;
            this.label23.Text = "Id :";
            // 
            // IdProductCategoryTxt
            // 
            this.IdProductCategoryTxt.Location = new System.Drawing.Point(88, 268);
            this.IdProductCategoryTxt.Name = "IdProductCategoryTxt";
            this.IdProductCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.IdProductCategoryTxt.TabIndex = 99;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(142, 314);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 20);
            this.label24.TabIndex = 100;
            this.label24.Text = "Name :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(233, 271);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 20);
            this.label25.TabIndex = 101;
            this.label25.Text = "Description :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(206, 242);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 20);
            this.label26.TabIndex = 102;
            this.label26.Text = "Category";
            // 
            // descriptionProductCategoryTxt
            // 
            this.descriptionProductCategoryTxt.Location = new System.Drawing.Point(331, 268);
            this.descriptionProductCategoryTxt.Name = "descriptionProductCategoryTxt";
            this.descriptionProductCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.descriptionProductCategoryTxt.TabIndex = 103;
            // 
            // nameProductCategoryTxt
            // 
            this.nameProductCategoryTxt.Location = new System.Drawing.Point(206, 311);
            this.nameProductCategoryTxt.Name = "nameProductCategoryTxt";
            this.nameProductCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.nameProductCategoryTxt.TabIndex = 104;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 755);
            this.Controls.Add(this.nameProductCategoryTxt);
            this.Controls.Add(this.descriptionProductCategoryTxt);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.IdProductCategoryTxt);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.countryProductTxt);
            this.Controls.Add(this.phoneProductTxt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cityProductTxt);
            this.Controls.Add(this.regionProductTxt);
            this.Controls.Add(this.companynameProductTxt);
            this.Controls.Add(this.contactnameProductTxt);
            this.Controls.Add(this.contacttitleProductTxt);
            this.Controls.Add(this.streetProductTxt);
            this.Controls.Add(this.IdsupplierProductTxt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nameProductTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.discontinuedcheckBoxProduct);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reorderlevelProductTxt);
            this.Controls.Add(this.categoryIdProductTxt);
            this.Controls.Add(this.unitpriceProductTxt);
            this.Controls.Add(this.unitinstockProductTxt);
            this.Controls.Add(this.unitsonorderProductTxt);
            this.Controls.Add(this.quantityperunitProductTxt);
            this.Controls.Add(this.supplierIdProductTxt);
            this.Controls.Add(this.IdProductTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdDeleteProductTxt);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdGetByProductTxt);
            this.Controls.Add(this.GetByIdProductBtn);
            this.Controls.Add(this.GetAllProductBtn);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddProductBtn;
        private Button UpdateProductBtn;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox reorderlevelProductTxt;
        private TextBox categoryIdProductTxt;
        private TextBox unitpriceProductTxt;
        private TextBox unitinstockProductTxt;
        private TextBox unitsonorderProductTxt;
        private TextBox quantityperunitProductTxt;
        private TextBox supplierIdProductTxt;
        private TextBox IdProductTxt;
        private Label label2;
        private TextBox IdDeleteProductTxt;
        private Button ProductDeleteBtn;
        private DataGridView dataGridViewProduct;
        private Label label1;
        private TextBox IdGetByProductTxt;
        private Button GetByIdProductBtn;
        private Button GetAllProductBtn;
        private CheckBox discontinuedcheckBoxProduct;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox nameProductTxt;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox IdsupplierProductTxt;
        private TextBox streetProductTxt;
        private TextBox contacttitleProductTxt;
        private TextBox contactnameProductTxt;
        private TextBox companynameProductTxt;
        private TextBox regionProductTxt;
        private TextBox cityProductTxt;
        private Label label21;
        private Label label22;
        private TextBox phoneProductTxt;
        private TextBox countryProductTxt;
        private Label label23;
        private TextBox IdProductCategoryTxt;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox descriptionProductCategoryTxt;
        private TextBox nameProductCategoryTxt;
    }
}