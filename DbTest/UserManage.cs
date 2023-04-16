using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DbTest
{
    public partial class UserManage : Form
    {
        manager.DatabaseManager databaseManager;
        DataTable datas;
        CreateUser createUser = new CreateUser(null);
        public UserManage()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
            datas = new DataTable();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            createUser.userid = null;
            createUser.ShowDialog();
        }

        public void display() {
            UserManageDetails.Columns.Clear();
            datas = databaseManager.DisplayDetails();
            UserManageDetails.DataSource = datas;
            editBtn();
            deleteBtn();
            UserManageDetails.Refresh();

            gridViewDesign();
        }

        public void searchUser() {

            String search = SearchUsersTxt.Text;

            UserManageDetails.Columns.Clear();
            datas = databaseManager.searchUser(search);
            UserManageDetails.DataSource = datas;
            editBtn();
            deleteBtn();

            UserManageDetails.Refresh();

            gridViewDesign();
        
        }

        public void gridViewDesign() {

            UserManageDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Userid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Mobile"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Usertype"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Edit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserManageDetails.Columns["Delete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            UserManageDetails.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 12, FontStyle.Bold);

            UserManageDetails.Columns["Name"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            UserManageDetails.Columns["Userid"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            UserManageDetails.Columns["Mobile"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            UserManageDetails.Columns["Usertype"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            UserManageDetails.Columns["Edit"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);
            UserManageDetails.Columns["Delete"].DefaultCellStyle.Font = new Font("arial", 11, FontStyle.Regular);

        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;

            display();
            createUser.callback += callback;
        }

        public void editBtn() {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Edit";
            link.Name = "edit";
            link.Text = "Edit";
            link.UseColumnTextForLinkValue = true;
            UserManageDetails.Columns.Add(link);

        }

        public void deleteBtn() {

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Delete";
            link.Name = "delete";
            link.Text = "Delete";
            link.UseColumnTextForLinkValue = true;
            UserManageDetails.Columns.Add(link);

        }

        private void UserManageDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {

                UserManageDetails.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = UserManageDetails.Rows[e.RowIndex];
                
                DataGridViewRow rowData = UserManageDetails.Rows[e.RowIndex];



                if (UserManageDetails.Columns[e.ColumnIndex].HeaderText == "Edit") {

                    createUser.userid = rowData.Cells[1].Value.ToString();
                    createUser.ShowDialog();

                }

                if (UserManageDetails.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to delete", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    String userId = rowData.Cells[1].Value.ToString();
                    if (dialogResult == DialogResult.OK)
                    {
                        databaseManager.deleteUser(userId, userDeleteResponse);
                    }
                }

            }
        }
        public void userDeleteResponse(Boolean res, String msg)
        {

            if (res)
            {
                CommonFunction.successMessage("User Delete Successfully!","Success");
                display();
            }
            else
            {
                CommonFunction.errorMessage(msg,"Erorr");
            }

        }

        private void UserManageDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserManageDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in UserManageDetails.Rows)
            {
                x.MinimumHeight = 30;
            }

        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            String search = SearchUsersTxt.Text;

            if (search == "") {
                display();
            }
        }

        public void callback() {
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 1500;
            //Thread.Sleep(1000);
            display();
        }

        private void SearchUsersTxt_KeyUp(object sender, KeyEventArgs e)
        {
            String search = SearchUsersTxt.Text;

            if (search != "" && e.KeyCode == Keys.Enter)
            {
                searchUser();
            }
            else if (search == "")
            {
                display();
            }
        }
    }
}
