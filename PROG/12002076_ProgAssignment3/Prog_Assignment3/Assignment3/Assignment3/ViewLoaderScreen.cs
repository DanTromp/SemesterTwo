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
        SqlConnection dbConn = new SqlConnection(Properties.Resources.sqlConn);

        public ViewLoaderScreen()
        {
            InitializeComponent();
        }

        private void ViewLoaderScreen_Load(object sender, EventArgs e)
        {
            dbConn.Open();
            //Getting the specific gun linked to the clientsID
            string view = @"SELECT * FROM tblGun WHERE clientID = '" + Properties.Settings.Default.code + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(view, dbConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            //Adding the data to the grid view
            gridLoader.DataSource = dataSet.Tables[0];
            dbConn.Close();
        }

        //Button added to update the information about the gun owned
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            try
            {
                //Update statement to update the information in the gun table
                string queryUpdate = @"UPDATE tblGun SET gunType = '" + txtUpdateGunType.Text 
                                    + "', gunAmmo = '" + txtUpdateGunAmmo.Text + "', gunYear =  '" + txtUpdateGunYear.Text
                                    + "', gunWeight =  '" + masktxtUpdateGunWeight.Text + "', gunColour = '" + masktxtUpdateGunColour.Text 
                                    + "' WHERE clientID = '" + Properties.Settings.Default.code + "'";

                SqlCommand sqlUpdateCmd = new SqlCommand(queryUpdate, dbConn);
                sqlUpdateCmd.ExecuteNonQuery();
            }
                //Catching the appropriate errors
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }

            //Adding the new updates to be shown on the data grid
            string view = @"SELECT * FROM tblGun WHERE clientID = '" + Properties.Settings.Default.code + "'";

            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(view, dbConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            //Adding the data to the grid view
            gridLoader.DataSource = dataSet.Tables[0];

            dbConn.Close();

        }
    }
}
