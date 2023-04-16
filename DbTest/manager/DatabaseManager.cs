using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace DbTest.manager
{
    public delegate void Mycallback(Boolean res, String msg);

    public delegate void LoginCallback(Boolean res, String msg, String type);

    public delegate void UserReadCallback(Boolean res, String msg, String name, String user, String nums, String type, String pass);

    public delegate void UpdateCallback(Boolean res, String msg, String user, String name, String nums, String type, String pass);

    public delegate void ProductReadCallback(Boolean res, String msg, int id, String pname, int srate, int prate, int quantity, String company, String descrip);

    public delegate void CompanySettingCallback(Boolean res, String msg, int id, String name, String cname, String mobile, String email, String address, String gstno, Double cgst, Double sgst, Double discount);

    public delegate void VendorReadCallback(Boolean res, String msg, int id, String name, String mobile, String email, String address);

    public delegate void SelectedValueCallback(Boolean res, String msg, int id, int purchse, int quantity, String company);

    public delegate void ReturnPurchaseId(int id);

    public delegate void FetchProductAndCompany(Boolean res, String product_name, String sale_rate);

    public delegate void FetchSaleRateAndQuantity(Boolean res, int sale_rat, int quantity);

    public delegate void FetchProduct(Boolean res, String product_name, int sale_rate, int quantity, String company);

    public delegate void SearchBillCallback(Boolean res, String coustomer_name, String transactio_date, int total_amount);

    public delegate void ChartCallback(Boolean res, String transaction_date, Double total_amount);
    internal class DatabaseManager
    {

        OleDbConnection con;

        public DatabaseManager()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\Database/Test.accdb;Persist Security Info=False");
            con.Open();
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void checkAndOpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void checkLogin(String userid, String pass, LoginCallback loginCallback)
        {

            try
            {

                checkAndOpenConnection();
                OleDbCommand cmd = new OleDbCommand("select * from Users where Userid  = '" + userid + "' and Passwd = '" + pass + "' ", con);

                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {

                    int id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String user_id = reader.GetString(2);
                    String mobile = reader.GetString(3);
                    String type = reader.GetString(4);

                    CommonFunction.userInfo = new UserInfo(id, name, user_id, mobile, type);

                    loginCallback(true, "Login Success", reader.GetString(4));
                }
                else
                {
                    loginCallback(false, "Login fail", "");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                loginCallback(false, ex.Message, "");
            }

        }

        public void CompanyCreating(String name, String companyNm, String mobileNo, String email, String companyAdd, Mycallback mycallback)
        {

            try
            {
                checkAndOpenConnection();
                OleDbCommand cmd = new OleDbCommand("insert into Company(Name,CompName,Mobile,EmailId,CompAdd,GstNo)values('" + name + "','" + companyNm + "','" + mobileNo + "','" + email + "','" + companyAdd + "','')", con);
                int i = cmd.ExecuteNonQuery();

                CommonFunction.companyInfo = new CompanyInfo(companyNm, mobileNo, email, companyAdd);

                if (i > 0)
                    mycallback(true, "Company Create");
                else
                    mycallback(false, "Company Not Create");
            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }

        public void adminAndUserCreating(String name, String user, String nums, String type, String pass, Mycallback mycallback)
        {

            try
            {
                checkAndOpenConnection();
                OleDbCommand cmd = new OleDbCommand("insert into Users(Name,Userid,Mobile,Usertype,Passwd)values('" + name + "','" + user + "','" + nums + "','" + type + "','" + pass + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, type + " Create");
                }
                else
                {
                    mycallback(false, type + " Not Create");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }

        public void companyExist(Mycallback mycallback)
        {
            try
            {
                checkAndOpenConnection();
                OleDbCommand cmd = new OleDbCommand("select * from Company", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                mycallback(reader.HasRows, "");
            }
            catch (Exception except)
            {
                mycallback(false, except.Message);
            }
        }

        public void adminExist(Mycallback mycallback)
        {

            try
            {
                checkAndOpenConnection();
                OleDbCommand cmd = new OleDbCommand("select * from Users where Usertype='Admin'", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                mycallback(reader.HasRows, "");
            }
            catch (Exception except)
            {
                mycallback(false, except.Message);
            }

        }

        public DataTable DisplayDetails()
        {


            OleDbCommand cmd = new OleDbCommand("select Name,Userid,Mobile,Usertype from Users", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Load(reader);
            return dt;

        }

        public DataTable searchUser(String search)
        {

            OleDbCommand cmd = new OleDbCommand("select Name,Userid,Mobile,Usertype from Users where Name like '%" + search + "%' ", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Clear();
            dt.Load(reader);
            return dt;
        }

        public void deleteUser(String user, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("delete from Users where Userid='" + user + "'", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Success");
                }
                else
                {
                    mycallback(false, "Fail");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }
        }

        public void userDataFeatch(String id, UserReadCallback userReadCallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select * from Users where Userid = '" + id + "'", con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    String name = reader.GetString(1);
                    String user = reader.GetString(2);
                    String nums = reader.GetString(3);
                    String type = reader.GetString(4);
                    String pass = reader.GetString(5);

                    userReadCallback(true, "Success", name, user, nums, type, pass);

                }

            }
            catch (Exception except)
            {
                userReadCallback(false, except.Message, "", "", "", "", "");
            }

        }

        public void updateUser(String user, String name, String nums, String type, String pass, UpdateCallback updateCallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("update Users set Name='" + name + "',Mobile='" + nums + "',Usertype='" + type + "',Passwd='" + pass + "' where Userid='" + user + "'", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    updateCallback(true, "Update Success", user, name, nums, type, pass);
                }
                else
                {
                    updateCallback(false, "Update Fail", "", "", "", "", "");
                }

            }
            catch (Exception except)
            {
                updateCallback(false, except.Message, "", "", "", "", "");
            }
        }

        public void addProduct(String pname, int srate, int prate, int quantity, String company, String descrip, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("insert into Products(Pname,Srate,Prate,Quantity,Company,Description)values('" + pname + "','" + srate + "','" + prate + "','" + quantity + "','" + company + "','" + descrip + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Success");
                }
                else
                {
                    mycallback(false, "Fail");
                }

            }
            catch (Exception except)
            {
                mycallback(false, except.Message);
            }

        }

        public DataTable productDisplay()
        {

            OleDbCommand cmd = new OleDbCommand("select * from Products", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Clear();
            dt.Load(reader);

            return dt;

        }

        public DataTable searchProduct(String search)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Products where Pname like '%" + search + "%'", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Clear();
            dt.Load(reader);

            return dt;
        }

        public void deleteProduct(int id, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("delete from Products where ID=" + id, con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {

                    mycallback(true, "Product Delete Success");
                }
                else
                {
                    mycallback(false, "Product Not Delete");
                }

            }
            catch (Exception Except)
            {
                mycallback(false, Except.Message);
            }

        }


        public void productDataFeatch(int? id, ProductReadCallback productReadCallback)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand("select * from Products where ID=" + id, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    int pid = reader.GetInt32(0);
                    String pname = reader.GetString(1);
                    int srate = reader.GetInt32(2);
                    int prate = reader.GetInt32(3);
                    int quantity = reader.GetInt32(4);
                    String company = reader.GetString(5);
                    String descrip = reader.GetString(6);

                    productReadCallback(true, "Success", pid, pname, srate, prate, quantity, company, descrip);

                }

            }
            catch (Exception ex)
            {
                productReadCallback(false, ex.Message, 0, "", 0, 0, 0, "", "");
            }

        }

        public void updateProduct(int? id, String pname, int srate, int prate, int quantity, String company, String descrip, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("update Products set Pname='" + pname + "',Srate='" + srate + "',Prate='" + prate + "',Quantity='" + quantity + "',Company='" + company + "',Description='" + descrip + "' where ID=" + id, con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Product Update Success");
                }
                else
                {
                    mycallback(false, "Product Not Update");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }

        public void companySetting(CompanySettingCallback companySettingCallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select * from Company", con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String cname = reader.GetString(2);
                    String mobile = reader.GetString(3);
                    String email = reader.GetString(4);
                    String address = reader.GetString(5);
                    String gstno = reader.GetString(6);
                    Double cgst = reader.GetDouble(7);
                    Double sgst = reader.GetDouble(8);
                    Double discount = reader.GetDouble(9);

                    //CommonFunction.companyInfo = new CompanyInfo(cname, mobile, email, gstno, cgst, sgst, discount);

                    companySettingCallback(true, "Company get", id, name, cname, mobile, email, address, gstno, cgst, sgst, discount);

                }

            }
            catch (Exception except)
            {
                companySettingCallback(false, except.Message, 0, "", "", "", "", "", "", 0, 0, 0);
            }
        }

        public void settingUpdate(int id, String name, String cname, String mobile, String email, String address, String gstno, Double cgst, Double sgst, Double discount, Mycallback mycallback)
        {

            try
            {
                OleDbCommand cmd = new OleDbCommand("update Company set Name='" + name + "', CompName='" + cname + "', Mobile='" + mobile + "', EmailId='" + email + "', CompAdd='" + address + "', GstNo='" + gstno + "', Cgst='" + cgst + "', Sgst='" + sgst + "', Discount='" + discount + "' where ID=" + id, con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Company Update Success");
                }
                else
                {
                    mycallback(false, "Company Not Update");
                }
            }
            catch (Exception except)
            {
                mycallback(false, except.Message);
            }

        }

        public void addVendor(String name, String mobile, String email, String address, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("insert into Vendors(name,mobile,email,address)values('" + name + "','" + mobile + "','" + email + "','" + address + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Vender Add Success");
                }
                else
                {
                    mycallback(false, "Vender Not Add");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }
        }

        public DataTable venderFeatchRecord()
        {

            OleDbCommand cmd = new OleDbCommand("select * from Vendors", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Load(reader);

            return dt;

        }

        public void deleteVendor(int id, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("delete from Vendors where ID=" + id, con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Vendor Delete Success");
                }
                else
                {
                    mycallback(false, "Vendor Not Delete");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }

        public void vendeorFeatchRecord(int? id, VendorReadCallback vendorReadCallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select * from Vendors where ID=" + id, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    vendorReadCallback(true, "", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }

            }
            catch (Exception ex)
            {
                vendorReadCallback(false, ex.Message, 0, "", "", "", "");
            }

        }

        public void updateVendor(int? id, String name, String mobile, String email, String address, Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("update Vendors set name='" + name + "',mobile='" + mobile + "',email='" + email + "',address='" + address + "' where ID=" + id, con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Product Update Success");
                }
                else
                {
                    mycallback(false, "Product Not Update");
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }

        public String[] vendorRecord()
        {

            OleDbCommand cmd = new OleDbCommand("select name from Vendors", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            int n = dt.Rows.Count;
            if (n == 0) return new string[] { };
            String[] items = new String[n];
            for (int i = 0; i < n; i++) {
                items[i] = dt.Rows[i].Field<String>(0);
            }

            return items;

        }

        public String[] productRecord()
        {

            OleDbCommand cmd = new OleDbCommand("select Pname from Products", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);
            int n = dt.Rows.Count;
            if (n == 0) return new String[] { };

            String[] items = new String[n];

            for (int i = 0; i < n; i++) {
                items[i] = dt.Rows[i].Field<String>(0);
            }

            return items;

        }

        public void selectValue(String product_name, SelectedValueCallback selectedValueCallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select ID,Prate,Quantity,Company from Products where Pname='" + product_name + "'", con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    selectedValueCallback(true, " ", reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                }


            }
            catch (Exception ex)
            {
                selectedValueCallback(false, ex.Message, 0, 0, 0, "");
            }

        }

        public DataTable searchVendor(String search)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Vendors where name like '%" + search + "%'", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Clear();
            dt.Load(reader);

            return dt;
        }

        public (Boolean res, String msg) multipleStock(int purchase_id, String Pname, int Prate, int quantity, int total, int product_id)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("insert into Vendor_Stock(purchase_id,product_name,purchase_rate,quantity,total,product_id)values('" + purchase_id + "','" + Pname + "','" + Prate + "','" + quantity + "','" + total + "','" + product_id + "')", con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return (true, "Success");
                }
                else
                {
                    return (false, "Erorr");
                }

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }

        }


        public int updateProducts(int product_id, int purchase, int quantity)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("update Products set Quantity = Quantity  + '" + quantity + "', Prate='" + purchase + "' where ID=" + product_id, con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return i;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }

        public (Boolean res, String message, int id) addVendorPurchase(double total, String vendorName, String payment, String dates)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("insert into Vendor_Purchase(total,vendor_name,payment,dates)values('" + total + "','" + vendorName + "','" + payment + "','" + dates + "')", con);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {

                    OleDbCommand cmd2 = new OleDbCommand("select top 1 ID from Vendor_Purchase order by ID desc", con);

                    OleDbDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        return (true, "Success", reader.GetInt32(0));
                    }
                    else
                    {
                        return (false, "Fail", 0);
                    }

                    //SELECT TOP 1 id FROM Products ORDER BY id DESC;
                    //update Products set Quantity=Quantity+50 where ID=3;

                }
                else
                {
                    return (false, "Fail", 0);
                }

            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);

            }

        }

        public String[] fetchOrderProducts()
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select Pname from Products where Quantity>0", con);

                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                int n = dt.Rows.Count;
                if (n == 0) return new String[] { };
                String[] items = new String[n];
                for (int i = 0; i < n; i++) {
                    items[i] = dt.Rows[i].Field<String>(0);
                }
                return items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new String[] { };
            }

        }

        public String[] productCompany() {

            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand("select distinct Company from products", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            int n = dt.Rows.Count;
            if (n == 0) return new String[] { };
            String[] items = new String[n];

            for (int i = 0; i < n; i++) {
                items[i] = dt.Rows[i].Field<String>(0);
            }

            return items;

        }

        public void fetchSaleRateandQuantity(String product_name, String company, FetchSaleRateAndQuantity fetchSaleRateAndQuantity)
        {

            try
            {
                OleDbCommand cmd = new OleDbCommand("select ID, Pname, Company from Products where Pname='" + product_name + "' and Company='" + company + "' ", con);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    OleDbCommand cmd2 = new OleDbCommand("select Srate, Quantity from Products where ID=" + reader.GetInt32(0), con);

                    OleDbDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        fetchSaleRateAndQuantity(true, reader2.GetInt32(0), reader2.GetInt32(1));
                    }
                }

            }
            catch (Exception ex)
            {
                fetchSaleRateAndQuantity(false, 0, 0);
                MessageBox.Show(ex.Message);
            }

        }

        public void fetchCompanyrecord()
        {

            OleDbCommand cmd = new OleDbCommand("select * from Company", con);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                CommonFunction.companyInfo = new CompanyInfo(reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetDouble(7), reader.GetDouble(8), reader.GetDouble(9));

            }

        }

        /*public void productGetName(Mycallback mycallback)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("select Pname from Products", con);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    mycallback(true, reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                mycallback(false, ex.Message);
            }

        }*/

        public DataTable productData(String product_name)
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand("select Pname as Product_Name, Srate as Sale_Rate, Quantity, Company from Products where Pname like '%" + product_name + "%' or Company like '%" + product_name + "%'", con);

            OleDbDataReader reader = cmd.ExecuteReader();

            dt.Clear();
            dt.Load(reader);

            return dt;
        }

        public DataTable productSearch() {

            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand("select Pname as Product_Name, Srate as Sale_Rate, Quantity, Company from products", con);

            OleDbDataReader reader = cmd.ExecuteReader();

            dt.Clear();
            dt.Load(reader);

            return dt;

        }

        public void counstomerDetailsInsert(string order_number, String customer_name, String date, String payment_type, int discount, int sgst, int cgst, decimal amount, decimal total_pay, decimal total_gst, Mycallback mycallback)
        {
            try {

                OleDbCommand cmd = new OleDbCommand("insert into order_info(order_number,customer_name,transaction_date,payment_type,discount,sgst,cgst,total_amount,total_to_pay,total_gst,sales_by)values('" + order_number + "','" + customer_name + "','" + date + "','" + payment_type + "','" + discount + "','" + sgst + "','" + cgst + "','" + amount + "','" + total_pay + "','" + total_gst + "','abc')", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    mycallback(true, "Payment Success");
                }
                else {
                    mycallback(false, "Payment Error");
                }
            } catch (Exception ex) {
                mycallback(false, ex.Message);
            }

        }

        public (Boolean ress, String msg) counstomerOrderInsert(String order_number, String item_name, int unit_price, Decimal total_price, String company, int quantity) {

            try {

                OleDbCommand cmd = new OleDbCommand("insert into order_items(order_number,item_name,unit_price,total_price,company,quantity)values('" + order_number + "','" + item_name + "','" + unit_price + "','" + total_price + "','" + company + "','" + quantity + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return (true, "Order Success");
                }
                else {
                    return (false, "Order Error");
                }

            } catch (Exception ex) {
                return (false, ex.Message);
            }

        }

        public int quantityUpdate(String product_name, String company, int quantity)
        {

            try
            {

                OleDbCommand cmd = new OleDbCommand("update Products set Quantity = Quantity - '" + quantity + "' where Pname='" + product_name + "' and Company='" + company + "'", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return 0;
                }
                else {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 1;
            }

        }

        public void searchBillNumber(String bill_number, SearchBillCallback searchBillCallback)
        {
            try {

                OleDbCommand cmd = new OleDbCommand("select customer_name,transaction_date,total_amount from order_info where order_number='" + bill_number + "'", con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime dt = reader.GetDateTime(1);
                    
                    searchBillCallback(true, reader.GetString(0), dt.ToShortDateString(), (int)reader.GetDouble(2)); ;
                }


            }
            catch (Exception ex) {
                CommonFunction.errorMessage(ex.Message, "Error");
            }

        }

        public void updateBill(String payment_type, String bill_number, Mycallback mycallback) {

            try {

                OleDbCommand cmd = new OleDbCommand("update order_info set payment_type='" + payment_type + "' where order_number='" + bill_number + "'", con);
                int i = cmd.ExecuteNonQuery();

                if (i > 0) {
                    mycallback(true, "Update Success");
                }
                else {
                    mycallback(false, "Update Fail");
                }

            }
            catch (Exception ex) {
                mycallback(false, ex.Message);
            }

        }

        public DataTable searchSellStock(String payment,String billnum, String sdate, String customer) {
            
            String query = "";

            if (payment.Equals("") && billnum.Equals("") && sdate.Equals("") && customer.Equals(""))
            {
                query = "select * from order_info";
            }
            else {
                query = "select * from order_info where";
                if (payment != "" && sdate == "") {
                    query += " payment_type='"+payment+"'";
                }
                else if (payment == "" && sdate != "") {
                    query += " transaction_date=#"+sdate+"#";
                }
                else if (payment != "" && sdate != "") {
                    query += " payment_type='"+payment+ "' AND transaction_date=#"+sdate+"#";
                }
                if (customer != "" || billnum != "")
                {
                    if (query != "select * from order_info where") {
                        query += " AND";
                    }
                    if (customer != "" && billnum == "") {
                        query += " customer_name like '%"+customer+"%'";
                    } else if (customer == "" && billnum != "") {
                        query += " order_number like '%" + billnum + "%'";
                    } else if (customer != "" && billnum != "") {
                        query += " customer_name like '%"+customer+ "%' AND order_number like '%"+billnum+"%'";
                    }
                }
            }
            query = query.Replace("*", "order_number as [Order Number],customer_name as Name,transaction_date as [Pay Date],payment_type as Payment,discount as Discount,sgst as Sgst,cgst as Cgst,total_amount as Amount,total_to_pay as Pay,total_gst as Gst,sales_by as [Sales By]");

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public void compareSellToDate(String startDate, String endDate, ChartCallback chartCallback) {

            OleDbCommand cmd = new OleDbCommand("select transaction_date, sum(total_amount) from order_info group by transaction_date Having transaction_date between #" + startDate+ "# AND #" + endDate + "#", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                DateTime date = reader.GetDateTime(0);

                String newDate = date.ToShortDateString();

                chartCallback(true, newDate, reader.GetDouble(1));
            
            }
        }

        public DataTable orderNumberInformation(String bill_number) {

            OleDbCommand cmd = new OleDbCommand("select order_number as [Order Number], item_name as [Name], unit_price as [Price], total_price as [Total Price], company as [Company], quantity as [Quantity] from order_items where order_number='"+bill_number+"' ", con);

            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

        }


    }
}


