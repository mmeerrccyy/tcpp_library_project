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
    public partial class ReadArticle : Form
    {
        public ReadArticle(Article article)
        {
            InitializeComponent();
            richTextBox1.Text = article.text;
            richTextBox1.ReadOnly = true;
            label1.Text = article.title + "(Author: " + article.Get_Author() + ")";
        }
    }
}
