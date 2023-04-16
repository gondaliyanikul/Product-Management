using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DbTest
{
    public delegate void BackCallBack();
    public partial class CreateUser : Form
    {
        manager.DatabaseManager databaseManager;
        public String userid;        
        String mobileNoPattern = "^[0-9]{10}$";
        public event BackCallBack callback;    
        public CreateUser(String id)
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            userid = id;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
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
            else if (SelectTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Select User Type", "Required");
                SelectTxt.Focus();
            }
            else {

                String name = NameTxt.Text;
                String user = UserIdTxt.Text;
                String nums = MobileNoTxt.Text;
                String pass = PasswordTxt.Text;
                String type = SelectTxt.Text;

                if (userid == null)
                {
                    databaseManager.adminAndUserCreating(name, user, nums, type, pass, userCreatingResult);
                }
                else if (user != null)
                {
                    databaseManager.updateUser(userid, name, nums, type, pass, updateUserResponse);
                }

            }

        }

        public void updateUserResponse(Boolean res, String msg, String user, String name, String nums, String type, String pass) {

            if (res) {
                CommonFunction.successMessage(msg, "Success");                
                this.Close();
                callback();
            }
            else {
                CommonFunction.errorMessage(msg, "Error");
            }
            
        }

        public void userCreatingResult(Boolean result, String messages) {

            if (result)
            {
                CommonFunction.successMessage(messages, "Success");
                clearTextBox();
                this.Close();
                callback();
            }
            else {
                CommonFunction.errorMessage(messages, "Error"); ;
                clearTextBox(); 
            }

        }

        public void clearTextBox() {
            NameTxt.Clear();
            UserIdTxt.Clear();
            MobileNoTxt.Clear();
            PasswordTxt.Clear();
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            clearTextBox();
            if (userid != null) {
                titleLabel.Text = "Update User";
                addUserBtn.Text = "Update";
                databaseManager.userDataFeatch(userid,dataFeatchResponse);
            }
        }

        public void dataFeatchResponse(Boolean res, String msg, String name, String user, String nums, String type, String pass) {

            if (res)
            {   
                NameTxt.Text = name;
                UserIdTxt.Text = user;
                MobileNoTxt.Text = nums;
                SelectTxt.Text = type;
                PasswordTxt.Text = pass;

            }
            else {
                CommonFunction.successMessage(msg, "Erorr");
            }
        
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

        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserManage userManage = new UserManage();
            userManage.display();
        }

        private void MobileNoTxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(MobileNoTxt.Text,mobileNoPattern) == false) {
                CommonFunction.warningMessage("Please Enter Valid Number","Required");
                MobileNoTxt.Focus();
            }
        }
    }

}
