using K4os.Compression.LZ4.Streams.Frames;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static library_app.Article;

namespace library_app
{
    public partial class UserForm : Form
    {
        private User user;
        private Article[] articles;
        private Article[] myArticles;
        public UserForm(User user)
        {
            this.user = user;
            InitializeComponent();
            this.Load_Articles();
            this.Load_My_Articles();
        }

        private void Load_Articles()
        {
            comboBox2.Items.Clear();
            this.articles = Article.Get_All_Articles();
            if (this.articles != null )
            {
                foreach (Article article in this.articles)
                {
                    if (article != null)
                    {
                        comboBox2.Items.Add(article.title);
                    }
                }
            }
        }

        private void Load_My_Articles()
        {
            comboBox1.Items.Clear();
            this.myArticles = Article.Get_Users_Articles(this.user);
            if (this.myArticles != null)
            {
                foreach (Article article in this.myArticles)
                {
                    if (article != null)
                    {
                        comboBox1.Items.Add(article.title);
                    }
                }
            }
        }


        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void buttonSaveBookData_Click(object sender, EventArgs e)
        {
            AddArticle form = new AddArticle(user);
            form.ShowDialog();
            this.Load_My_Articles();
        }

        private void buttonUpdateBookData_Click(object sender, EventArgs e)
        {
            Article selectedArticle = articles[comboBox1.SelectedIndex];
            selectedArticle.title = textBoxTitle.Text;
            selectedArticle.text = textArticle.Text;
            selectedArticle.Update_Article();
            this.Load_My_Articles();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            Article selectedArticle = myArticles[comboBox1.SelectedIndex];
            if (selectedArticle.Delete_Article())
            {
                textArticle.Text = string.Empty;
                textBoxTitle.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                comboBox1.SelectedItem = null;
                buttonDeleteBook.Enabled = false;
                buttonUpdateArticle.Enabled = false;
                textBoxTitle.Enabled = false;
                this.Load_My_Articles();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Article selectedArticle = myArticles[comboBox1.SelectedIndex];
                if (selectedArticle != null)
                {
                    textBoxTitle.Text = selectedArticle.title;
                    textArticle.Text = selectedArticle.text;
                    textBoxTitle.Enabled = true;
                    textArticle.Enabled = true;
                    buttonUpdateArticle.Enabled = true;
                    buttonDeleteBook.Enabled = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                Article selectedArticle = articles[comboBox2.SelectedIndex];
                if (selectedArticle != null)
                {
                    ReadArticle form = new ReadArticle(selectedArticle);
                    form.Show();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                Article selectedArticle = articles[comboBox2.SelectedIndex];
                if (selectedArticle != null)
                {
                  richTextBox1.Text = selectedArticle.text;
                }
            }
        }
    }
}
