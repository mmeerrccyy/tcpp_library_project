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

        //private bool CheckPaswords(string pswd1, string pswd2) 
        //{
        //    labelError.Visible = false;

        //    if (pswd1 == pswd2)
        //    {
        //        return true;
        //    } else
        //    {
        //        labelError.Visible = true;
        //        labelError.Text = "Passwords do not match!";
        //        return false;
        //    }
        //}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(foo.CheckPaswords(pass1.Text.ToString(), pass2.Text.ToString()))
            {
                labelError.Visible = false;
                MessageBox.Show("Registered");
            } else
            {
                labelError.Visible = true;
                labelError.Text = "Passwords do not match!";
            }
        }
    }
}
