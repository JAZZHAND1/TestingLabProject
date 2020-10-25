using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Login
{
    public class Sign_Up_validate
    {
        public void Sign_Up_User(string email,string username,string password,string confirm_password) 
        {
            if (password != confirm_password)
            {
                MessageBox.Show("Password does not match on two boxes");
                Console.WriteLine(password);
                Console.WriteLine(confirm_password);
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm_password) ||string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields should have a value");
            }
            else
            {
                User_Credentials dummy = new User_Credentials();
                List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
                users.Add(new User_Credentials() { ID1 = dummy.return_ID(), Username = username, Password =password, Email = email});
                JSONSerialization.WriteToJsonFile<List<User_Credentials>>("C:/Users.txt", users);
                MessageBox.Show("Sign Up Successful");
            }
        }

    }
}
