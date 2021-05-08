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
    public partial class LoginForm : Form
    {
        Useful_func foo = new Useful_func();
        public LoginForm()
        {
            InitializeComponent();
            username.Size = new System.Drawing.Size(224, 26);
            labelError.Visible = false;
        }

        private void showPasswrd_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswrd.Checked)
            {
                password.UseSystemPasswordChar = false;
                showPasswrd.Text = "Hide password";
            }
            else
            {
                password.UseSystemPasswordChar = true;
                showPasswrd.Text = "Show password";
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            foo.LoginUser(username.Text.ToString(), password.Text.ToString());
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
                else
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
