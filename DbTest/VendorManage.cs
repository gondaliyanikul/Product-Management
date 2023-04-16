using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{
    public partial class VendorManage : Form
    {

        manager.DatabaseManager databaseManager;
        DataTable dt;
        public VendorManage()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            dt = new DataTable();
        }

        private void addVenderBtn_Click(object sender, EventArgs e)
        {
            Vendors vendors = new Vendors(null);
            vendors.ShowDialog();
        }

        private void VendorManage_Load(object sender, EventArgs e)
        {
            companyNameTitle.Text = CommonFunction.companyInfo.company_name;
            display();
        }

        public void display() {

            vendorDetails.Columns.Clear();
            dt = databaseManager.venderFeatchRecord();
            vendorDetails.DataSource = dt;
            editBtn();
            deleteBtn();
            vendorDetails.Refresh();

            DataGridViewDesign();
        }

        public void searchDisplay() {

            String search = vendorSearchTxt.Text;

            vendorDetails.Columns.Clear();
            dt = databaseManager.searchVendor(search);
            vendorDetails.DataSource = dt;
            editBtn();
            deleteBtn();
            vendorDetails.Refresh();

            DataGridViewDesign();

        }

        public void editBtn() {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Edit";
            link.Name = "edit";
            link.Text = "Edit";
            link.UseColumnTextForLinkValue = true;
            vendorDetails.Columns.Add(link);

        }

        public void deleteBtn()
        {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Delete";
            link.Name = "delete";
            link.Text = "Delete";
            link.UseColumnTextForLinkValue = true;
            vendorDetails.Columns.Add(link);

        }

        public void DataGridViewDesign() {

            vendorDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["mobile"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["Edit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vendorDetails.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            vendorDetails.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 11, FontStyle.Bold);
            vendorDetails.Columns["name"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            vendorDetails.Columns["mobile"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            vendorDetails.Columns["email"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            vendorDetails.Columns["address"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            vendorDetails.Columns["Edit"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            vendorDetails.Columns["Delete"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
        }

        private void vendorDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                vendorDetails.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = vendorDetails.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (vendorDetails.Columns[e.ColumnIndex].HeaderText == "Edit") {


                    Vendors vendors = new Vendors(id);
                    vendors.ShowDialog();

                }

                if (vendorDetails.Columns[e.ColumnIndex].HeaderText == "Delete") {

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes) {
                        databaseManager.deleteVendor(id, deleteVendorResponse);

                    }
                }
            }
        }

        public void deleteVendorResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
            }
            else {
                CommonFunction.errorMessage(msg,"Error");
            }

        }

        private void vendorDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in vendorDetails.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String search = vendorSearchTxt.Text;

            if (search != "") {
                searchDisplay();
            }
        }


        private void vendorSearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            String search = vendorSearchTxt.Text;

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
