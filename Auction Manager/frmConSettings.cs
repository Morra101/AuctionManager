using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Manager
{
    public partial class frmConSettings : Form
    {
        public frmConSettings()
        {
            InitializeComponent();
        }
        private const string pass = "123!";
        private bool settingChanged;

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfigPass.Text))
            {
                if (txtConfigPass.Text==pass)
                {                 
                    try
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "ConnectionConfig.txt");
                        if (File.Exists(path))
                        {
                            string[] lines = File.ReadAllLines(path);
                            pnlSetting.Enabled = true;
                            txtServer.Text = lines[0];
                            txtPort.Text = lines[1];
                            btnTestConn.Enabled=true;                            
                        }                        
                    }
                    catch (Exception ex )
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }                    
                }
                else
                {
                    pnlSetting.Enabled = false;
                    MessageBox.Show("Password is Incorrect");
                }
            }
            else
            {
                MessageBox.Show("Please enter the password");
            }
        }

        private void FrmConSettings_Load(object sender, EventArgs e)
        {
            btnApplyConfig.Enabled = false;
            btnTestConn.Enabled = false;
        }

        private void BtnApplyConfig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServer.Text)&& !string.IsNullOrEmpty(txtPort.Text)&&settingChanged==true)
            {
                var sourceString = txtServer.Text;
                var match = Regex.Match(sourceString, @"\b(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\b");
                if (match.Success)
                {
                    try
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "ConnectionConfig.txt");
                        if (File.Exists(path))
                        {
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine(txtServer.Text);
                                writer.WriteLine(txtPort.Text);

                            }
                        }
                        MessageBox.Show("Connection settings updated");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The server address needs to be the host computers local ip\n The value you entered is not an IP");
                }

                
            }
            else
            {                
                MessageBox.Show("Conection settings cannot be empty");
            }
        }

        private void BtnTestConn_Click(object sender, EventArgs e)
        {
            DBConnectMySQL myConnection = new DBConnectMySQL();
            if (myConnection.TestConnection())
            {
                MessageBox.Show("Connnection succeeded");                
            }
            else
            {
                MessageBox.Show("Connnection failed");
            }
        }

        private void TxtServer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfigPass.Text))
            {
                settingChanged = true;
                btnApplyConfig.Enabled = true;
            }
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty( txtConfigPass.Text))
            {
                settingChanged = true;
                btnApplyConfig.Enabled = true;
            }
        }
    }
}
