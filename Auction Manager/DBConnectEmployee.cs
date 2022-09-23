
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
    class DBConnectEmployee
    {

        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnectEmployee()
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

        public DataSet SelectEmployee(string sqlQuery ,string empID)
        {
            string query = sqlQuery;
            if (sqlQuery.Contains("LIKE"))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);                    
                    cmd.Parameters.AddWithValue("@empID", empID);                    

                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds,"Source Table");

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

        public DataTable GetEmployeeList()
        {
            string query = "SELECT * FROM employees";
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
        public bool InsertEmployee(String empID, String adminId, String empName, String empSurn, String empIDnum, String empPass)
        {            
            string query = "INSERT INTO employees (EmployeeID,AdminID,EmployeeName,EmployeeSurname,EmployeeIDNumber,EmployeePassword) VALUES(@empID,@adminID,@empName,@empSurn,@empIdnum,@empPass)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@adminID", adminId);
                cmd.Parameters.AddWithValue("@empName", empName);
                cmd.Parameters.AddWithValue("@empSurn", empSurn);
                cmd.Parameters.AddWithValue("@empIdnum", empIDnum);
                cmd.Parameters.AddWithValue("@empPass", empPass);

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

        public bool EmployeeIDCheck(string empID)
        {
            string query = "SELECT * FROM employees WHERE EmployeeID= @empID";
            //Open connection
            if (this.OpenConnection() == true)
            {                
                MySqlCommand cmd = new MySqlCommand(query, connection);             //Create Command
                cmd.Parameters.AddWithValue("@empID", empID);                     //InsertVariable                
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

        #region update

        public void UpdateEmpName(string empName,string empID)
        {
            string query = "UPDATE employees SET EmployeeName=@empName WHERE EmployeeID=@empID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();                
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@empName", empName);                
                
                
                cmd.ExecuteNonQuery();

                this.CloseConnection();
                
            }
        }

        public void UpdateEmpSurname(string empSurname, string empID)
        {
            string query = "UPDATE employees SET EmployeeSurname=@empSurname WHERE EmployeeID=@empID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@empSurname", empSurname);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateEmpIDNum(string empIDNum, string empID)
        {
            string query = "UPDATE employees SET EmployeeIDNumber=@empIDNum WHERE EmployeeID=@empID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@empIDNum", empIDNum);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateEmpPass(string empPass, string empID)
        {
            string query = "UPDATE employees SET EmployeePassword=@empPass WHERE EmployeeID=@empID";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@empPass", empPass);

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        #endregion

        //Delete statement
        public void Delete(string empID)
        {
            string query = "DELETE FROM employees WHERE EmployeeID=@empID";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
