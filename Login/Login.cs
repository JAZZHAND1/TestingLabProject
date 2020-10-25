using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string given_username = txtUser.Text;
            string given_password = txtPass.Text;
            bool status;
           // Check_user_validity validity = new Check_user_validity();
            List<User_Credentials> users = JSONSerialization.ReadFromJsonFile<List<User_Credentials>>("C:/Users.txt");
            foreach (var user in users)
            {
                string username = user.Username, password = user.Password;
                Check_user_validity.authenticate_user(username, password, given_username, given_password);
         
            }
            Check_user_validity.Show_Messagebox();

        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
             SignUp Check = new SignUp();
             Check.Show();
             Hide();
        }
    }
}
