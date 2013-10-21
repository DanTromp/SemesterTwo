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
     
        }

        private void gridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

            if (comboSelection.SelectedIndex == 0)
            {
                string view = @"SELECT * FROM tblClient";
                string dbConn = Properties.Resources.sqlConn;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(view, dbConn);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                gridClient.DataSource = dataSet.Tables[0];
            }
            else if (comboSelection.SelectedIndex == 1)
            {
                string view = @"SELECT * FROM tblGun";
                string dbConn = Properties.Resources.sqlConn;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(view, dbConn);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                gridClient.DataSource = dataSet.Tables[0];
            }
        }
    }
}
