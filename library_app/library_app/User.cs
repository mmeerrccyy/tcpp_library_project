using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_app
{
    public class User
    {
        public string username;
        private string password;
        public int userId;

        public User(string username, string password, int userId)
        {
            this.username = username;
            this.password = password;
            this.userId = userId;
        }

        public static bool Check_Username(string username)
        {
            DB connection = new DB();
            string query = "SELECT * FROM `Users` WHERE `username` LIKE @username";

            MySqlCommand command = new MySqlCommand(query, connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable("Data Table");
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            connection.openConnection();

            connection.Close();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Create_User(string username, string password)
        {
            try
            {
                DB connection = new DB();
                string query = "INSERT INTO `Users` (username, password) VALUES (@username, @password)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User successfully created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static bool Login_User(string username, string password)
        {
            try
            {
                DB connection = new DB();
                string query = "SELECT username, idUsers FROM `Users` WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable("Data Table");
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                connection.openConnection();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                connection.Close();

                if (table.Rows.Count == 1)
                {
                    User user = new User(username: table.Rows[0]["username"].ToString(), "", userId: int.Parse(table.Rows[0]["idUsers"].ToString()));
                    UserForm admin_form = new UserForm(user);
                    admin_form.labelUsername.Text = table.Rows[0]["username"].ToString();
                    admin_form.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
