using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Manager
{
    class ConfigVariables
    {
        private static string v_server = "";

        public static string server
        {
            get { return v_server; }
            set { v_server = value; }
        }

        private static string v_port = "";

        public static string port
        {
            get { return v_port; }
            set { v_port = value; }
        }
    }
}
