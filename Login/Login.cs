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
            User_Credentials dummy = new User_Credentials();
            List<User_Credentials> users = new List<User_Credentials>();
            users.Add(new User_Credentials() {ID1 = dummy.return_ID(), Username = "Mushfiq", Password = "abc1234",Email="abc.com" });
            users.Add(new User_Credentials() {ID1 = dummy.return_ID(), Username = "Nawsad", Password = "cat1234",Email="cat.com"});
            string given_username = txtUser.Text;
            string given_password = txtPass.Text;
            bool status = false;

            foreach (var user in users)
            {
                string username = user.Username, password = user.Password;
                Check_user_validity validity = new Check_user_validity();
                status = validity.authenticate_user(username, password, given_username, given_password);
                if(status == true)
                {
                    break;
                }
            }

        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
             SignUp Check = new SignUp();
             Check.Show();
             Hide();
        }
    }
}
