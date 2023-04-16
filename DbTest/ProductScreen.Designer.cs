namespace DbTest
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.orderNmLabel = new System.Windows.Forms.Label();
            this.customerNmLabel = new System.Windows.Forms.Label();
            this.transactonDeteLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.orderNumberTxt = new System.Windows.Forms.TextBox();
            this.productNmLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.quanttyLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.companyCombo = new System.Windows.Forms.ComboBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.unitPriceTxt = new System.Windows.Forms.TextBox();
            this.availableTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.productSaleTable = new System.Windows.Forms.DataGridView();
            this.discountLabel = new System.Windows.Forms.Label();
            this.cgstLabel = new System.Windows.Forms.Label();
            this.sgstLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalPayLabel = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.sgstTxt = new System.Windows.Forms.TextBox();
            this.cgstTxt = new System.Windows.Forms.TextBox();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.totalPayTxt = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.paymentTypeCombo = new System.Windows.Forms.ComboBox();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.printOrderBtn = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewOrder = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpainOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDateTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNmLabel
            // 
            this.orderNmLabel.AutoSize = true;
            this.orderNmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNmLabel.Location = new System.Drawing.Point(41, 108);
            this.orderNmLabel.Name = "orderNmLabel";
            this.orderNmLabel.Size = new System.Drawing.Size(109, 20);
            this.orderNmLabel.TabIndex = 0;
            this.orderNmLabel.Text = "Order Number";
            // 
            // customerNmLabel
            // 
            this.customerNmLabel.AutoSize = true;
            this.customerNmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNmLabel.Location = new System.Drawing.Point(41, 162);
            this.customerNmLabel.Name = "customerNmLabel";
            this.customerNmLabel.Size = new System.Drawing.Size(124, 20);
            this.customerNmLabel.TabIndex = 0;
            this.customerNmLabel.Text = "Customer Name";
            // 
            // transactonDeteLabel
            // 
            this.transactonDeteLabel.AutoSize = true;
            this.transactonDeteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactonDeteLabel.Location = new System.Drawing.Point(539, 111);
            this.transactonDeteLabel.Name = "transactonDeteLabel";
            this.transactonDeteLabel.Size = new System.Drawing.Size(131, 20);
            this.transactonDeteLabel.TabIndex = 0;
            this.transactonDeteLabel.Text = "Transaction Date";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(539, 165);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.paymentTypeLabel.TabIndex = 0;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // orderNumberTxt
            // 
            this.orderNumberTxt.BackColor = System.Drawing.Color.White;
            this.orderNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberTxt.Location = new System.Drawing.Point(206, 108);
            this.orderNumberTxt.Name = "orderNumberTxt";
            this.orderNumberTxt.ReadOnly = true;
            this.orderNumberTxt.Size = new System.Drawing.Size(250, 20);
            this.orderNumberTxt.TabIndex = 55;
            // 
            // productNmLabel
            // 
            this.productNmLabel.AutoSize = true;
            this.productNmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNmLabel.Location = new System.Drawing.Point(41, 214);
            this.productNmLabel.Name = "productNmLabel";
            this.productNmLabel.Size = new System.Drawing.Size(110, 20);
            this.productNmLabel.TabIndex = 0;
            this.productNmLabel.Text = "Product Name";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(270, 213);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(76, 20);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company";
            // 
            // quanttyLabel
            // 
            this.quanttyLabel.AutoSize = true;
            this.quanttyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanttyLabel.Location = new System.Drawing.Point(836, 213);
            this.quanttyLabel.Name = "quanttyLabel";
            this.quanttyLabel.Size = new System.Drawing.Size(68, 20);
            this.quanttyLabel.TabIndex = 0;
            this.quanttyLabel.Text = "Quantity";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.Location = new System.Drawing.Point(490, 212);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.unitPriceLabel.TabIndex = 0;
            this.unitPriceLabel.Text = "Price";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.Location = new System.Drawing.Point(649, 212);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(72, 20);
            this.availableLabel.TabIndex = 0;
            this.availableLabel.Text = "Available";
            // 
            // productCombo
            // 
            this.productCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productCombo.BackColor = System.Drawing.Color.White;
            this.productCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(45, 251);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(150, 28);
            this.productCombo.TabIndex = 2;
            this.productCombo.SelectedIndexChanged += new System.EventHandler(this.productCombo_SelectedIndexChanged);
            // 
            // companyCombo
            // 
            this.companyCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyCombo.BackColor = System.Drawing.Color.White;
            this.companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyCombo.FormattingEnabled = true;
            this.companyCombo.Location = new System.Drawing.Point(241, 251);
            this.companyCombo.Name = "companyCombo";
            this.companyCombo.Size = new System.Drawing.Size(150, 28);
            this.companyCombo.TabIndex = 3;
            this.companyCombo.SelectedIndexChanged += new System.EventHandler(this.companyCombo_SelectedIndexChanged);
            this.companyCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.companyCombo_MouseClick);
            // 
            // quantityTxt
            // 
            this.quantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(812, 251);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(150, 20);
            this.quantityTxt.TabIndex = 4;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitPriceTxt
            // 
            this.unitPriceTxt.BackColor = System.Drawing.Color.White;
            this.unitPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTxt.Location = new System.Drawing.Point(440, 251);
            this.unitPriceTxt.Name = "unitPriceTxt";
            this.unitPriceTxt.ReadOnly = true;
            this.unitPriceTxt.Size = new System.Drawing.Size(150, 20);
            this.unitPriceTxt.TabIndex = 44;
            this.unitPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // availableTxt
            // 
            this.availableTxt.BackColor = System.Drawing.Color.White;
            this.availableTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableTxt.Location = new System.Drawing.Point(621, 251);
            this.availableTxt.Name = "availableTxt";
            this.availableTxt.ReadOnly = true;
            this.availableTxt.Size = new System.Drawing.Size(150, 20);
            this.availableTxt.TabIndex = 11;
            this.availableTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.BackColor = System.Drawing.Color.White;
            this.customerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxt.Location = new System.Drawing.Point(206, 162);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(250, 20);
            this.customerNameTxt.TabIndex = 1;
            // 
            // productSaleTable
            // 
            this.productSaleTable.AllowUserToAddRows = false;
            this.productSaleTable.AllowUserToDeleteRows = false;
            this.productSaleTable.AllowUserToOrderColumns = true;
            this.productSaleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productSaleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productSaleTable.BackgroundColor = System.Drawing.Color.White;
            this.productSaleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSaleTable.Location = new System.Drawing.Point(24, 304);
            this.productSaleTable.Name = "productSaleTable";
            this.productSaleTable.Size = new System.Drawing.Size(1283, 243);
            this.productSaleTable.TabIndex = 13;
            this.productSaleTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productSaleTable_CellClick);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(20, 633);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(72, 20);
            this.discountLabel.TabIndex = 15;
            this.discountLabel.Text = "Discount";
            // 
            // cgstLabel
            // 
            this.cgstLabel.AutoSize = true;
            this.cgstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgstLabel.Location = new System.Drawing.Point(435, 633);
            this.cgstLabel.Name = "cgstLabel";
            this.cgstLabel.Size = new System.Drawing.Size(53, 20);
            this.cgstLabel.TabIndex = 15;
            this.cgstLabel.Text = "CGST";
            // 
            // sgstLabel
            // 
            this.sgstLabel.AutoSize = true;
            this.sgstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgstLabel.Location = new System.Drawing.Point(232, 633);
            this.sgstLabel.Name = "sgstLabel";
            this.sgstLabel.Size = new System.Drawing.Size(53, 20);
            this.sgstLabel.TabIndex = 15;
            this.sgstLabel.Text = "SGST";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(653, 633);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(104, 20);
            this.totalAmountLabel.TabIndex = 15;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // totalPayLabel
            // 
            this.totalPayLabel.AutoSize = true;
            this.totalPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayLabel.Location = new System.Drawing.Point(1018, 633);
            this.totalPayLabel.Name = "totalPayLabel";
            this.totalPayLabel.Size = new System.Drawing.Size(100, 20);
            this.totalPayLabel.TabIndex = 15;
            this.totalPayLabel.Text = "Total To  Pay";
            // 
            // discountTxt
            // 
            this.discountTxt.BackColor = System.Drawing.Color.White;
            this.discountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(98, 630);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.ReadOnly = true;
            this.discountTxt.Size = new System.Drawing.Size(100, 20);
            this.discountTxt.TabIndex = 16;
            this.discountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sgstTxt
            // 
            this.sgstTxt.BackColor = System.Drawing.Color.White;
            this.sgstTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sgstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgstTxt.Location = new System.Drawing.Point(291, 630);
            this.sgstTxt.Name = "sgstTxt";
            this.sgstTxt.ReadOnly = true;
            this.sgstTxt.Size = new System.Drawing.Size(100, 20);
            this.sgstTxt.TabIndex = 17;
            this.sgstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cgstTxt
            // 
            this.cgstTxt.BackColor = System.Drawing.Color.White;
            this.cgstTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cgstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgstTxt.Location = new System.Drawing.Point(494, 630);
            this.cgstTxt.Name = "cgstTxt";
            this.cgstTxt.ReadOnly = true;
            this.cgstTxt.Size = new System.Drawing.Size(100, 20);
            this.cgstTxt.TabIndex = 18;
            this.cgstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.BackColor = System.Drawing.Color.White;
            this.totalAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTxt.Location = new System.Drawing.Point(763, 630);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.ReadOnly = true;
            this.totalAmountTxt.Size = new System.Drawing.Size(170, 20);
            this.totalAmountTxt.TabIndex = 19;
            this.totalAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPayTxt
            // 
            this.totalPayTxt.BackColor = System.Drawing.Color.White;
            this.totalPayTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPayTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayTxt.Location = new System.Drawing.Point(1124, 630);
            this.totalPayTxt.Name = "totalPayTxt";
            this.totalPayTxt.ReadOnly = true;
            this.totalPayTxt.Size = new System.Drawing.Size(170, 20);
            this.totalPayTxt.TabIndex = 20;
            this.totalPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, 27);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(1334, 50);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTypeCombo
            // 
            this.paymentTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.paymentTypeCombo.BackColor = System.Drawing.Color.White;
            this.paymentTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeCombo.FormattingEnabled = true;
            this.paymentTypeCombo.Items.AddRange(new object[] {
            "Online",
            "Cash",
            "Cheque",
            "Paytm",
            "Bhim",
            "Phone Pe",
            "NEFT",
            "IMPS",
            "UPI",
            "Borrow"});
            this.paymentTypeCombo.Location = new System.Drawing.Point(703, 167);
            this.paymentTypeCombo.Name = "paymentTypeCombo";
            this.paymentTypeCombo.Size = new System.Drawing.Size(250, 28);
            this.paymentTypeCombo.TabIndex = 22;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBtn.Image = global::DbTest.Properties.Resources.Cancel;
            this.cancelOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelOrderBtn.Location = new System.Drawing.Point(24, 565);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cancelOrderBtn.Size = new System.Drawing.Size(200, 40);
            this.cancelOrderBtn.TabIndex = 7;
            this.cancelOrderBtn.Text = "Cancel Order   ";
            this.cancelOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Image = global::DbTest.Properties.Resources.AddToCart;
            this.addToCartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToCartBtn.Location = new System.Drawing.Point(1093, 177);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addToCartBtn.Size = new System.Drawing.Size(200, 40);
            this.addToCartBtn.TabIndex = 5;
            this.addToCartBtn.Text = "Add To Cart  ";
            this.addToCartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // printOrderBtn
            // 
            this.printOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printOrderBtn.Image = global::DbTest.Properties.Resources.Print;
            this.printOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printOrderBtn.Location = new System.Drawing.Point(1093, 236);
            this.printOrderBtn.Name = "printOrderBtn";
            this.printOrderBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.printOrderBtn.Size = new System.Drawing.Size(200, 40);
            this.printOrderBtn.TabIndex = 6;
            this.printOrderBtn.Text = "Print Order    ";
            this.printOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printOrderBtn.UseVisualStyleBackColor = true;
            this.printOrderBtn.Click += new System.EventHandler(this.printOrderBtn_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newOrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.newOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderBtn.Image = global::DbTest.Properties.Resources.Add_New;
            this.newOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrderBtn.Location = new System.Drawing.Point(1093, 111);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.newOrderBtn.Size = new System.Drawing.Size(200, 40);
            this.newOrderBtn.TabIndex = 0;
            this.newOrderBtn.Text = "New Order    ";
            this.newOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newOrderBtn.UseVisualStyleBackColor = true;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreviewOrder
            // 
            this.printPreviewOrder.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewOrder.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewOrder.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewOrder.Enabled = true;
            this.printPreviewOrder.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewOrder.Icon")));
            this.printPreviewOrder.Name = "printPreviewDialog1";
            this.printPreviewOrder.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.unpainOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 27);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.searchToolStripMenuItem.Text = "Search Product";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.logoutToolStripMenuItem.Text = "Unpaid Order";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // unpainOrderToolStripMenuItem
            // 
            this.unpainOrderToolStripMenuItem.Name = "unpainOrderToolStripMenuItem";
            this.unpainOrderToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.unpainOrderToolStripMenuItem.Text = "Logout";
            this.unpainOrderToolStripMenuItem.Click += new System.EventHandler(this.unpainOrderToolStripMenuItem_Click);
            // 
            // transactionDateTxt
            // 
            this.transactionDateTxt.BackColor = System.Drawing.Color.White;
            this.transactionDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateTxt.Location = new System.Drawing.Point(703, 108);
            this.transactionDateTxt.Name = "transactionDateTxt";
            this.transactionDateTxt.ReadOnly = true;
            this.transactionDateTxt.Size = new System.Drawing.Size(250, 20);
            this.transactionDateTxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(206, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(206, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(704, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(703, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(45, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 2);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(241, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 2);
            this.panel6.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(439, 278);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 2);
            this.panel7.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel8.Location = new System.Drawing.Point(621, 278);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 2);
            this.panel8.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel9.Location = new System.Drawing.Point(812, 278);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(150, 2);
            this.panel9.TabIndex = 32;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel10.Location = new System.Drawing.Point(98, 655);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 2);
            this.panel10.TabIndex = 33;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel11.Location = new System.Drawing.Point(291, 655);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 2);
            this.panel11.TabIndex = 34;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel12.Location = new System.Drawing.Point(494, 655);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(100, 2);
            this.panel12.TabIndex = 35;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel13.Location = new System.Drawing.Point(763, 655);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(170, 2);
            this.panel13.TabIndex = 36;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel14.Location = new System.Drawing.Point(1125, 655);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(170, 2);
            this.panel14.TabIndex = 37;
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paymentTypeCombo);
            this.Controls.Add(this.totalPayTxt);
            this.Controls.Add(this.totalAmountTxt);
            this.Controls.Add(this.cgstTxt);
            this.Controls.Add(this.sgstTxt);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.totalPayLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.sgstLabel);
            this.Controls.Add(this.cgstLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.productSaleTable);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.availableTxt);
            this.Controls.Add(this.unitPriceTxt);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.companyCombo);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.printOrderBtn);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.transactionDateTxt);
            this.Controls.Add(this.orderNumberTxt);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.quanttyLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.productNmLabel);
            this.Controls.Add(this.customerNmLabel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.transactonDeteLabel);
            this.Controls.Add(this.orderNmLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSaleTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNmLabel;
        private System.Windows.Forms.Label customerNmLabel;
        private System.Windows.Forms.Label transactonDeteLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.TextBox orderNumberTxt;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Button printOrderBtn;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Label productNmLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label quanttyLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.ComboBox companyCombo;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox unitPriceTxt;
        private System.Windows.Forms.TextBox availableTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.DataGridView productSaleTable;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label cgstLabel;
        private System.Windows.Forms.Label sgstLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label totalPayLabel;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.TextBox sgstTxt;
        private System.Windows.Forms.TextBox cgstTxt;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.TextBox totalPayTxt;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.ComboBox paymentTypeCombo;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpainOrderToolStripMenuItem;
        private System.Windows.Forms.TextBox transactionDateTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
    }
}