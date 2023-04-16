using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DbTest
{
    public partial class CreateCompany : Form
    {
        manager.DatabaseManager databaseManager;

        public CreateCompany()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        String EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        String mobileNoPattern = "^[0-9]{10}$";

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            if (NameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Name", "Required");
                NameTxt.Focus();
            }
            else if (CompanyNameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Company Name", "Required");
                CompanyNameTxt.Focus();
            }
            else if (MobileNumberTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Mobile Number", "Required");
                MobileNumberTxt.Focus();
            }
            else if (EmailIdTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Email ID", "Required");
                EmailIdTxt.Focus();
            }
            else if (CompanyAddressTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Company Address", "Required");
                CompanyAddressTxt.Focus();
            }
            else {
                String name = NameTxt.Text;
                String companyNm = CompanyNameTxt.Text;
                String mobileNu = MobileNumberTxt.Text;
                String email = EmailIdTxt.Text;
                String companyAdd = CompanyAddressTxt.Text;

                databaseManager.CompanyCreating(name, companyNm, mobileNu, email, companyAdd, CompanyResult);
            }

        }

        public void CompanyResult(Boolean result, String messages) {

            if (result)
            {
                CommonFunction.successMessage(messages, "Success");
                clearTextBox();
                CreateAdmin createAdmin = new CreateAdmin();
                this.Hide();
                createAdmin.ShowDialog();
                this.Close();
            }
            else {
                CommonFunction.warningMessage(messages,"Erorr");
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

        private void CompanyNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MobileNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EmailIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 64 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CompanyAddressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 32 || e.KeyChar == 8)
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
            CompanyNameTxt.Clear();
            MobileNumberTxt.Clear();
            EmailIdTxt.Clear();
            CompanyAddressTxt.Clear();

        }

        private void CreateCompany_Load(object sender, EventArgs e)
        {

        }

        private void EmailIdTxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmailIdTxt.Text,EmailPattern) == false) {
                CommonFunction.warningMessage("Invalid Email ID", "Required");
                EmailIdTxt.Focus();
            }
        }

        private void MobileNumberTxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(MobileNumberTxt.Text, mobileNoPattern) == false) {
                CommonFunction.warningMessage("Invalid Mobile Number", "Required");
                MobileNumberTxt.Focus();
            }
        }
    }
}
