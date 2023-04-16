using System;
using System.Windows.Forms;

namespace DbTest
{
    public partial class Setting : Form
    {
        manager.DatabaseManager databaseManager;

        int id;
        public Setting()
        {
            InitializeComponent();
            databaseManager = new manager.DatabaseManager();
        }

        public void companySettingResponse(Boolean res, String msg, int id, String name, String cname, String mobile, String email, String address, String gstno, Double cgst, Double sgst, Double discount) {

            this.id = id;
            NameTxt.Text = name;
            CompanyNameTxt.Text = cname;
            MobileNoTxt.Text = mobile;
            EmailIdTxt.Text = email;
            CompanyAddressTxt.Text = address;
            GstNoTxt.Text = gstno;
            CgstTxt.Text = Convert.ToString(cgst);
            SgstTxt.Text = Convert.ToString(sgst);
            DiscountTxt.Text = Convert.ToString(discount);

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            databaseManager.companySetting(companySettingResponse);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String cname = CompanyNameTxt.Text;
            String mobile = MobileNoTxt.Text;
            String email = EmailIdTxt.Text;
            String address = CompanyAddressTxt.Text;
            String gstno = GstNoTxt.Text;
            Double cgst = Double.Parse(CgstTxt.Text.ToString());
            Double sgst = Double.Parse(SgstTxt.Text.ToString());
            Double discount = Double.Parse(DiscountTxt.Text.ToString());

            databaseManager.settingUpdate(id, name, cname, mobile, email, address, gstno, cgst, sgst, discount, settingUpdateResponse);
            databaseManager.fetchCompanyrecord();
            this.Close();
        }


        public void settingUpdateResponse(Boolean res, String msg) {

            if (res)
            {
                CommonFunction.successMessage(msg, "Success");
            }
            else {
                CommonFunction.errorMessage(msg,"Erorr");
            }
        
        }
    }
}
