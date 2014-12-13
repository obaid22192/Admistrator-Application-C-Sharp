using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Administraionapplication
{

    class DataHelper
    {
        public MySqlConnection connection;
        DataGridView da;
        BindingSource bs;
        DataSet myds;
        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                     "database=dbi281301;" +
                                     "user id=dbi281301;" +
                                     "password=2yHbIUCWYC;" +
                                     "connect timeout=30;";
            connection = new MySqlConnection(connectionInfo);
        }
        public DataHelper(DataGridView da , BindingSource bs , DataSet myds )
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                     "database=dbi281301;" +
                                     "user id=dbi281301;" +
                                     "password=2yHbIUCWYC;" +
                                     "connect timeout=30;";
            connection = new MySqlConnection(connectionInfo);
            this.da = da;
            this.bs = bs;
            this.myds = myds;
        
        }
        public int yetvisitingtheevent()
        {
            String sql = "SELECT COUNT(*) FROM client where `present_ In_event` = 1";
            return Countstatement(sql);
        }
        public int willvisitevent()
        {
            String sql = "SELECT COUNT(*) FROM client ";
            return Countstatement(sql);
        }
        public int SumofBalance()
        {
            string sql = "SELECT SUM(`Balance`) FROM client";
            return Countstatement(sql);

        }
        public int Eventpaymenttotal()
        {
            string sql = "SELECT SUM(`Event_fee`) FROM client";
            return Countstatement(sql);

        }
        public int NrofCampspotsBooked()
        {
            string sql = "SELECT COUNT(*) FROM `tent_booked_by`";
            return Countstatement(sql);
        }
        public int sumofcampamount()
        {
            string sql = "SELECT SUM(`Total_Cost`) FROM `tents_info` WHERE `Availability` = 0";
            return Countstatement(sql);
        }
        public int checkout()
        {
            string sql = "SELECT COUNT(*) FROM `checkout`";
            return Countstatement(sql);
        }
        public int visitorcomeback()
        {

            string sql = " SELECT COUNT(*) FROM `client` WHERE  `present_ In_event` = 0 AND `RFID` NOT IN((SELECT `client_rfid` FROM `checkout` ))";
            return Countstatement(sql);
        }
        public  int Countstatement(string sql)
        {
        MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:


                        return -1;
                    //break;
                    case 1045:


                        return 1045;
                    //break;
                    default:
                        MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -2;
                    //  break;
                }
            }
            finally
            {
                connection.Close();
            }
        
        }
        public int Addproduct(double product_id, double brand_id, string product_name, double price, DateTime date_of_expire, DateTime date_manufacture, int quantity)
        {

            String sql = "INSERT INTO  `product` (`ID_Product`, `Brand_ID_Brand`, `Name`, `Price`, `Date_of_exp`, `Date_of_manufacture`, `Quantity`)  VALUES ( " + "'" + product_id + "'" + "," + "'" + brand_id + "'" + "," + "'" + product_name + "'" + "," + "'" + price + "'" + "," + "'" + date_of_expire.ToString("yyyy-MM-dd") + "'" + "," + "'" + date_manufacture.ToString("yyyy-MM-dd") + "'" + "," + "'" + quantity + "'" + ")";
         

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public int AddhiredItem(int productcode, string item_name, string item_desc, int item_price)
        {

            string sql = "INSERT INTO `available_products_to_hire`(`PRODUCT_NUMBER`, `PRODUCT_NAME`, `P_DESCRIPTION`, `RENTAL_PRICE`,`Availability`) VALUES ( " + productcode + ",'" + item_name + "','" + item_desc + "'," + item_price + "," +"'"+ "Available" + "'"+ ")";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:


                        return -1;
                    //break;
                    case 1045:


                        return 1045;
                    //break;
                    default:
                        MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -2;
                    //  break;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public int searchallavailableproducts()
        {
           return SelectQuerygenrater("SELECT * FROM product");
        }

        public int searxchproductbyID(int id)
        {
           return SelectQuerygenrater("SELECT * FROM `product` WHERE `ID_Product` =" +id);
        }
        public int search_foodproduct_by_name(string name)
        {
            return SelectQuerygenrater("SELECT * FROM `product` WHERE `Name` LIKE '%"+name +"%'");
        }
        public int search_all_available_items_to_hire()
        {
           return SelectQuerygenrater("SELECT * FROM available_products_to_hire");
        }
        public int search_available_hire_item_by_id(int id)
        {

           return SelectQuerygenrater("SELECT * FROM available_products_to_hire WHERE `PRODUCT_NUMBER` ="+id);
        }
        public int search_hire_item_by_name(string name)
        {
            return SelectQuerygenrater("SELECT * FROM available_products_to_hire WHERE `PRODUCT_NAME` LIKE '%" + name +"%'");
        }
        public int free_camp_spots()
        {
            string sql = "SELECT * FROM `tents_info` WHERE `TentId` = 1";
             return SelectQuerygenrater(sql);
        }

       
        
        // **********************************Track Visitor************************************************

        public int Track_All_Clients()
        {
            return SelectQuerygenrater("SELECT * FROM `client`");
        }
        public int Track_one_client(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `client` WHERE `RFID` ='" + RFID + "'");
        }
        public int Client_info(string RFID)
        {
            return SelectQuerygenrater("SELECT  `First_name`, `Last_name`, `ID`, `Phone`, `Address`, `Email`,  `Gender`, `Birth_day`, `present_ In_event` FROM `client` WHERE `RFID` ='" + RFID+"'");
        }
        public int Account_info(string RFID)
        {

            return SelectQuerygenrater("SELECT  `First_name`, `Last_name`, `Balance` , `Event_fee` FROM `client` WHERE `RFID` = '" + RFID + "'");
        }
        public int Shoping_history(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `bill_of_products` WHERE `Client_RFID` = '" + RFID + "'");
        }
        public int Hired_stuff(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `hired_stuff` WHERE `Client_RFID` = '" + RFID + "'");
        }
        public int Tent_booked(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `tent_booked_by` WHERE `Client_RFID` = '" + RFID + "'");
        }
        public int Deposite(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `deposit` WHERE `Client_RFID` = '" + RFID + "'");
        }
        public int Event_payment_history(string RFID)
        {
            return SelectQuerygenrater("SELECT * FROM `payment_event` WHERE `Client_RFID` = '" + RFID + "'");
        }
        // **********************************Track Visitor************************************************


        // **********************************NOt Assigned  Rfid************************************************
        public int Notgotrfidyet()
        {

            return SelectQuerygenrater("SELECT `RFID`, `First_name`, `Last_name`, `ID`,  `Gender` FROM `client` WHERE `RFID_Assigned` = 0" );
        }



        // **********************************Not Assign Rfid************************************************
        public int SelectQuerygenrater(string sql)
        {
            MySqlDataAdapter msqldap;

            

            try
            {
                connection.Open();

                msqldap = new MySqlDataAdapter(sql, connection);
                myds.Reset();
                da.DataSource = null;
               
                msqldap.Fill(myds, "table");
                bs.DataSource = null;
                bs.DataSource = myds.Tables[0];
                
                da.Refresh();
                
                da.DataSource = bs;
                
                return bs.Count;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                      
                        return -1;
                        //break;
                    case 1045:

                       
                        return 1045;
                        //break;
                    default:
                        MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                      //  break;
                }
            }
            finally
            {
                connection.Close();
            }
        
        
        }
       
        public int DeleteFoodProduct()
        {
            return DeleteORupdate("DELETE FROM product WHERE `ID_Product`  = @param1");

        }
        public int deletehireitem_by_id()
        {
            return DeleteORupdate("DELETE FROM available_products_to_hire WHERE `PRODUCT_NUMBER`  = @param1");
        }
        public int deleteallfoodproducts()
        {
           return deleteall("DELETE FROM product");
        
        }
        public int deleteallitems()
        {
           return deleteall("DELETE FROM available_products_to_hire ");
        }
        //************************************Update Rfid Or Assign  Rfid**********************************

        public int AssignRfid(string rfidtemp)
        {
            return DeleteORupdate("set foreign_key_checks=0; \n UPDATE `client` SET `RFID` =" + "'" + rfidtemp + "'" + " , `RFID_Assigned`= 1 WHERE `RFID` = @param1");
        }
        public int updaterfidindeposite(string rfidtemp)
        {
            return DeleteORupdate("set foreign_key_checks=0; \n  UPDATE `deposit` SET `Client_RFID` =" + "'" + rfidtemp + "'" + "WHERE `Client_RFID` = @param1");
        }
        public int updaterfidinpyamentevent(string rfidtemp)
        {
            return DeleteORupdate("set foreign_key_checks=0; \n  UPDATE `payment_event` SET `Client_RFID` =" + "'" + rfidtemp + "'" + "WHERE `Client_RFID` = @param1");
        }
        public int updaterfidincamp_booked_by(string rfidtemp)
        {
            return DeleteORupdate("set foreign_key_checks=0; \n  UPDATE `tent_booked_by` SET `Client_RFID` =" + "'" + rfidtemp + "'" + "WHERE `Client_RFID` = @param1");
        }
        public int DeleteORupdate(string sql)
        {
            connection.Open();
            try
            {

               
                 
                    string query = @sql;
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@param1", da.Rows[da.CurrentCell.RowIndex].Cells[0].Value);


                   
                       int a = cmd.ExecuteNonQuery();
                     
                        
                       
                        return a;
                
            }
                    
                    catch (MySqlException ex)
                    {
                      
                        switch (ex.Number)
                        {
                            case 0:
                               
                                return -1;
                            case 1045:

                              
                                return 1045;
                            default:
                                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return 0;
                        }
                    }
                   
                    finally
                    {
                        connection.Close();
                    }
            return -3;
        }

        public int deleteall(string sql)
        { 
        MySqlCommand comm = new MySqlCommand(sql , connection);


        try
        {
            connection.Open();
       int temp =     comm.ExecuteNonQuery();
       return temp;

        }
        catch (MySqlException ex)
        {
           
            switch (ex.Number)
            {
                case 0:

                    return -1;
                case 1045:


                    return 1045;
                default:
                    MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            return 0;
        }
        finally
        {
            connection.Close();
        }

        
        }
        
    }
}
