using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{

    public partial class SearchProducts : Form
    {
        DataTable datas;
        manager.DatabaseManager databaseManager;

        public SearchProducts()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            datas = new DataTable();
        }

        public void display()
        {

            ProductDetails.Columns.Clear();
            datas = databaseManager.productSearch();
            ProductDetails.DataSource = datas;
            ProductDetails.Refresh();
            gridviewdegin();

        }

        public void searchDisplay()
        {

            String search = SearchTxt.Text;

            ProductDetails.Columns.Clear();
            datas = databaseManager.productData(search);
            ProductDetails.DataSource = datas;
            ProductDetails.Refresh();
            gridviewdegin();
        }

        public void gridviewdegin()
        {

            ProductDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Product_Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Sale_Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductDetails.Columns["Company"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            ProductDetails.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 11, FontStyle.Bold);
            ProductDetails.Columns["Product_Name"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Sale_Rate"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Quantity"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            ProductDetails.Columns["Company"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            companyNameTitle.Text = CommonFunction.companyInfo.company_name;
            display();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String search = SearchTxt.Text;

            if (search != "")
            {
                searchDisplay();
            }
        }

        private void SearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            String search = SearchTxt.Text;

            if (search != "" && e.KeyCode == Keys.Enter) {
                searchDisplay();
            }
            else if (search == "") {
                display();
            }
        }
    }
}
