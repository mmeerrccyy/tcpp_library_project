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

        //==========================REGISTER FUNC=======================================

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

        //==========================================LOGIN FUNC================================================

        public bool LoginUser(string username, string password)
        {
            try
            {
                string query = "SELECT role, username FROM `users` WHERE username = @username AND password = @password";
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
                    //MessageBox.Show("User successfully logged in!" +
                    //    "\nUsers role: " + table.Rows[0]["role"].ToString(), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switch (table.Rows[0]["role"].ToString())
                    {
                        case "reader":
                        case "landlord":
                            UserForm user_form = new UserForm();
                            user_form.Show();
                            break;
                        case "admin":
                            AdminForm admin_form = new AdminForm();
                            admin_form.labelUsername.Text = table.Rows[0]["username"].ToString();
                            admin_form.Show();
                            break;
                        case "librarian":
                            LibrarianForm librarian_form = new LibrarianForm();
                            librarian_form.Show();
                            break;
                    }
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

        //=========================================================ADMIN FUNC===================================================
    }
}
