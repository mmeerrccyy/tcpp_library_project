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
        private static ArrayList ListAuthorName = new ArrayList();
        private static ArrayList currentBookTitle = new ArrayList();
        private static ArrayList currentBookPages = new ArrayList();
        private static ArrayList currentBookYear = new ArrayList();
        private static ArrayList currentBookPrice = new ArrayList();
        private static ArrayList currentBookAuthor = new ArrayList();
        private static ArrayList currentAuthorName = new ArrayList();
        private static ArrayList currentAuthorBirthYear = new ArrayList();

        private object id;
        private object idBook;

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
            comboBoxAddAuthor.Items.Clear();
            ListAuthorName.Clear();
            try
            {
                connection.openConnection();
                string query = "SELECT name FROM `authors`";
                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListAuthorName.Add(row["name"]).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                connection.Close();
                for (int i = 0; i < ListAuthorName.Count; i++)
                {
                    comboBoxAuthors.Items.Add(ListAuthorName[i]);
                    comboBoxAddAuthor.Items.Add(ListAuthorName[i]);
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
                currentBookTitle.Clear();
                currentBookPages.Clear();
                currentBookPrice.Clear();
                currentBookYear.Clear();
                currentBookAuthor.Clear();

                AddAuthorToComboBox();
                textBoxTitle.Clear();
                textBoxPrice.Clear();
                textBoxPages.Clear();
                textBoxYear.Clear();
                connection.openConnection();

                string query = "SELECT title, pages, price, name, write_year FROM `books` LEFT JOIN `authors` ON Authors_idAuthors = idAuthors  WHERE title = '" + Title + "'";
                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        textBoxTitle.Text = row["title"].ToString();
                        textBoxPages.Text = row["pages"].ToString();
                        textBoxPrice.Text = row["price"].ToString();
                        textBoxYear.Text = row["write_year"].ToString();

                        currentBookTitle.Add(row["title"].ToString());
                        currentBookPages.Add(row["pages"].ToString());
                        currentBookPrice.Add(row["price"].ToString());
                        currentBookYear.Add(row["write_year"].ToString());
                        currentBookAuthor.Add(row["name"].ToString());
                        for (int i = 0; i < comboBoxAddAuthor.Items.Count; i++)
                        {
                            if (comboBoxAddAuthor.Items[i].ToString() == row["name"].ToString())
                            {
                                comboBoxAddAuthor.SelectedIndex = i;
                            }
                        }
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

        private void FindInformationAboutAuthor(string Name)
        {

            try
            {
                currentAuthorName.Clear();
                currentAuthorBirthYear.Clear();
                textBoxAuthorName.Text = "";
                textBoxAuthorYear.Text = "";

                connection.openConnection();

                string query = "SELECT birth_year, name FROM `authors` WHERE name = '" + Name + "'";

                MySqlDataReader row;
                row = connection.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        currentAuthorName.Add(row["name"].ToString());
                        currentAuthorBirthYear.Add(row["birth_year"].ToString());
                        textBoxAuthorYear.Text = row["birth_year"].ToString();
                        textBoxAuthorName.Text = row["name"].ToString();
                    }
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

        private void AddBookData(string add_Title, string add_Pages, string add_Price, string add_Year, string add_Name)
        {
            try
            {
                connection.openConnection();

                
                string idAuthor = "SELECT idAuthors FROM `authors` WHERE name = '" + add_Name + "'";
                MySqlDataReader row;
                row = connection.ExecuteReader(idAuthor);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        id = row["idAuthors"].ToString();
                    }
                } else
                {
                    MessageBox.Show("Author not found");
                }
                connection.Close();

                string query = "INSERT INTO `books` (title, pages, price, write_year, Authors_idAuthors) VALUES (@title, @pages, @price, @year, @id)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = add_Title;
                command.Parameters.Add("@pages", MySqlDbType.VarChar).Value = add_Pages;
                command.Parameters.Add("@price", MySqlDbType.Float).Value = add_Price;
                command.Parameters.Add("@year", MySqlDbType.Float).Value = add_Year;
                command.Parameters.Add("@id", MySqlDbType.Float).Value = id;

                connection.openConnection();

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

        private void AddAuthorData(string add_Name, string add_Year)
        {
            try
            {
                string query = "INSERT INTO `authors` (name, birth_year) VALUES (@name, @year)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = add_Name;
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = add_Year;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Author successfully added!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                AddAuthorToComboBox();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void UpdateBookDate(string add_Title, string add_Pages, string add_Price, string add_Year, string add_Name)
        {
            try
            {
                connection.openConnection();

                string idAuthor = "SELECT idAuthors FROM `authors` WHERE name = '" + add_Name + "'";
                MySqlDataReader row;
                row = connection.ExecuteReader(idAuthor);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        id = row["idAuthors"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Author not found");
                }
                connection.Close();

                connection.openConnection();

                MessageBox.Show(currentBookTitle[0].ToString() +
                    "\n" + currentBookPages[0] +
                    "\n" + currentBookPrice[0] +
                    "\n" + currentBookYear[0]);

                string idBooks = "SELECT idBooks FROM `books` WHERE title = '" + currentBookTitle[0].ToString() + "' AND pages = " + currentBookPages[0] + " AND " +
                    "price = " + currentBookPrice[0] + " AND write_year = " + currentBookYear[0];
                MySqlDataReader row2;
                row2 = connection.ExecuteReader(idBooks);
                if (row2.HasRows)
                {
                    while (row2.Read())
                    {
                        idBook = row2["idBooks"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Book not found");
                }

                connection.Close();


                string query = "UPDATE `books` SET title = @title, pages = @pages, price = @price, write_year = @year, Authors_idAuthors = @id WHERE idBooks = @idBook";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = add_Title;
                command.Parameters.Add("@pages", MySqlDbType.VarChar).Value = add_Pages;
                command.Parameters.Add("@price", MySqlDbType.Float).Value = add_Price;
                command.Parameters.Add("@year", MySqlDbType.Int64).Value = add_Year;
                command.Parameters.Add("@id", MySqlDbType.Float).Value = id;
                command.Parameters.Add("@idBook", MySqlDbType.Float).Value = idBook;

                currentBookTitle.Clear();
                currentBookPages.Clear();
                currentBookPrice.Clear();
                currentBookYear.Clear();

                currentBookTitle.Add(add_Title); 
                currentBookPages.Add(add_Pages); 
                currentBookPrice.Add(add_Price); 
                currentBookYear.Add(add_Year); 

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book successfully updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateAuthorDate(string add_Name, string add_Year)
        {

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
                AddBookToComboBox();
                AddAuthorToComboBox();
                comboBoxBooks.Enabled = true;
                if (radioButtonEdit.Checked)
                {
                    BlockUnblock(true, false);
                }
            }
            else
            {
                comboBoxBooks.Enabled = false;
            }
        }

        private bool EmptyAuthorFieldsCheck()
        {
            if (textBoxAuthorName.TextLength > 3 && textBoxAuthorYear.TextLength == 4)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Min name length: 4" +
                    "\nInput year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private bool EmptyBookFieldsCheck()
        {
            if (textBoxTitle.TextLength > 3 && textBoxPages.TextLength >= 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Min title length: 4" +
                    "\nMin pages length: 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void BlockUnblock(bool book, bool author)
        {
            textBoxTitle.Enabled = book;
            textBoxPages.Enabled = book;
            textBoxPrice.Enabled = book;
            textBoxYear.Enabled = book;
            comboBoxAddAuthor.Enabled = book;
            buttonAddBookData.Enabled = book;
            buttonClearBookInfo.Enabled = book;
            buttonDeleteBook.Enabled = book;
            buttonUpdateBookData.Enabled = book;


            textBoxAuthorYear.Enabled = author;
            textBoxAuthorName.Enabled = author;
            buttonAddAuthorData.Enabled = author;
            buttonClearAuthorInfo.Enabled = author;
            buttonDeleteAuthor.Enabled = author;
            buttonUpdateAuthorData.Enabled = author;
        }

        private void radioButtonAuthors_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAuthors.Checked)
            {
                AddAuthorToComboBox();
                comboBoxAuthors.Enabled = true;
                if (radioButtonEdit.Checked)
                {
                    BlockUnblock(false, true);
                }
            }
            else
            {
                comboBoxAuthors.Enabled = false;
            }
        }

        private void radioButtonReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonReadOnly.Checked)
            {
                BlockUnblock(false, false);
            }
        }

        private void radioButtonEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBooks.Checked && radioButtonEdit.Checked)
            {
                BlockUnblock(true, false);
            }
            else if (radioButtonAuthors.Checked && radioButtonEdit.Checked)
            {
                BlockUnblock(false, true);
            }
        }

        private void buttonSaveBookData_Click(object sender, EventArgs e)
        {
            if (EmptyBookFieldsCheck())
            {
                AddBookData(textBoxTitle.Text.ToString(), textBoxPages.Text.ToString(), textBoxPrice.Text.ToString(), textBoxYear.Text.ToString(), comboBoxAddAuthor.Text.ToString());
            }
        }

        private void buttonClearBookInfo_Click(object sender, EventArgs e)
        {
            textBoxPages.Text = "";
            textBoxTitle.Text = "";
            textBoxYear.Text = "";
            textBoxPrice.Text = "";
            comboBoxAddAuthor.SelectedIndex = -1;
        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindInformationAboutAuthor(comboBoxAuthors.Text.ToString());
        }

        private void buttonClearAuthorInfo_Click(object sender, EventArgs e)
        {
            textBoxAuthorName.Text = "";
            textBoxAuthorYear.Text = "";
        }

        private void buttonAddAuthorData_Click(object sender, EventArgs e)
        {
            if (EmptyAuthorFieldsCheck())
            {
                AddAuthorData(textBoxAuthorName.Text.ToString(), textBoxAuthorYear.Text.ToString());
            }
        }

        private void buttonUpdateBookData_Click(object sender, EventArgs e)
        {
            if (EmptyBookFieldsCheck())
            {
                UpdateBookDate(textBoxTitle.Text.ToString(), textBoxPages.Text.ToString(), textBoxPrice.Text.ToString(), textBoxYear.Text.ToString(), comboBoxAddAuthor.Text.ToString());
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (EmptyBookFieldsCheck())
            {

            }
        }

        private void buttonUpdateAuthorData_Click(object sender, EventArgs e)
        {
            if (EmptyAuthorFieldsCheck())
            {

            }
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (EmptyAuthorFieldsCheck())
            {

            }
        }
    }
}
