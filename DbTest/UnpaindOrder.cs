using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class UnpaindOrder : Form
    {
        manager.DatabaseManager DatabaseManager;

        public UnpaindOrder()
        {
            InitializeComponent();
            DatabaseManager = new manager.DatabaseManager();
        }

        private void UnpaindOrder_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (billNumberTxt.Text == "") {
                CommonFunction.warningMessage("Please Enter Biil Number", "Required");
            }
            else if (paymentTypeCombo.Text == "") {
                CommonFunction.warningMessage("Please Enter Payment Type", "Required");
            }
            else {
                DatabaseManager.updateBill(paymentTypeCombo.Text, billNumberTxt.Text, updateBillResponse);
            }
        }

        public void updateBillResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Successs");
            }
            else {
                CommonFunction.errorMessage(msg, "Error");
            }
        
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            DatabaseManager.searchBillNumber(billNumberTxt.Text, searchBillNumberResponse);
        }

        public void searchBillNumberResponse(Boolean res, String coustomer_name, String transaction_date, int total_amount) {

            coustomerNameTxt.Text = coustomer_name;
            transactionDateTxt.Text = transaction_date.ToString();
            totalAmountTxt.Text = total_amount.ToString();
        }
    }
}
