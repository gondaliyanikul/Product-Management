using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DbTest
{
    public partial class Vendors : Form
    {

        manager.DatabaseManager databaseManager;

        String mobileNoPattern = "^[0-9]{10}$";

        int? id;
        public Vendors(int? id)
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            this.id = id;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Vender Name", "Required");
            }
            else if (mobileNoTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Mobile Number", "Required");
            }
            else if (emailTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Email ID", "Required");
            }
            else if (nameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Address", "Required");
            }
            else {

                if (id == null)
                {
                    databaseManager.addVendor(nameTxt.Text, mobileNoTxt.Text, emailTxt.Text, addressTxt.Text, addVenderResponse);
                }
                else if(id != null){

                    databaseManager.updateVendor(id, nameTxt.Text, mobileNoTxt.Text, emailTxt.Text, addressTxt.Text, addVenderResponse);

                }                
                
            
            }

        }

        public void addVenderResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
                this.Close();
            }
            else {
                CommonFunction.errorMessage(msg, "Erorr");
            }
        
        }

        public void clearTextBox() {

            nameTxt.Clear();
            mobileNoTxt.Clear();
            emailTxt.Clear();
            addressTxt.Clear();
        
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        private void mobileNoTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void emailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 64 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void addressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 ||e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mobileNoTxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(mobileNoTxt.Text,mobileNoPattern) == false) {
                CommonFunction.warningMessage("Mobile Number Invalid","Required");
            }
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;
            
            if (id != null) {
                tittleLabel.Text = "Update Vendor";
                addBtn.Text = "Update";

                databaseManager.vendeorFeatchRecord(id, vendorFeatchRecorsResponse);

            }
        }

        public void vendorFeatchRecorsResponse(Boolean res, String mgs, int id, String name, String mobile, String email, String address) {

            nameTxt.Text = name;
            mobileNoTxt.Text = mobile;
            emailTxt.Text = email;
            addressTxt.Text = address;
        }

    }
}
