namespace WindowsFormUI
{
    partial class SupplierForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.phoneSupplierTxt = new System.Windows.Forms.TextBox();
            this.AddSupplierBtn = new System.Windows.Forms.Button();
            this.UpdateSupplierBtn = new System.Windows.Forms.Button();
            this.CountrySupplierTxt = new System.Windows.Forms.TextBox();
            this.RegionSupplierTxt = new System.Windows.Forms.TextBox();
            this.CitySupplierTxt = new System.Windows.Forms.TextBox();
            this.StreetSupplierTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.titleEmployeeLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameEmployeeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactnameSupplierTxt = new System.Windows.Forms.TextBox();
            this.contacttitleSupplierTxt = new System.Windows.Forms.TextBox();
            this.companynameSupplierTxt = new System.Windows.Forms.TextBox();
            this.IdSupplierTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdDeleteSupplierTxt = new System.Windows.Forms.TextBox();
            this.DeleteSupplierBtn = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdGetBySupplierTxt = new System.Windows.Forms.TextBox();
            this.GetByIdSupplierBtn = new System.Windows.Forms.Button();
            this.GetAllSupplierBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "Phone :";
            // 
            // phoneSupplierTxt
            // 
            this.phoneSupplierTxt.Location = new System.Drawing.Point(899, 147);
            this.phoneSupplierTxt.Name = "phoneSupplierTxt";
            this.phoneSupplierTxt.Size = new System.Drawing.Size(98, 27);
            this.phoneSupplierTxt.TabIndex = 113;
            // 
            // AddSupplierBtn
            // 
            this.AddSupplierBtn.Location = new System.Drawing.Point(827, 184);
            this.AddSupplierBtn.Name = "AddSupplierBtn";
            this.AddSupplierBtn.Size = new System.Drawing.Size(85, 35);
            this.AddSupplierBtn.TabIndex = 112;
            this.AddSupplierBtn.Text = "Ekle";
            this.AddSupplierBtn.UseVisualStyleBackColor = true;
            this.AddSupplierBtn.Click += new System.EventHandler(this.AddSupplierBtn_Click);
            // 
            // UpdateSupplierBtn
            // 
            this.UpdateSupplierBtn.Location = new System.Drawing.Point(919, 184);
            this.UpdateSupplierBtn.Name = "UpdateSupplierBtn";
            this.UpdateSupplierBtn.Size = new System.Drawing.Size(79, 35);
            this.UpdateSupplierBtn.TabIndex = 111;
            this.UpdateSupplierBtn.Text = "Güncelle";
            this.UpdateSupplierBtn.UseVisualStyleBackColor = true;
            this.UpdateSupplierBtn.Click += new System.EventHandler(this.UpdateSupplierBtn_Click);
            // 
            // CountrySupplierTxt
            // 
            this.CountrySupplierTxt.Location = new System.Drawing.Point(899, 104);
            this.CountrySupplierTxt.Name = "CountrySupplierTxt";
            this.CountrySupplierTxt.Size = new System.Drawing.Size(98, 27);
            this.CountrySupplierTxt.TabIndex = 110;
            // 
            // RegionSupplierTxt
            // 
            this.RegionSupplierTxt.Location = new System.Drawing.Point(681, 183);
            this.RegionSupplierTxt.Name = "RegionSupplierTxt";
            this.RegionSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.RegionSupplierTxt.TabIndex = 109;
            // 
            // CitySupplierTxt
            // 
            this.CitySupplierTxt.Location = new System.Drawing.Point(681, 141);
            this.CitySupplierTxt.Name = "CitySupplierTxt";
            this.CitySupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.CitySupplierTxt.TabIndex = 108;
            // 
            // StreetSupplierTxt
            // 
            this.StreetSupplierTxt.Location = new System.Drawing.Point(681, 100);
            this.StreetSupplierTxt.Name = "StreetSupplierTxt";
            this.StreetSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.StreetSupplierTxt.TabIndex = 107;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(625, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 106;
            this.label17.Text = "Street :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(634, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 105;
            this.label16.Text = "City :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(617, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 104;
            this.label15.Text = "Region :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(827, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "Country :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(787, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 102;
            this.label12.Text = "Address";
            // 
            // titleEmployeeLabel
            // 
            this.titleEmployeeLabel.AutoSize = true;
            this.titleEmployeeLabel.Location = new System.Drawing.Point(341, 97);
            this.titleEmployeeLabel.Name = "titleEmployeeLabel";
            this.titleEmployeeLabel.Size = new System.Drawing.Size(100, 20);
            this.titleEmployeeLabel.TabIndex = 98;
            this.titleEmployeeLabel.Text = "Contact Title :";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(30, 188);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(111, 20);
            this.firstnameLabel.TabIndex = 97;
            this.firstnameLabel.Text = "Contact Name :";
            this.firstnameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastnameEmployeeLabel
            // 
            this.lastnameEmployeeLabel.AutoSize = true;
            this.lastnameEmployeeLabel.Location = new System.Drawing.Point(18, 147);
            this.lastnameEmployeeLabel.Name = "lastnameEmployeeLabel";
            this.lastnameEmployeeLabel.Size = new System.Drawing.Size(123, 20);
            this.lastnameEmployeeLabel.TabIndex = 96;
            this.lastnameEmployeeLabel.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Id :";
            // 
            // contactnameSupplierTxt
            // 
            this.contactnameSupplierTxt.Location = new System.Drawing.Point(147, 185);
            this.contactnameSupplierTxt.Name = "contactnameSupplierTxt";
            this.contactnameSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.contactnameSupplierTxt.TabIndex = 94;
            // 
            // contacttitleSupplierTxt
            // 
            this.contacttitleSupplierTxt.Location = new System.Drawing.Point(447, 94);
            this.contacttitleSupplierTxt.Name = "contacttitleSupplierTxt";
            this.contacttitleSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.contacttitleSupplierTxt.TabIndex = 90;
            // 
            // companynameSupplierTxt
            // 
            this.companynameSupplierTxt.Location = new System.Drawing.Point(147, 144);
            this.companynameSupplierTxt.Name = "companynameSupplierTxt";
            this.companynameSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.companynameSupplierTxt.TabIndex = 89;
            // 
            // IdSupplierTxt
            // 
            this.IdSupplierTxt.Location = new System.Drawing.Point(147, 101);
            this.IdSupplierTxt.Name = "IdSupplierTxt";
            this.IdSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.IdSupplierTxt.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Silenecek Verinin Id si :";
            // 
            // IdDeleteSupplierTxt
            // 
            this.IdDeleteSupplierTxt.Location = new System.Drawing.Point(869, 31);
            this.IdDeleteSupplierTxt.Name = "IdDeleteSupplierTxt";
            this.IdDeleteSupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.IdDeleteSupplierTxt.TabIndex = 86;
            // 
            // DeleteSupplierBtn
            // 
            this.DeleteSupplierBtn.Location = new System.Drawing.Point(1023, 25);
            this.DeleteSupplierBtn.Name = "DeleteSupplierBtn";
            this.DeleteSupplierBtn.Size = new System.Drawing.Size(114, 36);
            this.DeleteSupplierBtn.TabIndex = 85;
            this.DeleteSupplierBtn.Text = "Sil";
            this.DeleteSupplierBtn.UseVisualStyleBackColor = true;
            this.DeleteSupplierBtn.Click += new System.EventHandler(this.DeleteSupplierBtn_Click);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(13, 235);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.RowTemplate.Height = 29;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(1165, 323);
            this.dataGridViewSupplier.TabIndex = 84;
            this.dataGridViewSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Id : ";
            // 
            // IdGetBySupplierTxt
            // 
            this.IdGetBySupplierTxt.Location = new System.Drawing.Point(304, 31);
            this.IdGetBySupplierTxt.Name = "IdGetBySupplierTxt";
            this.IdGetBySupplierTxt.Size = new System.Drawing.Size(125, 27);
            this.IdGetBySupplierTxt.TabIndex = 82;
            // 
            // GetByIdSupplierBtn
            // 
            this.GetByIdSupplierBtn.Location = new System.Drawing.Point(455, 25);
            this.GetByIdSupplierBtn.Name = "GetByIdSupplierBtn";
            this.GetByIdSupplierBtn.Size = new System.Drawing.Size(184, 36);
            this.GetByIdSupplierBtn.TabIndex = 81;
            this.GetByIdSupplierBtn.Text = "ID ye Göre Siparişi Getir";
            this.GetByIdSupplierBtn.UseVisualStyleBackColor = true;
            this.GetByIdSupplierBtn.Click += new System.EventHandler(this.GetByIdSupplierBtn_Click);
            // 
            // GetAllSupplierBtn
            // 
            this.GetAllSupplierBtn.Location = new System.Drawing.Point(56, 17);
            this.GetAllSupplierBtn.Name = "GetAllSupplierBtn";
            this.GetAllSupplierBtn.Size = new System.Drawing.Size(171, 52);
            this.GetAllSupplierBtn.TabIndex = 80;
            this.GetAllSupplierBtn.Text = "Tüm Verileri Getir";
            this.GetAllSupplierBtn.UseVisualStyleBackColor = true;
            this.GetAllSupplierBtn.Click += new System.EventHandler(this.GetAllSupplierBtn_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneSupplierTxt);
            this.Controls.Add(this.AddSupplierBtn);
            this.Controls.Add(this.UpdateSupplierBtn);
            this.Controls.Add(this.CountrySupplierTxt);
            this.Controls.Add(this.RegionSupplierTxt);
            this.Controls.Add(this.CitySupplierTxt);
            this.Controls.Add(this.StreetSupplierTxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.titleEmployeeLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.lastnameEmployeeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactnameSupplierTxt);
            this.Controls.Add(this.contacttitleSupplierTxt);
            this.Controls.Add(this.companynameSupplierTxt);
            this.Controls.Add(this.IdSupplierTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdDeleteSupplierTxt);
            this.Controls.Add(this.DeleteSupplierBtn);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdGetBySupplierTxt);
            this.Controls.Add(this.GetByIdSupplierBtn);
            this.Controls.Add(this.GetAllSupplierBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private TextBox phoneSupplierTxt;
        private Button AddSupplierBtn;
        private Button UpdateSupplierBtn;
        private TextBox CountrySupplierTxt;
        private TextBox RegionSupplierTxt;
        private TextBox CitySupplierTxt;
        private TextBox StreetSupplierTxt;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private Label titleEmployeeLabel;
        private Label firstnameLabel;
        private Label lastnameEmployeeLabel;
        private Label label3;
        private TextBox contactnameSupplierTxt;
        private TextBox contacttitleSupplierTxt;
        private TextBox companynameSupplierTxt;
        private TextBox IdSupplierTxt;
        private Label label2;
        private TextBox IdDeleteSupplierTxt;
        private Button DeleteSupplierBtn;
        private DataGridView dataGridViewSupplier;
        private Label label1;
        private TextBox IdGetBySupplierTxt;
        private Button GetByIdSupplierBtn;
        private Button GetAllSupplierBtn;
    }
}