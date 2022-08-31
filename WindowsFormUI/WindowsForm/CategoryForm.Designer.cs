namespace WindowsFormUI
{
    partial class CategoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.IdDeleteCategoryTxt = new System.Windows.Forms.TextBox();
            this.CategoryDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdGetByCategoryTxt = new System.Windows.Forms.TextBox();
            this.GetByIdCategoryBtn = new System.Windows.Forms.Button();
            this.GetAllCategoryBtn = new System.Windows.Forms.Button();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdCategoryTxt = new System.Windows.Forms.TextBox();
            this.nameCategoryTxt = new System.Windows.Forms.TextBox();
            this.descriptionCategoryTxt = new System.Windows.Forms.TextBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.UpdateCategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Silenecek Verinin Id si :";
            // 
            // IdDeleteCategoryTxt
            // 
            this.IdDeleteCategoryTxt.Location = new System.Drawing.Point(894, 50);
            this.IdDeleteCategoryTxt.Name = "IdDeleteCategoryTxt";
            this.IdDeleteCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.IdDeleteCategoryTxt.TabIndex = 84;
            // 
            // CategoryDeleteBtn
            // 
            this.CategoryDeleteBtn.Location = new System.Drawing.Point(1041, 47);
            this.CategoryDeleteBtn.Name = "CategoryDeleteBtn";
            this.CategoryDeleteBtn.Size = new System.Drawing.Size(114, 36);
            this.CategoryDeleteBtn.TabIndex = 83;
            this.CategoryDeleteBtn.Text = "Sil";
            this.CategoryDeleteBtn.UseVisualStyleBackColor = true;
            this.CategoryDeleteBtn.Click += new System.EventHandler(this.CategoryDeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Id : ";
            // 
            // IdGetByCategoryTxt
            // 
            this.IdGetByCategoryTxt.Location = new System.Drawing.Point(334, 51);
            this.IdGetByCategoryTxt.Name = "IdGetByCategoryTxt";
            this.IdGetByCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.IdGetByCategoryTxt.TabIndex = 81;
            // 
            // GetByIdCategoryBtn
            // 
            this.GetByIdCategoryBtn.Location = new System.Drawing.Point(484, 45);
            this.GetByIdCategoryBtn.Name = "GetByIdCategoryBtn";
            this.GetByIdCategoryBtn.Size = new System.Drawing.Size(184, 36);
            this.GetByIdCategoryBtn.TabIndex = 80;
            this.GetByIdCategoryBtn.Text = "ID ye Göre Siparişi Getir";
            this.GetByIdCategoryBtn.UseVisualStyleBackColor = true;
            this.GetByIdCategoryBtn.Click += new System.EventHandler(this.GetByIdCategoryBtn_Click);
            // 
            // GetAllCategoryBtn
            // 
            this.GetAllCategoryBtn.Location = new System.Drawing.Point(56, 37);
            this.GetAllCategoryBtn.Name = "GetAllCategoryBtn";
            this.GetAllCategoryBtn.Size = new System.Drawing.Size(171, 52);
            this.GetAllCategoryBtn.TabIndex = 79;
            this.GetAllCategoryBtn.Text = "Tüm Verileri Getir";
            this.GetAllCategoryBtn.UseVisualStyleBackColor = true;
            this.GetAllCategoryBtn.Click += new System.EventHandler(this.GetAllCategoryBtn_Click);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(56, 169);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 29;
            this.dataGridViewCategory.Size = new System.Drawing.Size(1099, 342);
            this.dataGridViewCategory.TabIndex = 86;
            this.dataGridViewCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Id : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Description : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Name : ";
            // 
            // IdCategoryTxt
            // 
            this.IdCategoryTxt.Location = new System.Drawing.Point(143, 123);
            this.IdCategoryTxt.Name = "IdCategoryTxt";
            this.IdCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.IdCategoryTxt.TabIndex = 90;
            // 
            // nameCategoryTxt
            // 
            this.nameCategoryTxt.Location = new System.Drawing.Point(379, 123);
            this.nameCategoryTxt.Name = "nameCategoryTxt";
            this.nameCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.nameCategoryTxt.TabIndex = 91;
            // 
            // descriptionCategoryTxt
            // 
            this.descriptionCategoryTxt.Location = new System.Drawing.Point(641, 123);
            this.descriptionCategoryTxt.Name = "descriptionCategoryTxt";
            this.descriptionCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.descriptionCategoryTxt.TabIndex = 92;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(867, 118);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(114, 36);
            this.AddCategoryBtn.TabIndex = 93;
            this.AddCategoryBtn.Text = "Ekle";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // UpdateCategoryBtn
            // 
            this.UpdateCategoryBtn.Location = new System.Drawing.Point(1008, 118);
            this.UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            this.UpdateCategoryBtn.Size = new System.Drawing.Size(114, 36);
            this.UpdateCategoryBtn.TabIndex = 94;
            this.UpdateCategoryBtn.Text = "Güncelle";
            this.UpdateCategoryBtn.UseVisualStyleBackColor = true;
            this.UpdateCategoryBtn.Click += new System.EventHandler(this.UpdateCategoryBtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 546);
            this.Controls.Add(this.UpdateCategoryBtn);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.descriptionCategoryTxt);
            this.Controls.Add(this.nameCategoryTxt);
            this.Controls.Add(this.IdCategoryTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdDeleteCategoryTxt);
            this.Controls.Add(this.CategoryDeleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdGetByCategoryTxt);
            this.Controls.Add(this.GetByIdCategoryBtn);
            this.Controls.Add(this.GetAllCategoryBtn);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox IdDeleteCategoryTxt;
        private Button CategoryDeleteBtn;
        private Label label1;
        private TextBox IdGetByCategoryTxt;
        private Button GetByIdCategoryBtn;
        private Button GetAllCategoryBtn;
        private DataGridView dataGridViewCategory;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IdCategoryTxt;
        private TextBox nameCategoryTxt;
        private TextBox descriptionCategoryTxt;
        private Button AddCategoryBtn;
        private Button UpdateCategoryBtn;
    }
}