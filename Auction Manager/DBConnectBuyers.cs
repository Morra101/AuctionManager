using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auction_Manager
{
    class DBConnectBuyers
    {
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public DBConnectBuyers()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = ConfigVariables.server;
            port = ConfigVariables.port;
            database = "auctiondb";
            uid = "jmppt";
            password = "Auction123!";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        #region open connection
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        #endregion //

        #region close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region selectbuyer
        public DataSet SelectBuyer(string sqlQuery, string BuyerID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@buyer_ID", BuyerID);

                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Source Table");

                    this.CloseConnection();    //close Connection

                    return ds;              //return dataset for the datagridview
                }
                else
                {
                    return null;
                }

            }
            else
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adap.Fill(ds, "Source Table");

                    this.CloseConnection();    //close Connection

                    return ds;              //return dataset for the datagridview
                }
                else
                {
                    return null;
                }
            }
        }
        //Open connection
        #endregion

        public DataTable GetPurchaserList()
        {
            string query = "SELECT * FROM purchasers";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                MySqlDataReader dataReader = cmd.ExecuteReader();                   //Create a data reader and Execute the command


                if (dataReader.HasRows)
                {
                    dt.Load(dataReader);

                    dataReader.Close();
                    this.CloseConnection();
                    return dt;
                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        #region Insert/add Buyer
        public bool InsertBuyers(string buyer_name,string buyer_surname, string buyer_address, string buyer_ID ,string buyer_contactNum,string empID )
        {
            string query = "INSERT INTO purchasers (PName,PSurname,PAddress,PIDNumber, PContactNum , EmployeeID ) VALUES(@buyer_name, @buyer_surname, @buyer_address,@buyer_ID , @buyer_contactNum , @empID)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@buyer_name", buyer_name);
                cmd.Parameters.AddWithValue("@buyer_surname", buyer_surname);
                cmd.Parameters.AddWithValue("@buyer_address", buyer_address);
                cmd.Parameters.AddWithValue("@buyer_ID" , buyer_ID);     
                cmd.Parameters.AddWithValue("@buyer_contactNum", buyer_contactNum);
                cmd.Parameters.AddWithValue("@empID",empID);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                return true;
            }
            else 
            {
                return false;
            }
        }
        #endregion

        #region Update buyers
        public void UpdateBuyerName(string buyer_name, string buyer_ID)
        {
            string query = "UPDATE purchasers SET PName=@buyer_name WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                cmd.Parameters.AddWithValue("@buyer_name", buyer_name);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        public void UpdateBuyerSurname(string buyer_surname , string buyer_ID)
        {
            string query = "UPDATE purchasers SET PSurname=@buyer_surname WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                cmd.Parameters.AddWithValue("@buyer_surname", buyer_surname);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        public void UpdateBuyerAddress(string buyer_address , string buyer_ID)
        {
            string query = "UPDATE purchasers SET PAddress=@buyer_address WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                cmd.Parameters.AddWithValue("@buyer_address", buyer_address);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        public void UpdateBuyerID(string buyer_IDNum, string buyer_ID)
        {
            string query = "UPDATE purchasers SET PurchaserID=@buyer_ID WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                //cmd.Parameters.AddWithValue("@buyer_address", buyer_address);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        public void UpdateBuyerContactNum(string buyer_contactNum , string buyer_ID)
        {
            string query = "UPDATE purchasers SET PConactNum=@buyer_contactNum WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                cmd.Parameters.AddWithValue("@buyer_contactNum", buyer_contactNum);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        #endregion
        #region delete
        public void Delete(string buyer_ID)
        {
            string query = "DELETE FROM purchasers WHERE PurchaserID=@buyer_ID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@buyer_ID", buyer_ID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        #endregion
    }
}
