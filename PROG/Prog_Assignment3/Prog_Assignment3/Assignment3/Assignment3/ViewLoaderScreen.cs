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
    public partial class ViewLoaderScreen : Form
    {
        public ViewLoaderScreen()
        {
            InitializeComponent();
        }

        private void ViewLoaderScreen_Load(object sender, EventArgs e)
        {
            

            string view = @"SELECT * FROM tblGun WHERE clientID = '" + Properties.Settings.Default.code + "'";
            string dbConn = Properties.Resources.sqlConn;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(view, dbConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            gridLoader.DataSource = dataSet.Tables[0];
        }
    }
}
