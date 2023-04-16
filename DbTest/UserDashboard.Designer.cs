namespace DbTest
{
    partial class UserDashboard
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
            this.stockManageBtn = new System.Windows.Forms.Button();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.unpaidOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockManageBtn
            // 
            this.stockManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockManageBtn.Location = new System.Drawing.Point(130, 175);
            this.stockManageBtn.Name = "stockManageBtn";
            this.stockManageBtn.Size = new System.Drawing.Size(142, 54);
            this.stockManageBtn.TabIndex = 0;
            this.stockManageBtn.Text = "Stock Manage";
            this.stockManageBtn.UseVisualStyleBackColor = true;
            this.stockManageBtn.Click += new System.EventHandler(this.stockManageBtn_Click);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBtn.Location = new System.Drawing.Point(332, 175);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(142, 54);
            this.productSearchBtn.TabIndex = 0;
            this.productSearchBtn.Text = "Search Products";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // unpaidOrderBtn
            // 
            this.unpaidOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidOrderBtn.Location = new System.Drawing.Point(525, 175);
            this.unpaidOrderBtn.Name = "unpaidOrderBtn";
            this.unpaidOrderBtn.Size = new System.Drawing.Size(143, 54);
            this.unpaidOrderBtn.TabIndex = 1;
            this.unpaidOrderBtn.Text = "Unpaid Order";
            this.unpaidOrderBtn.UseVisualStyleBackColor = true;
            this.unpaidOrderBtn.Click += new System.EventHandler(this.unpaidOrderBtn_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unpaidOrderBtn);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.stockManageBtn);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stockManageBtn;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.Button unpaidOrderBtn;
    }
}