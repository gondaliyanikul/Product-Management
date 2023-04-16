namespace DbTest
{
    partial class SellProduct
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
            this.selectPaymentLabel = new System.Windows.Forms.Label();
            this.paymentCombo = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.orderInformations = new System.Windows.Forms.DataGridView();
            this.orderItemInformations = new System.Windows.Forms.DataGridView();
            this.orderInformationLabel = new System.Windows.Forms.Label();
            this.orderItemsInformationLabel = new System.Windows.Forms.Label();
            this.billNumberLabel = new System.Windows.Forms.Label();
            this.billNumberTxt = new System.Windows.Forms.TextBox();
            this.selectDatelable = new System.Windows.Forms.Label();
            this.customerNameLable = new System.Windows.Forms.Label();
            this.dateTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderInformations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemInformations)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPaymentLabel
            // 
            this.selectPaymentLabel.AutoSize = true;
            this.selectPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPaymentLabel.Location = new System.Drawing.Point(161, 94);
            this.selectPaymentLabel.Name = "selectPaymentLabel";
            this.selectPaymentLabel.Size = new System.Drawing.Size(120, 20);
            this.selectPaymentLabel.TabIndex = 0;
            this.selectPaymentLabel.Text = "Select Payment";
            // 
            // paymentCombo
            // 
            this.paymentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCombo.FormattingEnabled = true;
            this.paymentCombo.Items.AddRange(new object[] {
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
            this.paymentCombo.Location = new System.Drawing.Point(302, 88);
            this.paymentCombo.Name = "paymentCombo";
            this.paymentCombo.Size = new System.Drawing.Size(196, 28);
            this.paymentCombo.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1225, 101);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(122, 43);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // orderInformations
            // 
            this.orderInformations.AllowUserToAddRows = false;
            this.orderInformations.AllowUserToDeleteRows = false;
            this.orderInformations.AllowUserToOrderColumns = true;
            this.orderInformations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderInformations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderInformations.BackgroundColor = System.Drawing.Color.White;
            this.orderInformations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderInformations.GridColor = System.Drawing.Color.White;
            this.orderInformations.Location = new System.Drawing.Point(13, 230);
            this.orderInformations.Name = "orderInformations";
            this.orderInformations.ReadOnly = true;
            this.orderInformations.Size = new System.Drawing.Size(1334, 225);
            this.orderInformations.TabIndex = 3;
            this.orderInformations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderInformationDetails_CellClick);
            // 
            // orderItemInformations
            // 
            this.orderItemInformations.AllowUserToAddRows = false;
            this.orderItemInformations.AllowUserToDeleteRows = false;
            this.orderItemInformations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderItemInformations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemInformations.BackgroundColor = System.Drawing.Color.White;
            this.orderItemInformations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemInformations.GridColor = System.Drawing.Color.White;
            this.orderItemInformations.Location = new System.Drawing.Point(12, 500);
            this.orderItemInformations.Name = "orderItemInformations";
            this.orderItemInformations.ReadOnly = true;
            this.orderItemInformations.Size = new System.Drawing.Size(1335, 169);
            this.orderItemInformations.TabIndex = 4;
            this.orderItemInformations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderItemInformations_CellClick);
            // 
            // orderInformationLabel
            // 
            this.orderInformationLabel.AutoSize = true;
            this.orderInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInformationLabel.Location = new System.Drawing.Point(12, 196);
            this.orderInformationLabel.Name = "orderInformationLabel";
            this.orderInformationLabel.Size = new System.Drawing.Size(134, 20);
            this.orderInformationLabel.TabIndex = 5;
            this.orderInformationLabel.Text = "Order Information";
            // 
            // orderItemsInformationLabel
            // 
            this.orderItemsInformationLabel.AutoSize = true;
            this.orderItemsInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemsInformationLabel.Location = new System.Drawing.Point(12, 477);
            this.orderItemsInformationLabel.Name = "orderItemsInformationLabel";
            this.orderItemsInformationLabel.Size = new System.Drawing.Size(178, 20);
            this.orderItemsInformationLabel.TabIndex = 5;
            this.orderItemsInformationLabel.Text = "Order Items Information";
            // 
            // billNumberLabel
            // 
            this.billNumberLabel.AutoSize = true;
            this.billNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumberLabel.Location = new System.Drawing.Point(811, 94);
            this.billNumberLabel.Name = "billNumberLabel";
            this.billNumberLabel.Size = new System.Drawing.Size(89, 20);
            this.billNumberLabel.TabIndex = 6;
            this.billNumberLabel.Text = "Bill Number";
            // 
            // billNumberTxt
            // 
            this.billNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumberTxt.Location = new System.Drawing.Point(922, 88);
            this.billNumberTxt.Name = "billNumberTxt";
            this.billNumberTxt.Size = new System.Drawing.Size(208, 26);
            this.billNumberTxt.TabIndex = 2;
            // 
            // selectDatelable
            // 
            this.selectDatelable.AutoSize = true;
            this.selectDatelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDatelable.Location = new System.Drawing.Point(811, 149);
            this.selectDatelable.Name = "selectDatelable";
            this.selectDatelable.Size = new System.Drawing.Size(93, 20);
            this.selectDatelable.TabIndex = 8;
            this.selectDatelable.Text = "Select Date";
            // 
            // customerNameLable
            // 
            this.customerNameLable.AutoSize = true;
            this.customerNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLable.Location = new System.Drawing.Point(162, 149);
            this.customerNameLable.Name = "customerNameLable";
            this.customerNameLable.Size = new System.Drawing.Size(133, 20);
            this.customerNameLable.TabIndex = 10;
            this.customerNameLable.Text = "Coustomer Name";
            // 
            // dateTimeTxt
            // 
            this.dateTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTxt.Location = new System.Drawing.Point(922, 144);
            this.dateTimeTxt.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimeTxt.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeTxt.Name = "dateTimeTxt";
            this.dateTimeTxt.Size = new System.Drawing.Size(205, 26);
            this.dateTimeTxt.TabIndex = 3;
            this.dateTimeTxt.Value = new System.DateTime(2000, 1, 1, 9, 40, 0, 0);
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxt.Location = new System.Drawing.Point(302, 149);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(199, 26);
            this.customerNameTxt.TabIndex = 12;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(-2, -1);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(1361, 50);
            this.companyNameLabel.TabIndex = 13;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 681);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.dateTimeTxt);
            this.Controls.Add(this.customerNameLable);
            this.Controls.Add(this.selectDatelable);
            this.Controls.Add(this.billNumberTxt);
            this.Controls.Add(this.billNumberLabel);
            this.Controls.Add(this.orderItemsInformationLabel);
            this.Controls.Add(this.orderInformationLabel);
            this.Controls.Add(this.orderItemInformations);
            this.Controls.Add(this.orderInformations);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.paymentCombo);
            this.Controls.Add(this.selectPaymentLabel);
            this.Name = "SellProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Poduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderInformations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemInformations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectPaymentLabel;
        private System.Windows.Forms.ComboBox paymentCombo;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView orderInformations;
        private System.Windows.Forms.DataGridView orderItemInformations;
        private System.Windows.Forms.Label orderInformationLabel;
        private System.Windows.Forms.Label orderItemsInformationLabel;
        private System.Windows.Forms.Label billNumberLabel;
        private System.Windows.Forms.TextBox billNumberTxt;
        private System.Windows.Forms.Label selectDatelable;
        private System.Windows.Forms.Label customerNameLable;
        private System.Windows.Forms.DateTimePicker dateTimeTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label companyNameLabel;
    }
}