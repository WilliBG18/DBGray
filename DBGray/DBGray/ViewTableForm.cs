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
    public partial class ViewTableForm : Form
    {
        readonly int TEXTBOX_WIDTH = 100;
        ConnString conn;
        string table;

        public ViewTableForm(ConnString cs, string table)
        {
            InitializeComponent();
            conn = cs;
            this.table = table;
            DisplayTable();
        }
        private void DisplayTable()
        {
            Tables tables = new Tables(conn, table);
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
                tuplePanel.Controls.Add(a);
                tuplePanel.Show();
                pointX += TEXTBOX_WIDTH;
            }
            pointY += 30;
            for (int y = 0; y < numRows; y++)
            {
                pointX = 0;
                for (int x = 0; x < numColums; x++)
                {
                    TextBox a = new TextBox();
                    a.ReadOnly = true;
                    a.Text = data[x,y];
                    a.Location = new Point(pointX, pointY);
                    tuplePanel.Controls.Add(a);
                    tuplePanel.Show();
                    pointX += TEXTBOX_WIDTH;
                }
                pointY += 22;
            }
        }
    }
}
