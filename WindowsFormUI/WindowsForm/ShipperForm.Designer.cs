namespace WindowsFormUI
{
    partial class ShipperForm
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
            this.UpdateShipperBtn = new System.Windows.Forms.Button();
            this.AddShipperBtn = new System.Windows.Forms.Button();
            this.descriptionCategoryTxt = new System.Windows.Forms.TextBox();
            this.companynameShipperTxt = new System.Windows.Forms.TextBox();
            this.IdShipperTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneShipperTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewShipper = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IdDeleteShipperTxt = new System.Windows.Forms.TextBox();
            this.DeleteShipperBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdGetByShipperTxt = new System.Windows.Forms.TextBox();
            this.GetByIdShipperBtn = new System.Windows.Forms.Button();
            this.GetAllShipperBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateShipperBtn
            // 
            this.UpdateShipperBtn.Location = new System.Drawing.Point(999, 120);
            this.UpdateShipperBtn.Name = "UpdateShipperBtn";
            this.UpdateShipperBtn.Size = new System.Drawing.Size(114, 36);
            this.UpdateShipperBtn.TabIndex = 110;
            this.UpdateShipperBtn.Text = "Güncelle";
            this.UpdateShipperBtn.UseVisualStyleBackColor = true;
            this.UpdateShipperBtn.Click += new System.EventHandler(this.UpdateShipperBtn_Click);
            // 
            // AddShipperBtn
            // 
            this.AddShipperBtn.Location = new System.Drawing.Point(870, 120);
            this.AddShipperBtn.Name = "AddShipperBtn";
            this.AddShipperBtn.Size = new System.Drawing.Size(114, 36);
            this.AddShipperBtn.TabIndex = 109;
            this.AddShipperBtn.Text = "Ekle";
            this.AddShipperBtn.UseVisualStyleBackColor = true;
            this.AddShipperBtn.Click += new System.EventHandler(this.AddShipperBtn_Click);
            // 
            // descriptionCategoryTxt
            // 
            this.descriptionCategoryTxt.Location = new System.Drawing.Point(672, 122);
            this.descriptionCategoryTxt.Name = "descriptionCategoryTxt";
            this.descriptionCategoryTxt.Size = new System.Drawing.Size(125, 27);
            this.descriptionCategoryTxt.TabIndex = 108;
            // 
            // companynameShipperTxt
            // 
            this.companynameShipperTxt.Location = new System.Drawing.Point(426, 125);
            this.companynameShipperTxt.Name = "companynameShipperTxt";
            this.companynameShipperTxt.Size = new System.Drawing.Size(125, 27);
            this.companynameShipperTxt.TabIndex = 107;
            // 
            // IdShipperTxt
            // 
            this.IdShipperTxt.Location = new System.Drawing.Point(133, 122);
            this.IdShipperTxt.Name = "IdShipperTxt";
            this.IdShipperTxt.Size = new System.Drawing.Size(125, 27);
            this.IdShipperTxt.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Company Name : ";
            // 
            // phoneShipperTxt
            // 
            this.phoneShipperTxt.AutoSize = true;
            this.phoneShipperTxt.Location = new System.Drawing.Point(609, 125);
            this.phoneShipperTxt.Name = "phoneShipperTxt";
            this.phoneShipperTxt.Size = new System.Drawing.Size(57, 20);
            this.phoneShipperTxt.TabIndex = 104;
            this.phoneShipperTxt.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Id : ";
            // 
            // dataGridViewShipper
            // 
            this.dataGridViewShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShipper.Location = new System.Drawing.Point(46, 168);
            this.dataGridViewShipper.Name = "dataGridViewShipper";
            this.dataGridViewShipper.RowHeadersWidth = 51;
            this.dataGridViewShipper.RowTemplate.Height = 29;
            this.dataGridViewShipper.Size = new System.Drawing.Size(1099, 342);
            this.dataGridViewShipper.TabIndex = 102;
            this.dataGridViewShipper.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShipper_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Silenecek Verinin Id si :";
            // 
            // IdDeleteShipperTxt
            // 
            this.IdDeleteShipperTxt.Location = new System.Drawing.Point(884, 49);
            this.IdDeleteShipperTxt.Name = "IdDeleteShipperTxt";
            this.IdDeleteShipperTxt.Size = new System.Drawing.Size(125, 27);
            this.IdDeleteShipperTxt.TabIndex = 100;
            // 
            // DeleteShipperBtn
            // 
            this.DeleteShipperBtn.Location = new System.Drawing.Point(1031, 46);
            this.DeleteShipperBtn.Name = "DeleteShipperBtn";
            this.DeleteShipperBtn.Size = new System.Drawing.Size(114, 36);
            this.DeleteShipperBtn.TabIndex = 99;
            this.DeleteShipperBtn.Text = "Sil";
            this.DeleteShipperBtn.UseVisualStyleBackColor = true;
            this.DeleteShipperBtn.Click += new System.EventHandler(this.DeleteShipperBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Id : ";
            // 
            // IdGetByShipperTxt
            // 
            this.IdGetByShipperTxt.Location = new System.Drawing.Point(324, 50);
            this.IdGetByShipperTxt.Name = "IdGetByShipperTxt";
            this.IdGetByShipperTxt.Size = new System.Drawing.Size(125, 27);
            this.IdGetByShipperTxt.TabIndex = 97;
            // 
            // GetByIdShipperBtn
            // 
            this.GetByIdShipperBtn.Location = new System.Drawing.Point(474, 44);
            this.GetByIdShipperBtn.Name = "GetByIdShipperBtn";
            this.GetByIdShipperBtn.Size = new System.Drawing.Size(184, 36);
            this.GetByIdShipperBtn.TabIndex = 96;
            this.GetByIdShipperBtn.Text = "ID ye Göre Siparişi Getir";
            this.GetByIdShipperBtn.UseVisualStyleBackColor = true;
            this.GetByIdShipperBtn.Click += new System.EventHandler(this.GetByIdShipperBtn_Click);
            // 
            // GetAllShipperBtn
            // 
            this.GetAllShipperBtn.Location = new System.Drawing.Point(46, 36);
            this.GetAllShipperBtn.Name = "GetAllShipperBtn";
            this.GetAllShipperBtn.Size = new System.Drawing.Size(171, 52);
            this.GetAllShipperBtn.TabIndex = 95;
            this.GetAllShipperBtn.Text = "Tüm Verileri Getir";
            this.GetAllShipperBtn.UseVisualStyleBackColor = true;
            this.GetAllShipperBtn.Click += new System.EventHandler(this.GetAllShipperBtn_Click);
            // 
            // ShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 546);
            this.Controls.Add(this.UpdateShipperBtn);
            this.Controls.Add(this.AddShipperBtn);
            this.Controls.Add(this.descriptionCategoryTxt);
            this.Controls.Add(this.companynameShipperTxt);
            this.Controls.Add(this.IdShipperTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneShipperTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewShipper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdDeleteShipperTxt);
            this.Controls.Add(this.DeleteShipperBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdGetByShipperTxt);
            this.Controls.Add(this.GetByIdShipperBtn);
            this.Controls.Add(this.GetAllShipperBtn);
            this.Name = "ShipperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipperForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateShipperBtn;
        private Button AddShipperBtn;
        private TextBox descriptionCategoryTxt;
        private TextBox companynameShipperTxt;
        private TextBox IdShipperTxt;
        private Label label5;
        private Label phoneShipperTxt;
        private Label label3;
        private DataGridView dataGridViewShipper;
        private Label label2;
        private TextBox IdDeleteShipperTxt;
        private Button DeleteShipperBtn;
        private Label label1;
        private TextBox IdGetByShipperTxt;
        private Button GetByIdShipperBtn;
        private Button GetAllShipperBtn;
    }
}