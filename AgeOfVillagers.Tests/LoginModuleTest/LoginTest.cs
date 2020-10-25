using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Login;

namespace AgeOfVillagers.Tests.LoginModule
{
    public class LoginTest
    {
       [Fact]
       public void valid_username_wrong_password_check()
       {
           Search_user_list.find_user("NodeJS", "123456");
           string expected =  Check_user_validity.Show_Messagebox();
           Assert.Equal("Invalid Username",expected);

       }
      

    }
}
