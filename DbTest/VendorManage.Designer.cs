namespace DbTest
{
    partial class VendorManage
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
            this.vendorDetails = new System.Windows.Forms.DataGridView();
            this.addVenderBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.vendorSearchTxt = new System.Windows.Forms.TextBox();
            this.companyNameTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(308, 71);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(184, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Vendor Manage";
            // 
            // vendorDetails
            // 
            this.vendorDetails.AllowUserToAddRows = false;
            this.vendorDetails.AllowUserToDeleteRows = false;
            this.vendorDetails.AllowUserToOrderColumns = true;
            this.vendorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorDetails.BackgroundColor = System.Drawing.Color.White;
            this.vendorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDetails.Location = new System.Drawing.Point(12, 169);
            this.vendorDetails.Name = "vendorDetails";
            this.vendorDetails.ReadOnly = true;
            this.vendorDetails.Size = new System.Drawing.Size(776, 359);
            this.vendorDetails.TabIndex = 1;
            this.vendorDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDetails_CellClick);
            this.vendorDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.vendorDetails_CellPainting);
            // 
            // addVenderBtn
            // 
            this.addVenderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addVenderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVenderBtn.Image = global::DbTest.Properties.Resources.plus;
            this.addVenderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVenderBtn.Location = new System.Drawing.Point(646, 126);
            this.addVenderBtn.Name = "addVenderBtn";
            this.addVenderBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addVenderBtn.Size = new System.Drawing.Size(142, 37);
            this.addVenderBtn.TabIndex = 2;
            this.addVenderBtn.Text = "Add Vendor";
            this.addVenderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addVenderBtn.UseVisualStyleBackColor = true;
            this.addVenderBtn.Click += new System.EventHandler(this.addVenderBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Image = global::DbTest.Properties.Resources.Search;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(279, 126);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(106, 37);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search ";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // vendorSearchTxt
            // 
            this.vendorSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorSearchTxt.Location = new System.Drawing.Point(12, 131);
            this.vendorSearchTxt.Name = "vendorSearchTxt";
            this.vendorSearchTxt.Size = new System.Drawing.Size(246, 30);
            this.vendorSearchTxt.TabIndex = 0;
            this.vendorSearchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vendorSearchTxt_KeyUp);
            // 
            // companyNameTitle
            // 
            this.companyNameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameTitle.Location = new System.Drawing.Point(-1, -1);
            this.companyNameTitle.Name = "companyNameTitle";
            this.companyNameTitle.Size = new System.Drawing.Size(802, 50);
            this.companyNameTitle.TabIndex = 6;
            this.companyNameTitle.Text = "Company Title";
            this.companyNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VendorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.companyNameTitle);
            this.Controls.Add(this.vendorSearchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addVenderBtn);
            this.Controls.Add(this.vendorDetails);
            this.Controls.Add(this.titleLabel);
            this.Name = "VendorManage";
            this.Text = "VendorManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView vendorDetails;
        private System.Windows.Forms.Button addVenderBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox vendorSearchTxt;
        private System.Windows.Forms.Label companyNameTitle;
    }
}