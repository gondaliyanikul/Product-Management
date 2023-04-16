namespace DbTest
{
    partial class AddProduct
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.saleRateLabel = new System.Windows.Forms.Label();
            this.purchaseRateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.SaleRateTxt = new System.Windows.Forms.TextBox();
            this.PurcharseRateTxt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.CompanyTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.ForeColor = System.Drawing.Color.Black;
            this.addProductLabel.Location = new System.Drawing.Point(243, 78);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(201, 29);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add New Product";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(79, 144);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(136, 25);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            // 
            // saleRateLabel
            // 
            this.saleRateLabel.AutoSize = true;
            this.saleRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRateLabel.Location = new System.Drawing.Point(79, 202);
            this.saleRateLabel.Name = "saleRateLabel";
            this.saleRateLabel.Size = new System.Drawing.Size(97, 25);
            this.saleRateLabel.TabIndex = 1;
            this.saleRateLabel.Text = "Sale Rate";
            // 
            // purchaseRateLabel
            // 
            this.purchaseRateLabel.AutoSize = true;
            this.purchaseRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseRateLabel.Location = new System.Drawing.Point(79, 263);
            this.purchaseRateLabel.Name = "purchaseRateLabel";
            this.purchaseRateLabel.Size = new System.Drawing.Size(140, 25);
            this.purchaseRateLabel.TabIndex = 1;
            this.purchaseRateLabel.Text = "Purchase Rate";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(79, 319);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 25);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(79, 378);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(97, 25);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Company";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(79, 434);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.White;
            this.ProductNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(266, 141);
            this.ProductNameTxt.Multiline = true;
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(340, 28);
            this.ProductNameTxt.TabIndex = 0;
            this.ProductNameTxt.TextChanged += new System.EventHandler(this.ProductNameTxt_TextChanged);
            this.ProductNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameTxt_KeyPress);
            // 
            // SaleRateTxt
            // 
            this.SaleRateTxt.BackColor = System.Drawing.Color.White;
            this.SaleRateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleRateTxt.Location = new System.Drawing.Point(266, 199);
            this.SaleRateTxt.Multiline = true;
            this.SaleRateTxt.Name = "SaleRateTxt";
            this.SaleRateTxt.Size = new System.Drawing.Size(340, 28);
            this.SaleRateTxt.TabIndex = 1;
            this.SaleRateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaleRateTxt_KeyPress);
            // 
            // PurcharseRateTxt
            // 
            this.PurcharseRateTxt.BackColor = System.Drawing.Color.White;
            this.PurcharseRateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurcharseRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurcharseRateTxt.Location = new System.Drawing.Point(266, 260);
            this.PurcharseRateTxt.Multiline = true;
            this.PurcharseRateTxt.Name = "PurcharseRateTxt";
            this.PurcharseRateTxt.Size = new System.Drawing.Size(340, 28);
            this.PurcharseRateTxt.TabIndex = 2;
            this.PurcharseRateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurcharseRateTxt_KeyPress);
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.BackColor = System.Drawing.Color.White;
            this.QuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxt.Location = new System.Drawing.Point(266, 316);
            this.QuantityTxt.Multiline = true;
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(340, 28);
            this.QuantityTxt.TabIndex = 3;
            this.QuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTxt_KeyPress);
            // 
            // CompanyTxt
            // 
            this.CompanyTxt.BackColor = System.Drawing.Color.White;
            this.CompanyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTxt.Location = new System.Drawing.Point(266, 375);
            this.CompanyTxt.Multiline = true;
            this.CompanyTxt.Name = "CompanyTxt";
            this.CompanyTxt.Size = new System.Drawing.Size(340, 28);
            this.CompanyTxt.TabIndex = 4;
            this.CompanyTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompanyTxt_KeyPress);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BackColor = System.Drawing.Color.White;
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxt.Location = new System.Drawing.Point(266, 431);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(340, 28);
            this.DescriptionTxt.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(266, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(266, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(266, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 2);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(266, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 2);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(266, 402);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 2);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(266, 458);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 2);
            this.panel6.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = global::DbTest.Properties.Resources.Cancel;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(455, 496);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CloseBtn.Size = new System.Drawing.Size(151, 41);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.Image = global::DbTest.Properties.Resources.Add;
            this.AddProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductBtn.Location = new System.Drawing.Point(266, 496);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AddProductBtn.Size = new System.Drawing.Size(161, 41);
            this.AddProductBtn.TabIndex = 6;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, -1);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(688, 50);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 555);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.CompanyTxt);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.PurcharseRateTxt);
            this.Controls.Add(this.SaleRateTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.purchaseRateLabel);
            this.Controls.Add(this.saleRateLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.addProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label saleRateLabel;
        private System.Windows.Forms.Label purchaseRateLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox SaleRateTxt;
        private System.Windows.Forms.TextBox PurcharseRateTxt;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.TextBox CompanyTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label companyNameLabel;
    }
}