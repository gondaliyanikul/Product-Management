using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{

    public partial class ProductManage : Form
    {
        manager.DatabaseManager databaseManager;

        DataTable datas;
        AddProduct addProduct = new AddProduct(null);

        public ProductManage()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            datas = new DataTable();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            addProduct.pid = null;
            addProduct.ShowDialog();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            display();
            addProduct.callback += callback;
        }

        public void display() {

            ProductDetails.Columns.Clear();
            datas = databaseManager.productDisplay();
            ProductDetails.DataSource = datas;
            editBtn();
            deleteBtn();
            ProductDetails.Refresh();
            gridviewdegin();

        }

        public void searchDisplay() {

            String search = SearchTxt.Text;

            ProductDetails.Columns.Clear();
            datas = databaseManager.searchProduct(search);
            ProductDetails.DataSource = datas;
            editBtn();
            deleteBtn();
            ProductDetails.Refresh();
            gridviewdegin();
        }

        public void gridviewdegin() {

            ProductDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Pname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Srate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Prate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Company"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Edit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            ProductDetails.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 11, FontStyle.Bold);
            ProductDetails.Columns["Pname"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Srate"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Prate"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Quantity"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Company"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Description"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Edit"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Delete"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);

        }


        public void editBtn() {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Edit";
            link.Text = "Edit";
            link.Name = "edit";
            link.UseColumnTextForLinkValue = true;
            ProductDetails.Columns.Add(link);
        }

        public void deleteBtn()
        {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Delete";
            link.Text = "Delete";
            link.Name = "delete";
            link.UseColumnTextForLinkValue = true;
            ProductDetails.Columns.Add(link);
        }

        private void ProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                ProductDetails.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = ProductDetails.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (ProductDetails.Columns[e.ColumnIndex].HeaderText == "Edit") {

                    addProduct.pid = id;
                    addProduct.ShowDialog();
                
                }

                if (ProductDetails.Columns[e.ColumnIndex].HeaderText == "Delete") {

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to delete","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes) {

                        databaseManager.deleteProduct( id, productDeleteResponse);
                    
                    }

                }

            }
        }

        public void productDeleteResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
                display();
            }
            else {
                CommonFunction.errorMessage(msg,"Error");
            }
        
        }

        private void ProductDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in ProductDetails.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String search = SearchTxt.Text;

            if (search != "") {
                searchDisplay();
            }

        }

        public void callback() {
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 1500;
            //Thread.Sleep(1000);
            display();
        }

        private void SearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            String search = SearchTxt.Text;

            if (search != "" && e.KeyCode == Keys.Enter)
            {
                searchDisplay();
            }
            else if (search == "")
            {
                display();
            }
        }
    }
}
