using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers;

namespace Login
{
    class Check_user_validity
    {
        public string username;
        public string password;
        public bool  loginstatus = false;
        public string username_status;
        public string password_status;

        public bool authenticate_user(string username,string password,string given_username,string given_password)
        {
            if (string.IsNullOrEmpty(given_username) || string.IsNullOrEmpty(given_password))
            {
                username_status = "Empty";
                password_status = "Empty";
                MessageBox.Show("username or password cannot be empty");
                return false;
            }
            else if (given_username == username && given_password == password)
            {
                username_status = "Correct";
                password_status = "Correct";
                MessageBox.Show("Successful");
                loginstatus = true;
                VillageWindow a = new VillageWindow();
                a.Show();

                return true;
            }
            else if (given_username == username && given_password != password)
            {
                username_status = "Correct";
                password_status = "Incorrect";
                MessageBox.Show("Invalid Password");
                return false;

            }
            else if (given_username != username && given_password == password)
            {
                username_status = "Incorrect";
                password_status = "Correct";
                MessageBox.Show("Invalid Username");
                return false;

            }
            else
            {
                username_status = "Incorrect";
                password_status = "Incorrect";
                MessageBox.Show("Invalid Username and Password");
                return false;
            }
        }
        public bool login_status()
        {
            return loginstatus;
        }
        public string return_username_status()
        {
            return username_status;
        }
        public string return_password_status()
        {
            return password_status;
        }
    }
}
