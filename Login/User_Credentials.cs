using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Login
{
    class User_Credentials
    {
        private static int generateID = 0;
        private int ID;
        private string username;
        private string password;

        public User_Credentials()
        {
            generateID = generateID + 1;
        }

        public int return_ID()
        {
            return generateID;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int ID1 { get => ID; set => ID = value; }
    }

}
