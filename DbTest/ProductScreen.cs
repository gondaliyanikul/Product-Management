using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{
    public partial class ProductScreen : Form
    {
        manager.DatabaseManager databaseManager;

        String product_name;
        String company;

        DataTable table = new DataTable("table");

        int available = 0;
        int quantity = 0;

        private int printItem = 0;
        private Decimal total_total = 0;
        decimal total_pay = 0;

        public ProductScreen()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void StockManage_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            dataGridViewColumns();

            allDesable();

            productCombo.Items.AddRange(databaseManager.fetchOrderProducts());

            companyCombo.Items.AddRange(databaseManager.productCompany());

            databaseManager.fetchCompanyrecord();

            //orderNumberTxt.Text = Convert.ToString(randomNumber().ToString());

            //getRecord();

        }

        public void allDesable() {

            orderNumberTxt.Enabled = false;
            orderNumberTxt.Clear();
            transactionDateTxt.Enabled = false;
            transactionDateTxt.Clear();
            customerNameTxt.Clear();
            customerNameTxt.Enabled = false;
            paymentTypeCombo.SelectedIndex = -1;
            paymentTypeCombo.Enabled = false;
            productCombo.Enabled = false;
            companyCombo.Enabled = false;
            unitPriceTxt.Enabled = false;
            availableTxt.Enabled = false;
            discountTxt.Enabled = false;
            discountTxt.Clear();
            sgstTxt.Enabled = false;
            sgstTxt.Clear();
            cgstTxt.Enabled = false;
            cgstTxt.Clear();
            totalAmountTxt.Clear();
            totalAmountTxt.Enabled = false;
            totalPayTxt.Enabled = false;
            addToCartBtn.Enabled = false;
            printOrderBtn.Enabled = false;
            cancelOrderBtn.Enabled = false;
            newOrderBtn.Enabled = true;
        }

        public String randomNumber() {

            transactionDateTxt.Text = DateTime.Now.ToShortDateString();

            Random r = new Random();

            long number1 = r.Next(10000, 99999);
            long number2 = r.Next(10000, 99999);
            char ch1 = (char)r.Next('A', 'Z');
            char ch2 = (char)r.Next('A', 'Z');

            return (ch1 +""+ ch2 + "-" + number1 + "-" + number2);
 
        }

        public void getRecord() {

            discountTxt.Text = CommonFunction.companyInfo.discount.ToString();
            sgstTxt.Text = CommonFunction.companyInfo.sgst.ToString();
            cgstTxt.Text = CommonFunction.companyInfo.cgst.ToString();
        
        }

        public void dataGridViewColumns() {

            table.Columns.Add("Product",Type.GetType("System.String"));
            table.Columns.Add("Company",Type.GetType("System.String"));
            table.Columns.Add("Quantity",Type.GetType("System.Int32"));
            table.Columns.Add("Price",Type.GetType("System.Int32"));
            
            productSaleTable.DataSource = table;

            deleteBtn();

            dataGridViewDesign();
        }

        public void dataGridViewDesign() {

            productSaleTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productSaleTable.Columns["Product"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productSaleTable.Columns["Company"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productSaleTable.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productSaleTable.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productSaleTable.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            productSaleTable.ColumnHeadersDefaultCellStyle.Font = new Font("arial",11,FontStyle.Bold);
            productSaleTable.Columns["Product"].DefaultCellStyle.Font = new Font("arial",11,FontStyle.Regular);
            productSaleTable.Columns["Company"].DefaultCellStyle.Font = new Font("arial",11,FontStyle.Regular);
            productSaleTable.Columns["Quantity"].DefaultCellStyle.Font = new Font("arial",11,FontStyle.Regular);
            productSaleTable.Columns["Price"].DefaultCellStyle.Font = new Font("arial",11,FontStyle.Regular);
            productSaleTable.Columns["Delete"].DefaultCellStyle.Font = new Font("arial",11,FontStyle.Regular);

        }

        public void deleteBtn() {

            //DataGridViewImageColumn

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Action";
            link.Name = "delete";
            link.Text = "Delete";
            link.UseColumnTextForLinkValue = true;
            productSaleTable.Columns.Add(link);


        }

        

        private void companyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitPriceTxt.Text = "";
            availableTxt.Text = "";

            product_name = productCombo.Text;
            company = companyCombo.Text;

            databaseManager.fetchSaleRateandQuantity(product_name, company, fetchSaleRateAndQuantityResponse);
        }

        public void fetchSaleRateAndQuantityResponse(Boolean res, int sale_rate, int quanrtity) {

            unitPriceTxt.Text = Convert.ToString(sale_rate);
            availableTxt.Text = Convert.ToString(quanrtity);
        
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {

            if (productCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Product", "Required");
                return;
            }
            if (companyCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Company", "Required");
                return;
            }
            if (quantityTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Quantity", "Required");
                quantityTxt.Focus();
                return;
            }
            available = int.Parse(availableTxt.Text);
            quantity = int.Parse(quantityTxt.Text);
            
            if (available < quantity) {
                CommonFunction.warningMessage("Stock Not Available", "Required");
                quantityTxt.Focus();
                return;
            }

            for (int i = 0; i < productSaleTable.Rows.Count; i++)
            {
                String products = productSaleTable.Rows[i].Cells[0].Value.ToString();
                String companys = productSaleTable.Rows[i].Cells[1].Value.ToString();

                if (productCombo.Text == products && companyCombo.Text == companys)
                {
                    CommonFunction.warningMessage("Duplicate Product", "Warning");
                    return;
                }

            }

            table.Rows.Add(productCombo.Text, companyCombo.Text, quantityTxt.Text, unitPriceTxt.Text);

            Decimal total_amount = 0;

            for (int i = 0; i < productSaleTable.Rows.Count; i++)
            {

                total_amount += Decimal.Parse(productSaleTable.Rows[i].Cells[3].Value.ToString()) * Decimal.Parse(productSaleTable.Rows[i].Cells[2].Value.ToString());

            }

            totalAmountTxt.Text = total_amount.ToString();

            clearTextBox();

        }

        public void clearTextBox() {

            productCombo.SelectedIndex = -1;
            companyCombo.SelectedIndex = -1;
            quantityTxt.Clear();
            unitPriceTxt.Clear();
            availableTxt.Clear();
        }

        private void productSaleTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                productSaleTable.Rows[e.RowIndex].Selected = true;

                if (productSaleTable.Columns[e.ColumnIndex].HeaderText == "Delete") {

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to delete","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes) {

                        productSaleTable.Rows.RemoveAt(e.RowIndex);

                    }

                }

            }
        }


        private void companyCombo_MouseClick(object sender, MouseEventArgs e)
        {
            if (productCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Product", "Required");
                return;
            }
        }

        private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitPriceTxt.Text = "";
            availableTxt.Text = "";
            quantityTxt.Text = "";
            companyCombo.SelectedIndex = -1;
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            
            //this.Close();
        }

        public void clearAll() {

            productSaleTable.Columns.Clear();

            customerNameTxt.Clear();
            paymentTypeCombo.SelectedIndex = -1;
            productCombo.SelectedIndex = -1;
            companyCombo.SelectedIndex = -1;
            quantityTxt.Clear();
            unitPriceTxt.Clear();
            availableTxt.Clear();

        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            // print document print order

            Font title = new Font("Arial", 45, FontStyle.Bold);
            Font font = new Font("Arial", 15, FontStyle.Regular);
            Font headerFont = new Font("Arial", 15, FontStyle.Bold);
            

            //Title Name

            e.Graphics.DrawString(" Receipt ", title, Brushes.Black, 525, 35);

            // Company Name
            e.Graphics.DrawString("Company Name : "+CommonFunction.companyInfo.company_name, font, Brushes.Black, 25, 35);
            //Company Mobile
            e.Graphics.DrawString("Mobile : " + CommonFunction.companyInfo.mobileNo, font, Brushes.Black, 25, 65);
            //Company Email
            e.Graphics.DrawString("Email : " + CommonFunction.companyInfo.email_id, font, Brushes.Black, 25, 95);
            //GST Number
            e.Graphics.DrawString("GST Number : " + CommonFunction.companyInfo.gst_number, font, Brushes.Black, 25, 125);
            //Company Address
            e.Graphics.DrawString("Address : " + CommonFunction.companyInfo.address, font, Brushes.Black, 25, 155);
            //Customer Name
            e.Graphics.DrawString("Customer Name : "+customerNameTxt.Text, font, Brushes.Black, 25, 200);
            //Bill Date
            e.Graphics.DrawString("Date : "+DateTime.Now.ToShortDateString(), font, Brushes.Black, 550, 130);
            //Bill Number
            e.Graphics.DrawString("Bill Number : "+orderNumberTxt.Text, font, Brushes.Black, 550, 165);
            // Sales By Name
            //e.Graphics.DrawString("Sales By : " +"Abc", font, Brushes.Black, 550, 115);



            
            if (paymentTypeCombo.Text == "Borrow")
            {
                // Unpaid Order
                e.Graphics.DrawString("Order Unpaid", font, Brushes.Black, 550,200);
            }
            // ------
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 255));
            // Item Header
            e.Graphics.DrawString("No", headerFont, Brushes.Black, 30, 275);
            e.Graphics.DrawString("Item Name", headerFont, Brushes.Black, 70, 275);
            e.Graphics.DrawString("Quantity", headerFont, Brushes.Black, 405, 275);
            e.Graphics.DrawString("Price", headerFont, Brushes.Black, 535, 275);
            e.Graphics.DrawString("Total Price", headerFont, Brushes.Black, 680, 275);
            // ------
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 290));
            int pos = 315;
            // items
            int no = 1;
            int itemNumber = 0;
            Decimal quant = 0;
            Decimal totalPrice = 0;

            for (int i = printItem; i < productSaleTable.Rows.Count; i++)
            {
                itemNumber++;
                if (itemNumber <= 20)
                {
                    printItem++;
                    if (printItem <= productSaleTable.Rows.Count)
                    {

                        Decimal total = ((Decimal.Parse(productSaleTable.Rows[i].Cells[2].Value.ToString()) * Decimal.Parse(productSaleTable.Rows[i].Cells[3].Value.ToString())));
                        e.Graphics.DrawString(no.ToString(), font, Brushes.Black, 30, pos);
                        e.Graphics.DrawString(productSaleTable.Rows[i].Cells[0].Value.ToString(), font, Brushes.Black, 70, pos);

                        e.Graphics.DrawString(productSaleTable.Rows[i].Cells[2].Value.ToString(), font, Brushes.Black, 420, pos);
                        e.Graphics.DrawString(productSaleTable.Rows[i].Cells[3].Value.ToString(), font, Brushes.Black, 545, pos);
                        total_total += total;
                        e.Graphics.DrawString(total.ToString(), font, Brushes.Black, 680, pos);

                        quant += Decimal.Parse(productSaleTable.Rows[i].Cells[2].Value.ToString());
                        totalPrice += Decimal.Parse(productSaleTable.Rows[i].Cells[3].Value.ToString());

                        pos += 30;
                        no++;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, pos));
                    pos += 30;

                    itemNumber = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            pos -= 5;
            // ------
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, pos));
            // total
            pos += 25;
            e.Graphics.DrawString("Total", headerFont, Brushes.Black, 70, pos);
            e.Graphics.DrawString(quant.ToString(), headerFont, Brushes.Black, 420, pos);
            e.Graphics.DrawString(total_total.ToString(), headerFont, Brushes.Black, 680, pos);
            pos += 20;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, pos));
            //decimal price = productSaleTable.Sum(x => x.TotalPrice);
            int cgst = int.Parse(cgstTxt.Text);
            int sgst = int.Parse(sgstTxt.Text);
            decimal CGST = (total_total * cgst) / 100;
            decimal SGST = (total_total * sgst) / 100;
            pos += 30;
            // cgst
            e.Graphics.DrawString("CGST " + cgstTxt.Text + "%", headerFont, Brushes.Black, 405, pos);
            e.Graphics.DrawString(CGST.ToString(), headerFont, Brushes.Black, 680, pos);
            pos += 30;
            // sgst
            e.Graphics.DrawString("SGST " + sgstTxt.Text + "%", headerFont, Brushes.Black, 405, pos);
            e.Graphics.DrawString(SGST.ToString(), headerFont, Brushes.Black, 680, pos);
            pos += 30;
            // total
            e.Graphics.DrawString("Total", headerFont, Brushes.Black, 405, pos);
            e.Graphics.DrawString((total_total + CGST + SGST).ToString(), headerFont, Brushes.Black, 680, pos);

            pos += 35;
            // discount
            int discount = int.Parse(discountTxt.Text);
            decimal DISCOUNT = ((total_total + CGST + SGST) * discount) / 100;
            e.Graphics.DrawString("Discount "+discountTxt.Text+" % ", headerFont, Brushes.Black, 405, pos);
            e.Graphics.DrawString(DISCOUNT.ToString(), headerFont, Brushes.Black, 680, pos);
            pos += 30;
            // total to pay

            total_pay = ((total_total + CGST + SGST) - DISCOUNT);

            e.Graphics.DrawString("Total To Pay", headerFont, Brushes.Black, new Point(405, pos));
            e.Graphics.DrawString(((total_total + CGST + SGST) - DISCOUNT).ToString(), headerFont, Brushes.Black, 680, pos);
            //e.Graphics.DrawString(((total_total + CGST + SGST) – DISCOUNT).ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(680, pos));
            itemNumber = 0;
            printItem = 0;
            no = 1;

            // Notes
            e.Graphics.DrawString("Notes", headerFont, Brushes.Black, 25, pos+=30);
            e.Graphics.DrawString("Thanks for your bussines", font, Brushes.Black, 25, pos+=30);

            // Terms & Conditios
            e.Graphics.DrawString("Terms & Conditions", headerFont, Brushes.Black, 25, pos+=50);
            e.Graphics.DrawString("This is Computer Generated receipt", font, Brushes.Black, 25, pos+=30);

            // Sales By Name
            e.Graphics.DrawString("Authorized Signature : "+CommonFunction.userInfo.name , font, Brushes.Black, 25, pos+=50);


        }

        private void printOrderBtn_Click(object sender, EventArgs e)
        {
            if (productSaleTable.Rows.Count == 0)
            {
                return;
            }
            else if (customerNameTxt.Text == "")
            {
                CommonFunction.warningMessage("Please Enter Customer Name", "Required");
            }
            else if (paymentTypeCombo.Text == "")
            {
                CommonFunction.warningMessage("Please Select payment Type", "Required");
            }
            else
            {

                int discount = int.Parse(discountTxt.Text);
                int sgst = int.Parse(sgstTxt.Text);
                int cgst = int.Parse(cgstTxt.Text);
                decimal total_gst = sgst + cgst;
                decimal total_amount = Decimal.Parse(totalAmountTxt.Text);

                //int total_pay = int.Parse(totalAmountTxt.Text);
                //int total_to_pay = int.Parse(totalPayTxt.Text);

                decimal total_price;

                foreach (DataGridViewRow row in productSaleTable.Rows)
                {

                    int unit_price = int.Parse(row.Cells[3].Value.ToString());

                    total_price = Decimal.Parse(row.Cells[2].Value.ToString()) * Decimal.Parse(row.Cells[3].Value.ToString());

                    (Boolean res, String msg) = databaseManager.counstomerOrderInsert(orderNumberTxt.Text, row.Cells[0].Value.ToString(), (int)row.Cells[3].Value, total_price, row.Cells[1].Value.ToString(), (int)row.Cells[2].Value);

                    int update = databaseManager.quantityUpdate(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), (int)row.Cells[2].Value);
                }

                printPreviewOrder.Document = printDoc;
                printPreviewOrder.ShowDialog();
                databaseManager.counstomerDetailsInsert(orderNumberTxt.Text, customerNameTxt.Text, transactionDateTxt.Text, paymentTypeCombo.Text, discount, sgst, cgst, total_amount, total_pay, total_gst, counstomerOrderInsertResponse);
                allDesable();
            }


        }

        public void counstomerOrderInsertResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
            }
            else {
                CommonFunction.errorMessage(msg, "Error");
            }
        
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProducts searchProducts = new SearchProducts();
            searchProducts.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnpaindOrder unpaindOrder = new UnpaindOrder();
            unpaindOrder.ShowDialog();
        }

        private void unpainOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Restart();
        }

        public void allEnable() {

            orderNumberTxt.Enabled = true;
            transactionDateTxt.Enabled = true;
            customerNameTxt.Enabled = true;
            paymentTypeCombo.Enabled = true;
            productCombo.Enabled = true;
            companyCombo.Enabled = true;
            unitPriceTxt.Enabled = true;
            availableTxt.Enabled = true;
            discountTxt.Enabled = true;
            sgstTxt.Enabled = true;
            cgstTxt.Enabled = true;
            totalAmountTxt.Enabled = true;
            totalPayTxt.Enabled = true;
            addToCartBtn.Enabled = true;
            printOrderBtn.Enabled = true;
            cancelOrderBtn.Enabled = true;
            newOrderBtn.Enabled = false;
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            allEnable();
            orderNumberTxt.Text = Convert.ToString(randomNumber().ToString());
            getRecord();
        }
    }
}