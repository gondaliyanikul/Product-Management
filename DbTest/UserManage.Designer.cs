namespace DbTest
{
    partial class UserManage
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
            this.userManageLabel = new System.Windows.Forms.Label();
            this.UserManageDetails = new System.Windows.Forms.DataGridView();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.SearchUsersTxt = new System.Windows.Forms.TextBox();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserManageDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // userManageLabel
            // 
            this.userManageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userManageLabel.AutoSize = true;
            this.userManageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.userManageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManageLabel.ForeColor = System.Drawing.Color.Black;
            this.userManageLabel.Location = new System.Drawing.Point(321, 77);
            this.userManageLabel.Name = "userManageLabel";
            this.userManageLabel.Size = new System.Drawing.Size(157, 29);
            this.userManageLabel.TabIndex = 0;
            this.userManageLabel.Text = "User Manage";
            this.userManageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserManageDetails
            // 
            this.UserManageDetails.AllowUserToAddRows = false;
            this.UserManageDetails.AllowUserToDeleteRows = false;
            this.UserManageDetails.AllowUserToOrderColumns = true;
            this.UserManageDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManageDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserManageDetails.BackgroundColor = System.Drawing.Color.White;
            this.UserManageDetails.ColumnHeadersHeight = 40;
            this.UserManageDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserManageDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UserManageDetails.Location = new System.Drawing.Point(12, 173);
            this.UserManageDetails.MultiSelect = false;
            this.UserManageDetails.Name = "UserManageDetails";
            this.UserManageDetails.RowHeadersWidth = 50;
            this.UserManageDetails.Size = new System.Drawing.Size(776, 354);
            this.UserManageDetails.TabIndex = 2;
            this.UserManageDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserManageDetails_CellClick);
            this.UserManageDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserManageDetails_CellContentClick);
            this.UserManageDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.UserManageDetails_CellPainting);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.Image = global::DbTest.Properties.Resources.plus;
            this.AddUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserBtn.Location = new System.Drawing.Point(640, 131);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddUserBtn.Size = new System.Drawing.Size(148, 36);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // SearchUsersTxt
            // 
            this.SearchUsersTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUsersTxt.Location = new System.Drawing.Point(12, 137);
            this.SearchUsersTxt.Name = "SearchUsersTxt";
            this.SearchUsersTxt.Size = new System.Drawing.Size(234, 30);
            this.SearchUsersTxt.TabIndex = 3;
            this.SearchUsersTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchUsersTxt_KeyUp);
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchBtn.Image = global::DbTest.Properties.Resources.Search;
            this.UserSearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserSearchBtn.Location = new System.Drawing.Point(264, 131);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UserSearchBtn.Size = new System.Drawing.Size(120, 36);
            this.UserSearchBtn.TabIndex = 1;
            this.UserSearchBtn.Text = "Search  ";
            this.UserSearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            this.UserSearchBtn.Click += new System.EventHandler(this.UserSearchBtn_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(-1, -1);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(803, 50);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.UserSearchBtn);
            this.Controls.Add(this.SearchUsersTxt);
            this.Controls.Add(this.UserManageDetails);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.userManageLabel);
            this.MinimizeBox = false;
            this.Name = "UserManage";
            this.Text = "UserManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserManageDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userManageLabel;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.DataGridView UserManageDetails;
        private System.Windows.Forms.TextBox SearchUsersTxt;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.Label companyNameLabel;
    }
}