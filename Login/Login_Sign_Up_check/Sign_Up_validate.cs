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
                List<User_Credentials> users = ReadFromJsonFile<List<User_Credentials>>("C:/Users/Rakib/Desktop/Testing Lab/age-of-villagers-swe-17-88-musfik/solutions/88-musfik/Login/User_Credential_Data/Users.txt");
                users.Add(new User_Credentials() { ID1 = dummy.return_ID(), Username = username, Password =password, Email = email});
                WriteToJsonFile<List<User_Credentials>>("C:/Users/Rakib/Desktop/Testing Lab/age-of-villagers-swe-17-88-musfik/solutions/88-musfik/Login/User_Credential_Data/Users.txt", users);
            }
        }

        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

    }
}
