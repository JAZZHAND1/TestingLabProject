using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Login
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            string username = new_username_box.Text;
            string password = new_password_box.Text;
            string email = email_box.Text;
            string confirm_password = confirm_password_box.Text;
            Sign_Up_validate sign_Up_Validate = new Sign_Up_validate();
            sign_Up_Validate.Sign_Up_User(email,username, password, confirm_password); ;
        }
    }
}
