using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;

namespace Auction_Manager
{
    class DBConnectMySQLReports
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnectMySQLReports()
        {
            Initialize();
        }

        //Initialize values
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

        public DataTable AuctionInfo()
        {
            string query = "SELECT * FROM auctions";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable EmployeeInfo()
        {
            string query = "SELECT * FROM employees";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable PurchaserInfo()
        {
            string query = "SELECT * FROM purchasers";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable StockInfo()
        {
            string query = "SELECT * FROM stock";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);                
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable SupplierInfo()
        {
            string query = "SELECT * FROM suppliers";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable InvoiceInfo(string purID)
        {
            string query = "SELECT * FROM stock WHERE PurchaserID = @purID";

            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@purID", purID);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.CloseConnection();
                return dt;
            }
            else
            {
                return null;
            }
        }


        //open connection to database
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

        //Close connection
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


    }


}