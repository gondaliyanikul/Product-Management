using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;
        }

        private void UserManageBtn_Click(object sender, EventArgs e)
        {
            UserManage userManage = new UserManage();
            userManage.ShowDialog();

        }

        private void ProductManageBtn_Click(object sender, EventArgs e)
        {
            ProductManage productManage = new ProductManage();
            productManage.ShowDialog();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
                Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendorManage vendorManage = new VendorManage();
            vendorManage.ShowDialog();
        }

        private void compareSellBtn_Click(object sender, EventArgs e)
        {
            CompareSell compareSell = new CompareSell();
            compareSell.ShowDialog();
        }

        private void sellStockBtn_Click(object sender, EventArgs e)
        {
            SellProduct sellStock = new SellProduct();
            sellStock.ShowDialog();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.ShowDialog();
        }
    }
}
