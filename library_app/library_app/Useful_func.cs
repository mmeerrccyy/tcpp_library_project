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

    }
}
