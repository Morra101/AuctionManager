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
    class DBConnectStock
    {

        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public DBConnectStock()
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

        #region Connections
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
               

        #region Select 
        public DataTable GetStockList()
        {
            string query = "SELECT * FROM stock";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
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

        public DataSet SelectStock(string sqlQuery, string stockID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@stockID", stockID);

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
            //Open connection

        }

        public bool CheckRegNum(string rNum)
        {
            string query = "SELECT * FROM stock WHERE RegNum= @rNum";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@rNum", rNum);                     //InsertVariable                
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

        public bool CheckStockID(string rNum)
        {
            string query = "SELECT * FROM stock WHERE stockID= @stkID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@stkID", rNum);                     //InsertVariable                
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

        public DataTable GetStockList(string query, string stockID)
        {
            if (this.OpenConnection() == true)
            {
                if (string.IsNullOrEmpty(query))
                {
                    query = "SELECT * FROM auctions";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (!(string.IsNullOrEmpty(stockID)) && query.Contains("@date"))
                {
                    cmd.Parameters.AddWithValue("@date", stockID);
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

        #endregion

        #region Insert
        public bool InsertStock(string stkID, string empID, DateTime dateIn, string rNum, string eNum, string chsNum,string suppID)
        {
            if (empID.Substring(0,1).Equals("A"))
            {
                empID = "ETest123";
            }
            string query = "INSERT INTO stock (stockID,EmployeeID,SupplierID,DateIn,RegNum,EngNum,ChasNum) VALUES(@stkID,@userID,@suppID,@dateIn,@rNum,@eNum,@chsNum)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@userID", empID);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                cmd.Parameters.AddWithValue("@dateIn", dateIn);         //Pierre comment:Did not add AuctionID nor AuctionSoldPrice due to it being added later in the process
                cmd.Parameters.AddWithValue("@rNum", rNum);
                cmd.Parameters.AddWithValue("@eNum", eNum);
                cmd.Parameters.AddWithValue("@chsNum", chsNum);

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
      
        #region Updates
        public void UpdateRNum(string rNum, string stkID)
        {
            string query = "UPDATE stock SET RegNum=@rNum WHERE stockID=@stkID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@rNum", rNum);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        public void UpdateENum(string eNum, string stkID)
        {
            string query = "UPDATE stock SET EngNum=@eNum WHERE stockID=@stkID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@eNum", eNum);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        public void UpdateChsNum(string chsNum, string stkID)
        {
            string query = "UPDATE stock SET ChasNum=@chsNum WHERE stockID=@stkID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@chsNum", chsNum);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        public void UpdateDateIn(DateTime dateIn, string stkID)
        {
            string query = "UPDATE stock SET DateIn=@dateIn WHERE stockID=@stkID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@dateIn", dateIn);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        public void UpdateSupplier(string suppID, string stkID)
        {
            string query = "UPDATE stock SET SupplierID=@suppID WHERE stockID=@stkID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.Parameters.AddWithValue("@suppID", suppID);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        #endregion
        
        #region Delete
        public void Delete(string stkID)
        {
            string query = "DELETE FROM stock WHERE stockID=@stkID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@stkID", stkID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        #endregion

    }
}
