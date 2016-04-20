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
    public partial class SQLForm : Form
    {
        ConnString conn;

        public SQLForm(ConnString cs)
        {
            InitializeComponent();
            conn = cs;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string query = sqlTextBox.Text;
            MySqlConnection connection = new MySqlConnection(conn.GetConStr());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            //string output = "";
            //while (reader.Read())
            //{
            //    foreach (object s in reader)
            //        output += s.ToString();
            //    output += "\n";
            //}

            reader.Close();
            connection.Close();

            //MessageBox.Show(output);
        
        }
    }
}
