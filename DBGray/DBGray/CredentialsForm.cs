﻿using System;
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
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string server = ServerTB.Text;
            string userID = textBox2.Text;
            string password = textBox3.Text;
            ConnString conn = new ConnString(server, userID, password);
            ConnectDB connect = new ConnectDB(conn);
            connect.connectToDBMS(conn);
        }
    }
}
