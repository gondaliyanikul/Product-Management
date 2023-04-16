using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbTest
{
    internal class CommonFunction
    {
        public static UserInfo userInfo;

        public static CompanyInfo companyInfo;

        public static void successMessage(String messages, String title) {

            MessageBox.Show(messages, title, MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        }

        public static void errorMessage(String messages, String title)
        {

            MessageBox.Show(messages,  title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void warningMessage(String messages, String title)
        {

            MessageBox.Show( messages, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

    }

    public class UserInfo {
        public int id;
        public String name;
        public String userid;
        public String mobile;
        public String type;
        public UserInfo(int id,String name,String userid,String mobile,String type) {
            this.id = id;
            this.name = name;
            this.userid = userid;
            this.mobile = mobile;
            this.type = type;
        }
    }

    public class CompanyInfo {

        public String company_name;
        public String mobileNo;
        public String email_id;
        public String address;
        public String gst_number;
        public double cgst;
        public double sgst;
        public double discount;

        public CompanyInfo(String company_name, String mobileNo, String email_id, String addr, String gst_number = "0", double cgst = 0, double sgst = 0, double discount = 0) {

            this.company_name = company_name;
            this.mobileNo = mobileNo;
            this.email_id = email_id;
            this.address = addr;
            this.gst_number = gst_number;
            this.cgst = cgst;
            this.sgst = sgst;
            this.discount = discount;
        
        }

    }
}
