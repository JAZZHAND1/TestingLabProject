using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Login;
namespace AgeOfVillagers.Tests.LoginModule
{
    [TestFixture]
    public class LoginTest
    {
       [Test]
       public void correct_username_wrong_password_check()
       {
           List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
           Search_user_list.find_user("NodeJS", "1234567");
           string actual =  Check_user_validity.Show_Messagebox();
           Assert.AreEqual("Invalid Password",actual);

       }
       [Test]
       public void correct_username_correct_password()
       {
            List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
            Search_user_list.find_user("NodeJS", "123456");
            string actual = Check_user_validity.Show_Messagebox();
            Assert.AreEqual("Successful", actual);
       }
       [Test]
       public void wrong_username()
       {
           List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
           Search_user_list.find_user("Wrong", "123456");
           string actual = Check_user_validity.Show_Messagebox();
           Assert.AreEqual("Invalid Username", actual);
        }

    }
}
