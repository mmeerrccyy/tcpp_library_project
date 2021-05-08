using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_app
{
    class Useful_func
    {
        DB connection = new DB();


        public bool CheckPaswords(string pswd1, string pswd2)
        {
            if (pswd1 == pswd2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUsername(string username)
        {
            string query = "SELECT * FROM `users` WHERE `username` = @username";

            MySqlCommand command = new MySqlCommand(query, connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable("Data Table");
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            connection.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

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

        public void RegisterUser(string username, string password)
        {
            try
            {
                string query = "INSERT INTO `users` (username, password) VALUES (@username, @password)";
                MySqlCommand command = new MySqlCommand(query, connection.getConnection());
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                connection.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User successfully registered!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        public int LoginUser(string username, string password)
        {
            try
            {
                string query = "SELECT role FROM `users` WHERE username = @username AND password = @password";
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
                    MessageBox.Show("User successfully logged in!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                else
                {
                    MessageBox.Show("Error!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
