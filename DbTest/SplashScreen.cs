using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbTest
{
    public partial class SplashScreen : Form
    {

        manager.DatabaseManager databaseManager;
        
        public SplashScreen()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            checkInit();
        }

        public async void checkInit() {
            try
            {
                this.Show();
                await Task.Delay(3000);
                
                databaseManager.companyExist(companyExistResult);

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void companyExistResult(Boolean result, String messages)
        {

            if (result)
            {
                databaseManager.adminExist(adminExistResult);
            }
            else {
                this.Hide();
                CreateCompany createCompany = new CreateCompany();
                createCompany.ShowDialog();
                this.Close();
            }
            if (messages != "") {
                MessageBox.Show(messages);
            }
        }

        public void adminExistResult(Boolean result, String messages)
        {
            if (result)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            else {
                this.Hide();
                CreateAdmin createAdmin = new CreateAdmin();
                createAdmin.ShowDialog();
                this.Close();
            }
            if (messages != "")
            {
                MessageBox.Show(messages);
            }
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (databaseManager != null) {
                databaseManager.closeConnection();
            }
        }

    }
}
