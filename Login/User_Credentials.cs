using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Login
{   
    [Serializable]
    public class User_Credentials
    {
        public static int generateID = -1;
        public string email;
        public int ID;
        public string username;
        public string password;

        public User_Credentials()
        {
            generateID = generateID + 1;
        }

        public int return_ID()
        {
            return generateID;
        }
        [JsonIgnore]
        public string Username { get => username; set => username = value; }
        [JsonIgnore]
        public string Password { get => password; set => password = value; }
        [JsonIgnore]
        public int ID1 { get => ID; set => ID = value; }
        [JsonIgnore]
        public string Email { get => email; set => email = value; }
    }

}
