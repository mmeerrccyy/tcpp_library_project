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
            textBox1.Size = new System.Drawing.Size(224, 26);
            labelError.Visible = false;
        }

        private void showPasswrd_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswrd.Checked)
            {
                maskedTextBox1.UseSystemPasswordChar = false;
                showPasswrd.Text = "Hide password";
            } else
            {
                maskedTextBox1.UseSystemPasswordChar = true;
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
        }
    }
}
