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
            dtbase.ShowDialog();
        }

        //Looks to see if the client is part of the database
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting the variables from the textboxes
                string userNames = masktxtFirstName.Text;
                string password = masktxtSurname.Text;

                //If the textboxes are empty the programme will give the user an error message
                if (String.IsNullOrEmpty(masktxtFirstName.Text) || (String.IsNullOrEmpty(masktxtSurname.Text)))
                {
                    MessageBox.Show("Please enter field information");
                }
                //If there is information in the textboxes the system will run
                else
                {
                    //Opening the database connection
                    dbConn.Open();
                    //Query to see if the name and surname is contained in the database
                    string query = @"SELECT clientName, clientSurname FROM tblClient WHERE clientName = '" + masktxtFirstName.Text + "' AND clientSurname = '" + masktxtSurname.Text + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, dbConn);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    reader.Read();

                    //Reading and setting the variables from the database
                    string dbUser = reader[0].ToString();
                    string dbPass = reader[1].ToString();
                    reader.Close();

                    //Seeing if the user is contained in the database
                    if (userNames == dbUser && password == dbPass)
                    {
                    
                        //Query to get the specific clientID for the client logged in
                    string getCodeQuery = @"SELECT clientID FROM tblClient WHERE clientName = '" + masktxtFirstName.Text + "'";
                    SqlCommand sqlGetCode = new SqlCommand(getCodeQuery, dbConn);
                    SqlDataReader readers = sqlGetCode.ExecuteReader();
                    readers.Read();

                    string codeString = readers[0].ToString();

                        //Saving the code into the properties to be used in the other forms
                    Properties.Settings.Default.code = codeString;

                    MessageBox.Show("Your client code is: " + codeString);
                        
                        //Yes/No box to allow the user to do different option
                       DialogResult dr = MessageBox.Show("Would you like to add a new gun under your name?",
                      "View Database", MessageBoxButtons.YesNo);
                       if (dr == DialogResult.Yes)
                       {
                           this.Hide();
                           AddGun newGun = new AddGun();
                           newGun.ShowDialog();
                       }
                       else if (dr == DialogResult.No)
                       {
                           this.Hide();
                           ViewLoaderScreen viewLoader = new ViewLoaderScreen();
                           viewLoader.ShowDialog();
                       }

                        dbConn.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password incorrect.");

                    }
                } 
            }
                //If the client does not exist in the database
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Username or Password not contained in database" + "\n" + ex.Message);
                btnAddNewGun.Show();
                btnAddNewClient.Show();
                btnFind.Hide();
                btnViewDatabase.Hide();
                btnAddButtons.Hide();
                dbConn.Close();
            }
            
        }

        //brings up a screen to add a new gun
        private void btnAddNewGun_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGun newGun = new AddGun();
            newGun.ShowDialog();
        }

        //Brings up a screen to add a new client
        private void AddNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient newClient = new AddClient();
            newClient.ShowDialog();
        }

        //If the user clicks Add, new buttons will pop up and others vanish
        private void btnAddButtons_Click(object sender, EventArgs e)
        {
            btnAddNewGun.Show();
            btnAddNewClient.Show();
            btnFind.Hide();
            btnViewDatabase.Hide();
            btnAddButtons.Hide();
        }

        private void addNewGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGun newGun = new AddGun();
            newGun.ShowDialog();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient newClient = new AddClient();
            newClient.ShowDialog();
        }

        private void exitTheAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         }
    }

