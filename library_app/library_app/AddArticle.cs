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
    public partial class AddArticle : Form
    {
        private User user;
        public AddArticle(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Article newArticle = new Article(title: articleTitle.Text, text: articleText.Text);
            newArticle.Create_Article(user);
            this.Close();
        }

        private void AddArticle_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
