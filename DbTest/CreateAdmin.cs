using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DbTest
{
    public partial class CreateAdmin : Form
    {
        manager.DatabaseManager databaseManager;

        String mobileNoPattern = "^[0-9]{10}$";

        public CreateAdmin()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();            
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Name", "Required");
                NameTxt.Focus();
            }
            else if (MobileNoTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Mobile Number", "Required");
                MobileNoTxt.Focus();
            }
            else if (UserIdTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter User ID", "Required");
                UserIdTxt.Focus();
            }
            else if (PasswordTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Password", "Required");
                PasswordTxt.Focus();
            }
            else {

                String name = NameTxt.Text;
                String user = UserIdTxt.Text;
                String nums = MobileNoTxt.Text;
                String pass = PasswordTxt.Text;

                databaseManager.adminAndUserCreating(name, user, nums, "Admin", pass, AdminResult);

            }

        }

        public void AdminResult(Boolean result, String messages) {

            if (result)
            {
                CommonFunction.successMessage(messages,"Success");
                clearTextBox();
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else {
                CommonFunction.errorMessage(messages,"Error");
                clearTextBox();
            }

        }

        private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UserIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void clearTextBox() {

            NameTxt.Clear();
            UserIdTxt.Clear();
            PasswordTxt.Clear();
        
        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void MobileNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MobileNoTxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(MobileNoTxt.Text,mobileNoPattern)==false) {
                CommonFunction.warningMessage("Please Enter Valid Number","Required");
                MobileNoTxt.Focus();
            }
        }
    }
}
