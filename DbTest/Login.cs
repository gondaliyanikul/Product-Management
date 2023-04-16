using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class Login : Form
    {

        manager.DatabaseManager databaseManager;
        public Login()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (userTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter User Id", "Required");
                userTxt.Focus();
                return;
            }
            else if (passwordTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Password", "Required");
                passwordTxt.Focus();
                return;
            }
            else {

                String id = userTxt.Text;
                String pass = passwordTxt.Text;

                manager.DatabaseManager databaseManager = new manager.DatabaseManager();
                databaseManager.checkLogin(id, pass, LoginResult);

            }

            
        }

        private void userTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        public void LoginResult(Boolean result, String messages,String type) {
            if (result)
            {
                if (type == "Admin")
                {
                    //CommonFunction.successMessage(messages,"Success");
                    this.Hide();
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else if (type == "User")
                {
                    //CommonFunction.successMessage(messages, "Success");
                    this.Hide();
                    ProductScreen stockManage = new ProductScreen();
                    stockManage.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                CommonFunction.errorMessage(messages,"Error");
                passwordTxt.Clear();
            }
        }

        public void clearTextBox() {

            userTxt.Clear();
            passwordTxt.Clear();
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
            databaseManager.fetchCompanyrecord();
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            ShowImage.Hide();
            HideImage.Show();
        }

        private void HideImage_Click(object sender, EventArgs e)
        {
            HideImage.Hide();
            ShowImage.Show();
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void ShowImage_Click(object sender, EventArgs e)
        {
            ShowImage.Hide();
            HideImage.Show();
            passwordTxt.UseSystemPasswordChar = true;
        }
    }
}
