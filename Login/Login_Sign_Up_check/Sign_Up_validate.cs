using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace Login
{
    public class Sign_Up_validate
    {
        public String Sign_Up_User(string email,string username,string password,string confirm_password) 
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
           
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm_password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("No fields may be empty");
                return "No fields may be empty";
            }
            else if (password != confirm_password)
            {
                MessageBox.Show("Password does not match on two boxes");
                return "Password does not match on two boxes";
            }
           
            else if (match.Success==false)
            {
                MessageBox.Show("Please enter a valid email address");
                return "Please enter a valid email address";
            }
            else if (password.Length <=8)
            {

                MessageBox.Show("Password is shorter than 8 characters");
                return "Password is shorter than 8 characters";
            }
           
            else
            {
                User_Credentials dummy = new User_Credentials();
                List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
                users.Add(new User_Credentials() { ID1 = dummy.return_ID(), Username = username, Password =password, Email = email});
                JSONSerialization.WriteToJsonFile<List<User_Credentials>>("C:/Users.txt", users);
                MessageBox.Show("Sign Up Successful");
                return "Sign Up Successful";
            }

            

        }



    }
}
