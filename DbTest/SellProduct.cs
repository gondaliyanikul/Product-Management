using System;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{
    public partial class SellProduct : Form
    {
        manager.DatabaseManager databaseManager;

        public SellProduct()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String payment = "";
            String billnumber = billNumberTxt.Text.Trim();
            String sdate = "";
            String customer = customerNameTxt.Text.Trim();

            if (paymentCombo.SelectedIndex != -1) {
                payment = paymentCombo.Text;
            }
            if (dateTimeTxt.Text != "01-01-2000")
            {
                sdate = dateTimeTxt.Text;
            }
            orderInformations.DataSource = databaseManager.searchSellStock(payment, billnumber, sdate, customer);

            gridViewInformationDesign();
        }

        public void gridViewInformationDesign() {

            orderInformations.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Order Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Pay Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Payment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Sgst"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Cgst"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Pay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Gst"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderInformations.Columns["Sales By"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            orderInformations.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 11, FontStyle.Bold);
            orderInformations.Columns["Order Number"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Name"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Pay Date"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Payment"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Discount"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Sgst"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Cgst"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Amount"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Pay"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Gst"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            orderInformations.Columns["Sales By"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);


        }

        private void SellStock_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;
        }

        private void orderInformationDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                orderInformations.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = orderInformations.Rows[e.RowIndex];

                String order_number = row.Cells[0].Value.ToString();

                orderItemInformations.DataSource = databaseManager.orderNumberInformation(order_number);
                grisViewItemDesign();
            }
        }

        public void grisViewItemDesign() {

            try
            {

                orderItemInformations.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Order Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Total Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Company"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderItemInformations.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                orderItemInformations.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
                orderItemInformations.Columns["Order Number"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                orderItemInformations.Columns["Name"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                orderItemInformations.Columns["Price"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                orderItemInformations.Columns["Total Price"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                orderItemInformations.Columns["Company"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                orderItemInformations.Columns["Quantity"].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderItemInformations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                orderItemInformations.Rows[e.RowIndex].Selected = true;

            }
        }
    }
}
