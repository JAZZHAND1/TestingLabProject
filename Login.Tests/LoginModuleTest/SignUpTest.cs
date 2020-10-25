using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Login;
namespace AgeOfVillagers.Tests.LoginModuleTest
{   
    [TestFixture]
    public class SignUpTest
    {
        [Test]
        public void test_short_password()
        {
            Sign_Up_validate sign_Up = new Sign_Up_validate();
            string actual =sign_Up.Sign_Up_User("Hello@yahoo.com", "hello", "45646", "45646");
            Assert.AreEqual("Password is shorter than 8 characters", actual);
        }
        [Test]
        public void invalid_mail_test()
        {
            Sign_Up_validate sign_Up = new Sign_Up_validate();
            string actual = sign_Up.Sign_Up_User("Hello.com", "hello", "45646", "45646");
            Assert.AreEqual("Please enter a valid email address", actual);
        }
        [Test]
        public void taken_user_name()
        {
            Sign_Up_validate sign_Up = new Sign_Up_validate();
            sign_Up.Sign_Up_User("Vettel@yahoo.com", "Sebastian Vettel", "car_no_05", "car_no_05");
            string actual = sign_Up.Sign_Up_User("Vettel@yahoo.com", "Sebastian Vettel", "car_no_05", "car_no_05");
            Assert.AreEqual("The username is already taken.", actual);
        }
     
    }
}
