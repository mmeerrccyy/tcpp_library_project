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

namespace library_app
{
    public partial class AdminForm : Form
    {

        DB connection = new DB();

        private static ArrayList ListTitle = new ArrayList();
        private static ArrayList ListAuthorFirstName = new ArrayList();
        private static ArrayList ListAuthorLastName = new ArrayList();

        public AdminForm()
        {
            InitializeComponent();
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

        private void AddAuthorToComboBox()
        {
            comboBoxAuthors.Items.Clear();
            ListAuthorFirstName.Clear();
            ListAuthorLastName.Clear();
            try
            {
                connection.openConnection();
                string query = "SELECT first_name, last_name FROM `authors`";
                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListAuthorFirstName.Add(row["first_name"]).ToString();
                        ListAuthorLastName.Add(row["last_name"]).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                connection.Close();
                for (int i = 0; i < ListTitle.Count; i++)
                {
                    string load = ListAuthorFirstName[i] + " " + ListAuthorLastName[i];
                    comboBoxAuthors.Items.Add(load);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void FindInformationAboutBook(string Title)
        {
            try
            {
                connection.openConnection();

                string query = "SELECT title, pages, price, Authors_idAuthors FROM `books`";
                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        textBoxTitle.Text = row["title"].ToString();
                        textBoxPages.Text = row["pages"].ToString();
                        //textBoxPrice.Text = row["Authors_idAuthors"].ToString();
                        textBoxPrice.Text = row["price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void AddBookToComboBox()
        {
            comboBoxBooks.Items.Clear();
            ListTitle.Clear();
            try
            {
                connection.openConnection();
                string query = "SELECT title FROM `books`";
                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListTitle.Add(row["title"]).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                connection.Close();
                for (int i = 0; i < ListTitle.Count; i++)
                {
                    comboBoxBooks.Items.Add(ListTitle[i]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void AddBookData(string add_Title, string add_Pages, string add_Price)
        {
            try
            {
                connection.openConnection();
                string query = "INSERT INTO `books` (title, pages, price) VALUES (@title, @pages, @price)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = add_Title;
                command.Parameters.Add("@pages", MySqlDbType.VarChar).Value = add_Pages;
                command.Parameters.Add("@price", MySqlDbType.Float).Value = add_Price;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book successfully added!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                AddBookToComboBox();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindInformationAboutBook(comboBoxBooks.SelectedItem.ToString());
        }

        private void radioButtonBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBooks.Checked)
            {
                if (radioButtonEdit.Checked)
                {
                    textBoxTitle.Enabled = true;
                    textBoxPages.Enabled = true;
                    textBoxPrice.Enabled = true;
                    buttonSaveBookData.Enabled = true;
                }
                AddBookToComboBox();
                comboBoxBooks.Enabled = true;
            }
            else
            {
                comboBoxBooks.Enabled = false;
            }

        }

        private void radioButtonAuthors_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAuthors.Checked)
            {
                AddAuthorToComboBox();
                comboBoxAuthors.Enabled = true;
            }
            else
            {
                comboBoxAuthors.Enabled = false;
            }
        }

        private void radioButtonReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBooks.Checked && radioButtonReadOnly.Checked)
            {
                textBoxTitle.Enabled = false;
                textBoxPages.Enabled = false;
                textBoxPrice.Enabled = false;
                buttonSaveBookData.Enabled = false;
            }
            else if (radioButtonAuthors.Checked && radioButtonAuthors.Checked)
            {

            }
        }

        private void radioButtonEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBooks.Checked && radioButtonEdit.Checked)
            {
                textBoxTitle.Enabled = true;
                textBoxPages.Enabled = true;
                textBoxPrice.Enabled = true;
                buttonSaveBookData.Enabled = true;
            }
            else if (radioButtonAuthors.Checked && radioButtonEdit.Checked)
            {

            }
        }

        private void buttonSaveBookData_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.TextLength > 3 && textBoxPages.TextLength >= 1)
            {
                AddBookData(textBoxTitle.Text.ToString(), textBoxPages.Text.ToString(), textBoxPrice.Text.ToString());
            }
            else
            {
                MessageBox.Show("Min title length: 4" +
                    "\nMin pages length: 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
