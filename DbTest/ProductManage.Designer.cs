namespace DbTest
{
    partial class ProductManage
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
            this.productManageLabel = new System.Windows.Forms.Label();
            this.ProductDetails = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // productManageLabel
            // 
            this.productManageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productManageLabel.AutoSize = true;
            this.productManageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManageLabel.ForeColor = System.Drawing.Color.Black;
            this.productManageLabel.Location = new System.Drawing.Point(294, 66);
            this.productManageLabel.Name = "productManageLabel";
            this.productManageLabel.Size = new System.Drawing.Size(212, 31);
            this.productManageLabel.TabIndex = 0;
            this.productManageLabel.Text = "Product Manage";
            // 
            // ProductDetails
            // 
            this.ProductDetails.AllowUserToAddRows = false;
            this.ProductDetails.AllowUserToDeleteRows = false;
            this.ProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDetails.BackgroundColor = System.Drawing.Color.White;
            this.ProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDetails.Location = new System.Drawing.Point(12, 167);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.ReadOnly = true;
            this.ProductDetails.Size = new System.Drawing.Size(776, 346);
            this.ProductDetails.TabIndex = 2;
            this.ProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDetails_CellClick);
            this.ProductDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ProductDetails_CellPainting);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(12, 131);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(243, 29);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyUp);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = global::DbTest.Properties.Resources.Search;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(261, 125);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(111, 35);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search  ";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.Image = global::DbTest.Properties.Resources.plus;
            this.AddProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductBtn.Location = new System.Drawing.Point(651, 125);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AddProductBtn.Size = new System.Drawing.Size(137, 33);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.Text = "  Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
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
            this.companyNameLabel.Size = new System.Drawing.Size(801, 50);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.ProductDetails);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.productManageLabel);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productManageLabel;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.DataGridView ProductDetails;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label companyNameLabel;
    }
}