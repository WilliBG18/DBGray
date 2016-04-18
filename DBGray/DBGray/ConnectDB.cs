using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBGray
{
    class ConnectDB
    {

        ConnString conn;
        MySqlConnection mySqlConnection;
        bool connection = false;

        public ConnectDB(ConnString cs)
        {
            conn = cs;
        }
        
        public void connectToDBMS(ConnString cs)
        {
            DatabasesForm form2 = new DatabasesForm(cs);
            ConnString connect = cs;
            mySqlConnection = new MySqlConnection();
            if (connection == false)
            {
                mySqlConnection.ConnectionString = connect.GetConStr();
                mySqlConnection.Open();
                connection = true;
            }
            if (connection == true)
            {
                MessageBox.Show("Connection Successful");
                form2.Show();
            }
        }
        public void CloseConn()
        {
            if (connection == true)
            {
                mySqlConnection.Close();
                connection = false;
            }
        }
        public void OpenConn()
        {
            if (connection == true)
            {
                mySqlConnection.Open();
            }
        }
        public void connectToDB(string database)
        {
            DBTablesForm form3 = new DBTablesForm(conn, database);
            MessageBox.Show("Connection to Database Successful");
            form3.Show();
        }
    }
}
