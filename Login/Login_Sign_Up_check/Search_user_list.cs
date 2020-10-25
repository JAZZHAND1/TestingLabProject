using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Login
{
    public static class Search_user_list
    {
       public static void find_user(string given_username,string given_password)
       {
          List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
          foreach (var user in users)
          {
             string username = user.Username, password = user.Password;
             Check_user_validity.authenticate_user(username, password, given_username, given_password);

          }
          
       }      
      
    }
}
