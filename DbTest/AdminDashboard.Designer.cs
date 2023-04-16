namespace DbTest
{
    partial class AdminDashboard
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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.sellStockBtn = new System.Windows.Forms.Button();
            this.compareSellBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.ProductManageBtn = new System.Windows.Forms.Button();
            this.UserManageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(0, -1);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(1340, 50);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellStockBtn
            // 
            this.sellStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellStockBtn.Image = global::DbTest.Properties.Resources.Shell_Stock;
            this.sellStockBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sellStockBtn.Location = new System.Drawing.Point(453, 396);
            this.sellStockBtn.Name = "sellStockBtn";
            this.sellStockBtn.Size = new System.Drawing.Size(155, 100);
            this.sellStockBtn.TabIndex = 5;
            this.sellStockBtn.Text = "Sell Product";
            this.sellStockBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sellStockBtn.UseVisualStyleBackColor = true;
            this.sellStockBtn.Click += new System.EventHandler(this.sellStockBtn_Click);
            // 
            // compareSellBtn
            // 
            this.compareSellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareSellBtn.Image = global::DbTest.Properties.Resources.Compare_Shell;
            this.compareSellBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.compareSellBtn.Location = new System.Drawing.Point(146, 396);
            this.compareSellBtn.Name = "compareSellBtn";
            this.compareSellBtn.Size = new System.Drawing.Size(155, 100);
            this.compareSellBtn.TabIndex = 4;
            this.compareSellBtn.Text = "Compare Sell";
            this.compareSellBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compareSellBtn.UseVisualStyleBackColor = true;
            this.compareSellBtn.Click += new System.EventHandler(this.compareSellBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.Image = global::DbTest.Properties.Resources.purchase;
            this.purchaseBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.purchaseBtn.Location = new System.Drawing.Point(1033, 185);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(155, 100);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DbTest.Properties.Resources.cashier;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(756, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vendor Manage";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Image = global::DbTest.Properties.Resources.Logout;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogOutBtn.Location = new System.Drawing.Point(1033, 396);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(155, 100);
            this.LogOutBtn.TabIndex = 7;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.Image = global::DbTest.Properties.Resources.Settings;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingBtn.Location = new System.Drawing.Point(756, 396);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(155, 100);
            this.SettingBtn.TabIndex = 6;
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // ProductManageBtn
            // 
            this.ProductManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductManageBtn.Image = global::DbTest.Properties.Resources.products;
            this.ProductManageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductManageBtn.Location = new System.Drawing.Point(453, 185);
            this.ProductManageBtn.Name = "ProductManageBtn";
            this.ProductManageBtn.Size = new System.Drawing.Size(155, 100);
            this.ProductManageBtn.TabIndex = 1;
            this.ProductManageBtn.Text = "Product Manage";
            this.ProductManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductManageBtn.UseVisualStyleBackColor = true;
            this.ProductManageBtn.Click += new System.EventHandler(this.ProductManageBtn_Click);
            // 
            // UserManageBtn
            // 
            this.UserManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManageBtn.Image = global::DbTest.Properties.Resources.User_Manage;
            this.UserManageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserManageBtn.Location = new System.Drawing.Point(146, 184);
            this.UserManageBtn.Name = "UserManageBtn";
            this.UserManageBtn.Size = new System.Drawing.Size(156, 101);
            this.UserManageBtn.TabIndex = 0;
            this.UserManageBtn.Text = "User Manage";
            this.UserManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserManageBtn.UseVisualStyleBackColor = true;
            this.UserManageBtn.Click += new System.EventHandler(this.UserManageBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.sellStockBtn);
            this.Controls.Add(this.compareSellBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.ProductManageBtn);
            this.Controls.Add(this.UserManageBtn);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserManageBtn;
        private System.Windows.Forms.Button ProductManageBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button compareSellBtn;
        private System.Windows.Forms.Button sellStockBtn;
        private System.Windows.Forms.Label companyNameLabel;
    }
}