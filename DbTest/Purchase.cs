using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{
    public partial class Purchase : Form
    {
        manager.DatabaseManager databaseManager;

        DataTable table = new DataTable("table");

        //int quantitys;
        int product_id;
        int product_quantity;
        int purchase;
        int purchase_id;
        String product_company;
        Double total_purchase;
        public Purchase()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text =  CommonFunction.companyInfo.company_name;
            orderDateTxt.Text = DateTime.Now.ToShortDateString();
            display();
        }

        public void display() {

            vendorCombo.Items.AddRange(databaseManager.vendorRecord());
            productCombo.Items.AddRange(databaseManager.productRecord());

            dataGridView();

        }

        public void dataGridView() {

            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Product Name",Type.GetType("System.String"));
            table.Columns.Add("Purchase Rate",Type.GetType("System.Int32"));
            table.Columns.Add("Company", Type.GetType("System.String"));
            table.Columns.Add("Quantity",Type.GetType("System.Int32"));
            table.Columns.Add("Total",Type.GetType("System.Int32"));
            
            BuyDetails.DataSource = table;

            deleteLink();
            dataGridViewDesign();
        }

        public void deleteLink() {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Delete";
            link.Name = "delete";
            link.Text = "Delete";
            link.UseColumnTextForLinkValue = true;
            BuyDetails.Columns.Add(link);
        
        }

        public void dataGridViewDesign() {
        
            BuyDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Product Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Purchase Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Company"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyDetails.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            BuyDetails.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 11, FontStyle.Bold);
            BuyDetails.Columns["ID"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Product Name"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Purchase Rate"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Company"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Quantity"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Total"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            BuyDetails.Columns["Delete"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
        
        }

        private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            databaseManager.selectValue(productCombo.Text,selectValueResponse);
        }

        public void selectValueResponse(Boolean res, String msg, int id, int purchse, int quantity, String company)
        {
            product_id = id;
            purchaseRateTxt.Text = Convert.ToString(purchse);
            //quantitys = quantity;
            product_company = company;
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (!quantityTxt.Text.Equals(String.Empty))
            {
                purchase = int.Parse(purchaseRateTxt.Text);
                product_quantity = int.Parse(quantityTxt.Text);

                double total = purchase * product_quantity;
                totalTxt.Text = total.ToString();
            }
            else {
                totalTxt.Text = "";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (vendorCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Select Vendor", "Required");
            }
            else if (productCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Select Product", "Required");
            }
            else if (purchaseRateTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Purchase Rate", "Required");
            }
            else if (quantityTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Quantity", "Required");
            }
            else {

                table.Rows.Add(product_id, productCombo.Text, purchaseRateTxt.Text, product_company, quantityTxt.Text, totalTxt.Text);

                clearBox();

            }
            
        }

        public void clearBox() {

            //vendorCombo.Text = String.Empty;
            productCombo.SelectedIndex = -1;
            purchaseRateTxt.Clear();
            quantityTxt.Clear();
            totalTxt.Clear();


        }

        private void BuyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                BuyDetails.Rows[e.RowIndex].Selected = true;

                if (BuyDetails.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        BuyDetails.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (vendorCombo.Text == "") {
                CommonFunction.warningMessage("Please Select Vendor", "Required");
            }

            else if (BuyDetails.Rows.Count == 0) {
                CommonFunction.warningMessage("Record Not Fount","Required");
            }
            else if (paymentCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Select Payment Mode", "Required");
            }
            else {

                for (int i = 0; i <= BuyDetails.Rows.Count - 1; i++)
                {

                    total_purchase += Double.Parse(BuyDetails.Rows[i].Cells[5].Value.ToString());

                }

                String vendorName = vendorCombo.Text;
                String payment = paymentCombo.Text;
                String dates = orderDateTxt.Text;

                (Boolean res, String msg, int id) = databaseManager.addVendorPurchase(total_purchase, vendorName, payment, dates);
                if (res)
                {
                    purchase_id = id;
                }
                else
                {
                    CommonFunction.errorMessage(msg, "Error");
                }

                foreach (DataGridViewRow rows in BuyDetails.Rows)
                {
                    (Boolean r, String messages) = databaseManager.multipleStock(purchase_id, rows.Cells[1].Value.ToString(), (int)rows.Cells[2].Value, (int)rows.Cells[4].Value, (int)rows.Cells[5].Value, product_id);

                    int update = databaseManager.updateProducts((int)rows.Cells[0].Value, (int)rows.Cells[2].Value, (int)rows.Cells[4].Value);

                }

                BuyDetails.Columns.Clear();
                BuyDetails.Refresh();

                if (BuyDetails.Rows.Count == 0)
                {
                    CommonFunction.successMessage("Order Success", "Success");
                    this.Close();
                }

            }
            
        }

        public void retutnPurchaseIdResponse(int id) {

            purchase_id = id;

        }
        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        private void paymentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
