namespace DbTest
{
    partial class CreateAdmin
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
            this.NamePan = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserIdTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreateAdminLabel = new System.Windows.Forms.Label();
            this.PasswordPan = new System.Windows.Forms.Panel();
            this.userIdPan = new System.Windows.Forms.Panel();
            this.mobileNoLabel = new System.Windows.Forms.Label();
            this.MobileNoTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mobileNoPane = new System.Windows.Forms.Panel();
            this.NamePan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamePan
            // 
            this.NamePan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.NamePan.Controls.Add(this.panel2);
            this.NamePan.Location = new System.Drawing.Point(230, 147);
            this.NamePan.Name = "NamePan";
            this.NamePan.Size = new System.Drawing.Size(301, 2);
            this.NamePan.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 2);
            this.panel2.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Location = new System.Drawing.Point(239, 382);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(120, 46);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(230, 314);
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(301, 28);
            this.PasswordTxt.TabIndex = 3;
            // 
            // UserIdTxt
            // 
            this.UserIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTxt.Location = new System.Drawing.Point(230, 251);
            this.UserIdTxt.Multiline = true;
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.Size = new System.Drawing.Size(301, 28);
            this.UserIdTxt.TabIndex = 2;
            this.UserIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTxt_KeyPress);
            // 
            // NameTxt
            // 
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(230, 119);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(301, 29);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(67, 317);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(67, 254);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(77, 25);
            this.UserIdLabel.TabIndex = 9;
            this.UserIdLabel.Text = "User ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(60, 123);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // CreateAdminLabel
            // 
            this.CreateAdminLabel.AutoSize = true;
            this.CreateAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAdminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.CreateAdminLabel.Location = new System.Drawing.Point(208, 43);
            this.CreateAdminLabel.Name = "CreateAdminLabel";
            this.CreateAdminLabel.Size = new System.Drawing.Size(191, 31);
            this.CreateAdminLabel.TabIndex = 7;
            this.CreateAdminLabel.Text = "Create Admin";
            // 
            // PasswordPan
            // 
            this.PasswordPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.PasswordPan.Location = new System.Drawing.Point(230, 342);
            this.PasswordPan.Name = "PasswordPan";
            this.PasswordPan.Size = new System.Drawing.Size(301, 2);
            this.PasswordPan.TabIndex = 17;
            // 
            // userIdPan
            // 
            this.userIdPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.userIdPan.Location = new System.Drawing.Point(230, 279);
            this.userIdPan.Name = "userIdPan";
            this.userIdPan.Size = new System.Drawing.Size(301, 2);
            this.userIdPan.TabIndex = 16;
            // 
            // mobileNoLabel
            // 
            this.mobileNoLabel.AutoSize = true;
            this.mobileNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoLabel.Location = new System.Drawing.Point(67, 190);
            this.mobileNoLabel.Name = "mobileNoLabel";
            this.mobileNoLabel.Size = new System.Drawing.Size(144, 25);
            this.mobileNoLabel.TabIndex = 10;
            this.mobileNoLabel.Text = "Mobile Number";
            // 
            // MobileNoTxt
            // 
            this.MobileNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MobileNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNoTxt.Location = new System.Drawing.Point(230, 186);
            this.MobileNoTxt.MaxLength = 10;
            this.MobileNoTxt.Multiline = true;
            this.MobileNoTxt.Name = "MobileNoTxt";
            this.MobileNoTxt.Size = new System.Drawing.Size(301, 29);
            this.MobileNoTxt.TabIndex = 1;
            this.MobileNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobileNoTxt_KeyPress);
            this.MobileNoTxt.Leave += new System.EventHandler(this.MobileNoTxt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.mobileNoPane);
            this.panel1.Location = new System.Drawing.Point(230, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 2);
            this.panel1.TabIndex = 15;
            // 
            // mobileNoPane
            // 
            this.mobileNoPane.Location = new System.Drawing.Point(0, 0);
            this.mobileNoPane.Name = "mobileNoPane";
            this.mobileNoPane.Size = new System.Drawing.Size(301, 2);
            this.mobileNoPane.TabIndex = 5;
            // 
            // CreateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NamePan);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserIdTxt);
            this.Controls.Add(this.MobileNoTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.mobileNoLabel);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CreateAdminLabel);
            this.Controls.Add(this.PasswordPan);
            this.Controls.Add(this.userIdPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAdmin";
            this.Load += new System.EventHandler(this.CreateAdmin_Load);
            this.NamePan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NamePan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserIdTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CreateAdminLabel;
        private System.Windows.Forms.Panel PasswordPan;
        private System.Windows.Forms.Panel userIdPan;
        private System.Windows.Forms.Label mobileNoLabel;
        private System.Windows.Forms.TextBox MobileNoTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mobileNoPane;
    }
}