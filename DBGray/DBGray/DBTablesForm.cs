using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGray
{
    public partial class DBTablesForm : Form
    {
        String database;
        ConnString conn;
        public DBTablesForm(ConnString cs, string database)
        {
            InitializeComponent();
            this.database = database;
            conn = cs;
            conn.AddDatabase(database);
            DisplayTables();
        }
        private void DisplayTables()
        {
            Display dispTables = new Display(conn);
            dispTables.DisplayTables(database);
            string[] row = dispTables.DisplayTables(database);
            for (int i = 0; i < row.Length; i++)
            {
                TablesLB.Items.Add(row[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = TablesLB.SelectedItem.ToString();
            Tables tables = new Tables(conn, table);
            tables.SelectTable();
        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            SQLForm sqlForm = new SQLForm(conn);
            sqlForm.Show();
        }
    }
}
