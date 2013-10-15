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
    public partial class ShootingRangeManager : Form
    {
        SqlConnection dbConn = new SqlConnection(Properties.Resources.sqlConn);

        public ShootingRangeManager()
        {
            InitializeComponent();

            try
            {
                // Create the connection object once - do not connect
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Adding_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database dtbase = new Database();
            dtbase.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {

                string userNames = masktxtFirstName.Text;
                string password = masktxtSurname.Text;

                if (String.IsNullOrEmpty(masktxtFirstName.Text) || (String.IsNullOrEmpty(masktxtSurname.Text)))
                {
                    MessageBox.Show("Please enter field information");
                }
                //If there is information in the textboxes the system will run
                else
                {

                    dbConn.Open();
                    string query = @"SELECT clientName, clientSurname FROM tblClient WHERE clientName = '" + masktxtFirstName.Text + "' AND clientSurname = '" + masktxtSurname.Text + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, dbConn);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    reader.Read();

                    string dbUser = reader[0].ToString();
                    string dbPass = reader[1].ToString();              

                    if (userNames == dbUser && password == dbPass)
                    {
                        MessageBox.Show("Exists in database");
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password incorrect.");

                    }
                } 
            }
            catch (SqlException ex)
            {
                 
                MessageBox.Show("Username or Password not contained in database" + "\n"+ex.Message);
                dbConn.Close();
            }
            
        }

        private void btnAddNewGun_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGun newGun = new AddGun();
            newGun.ShowDialog();
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient newClient = new AddClient();
            newClient.ShowDialog();
        }

        private void btnAddButtons_Click(object sender, EventArgs e)
        {
            btnAddNewGun.Show();
            btnAddNewClient.Show();
            btnFind.Hide();
            btnViewDatabase.Hide();
            btnAddButtons.Hide();
        }
 


        }
    }

