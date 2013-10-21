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
    public partial class AddGun : Form
    {
        public AddGun()
        {
            InitializeComponent();
        }

        private void btnAddGun_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlConnection dbConn = new SqlConnection(Properties.Resources.sqlConn);
                    dbConn.Open();
                    
                    //Query to populate the tableGun with the new information
                    string gunQuery = @"INSERT INTO tblGun(clientID, guntype, gunAmmo, gunYear, gunWeight, gunColour) 
                                        VALUES ('" + masktxtGunCLient.Text + "','" + txtGunType.Text + "','" + txtGunAmmo.Text + "', '" 
                                                   + txtGunYear.Text + "','" + masktxtGunWeight.Text + "','" + masktxtGunColour.Text + "')";

                    SqlCommand sqlCmd = new SqlCommand(gunQuery, dbConn);
                    sqlCmd.ExecuteNonQuery();
                    dbConn.Close();

                    clearAll();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("ERROR: Client Not Added Because: " + ex.Message);
                }
            
            
            }
        

        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtGunType.Clear();
            txtGunAmmo.Clear();
            txtGunYear.Clear();
            masktxtGunWeight.Clear();
            masktxtGunColour.Clear();
            
        }

        private void AddGun_Load(object sender, EventArgs e)
        {

        }
    
    }
}
