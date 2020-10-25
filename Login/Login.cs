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
            Search_user_list.find_user(given_username, given_password);
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
