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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        //Adding the new client to the database
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Establishing the database connection
                SqlConnection dbConn = new SqlConnection(Properties.Resources.sqlConn);
                dbConn.Open();

                //Adding the new client to the database with the appropriate query
                string clientQuery = @"INSERT INTO tblClient(clientName, clientSurname, clientAddress, clientEmail, clientIDNum, clientCell) 
                                    VALUES ('" + masktxtName.Text + "','" + masktxtSurname.Text + "', '" + txtAddress.Text + "','" 
                                               + txtEmail.Text + "','" + masktxtIDNum.Text + "','" + txtCellNumber.Text + "')";

                
                SqlCommand sqlCmd = new SqlCommand(clientQuery, dbConn);

                //Executing the query
                sqlCmd.ExecuteNonQuery();
                dbConn.Close();

                clearAll();

                //If the query executes successfully
                MessageBox.Show("Added Successfully");
                this.Hide();
                ShootingRangeManager shooter = new ShootingRangeManager();
                shooter.Show();
            }
                //Appropriate catch for the method errors
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: Client Not Added Because: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //Method to clear all the fields
        private void clearAll()
        {
            txtCellNumber.Clear();
            masktxtIDNum.Clear();
            masktxtName.Clear();
            masktxtSurname.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    
    }
}
