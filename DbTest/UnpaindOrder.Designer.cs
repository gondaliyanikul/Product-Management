namespace DbTest
{
    partial class UnpaindOrder
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.billNumberLabel = new System.Windows.Forms.Label();
            this.billNumberTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.coustomerNmLabel = new System.Windows.Forms.Label();
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.coustomerNameTxt = new System.Windows.Forms.TextBox();
            this.transactionDateTxt = new System.Windows.Forms.TextBox();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.paymentTypeCombo = new System.Windows.Forms.ComboBox();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(296, 75);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Unpaid Order";
            // 
            // billNumberLabel
            // 
            this.billNumberLabel.AutoSize = true;
            this.billNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumberLabel.Location = new System.Drawing.Point(92, 124);
            this.billNumberLabel.Name = "billNumberLabel";
            this.billNumberLabel.Size = new System.Drawing.Size(111, 25);
            this.billNumberLabel.TabIndex = 1;
            this.billNumberLabel.Text = "Bill Number";
            // 
            // billNumberTxt
            // 
            this.billNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumberTxt.Location = new System.Drawing.Point(256, 124);
            this.billNumberTxt.Name = "billNumberTxt";
            this.billNumberTxt.Size = new System.Drawing.Size(270, 25);
            this.billNumberTxt.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Image = global::DbTest.Properties.Resources.Search;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(559, 122);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(120, 40);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search ";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // coustomerNmLabel
            // 
            this.coustomerNmLabel.AutoSize = true;
            this.coustomerNmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coustomerNmLabel.Location = new System.Drawing.Point(86, 186);
            this.coustomerNmLabel.Name = "coustomerNmLabel";
            this.coustomerNmLabel.Size = new System.Drawing.Size(149, 22);
            this.coustomerNmLabel.TabIndex = 1;
            this.coustomerNmLabel.Text = "Coustomer Name";
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateLabel.Location = new System.Drawing.Point(86, 248);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(148, 22);
            this.transactionDateLabel.TabIndex = 1;
            this.transactionDateLabel.Text = "Transaction Date";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(86, 307);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(117, 22);
            this.totalAmountLabel.TabIndex = 1;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // coustomerNameTxt
            // 
            this.coustomerNameTxt.BackColor = System.Drawing.Color.White;
            this.coustomerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coustomerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coustomerNameTxt.Location = new System.Drawing.Point(256, 182);
            this.coustomerNameTxt.Name = "coustomerNameTxt";
            this.coustomerNameTxt.ReadOnly = true;
            this.coustomerNameTxt.Size = new System.Drawing.Size(270, 25);
            this.coustomerNameTxt.TabIndex = 11;
            // 
            // transactionDateTxt
            // 
            this.transactionDateTxt.BackColor = System.Drawing.Color.White;
            this.transactionDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateTxt.Location = new System.Drawing.Point(256, 245);
            this.transactionDateTxt.Name = "transactionDateTxt";
            this.transactionDateTxt.ReadOnly = true;
            this.transactionDateTxt.Size = new System.Drawing.Size(270, 25);
            this.transactionDateTxt.TabIndex = 4;
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.BackColor = System.Drawing.Color.White;
            this.totalAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTxt.Location = new System.Drawing.Point(256, 304);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.ReadOnly = true;
            this.totalAmountTxt.Size = new System.Drawing.Size(270, 25);
            this.totalAmountTxt.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(256, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(256, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(256, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(256, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 5;
            // 
            // paymentTypeCombo
            // 
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
            "UPI"});
            this.paymentTypeCombo.Location = new System.Drawing.Point(256, 369);
            this.paymentTypeCombo.Name = "paymentTypeCombo";
            this.paymentTypeCombo.Size = new System.Drawing.Size(270, 28);
            this.paymentTypeCombo.TabIndex = 6;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(93, 372);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(126, 22);
            this.paymentTypeLabel.TabIndex = 1;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Image = global::DbTest.Properties.Resources.Update;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(559, 357);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updateBtn.Size = new System.Drawing.Size(120, 40);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update ";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 395);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 2);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(755, 50);
            this.companyNameLabel.TabIndex = 9;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnpaindOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 439);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.paymentTypeCombo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalAmountTxt);
            this.Controls.Add(this.transactionDateTxt);
            this.Controls.Add(this.coustomerNameTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.billNumberTxt);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.transactionDateLabel);
            this.Controls.Add(this.coustomerNmLabel);
            this.Controls.Add(this.billNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnpaindOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnpaindOrder";
            this.Load += new System.EventHandler(this.UnpaindOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label billNumberLabel;
        private System.Windows.Forms.TextBox billNumberTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label coustomerNmLabel;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.TextBox coustomerNameTxt;
        private System.Windows.Forms.TextBox transactionDateTxt;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox paymentTypeCombo;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label companyNameLabel;
    }
}