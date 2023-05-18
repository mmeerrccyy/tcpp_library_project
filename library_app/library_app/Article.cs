using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;

namespace library_app
{
    public class Article
    {
        public int id;
        public string title;
        public string text;
        DB connection = new DB();

        public Article(string title, string text, int id = -1)
        {
            this.title = title;
            this.text = text;
            this.id = id != -1 ? id : this.GetLastId();
        }

        int GetLastId()
        {
            string query = "select max(`idArticle`) as ID from `Article`";
            MySqlCommand command = new MySqlCommand(query, connection.getConnection());
            DataTable table = new DataTable("Data Table");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            connection.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            connection.Close();
            int id = 0;
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["ID"].ToString() != "null")
                {
                    id = int.Parse(table.Rows[0]["ID"].ToString());
                }
            }
            connection.Close();
            return id + 1;
        }

        public void Create_Article(User user)
        {
            try
            {
                string query = "INSERT INTO `Article` (idArticle, articleName, articleText, Users_idUsers) VALUES (@idArticle, @name, @text, @idUser)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@idArticle", MySqlDbType.Int64).Value = this.GetLastId();
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.title;
                command.Parameters.Add("@text", MySqlDbType.VarChar).Value = this.text;
                command.Parameters.Add("@idUser", MySqlDbType.VarChar).Value = user.userId;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Article successfully created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Update_Article()
        {
            try
            {
                string query = "UPDATE `Article` SET articleName = @name, ArticleText = @text WHERE idArticle = @id";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.title;
                command.Parameters.Add("@text", MySqlDbType.VarChar).Value = this.text;
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.id;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Article successfully updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
                return false;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete_Article()
        {
            try
            {
                string query = "DELETE FROM `Article` WHERE idArticle = @id";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.id;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Article successfully deleted!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static Article[] Get_All_Articles()
        {
            try
            {
                DB connection = new DB();
                string query = "SELECT idArticle, articleName, articleText FROM `Article`";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable("Data Table");
                connection.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                connection.Close();

                if (table.Rows.Count > 0)
                {
                    Article[] articleList = new Article[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Article article = new Article(title: table.Rows[i]["articleName"].ToString(), text: table.Rows[i]["articleText"].ToString(), id: int.Parse(table.Rows[i]["idArticle"].ToString()));
                        articleList[i] = (article);
                    }
                    return articleList;
                }

                connection.Close();
                return null;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Article[] Get_Users_Articles(User user)
        {
            try
            {
                DB connection = new DB();
                string query = "SELECT idArticle, articleName, articleText FROM `Article` WHERE Users_idUsers = @id";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = user.userId;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable("Data Table");
                connection.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                connection.Close();

                if (table.Rows.Count > 0)
                {
                    Article[] articleList = new Article[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Article article = new Article(title: table.Rows[i]["articleName"].ToString(), text: table.Rows[i]["articleText"].ToString(), id: int.Parse(table.Rows[i]["idArticle"].ToString()));
                        articleList[i] = (article);
                    }
                    return articleList;
                }

                connection.Close();
                return null;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string Get_Author()
        {
            try
            {
                DB connection = new DB();
                string query = "SELECT Users.username as author FROM `Article` JOIN `Users` ON `Article`.Users_idUsers = `Users`.idUsers WHERE `Article`.idArticle = 2";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@articleId", MySqlDbType.Int64).Value = this.id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable("Data Table");
                connection.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                connection.Close();

                if (table.Rows.Count == 1)
                {
                    return table.Rows[0]["author"].ToString();
                }

                return null;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
