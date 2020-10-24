
namespace Login
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.new_username_box = new System.Windows.Forms.TextBox();
            this.new_password_box = new System.Windows.Forms.TextBox();
            this.confirm_password_box = new System.Windows.Forms.TextBox();
            this.Sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(279, 105);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(100, 20);
            this.email_box.TabIndex = 4;
            // 
            // new_username_box
            // 
            this.new_username_box.Location = new System.Drawing.Point(279, 165);
            this.new_username_box.Name = "new_username_box";
            this.new_username_box.Size = new System.Drawing.Size(100, 20);
            this.new_username_box.TabIndex = 5;
            // 
            // new_password_box
            // 
            this.new_password_box.Location = new System.Drawing.Point(279, 220);
            this.new_password_box.Name = "new_password_box";
            this.new_password_box.Size = new System.Drawing.Size(100, 20);
            this.new_password_box.TabIndex = 6;
            // 
            // confirm_password_box
            // 
            this.confirm_password_box.Location = new System.Drawing.Point(279, 272);
            this.confirm_password_box.Name = "confirm_password_box";
            this.confirm_password_box.Size = new System.Drawing.Size(100, 20);
            this.confirm_password_box.TabIndex = 7;
            // 
            // Sign_up
            // 
            this.Sign_up.Location = new System.Drawing.Point(279, 336);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(100, 23);
            this.Sign_up.TabIndex = 8;
            this.Sign_up.Text = "Sign Up";
            this.Sign_up.UseVisualStyleBackColor = true;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.confirm_password_box);
            this.Controls.Add(this.new_password_box);
            this.Controls.Add(this.new_username_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox new_username_box;
        private System.Windows.Forms.TextBox new_password_box;
        private System.Windows.Forms.TextBox confirm_password_box;
        private System.Windows.Forms.Button Sign_up;
    }
}