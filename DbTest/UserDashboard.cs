using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class UserDashboard : Form
    {
        
        public UserDashboard()
        {
            InitializeComponent();
        }

        
        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void stockManageBtn_Click(object sender, EventArgs e)
        {
            ProductScreen stockManage = new ProductScreen();
            stockManage.ShowDialog();
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            SearchProducts searchProducts = new SearchProducts();
            searchProducts.ShowDialog();
        }

        private void unpaidOrderBtn_Click(object sender, EventArgs e)
        {
            UnpaindOrder unpaindOrder = new UnpaindOrder();
            unpaindOrder.ShowDialog();
        }
    }
}
