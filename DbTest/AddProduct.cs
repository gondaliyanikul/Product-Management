using System;
using System.Windows.Forms;

namespace DbTest
{
    public delegate void BackCallback();
    public partial class AddProduct : Form
    {

        manager.DatabaseManager DatabaseManager;

        public event BackCallback callback;

        public AddProduct() { }

        public int? pid;
        public AddProduct(int? id)
        {
            InitializeComponent();
            DatabaseManager = new manager.DatabaseManager();
            pid = id;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductNameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Product Name", "Required");
                ProductNameTxt.Focus();
            }
            else if (SaleRateTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Sale Rate", "Required");
                SaleRateTxt.Focus();
            }
            else if (PurcharseRateTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Purchase Rate", "Required");
                PurcharseRateTxt.Focus();
            }
            else if (QuantityTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Quantity", "Required");
                QuantityTxt.Focus();
            }
            else if (CompanyTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Company", "Required");
                CompanyTxt.Focus();
            }
            else {

                String pname = ProductNameTxt.Text;
                int srate = Convert.ToInt32(SaleRateTxt.Text);
                int prate = Convert.ToInt32(PurcharseRateTxt.Text);
                int quantity = Convert.ToInt32(QuantityTxt.Text);
                String company = CompanyTxt.Text;
                String descrip = DescriptionTxt.Text;

                if (pid == null)
                {
                    DatabaseManager.addProduct(pname, srate, prate, quantity, company, descrip, addProductResponse);

                }
                else if (pid != null) {

                    DatabaseManager.updateProduct(pid, pname, srate, prate, quantity, company, descrip, addProductResponse);
                    
                }

            }
        }

        public void clearTextBox() {

            ProductNameTxt.Clear();
            SaleRateTxt.Clear();
            PurcharseRateTxt.Clear();
            QuantityTxt.Clear();
            CompanyTxt.Clear();
            DescriptionTxt.Clear();
        
        }

        public void addProductResponse(Boolean res, String msg) {
            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
                this.Close();
                callback();
            }
            else {
                CommonFunction.errorMessage(msg,"Erorr");
            }
        
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            clearTextBox();   
            if (pid != null) {
                AddProductBtn.Text = "Update";
                addProductLabel.Text = "Update Product";
                DatabaseManager.productDataFeatch(pid,productDataFeatchResponse);
            }

        }

        public void productDataFeatchResponse(Boolean res, String msg, int id, String pname, int srate, int prate, int quantity, String company, String descrip) {

            if (res)
            {

                ProductNameTxt.Text = pname;
                SaleRateTxt.Text = Convert.ToString(srate);
                PurcharseRateTxt.Text = Convert.ToString(prate);
                QuantityTxt.Text = Convert.ToString(quantity);
                CompanyTxt.Text = company;
                DescriptionTxt.Text = descrip;

            }
            else {
                CommonFunction.errorMessage(msg,"Error");
            }
        }

        private void ProductNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122|| e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        private void SaleRateTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PurcharseRateTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void QuantityTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CompanyTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ProductNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
