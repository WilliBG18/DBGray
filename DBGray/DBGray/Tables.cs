using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBGray
{
    class Tables
    {
        ConnString conn;
        string table;

        public Tables(ConnString cs, string table)
        {
            conn = cs;
            this.table = table;
        }

        public void SelectTable()
        {
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            connection.Open();
            bool connect = true;
            if (connect == true)
            {
                ViewTableForm veiwTable = new ViewTableForm(conn, table);
                veiwTable.Show();
            }
        }

        public int GetNumCollumns()
        {
            string query = "SELECT * From " + table;
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            int numCol = 0;
            while (reader.Read())
            {
                numCol = reader.FieldCount;
            }

            reader.Close();
            connection.Close();

            return numCol;
        }

        public int GetNumTuples()
        {
            string query = "SELECT Count(*) From " + table;
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            int numRows = 0;
            while (reader.Read())
            {
                numRows = reader.GetInt32(0);
            }

            reader.Close();
            connection.Close();

            return numRows;
        }

        public string[,] GetTuples()
        {
            int numCol = GetNumCollumns();
            int numRows = GetNumTuples();
            string[,] st = new string[numCol,numRows];

            string query = "SELECT * From " + table;
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            int c = 0;
            while (reader.Read())
            {
                for (int i = 0; i < numCol; i++)
                    st[i, c] = reader[i].ToString();
                c++;
            }

            reader.Close();
            connection.Close();

            return st;
        }

        public string[] GetAttributeNames()
        {
            int numCol = GetNumCollumns();
            string[] st = new string[numCol];
            if (numCol == 0)
                return st;

            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA . COLUMNS WHERE TABLE_SCHEMA = 'dbGray' AND TABLE_NAME = '" + table + "';";
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                st[i] = reader[0].ToString();
                i++;
            }

            reader.Close();
            connection.Close();

            return st;
        }
        public Type[] GetAttributeTypes()
        {
            int numCol = GetNumCollumns();
            Type[] st = new Type[numCol];
            if (numCol == 0)
                return st;

            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA . COLUMNS WHERE TABLE_SCHEMA = 'dbGray' AND TABLE_NAME = '" + table + "';";
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                st[i] = reader[0].GetType();
                i++;
            }

            reader.Close();
            connection.Close();

            return st;
        }
    }
}
