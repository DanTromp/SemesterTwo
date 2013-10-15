using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment3
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            string dbConn = Properties.Resources.sqlConn;
            string viewClients = @"SELECT * FROM tblCLient";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(viewClients, dbConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            gridClient.DataSource = dataSet.Tables[0];

            
        }
    }
}
