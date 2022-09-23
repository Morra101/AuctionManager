using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Manager
{
    public class User
    {
        private string userID;
        private string firstName;
        private string lastName;
        private string password;
        private bool Admin;

        public User(string userID, string password)
        {
            SetUserID(userID);
            SetPassword(password);            
        }
        public void LogOut()
        {
            SetUserID(null);
            SetPassword(null);
            SetfirstName(null);
            SetLastName(null);

        }
        public void SetUserID(string user)
        {
            userID = user;
            CheckAdmin();
        }
        public string GetUserID()
        {
            return userID;
        }

        public void SetfirstName(string name)
        {
            firstName = name;
        }
        public string GetFirstName()
        {
            return firstName;
        }

        public void SetLastName(string surname)
        {
            lastName = surname;
        }
        public string GetLastName()
        {
            return lastName;
        }

        public void SetPassword(string pass)
        {
            password = pass;
        }
        public string GetPassword()
        {
            return password;
        }

        public void CheckAdmin()
        {          

            if (userID != null)
            {
                char temp = char.Parse(userID.Substring(0, 1));
                if (temp == 'A')
                {
                    this.Admin = true;
                }
                else
                {
                    this.Admin = false;
                }
            }
            else
            {
                this.Admin = false;
            }
        }

        public bool GetAdmin()
        {            
            return Admin;
        }
    }
}
