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
    class DBConnectSuppliers
    {
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnectSuppliers()
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

        public DataSet SelectSupplier(string sqlQuery, string supID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@supID", supID);

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

        public DataTable GetSuppliersList()
        {
            string query = "SELECT * FROM suppliers";
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

        //Insert statement
        public bool InsertSupplier(String supID, String adminId, Char supBoP, String supAddress, String supName, String supSurn, String supIDnum, String supBusRegNum )
        {
            string query = "INSERT INTO suppliers (SupplierID,AdminID,BusinessOrPrivate,SupplierAddress,SupplierName,SupplierSurname, PrivateIDnum, Business_RegNum) VALUES(@supID,@adminID,@supBoP,@supAddress,@supName,@supSurn,@supIdnum,@supBusRegNum)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.Parameters.AddWithValue("@adminID", adminId);
                cmd.Parameters.AddWithValue("@supBoP", supBoP);
                cmd.Parameters.AddWithValue("@supAddress", supAddress);
                cmd.Parameters.AddWithValue("@supName", supName);
                cmd.Parameters.AddWithValue("@supSurn", supSurn);
                cmd.Parameters.AddWithValue("@supIdnum", supIDnum);               
                cmd.Parameters.AddWithValue("@supBusRegNum", supBusRegNum);

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

        public bool SupplierCheck(string supName, string supSurn)
        {
            string query = $"SELECT * FROM suppliers WHERE SupplierName= '{@supName}' AND SupplierSurname= '{@supSurn}'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@supID", supName);                     //InsertVariable                
                cmd.Parameters.AddWithValue("@supsurn", supSurn);
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

        public void UpdateSupName(string supName, string supID)
        {
            string query = "UPDATE suppliers SET SupplierName=@supName WHERE SupplierID=@supID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@supId", supID);
                cmd.Parameters.AddWithValue("@supName", supName);


                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }

        public void UpdateSupSurname(string supSurname, string supID)
        {
            string query = "UPDATE suppliers SET SupplierSurname=@supSurname WHERE SupplierID=@supID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.Parameters.AddWithValue("@supSurname", supSurname);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateSupIDNum(string supIDNum, string supID)
        {
            string query = "UPDATE suppliers SET PrivateIDnum=@supIDNum WHERE SupplierID=@supID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.Parameters.AddWithValue("@supIDNum", supIDNum);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateSupAddress(string supAddress, string supID)
        {
            string query = "UPDATE suppliers SET SupplierAddress=@supAddress WHERE SupplierID=@supID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.Parameters.AddWithValue("@supAddress", supAddress);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateSupBusRegNum(string supBusRegNum, string supID)
        {
            string query = "UPDATE suppliers SET Business_RegNum=@supBusRegNum WHERE SupplierID=@supID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.Parameters.AddWithValue("@supBusRegNum", supBusRegNum);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string supID)
        {
            string query = "DELETE FROM suppliers WHERE SupplierID=@supID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@supID", supID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
