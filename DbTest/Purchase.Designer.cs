namespace DbTest
{
    partial class Purchase
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
            this.productLabel = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.purchaseRateLabel = new System.Windows.Forms.Label();
            this.purchaseRateTxt = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.paymentCombo = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.BuyDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.orderDateTxt = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vendorCombo = new System.Windows.Forms.ComboBox();
            this.vendorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuyDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(28, 100);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(139, 25);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Select Product";
            // 
            // productCombo
            // 
            this.productCombo.BackColor = System.Drawing.Color.White;
            this.productCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(33, 144);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(199, 33);
            this.productCombo.TabIndex = 0;
            this.productCombo.SelectedIndexChanged += new System.EventHandler(this.productCombo_SelectedIndexChanged);
            // 
            // purchaseRateLabel
            // 
            this.purchaseRateLabel.AutoSize = true;
            this.purchaseRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseRateLabel.Location = new System.Drawing.Point(28, 194);
            this.purchaseRateLabel.Name = "purchaseRateLabel";
            this.purchaseRateLabel.Size = new System.Drawing.Size(140, 25);
            this.purchaseRateLabel.TabIndex = 0;
            this.purchaseRateLabel.Text = "Purchase Rate";
            // 
            // purchaseRateTxt
            // 
            this.purchaseRateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchaseRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseRateTxt.Location = new System.Drawing.Point(33, 241);
            this.purchaseRateTxt.Name = "purchaseRateTxt";
            this.purchaseRateTxt.Size = new System.Drawing.Size(200, 23);
            this.purchaseRateTxt.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(28, 287);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(136, 25);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Enter Quantity";
            // 
            // quantityTxt
            // 
            this.quantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(33, 325);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(200, 23);
            this.quantityTxt.TabIndex = 2;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            this.quantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTxt_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::DbTest.Properties.Resources.Add;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(59, 487);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addBtn.Size = new System.Drawing.Size(126, 40);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "  Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // paymentLabel
            // 
            this.paymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(529, 563);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(204, 25);
            this.paymentLabel.TabIndex = 0;
            this.paymentLabel.Text = "Select Payment Mode";
            this.paymentLabel.Click += new System.EventHandler(this.paymentLabel_Click);
            // 
            // paymentCombo
            // 
            this.paymentCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentCombo.BackColor = System.Drawing.Color.White;
            this.paymentCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Borrow\t\t"});
            this.paymentCombo.Location = new System.Drawing.Point(524, 611);
            this.paymentCombo.Name = "paymentCombo";
            this.paymentCombo.Size = new System.Drawing.Size(220, 33);
            this.paymentCombo.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(796, 563);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(113, 25);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Select Date";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(1072, 598);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(136, 40);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // totalTxt
            // 
            this.totalTxt.BackColor = System.Drawing.Color.White;
            this.totalTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(33, 419);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(200, 23);
            this.totalTxt.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(31, 375);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 25);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total";
            // 
            // BuyDetails
            // 
            this.BuyDetails.AllowUserToAddRows = false;
            this.BuyDetails.AllowUserToDeleteRows = false;
            this.BuyDetails.AllowUserToOrderColumns = true;
            this.BuyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuyDetails.BackgroundColor = System.Drawing.Color.White;
            this.BuyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyDetails.Location = new System.Drawing.Point(273, 100);
            this.BuyDetails.Name = "BuyDetails";
            this.BuyDetails.ReadOnly = true;
            this.BuyDetails.Size = new System.Drawing.Size(979, 443);
            this.BuyDetails.TabIndex = 10;
            this.BuyDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuyDetails_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(33, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(32, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(32, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(32, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(524, 636);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 2);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(801, 636);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 2);
            this.panel7.TabIndex = 17;
            // 
            // orderDateTxt
            // 
            this.orderDateTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTxt.Location = new System.Drawing.Point(801, 607);
            this.orderDateTxt.Name = "orderDateTxt";
            this.orderDateTxt.Size = new System.Drawing.Size(200, 23);
            this.orderDateTxt.TabIndex = 7;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, -2);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(1284, 50);
            this.companyNameLabel.TabIndex = 19;
            this.companyNameLabel.Tag = "";
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(279, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 22;
            // 
            // vendorCombo
            // 
            this.vendorCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorCombo.BackColor = System.Drawing.Color.White;
            this.vendorCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorCombo.FormattingEnabled = true;
            this.vendorCombo.Location = new System.Drawing.Point(279, 605);
            this.vendorCombo.Name = "vendorCombo";
            this.vendorCombo.Size = new System.Drawing.Size(200, 33);
            this.vendorCombo.TabIndex = 5;
            // 
            // vendorLabel
            // 
            this.vendorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(274, 563);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(136, 25);
            this.vendorLabel.TabIndex = 21;
            this.vendorLabel.Text = "Select Vendor";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vendorCombo);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.orderDateTxt);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BuyDetails);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.paymentCombo);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.purchaseRateTxt);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.purchaseRateLabel);
            this.Controls.Add(this.productLabel);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuyDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label purchaseRateLabel;
        private System.Windows.Forms.TextBox purchaseRateTxt;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.ComboBox paymentCombo;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView BuyDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox orderDateTxt;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox vendorCombo;
        private System.Windows.Forms.Label vendorLabel;
    }
}