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
            Tables tables = new Tables(conn);
            string[] row = tables.DisplayTable(table);
            for (int i = 0; i < row.Length; i++)
            {
                TuplesLB.Items.Add(row[i]);
            }
        }
    }
}
