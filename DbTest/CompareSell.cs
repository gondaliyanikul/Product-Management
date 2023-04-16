using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class CompareSell : Form
    {
        manager.DatabaseManager databaseManager;

        public CompareSell()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        private void CompareSell_Load(object sender, EventArgs e)
        {
            companyNameLabel.Text = CommonFunction.companyInfo.company_name;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(startDateTxt.Text);
            DateTime endDate = Convert.ToDateTime(endDateTxt.Text);

            if (startDate > endDate)
            {
                MessageBox.Show("Invalid Date Please Select Specific Date");
                return;
            }
            else if (startDate == endDate)
            {
                MessageBox.Show("Invalid Date Please Select Specific Date");
            }
            else {
                                
                sellChart.Series["Total_Amount"].Points.Clear();
                databaseManager.compareSellToDate(startDateTxt.Text, endDateTxt.Text, compareSellToDateResponse);
                
            }
        }

        public void compareSellToDateResponse(Boolean res, String date, Double total_amount) {

            sellChart.Series["Total_Amount"].Points.AddXY(date,total_amount.ToString());
        
        }

    }
}
