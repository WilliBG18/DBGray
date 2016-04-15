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
    public partial class InsertTupleForm : Form
    {
        Tables tables; 
        ConnString conn;
        TextBox[] txtBoxes;
        readonly int TEXTBOX_WIDTH = 100;
        string table;

        public InsertTupleForm(ConnString cs, string table)
        {
            InitializeComponent();
            conn = cs;
            this.table = table;
            DisplayInsertPanelContents();
            PrepareTextBoxes();
        }

        private void PrepareTextBoxes()
        {
            Type[] types = tables.GetAttributeTypes();
            for(int i = 0; i < types.Length; i++)
            {

            }
        }

        private void DisplayInsertPanelContents()
        {
            tables = new Tables(conn, table);
            int numRows = tables.GetNumTuples();
            int numColums = tables.GetNumCollumns();
            string[,] data = tables.GetTuples();
            string[] attributes = tables.GetAttributeNames();

            int pointX = 0;
            int pointY = 0;

            for (int i = 0; i < numColums; i++)
            {
                Label a = new Label();
                a.Text = attributes[i];
                a.Location = new Point(pointX, pointY);
                InsertTuplePnl.Controls.Add(a);
                InsertTuplePnl.Show();
                pointX += TEXTBOX_WIDTH;
            }
            pointY += 30;
            pointX = 0;

            txtBoxes = new TextBox[numColums];
            for (int x = 0; x < numColums; x++)
            {
                txtBoxes[x] = new TextBox();
                txtBoxes[x].Location = new Point(pointX, pointY);
                InsertTuplePnl.Controls.Add(txtBoxes[x]);
                InsertTuplePnl.Show();
                pointX += TEXTBOX_WIDTH;
            }
        }

        private string GetInsertQueryString()
        {
            string str = "";
            for (int i = 0; i < txtBoxes.Length - 1; i++)
            {
                str += "'" + txtBoxes[i].Text + "',";
            }
            str += "'" + txtBoxes[txtBoxes.Length - 1] + "'";

            return str;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.GetConStr());
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO  " + table + " VALUES(" + GetInsertQueryString() + ");";
                cmd.ExecuteNonQuery();
                ViewTableForm tableForm = new ViewTableForm(conn, table);
                tableForm.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Entries");
            }
        }
    }
}
