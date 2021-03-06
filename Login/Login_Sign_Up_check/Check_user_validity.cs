﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers;

namespace Login
{
    public static class Check_user_validity
    {

        public static bool loginstatus = false;
        public static string username_status;
        public static string password_status;

        public static bool authenticate_user(string username, string password, string given_username, string given_password)
        {
            loginstatus = false;
            username_status = "Empty";
            password_status = "Empty";
            if (string.IsNullOrEmpty(given_username) || string.IsNullOrEmpty(given_password))
            {
                username_status = "Empty";
                password_status = "Empty";
                return false;
            }
            else if (given_username == username && given_password == password)
            {
                username_status = "Correct";
                password_status = "Correct";
             //   MessageBox.Show("Successful");
                loginstatus = true;
                VillageWindow a = new VillageWindow();
                a.Show();
                return true;
            }
            else if (given_username == username && given_password != password)
            {
                username_status = "Correct";
                password_status = "Incorrect";
                return false;

            }
            else if (given_username != username && given_password == password)
            {
                username_status = "Incorrect";
                password_status = "Correct";
                return false;

            }
            else
            {
                username_status = "Incorrect";
                password_status = "Incorrect";
                return false;
            }
        }
        public static string Show_Messagebox()
        {
            Console.WriteLine(username_status);
            Console.WriteLine(password_status);
            string message="";
            if (username_status == "Empty" || password_status == "Empty")
            {
                message ="username or password cannot be empty";
                MessageBox.Show(message);
                return message;
            }
            else if(username_status == "Correct" && password_status == "Correct")
            {
                message = "Successful";
                MessageBox.Show(message);
                return message;
            }
            else if(username_status == "Correct" && password_status == "Incorrect")
            {
                message = "Invalid Password";
                MessageBox.Show(message);
                return message;
            }
            else if (username_status == "Incorrect" && password_status == "Correct")
            {
                message = "Invalid Username";
                MessageBox.Show(message);
                return message;
            }
            else if(username_status == "Incorrect" && password_status == "Incorrect")
            {
                message = "Invalid Username and Password";
                MessageBox.Show(message);
                return message;
            }
            return message;
        }
        public static bool login_status()
        {
            return loginstatus;
        }
        public static string return_username_status()
        {
            return username_status;
        }
        public static string return_password_status()
        {
            return password_status;
        }
    }
}
