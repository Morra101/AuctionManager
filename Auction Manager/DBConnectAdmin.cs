
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
    class DBConnectAdmin
    {

        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnectAdmin()
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

        public DataSet SelectAdmin(string sqlQuery, string adminID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@adminID", adminID);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Source Table");

                    this.CloseConnection();

                    return ds;
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

                    this.CloseConnection();

                    return ds;
                }
                else
                {
                    return null;
                }
            }


        }

        public DataTable GetAdminList()
        {
            string query = "SELECT * FROM admin";
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

        public bool AdminIDCheck(string adminID)
        {
            string query = "SELECT * FROM admin WHERE AdminID= @adminID";
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@adminID", adminID);
                MySqlDataReader dataReader = cmd.ExecuteReader();

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

        #region Insert

        public bool InsertAdmin(string adminId, string adminName, string adminSurn, string adminIDnum, string adminPass)
        {
            string query = "INSERT INTO admin (AdminID,AdminName,AdminSurname,AdminIDNumber,AdminPassword) VALUES(@adminID,@adminName,@adminSurn,@adminIdnum,@adminPass)";

            //open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@adminID", adminId);
                cmd.Parameters.AddWithValue("@adminName", adminName);
                cmd.Parameters.AddWithValue("@adminSurn", adminSurn);
                cmd.Parameters.AddWithValue("@adminIdnum", adminIDnum);
                cmd.Parameters.AddWithValue("@adminPass", adminPass);

                cmd.ExecuteNonQuery();

                this.CloseConnection();

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
                
        #region update

        public void UpdateAdminName(string adminName, string adminID)
        {
            string query = "UPDATE admin SET AdminName=@adminName WHERE AdminID=@adminID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@adminID", adminID );
                cmd.Parameters.AddWithValue("@adminName", adminName );

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void UpdateAdminSurname(string adminSurname, string adminID)
        {
            string query = "UPDATE admin SET AdminSurname=@adminSurname WHERE AdminID=@adminID"; 

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@adminID", adminID);
                cmd.Parameters.AddWithValue("@adminSurname", adminSurname);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateAdminIDNum(string adminIDNum, string adminID)
        {
            string query = "UPDATE admin SET AdminIDNumber=@adminIDNum WHERE AdminID=@adminID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@adminID", adminID);
                cmd.Parameters.AddWithValue("@adminIDNum", adminIDNum);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateAdminPass(string adminPass, string adminID)
        {
            string query = "UPDATE admin SET AdminPassword=@adminPass WHERE AdminID=@adminID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@adminID", adminID);
                cmd.Parameters.AddWithValue("@adminPass", adminPass);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        #endregion

    }
}

