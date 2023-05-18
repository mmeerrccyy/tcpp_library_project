using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_app
{
    
    public partial class RegisterForm : Form
    {

        Useful_func foo = new Useful_func();

        public RegisterForm()
        {
            InitializeComponent();
            labelError.Visible = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void switchToLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switchToLogin();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (pass1.TextLength > 7 && pass2.TextLength > 7 && new_username.TextLength > 4)
            {
                if (foo.CheckPaswords(pass1.Text.ToString(), pass2.Text.ToString()))
                {
                    if (!User.Check_Username(new_username.Text.ToString()))
                    {
                        labelError.Visible = false;
                        User.Create_User(new_username.Text.ToString(), pass1.Text.ToString());
                        switchToLogin();
                    }
                    else
                    {
                        labelError.Visible = true;
                        labelError.Text = "Username already in use!";
                    }
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "Passwords do not match!";
                }
            }
            else
            {
                MessageBox.Show("Min username length: 5" +
                    "\nMin password length: 8", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPasswrd_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswrd.Checked)
            {
                pass1.UseSystemPasswordChar = false;
                pass2.UseSystemPasswordChar = false;
                showPasswrd.Text = "Hide password";
            }
            else
            {
                pass1.UseSystemPasswordChar = true;
                pass2.UseSystemPasswordChar = true;
                showPasswrd.Text = "Show password";
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                } 
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
