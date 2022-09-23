
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
    class DBConnectAuction
    {

        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;


        public DBConnectAuction()
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

        #region Connection
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

        #endregion     

        #region SelcectStatements

        public DataTable GetAuctionList(string query, string aucID)
        {
            if (this.OpenConnection() == true)
            {
                if (string.IsNullOrEmpty(query))
                {
                    query = "SELECT * FROM auctions";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (query.Contains("LIKE") && !(string.IsNullOrEmpty(aucID)) && query.Contains("@aucID"))
                {
                    cmd.Parameters.AddWithValue("@aucID", aucID);
                }
                if (query.Contains("=") && !(string.IsNullOrEmpty(aucID)) && query.Contains("@aucID"))
                {
                    cmd.Parameters.AddWithValue("@aucID", aucID);
                }
                if (!(string.IsNullOrEmpty(aucID)) && query.Contains("@date"))
                {
                    cmd.Parameters.AddWithValue("@date", aucID);
                }
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

        public DataSet GetAuctionListDS(string sqlQuery, string aucID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@aucID", aucID);

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

        public bool AuctionIDCheck(string aucID)
        {
            string query = "SELECT * FROM auction WHERE Auction= @aucID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@aucID", aucID);                     //InsertVariable                
                MySqlDataReader dataReader = cmd.ExecuteReader();                   //Create a data reader and Execute the command

                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool StockAucIDCheck(string aucID)
        {
            string query = "SELECT * FROM stock WHERE AuctionID= @aucID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@aucID", aucID);                     //InsertVariable                
                MySqlDataReader dataReader = cmd.ExecuteReader();                   //Create a data reader and Execute the command

                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public DataTable GetAvailableStockList()
        {
            string query = "SELECT stockID,regNum,SupplierID,DateIn FROM stock WHERE AuctionID IS NULL";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adap.Fill(dt);

                this.CloseConnection();    //close Connection

                return dt;              //return dataset for the datagridview
            }
            else
            {
                return null;
            }
        }

        public DataTable GetAuctionStockListDT(string aucID)
        {
            string query = "SELECT * FROM stock WHERE AuctionID = @aucID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aucID", aucID);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adap.Fill(dt);

                this.CloseConnection();    //close Connection
                return dt;              //return dataset for the datagridview
            }
            else
            {
                return null;
            }
        }

        public DataSet GetAvailableStockID()
        {
            string query = "SELECT stockID FROM stock WHERE AuctionID IS NULL";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds, "Source Table");

                this.CloseConnection();    //close Connection

                return ds;
            }
            else
            {
                return null;
            }
        }

        public DataSet GetAuctionStockList(string aucID)
        {
            string query = "SELECT stockID FROM stock WHERE AuctionID = @aucID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aucID", aucID);
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


        public bool GetSoldItemList(string aucID)
        {
            string query = "SELECT stockID,AuctionID,AuctionSoldPrice FROM stock WHERE AuctionID=@aucID";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.CommandText = query;
                //cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@aucID", aucID);

                MySqlDataReader dataReader = cmd.ExecuteReader();                   //Create a data reader and Execute the command

                decimal totalIncomeReceived = 0.0M;
                int itemCount = 0;
                decimal totalSARS = 0.0M;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        totalIncomeReceived += (decimal)dataReader["AuctionSoldPrice"];
                        totalIncomeReceived += ((decimal)dataReader["AuctionSoldPrice"]) * 15 / 100;
                        itemCount++;
                    }
                    dataReader.Close();
                    this.CloseConnection();
                    if (UpdateTotals(aucID, totalIncomeReceived, itemCount, totalSARS))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    MessageBox.Show("No Items have been sold on auction : " + aucID);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Database Couldnt be accesses please contact your system administrator");
                return false;
            }
        }

        public bool CheckAuctionStock(string stkID)
        {
            string query = "SELECT * FROM stock WHERE AuctionID= @stkID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@stkID", stkID);                     //InsertVariable                
                MySqlDataReader dataReader = cmd.ExecuteReader();                   //Create a data reader and Execute the command
                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    dataReader.Close();
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region InsertStatements

        public void InsertNewAuction(string adminId, DateTime aucDate)
        {
            string query = "INSERT INTO auctions(AdminID,AuctionDate) VALUES(@adminID,@aucDate)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@adminID", adminId);
                cmd.Parameters.AddWithValue("@aucDate", aucDate);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                MessageBox.Show("Auction was succesfully added");
            }
            else
            {
                MessageBox.Show("Connection to the database couldnt be established");
            }
        }

        #endregion

        #region update

        public bool UpdateTotals(string aucID, decimal totalIncomeReceived, int itemCount, decimal totalSARS)
        {
            string query = "UPDATE auctions SET TotalIncomeReceived=@totalIncRec,TotalItemsSold=@totalItems,TotalDueSARS=@totalSars WHERE AuctionID=@aucID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aucID", aucID);
                cmd.Parameters.AddWithValue("@totalIncRec", totalIncomeReceived);
                cmd.Parameters.AddWithValue("@totalItems", itemCount);
                cmd.Parameters.AddWithValue("@totalSars", totalSARS);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }            
        }

        public bool UpdateStock(string aucID, string stockID)
        {
            string query = "UPDATE stock SET AuctionID=@aucID WHERE stockID=@stockID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                // try
                //{
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.CommandText = query;
                // cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@aucID", aucID);
                cmd.Parameters.AddWithValue("@stockID", stockID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
                //  }
                // catch (Exception ex )
                //  {
                //      MessageBox.Show(ex.Message);
                //      return false;                    
                // }
                //create mysql command

            }
            else
            {
                return false;
            }
        }

        public void UpdateStockPurch(string stockID, decimal soldPrice)
        {
            string query = "UPDATE stock SET AuctionSoldPrice=@soldPrice WHERE StockID=@stockID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@stockID", stockID);
                cmd.Parameters.AddWithValue("@soldPrice", soldPrice);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateSTKPurchID(string stockID, string purchID)
        {
            string query = "UPDATE stock SET PurchaserID=@purchID WHERE StockID=@stockID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@stockID", stockID);
                cmd.Parameters.AddWithValue("@purchID", purchID);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        #endregion

        #region deleteStatements

        public void Delete(string aucID)
        {
            string query = "DELETE FROM auctions WHERE AuctionID=@aucID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aucID", aucID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        #endregion
    }
}
