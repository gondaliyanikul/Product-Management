namespace DbTest
{
    partial class CreateUser
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.UserIdTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.SelectTxt = new System.Windows.Forms.ComboBox();
            this.namePan = new System.Windows.Forms.Panel();
            this.useridPan = new System.Windows.Forms.Panel();
            this.passwordPan = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.mobileNoLabel = new System.Windows.Forms.Label();
            this.MobileNoTxt = new System.Windows.Forms.TextBox();
            this.mobileNoPane = new System.Windows.Forms.Panel();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(259, 79);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(169, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New User";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(84, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(84, 261);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(71, 24);
            this.userIdLabel.TabIndex = 1;
            this.userIdLabel.Text = "User ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(84, 321);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.Location = new System.Drawing.Point(84, 379);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.userTypeLabel.TabIndex = 1;
            this.userTypeLabel.Text = "User Type";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Image = global::DbTest.Properties.Resources.Add;
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.Location = new System.Drawing.Point(248, 453);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addUserBtn.Size = new System.Drawing.Size(155, 37);
            this.addUserBtn.TabIndex = 5;
            this.addUserBtn.Text = "Add User  ";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(248, 137);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(340, 28);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // UserIdTxt
            // 
            this.UserIdTxt.BackColor = System.Drawing.Color.White;
            this.UserIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTxt.Location = new System.Drawing.Point(248, 257);
            this.UserIdTxt.Multiline = true;
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.Size = new System.Drawing.Size(340, 28);
            this.UserIdTxt.TabIndex = 2;
            this.UserIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTxt_KeyPress);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(248, 317);
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(340, 28);
            this.PasswordTxt.TabIndex = 3;
            // 
            // SelectTxt
            // 
            this.SelectTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SelectTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectTxt.BackColor = System.Drawing.Color.White;
            this.SelectTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTxt.FormattingEnabled = true;
            this.SelectTxt.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.SelectTxt.Location = new System.Drawing.Point(248, 376);
            this.SelectTxt.Name = "SelectTxt";
            this.SelectTxt.Size = new System.Drawing.Size(340, 32);
            this.SelectTxt.TabIndex = 4;
            // 
            // namePan
            // 
            this.namePan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.namePan.Location = new System.Drawing.Point(248, 165);
            this.namePan.Name = "namePan";
            this.namePan.Size = new System.Drawing.Size(340, 2);
            this.namePan.TabIndex = 6;
            // 
            // useridPan
            // 
            this.useridPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.useridPan.Location = new System.Drawing.Point(248, 285);
            this.useridPan.Name = "useridPan";
            this.useridPan.Size = new System.Drawing.Size(340, 2);
            this.useridPan.TabIndex = 7;
            // 
            // passwordPan
            // 
            this.passwordPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.passwordPan.Location = new System.Drawing.Point(248, 345);
            this.passwordPan.Name = "passwordPan";
            this.passwordPan.Size = new System.Drawing.Size(340, 2);
            this.passwordPan.TabIndex = 7;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = global::DbTest.Properties.Resources.Cancel;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(444, 453);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CloseBtn.Size = new System.Drawing.Size(144, 37);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Close    ";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // mobileNoLabel
            // 
            this.mobileNoLabel.AutoSize = true;
            this.mobileNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoLabel.Location = new System.Drawing.Point(84, 203);
            this.mobileNoLabel.Name = "mobileNoLabel";
            this.mobileNoLabel.Size = new System.Drawing.Size(141, 24);
            this.mobileNoLabel.TabIndex = 1;
            this.mobileNoLabel.Text = "Mobile Number";
            // 
            // MobileNoTxt
            // 
            this.MobileNoTxt.BackColor = System.Drawing.Color.White;
            this.MobileNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MobileNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNoTxt.Location = new System.Drawing.Point(248, 199);
            this.MobileNoTxt.MaxLength = 10;
            this.MobileNoTxt.Multiline = true;
            this.MobileNoTxt.Name = "MobileNoTxt";
            this.MobileNoTxt.Size = new System.Drawing.Size(340, 28);
            this.MobileNoTxt.TabIndex = 1;
            this.MobileNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobileNoTxt_KeyPress);
            this.MobileNoTxt.Leave += new System.EventHandler(this.MobileNoTxt_Leave);
            // 
            // mobileNoPane
            // 
            this.mobileNoPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.mobileNoPane.Location = new System.Drawing.Point(248, 225);
            this.mobileNoPane.Name = "mobileNoPane";
            this.mobileNoPane.Size = new System.Drawing.Size(340, 2);
            this.mobileNoPane.TabIndex = 6;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.companyNameLabel.Location = new System.Drawing.Point(-1, -2);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(687, 50);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Company Title";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(248, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 9;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.passwordPan);
            this.Controls.Add(this.useridPan);
            this.Controls.Add(this.mobileNoPane);
            this.Controls.Add(this.namePan);
            this.Controls.Add(this.SelectTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserIdTxt);
            this.Controls.Add(this.MobileNoTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.mobileNoLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUser_FormClosing);
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox UserIdTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.ComboBox SelectTxt;
        private System.Windows.Forms.Panel namePan;
        private System.Windows.Forms.Panel useridPan;
        private System.Windows.Forms.Panel passwordPan;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label mobileNoLabel;
        private System.Windows.Forms.TextBox MobileNoTxt;
        private System.Windows.Forms.Panel mobileNoPane;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Panel panel1;
    }
}