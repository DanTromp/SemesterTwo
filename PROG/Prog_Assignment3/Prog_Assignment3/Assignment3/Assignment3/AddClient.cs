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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string cFirstname = masktxtName.Text;
            string cSurname = masktxtSurname.Text;
            string cAddress = txtAddress.Text;
            string cEmail = txtEmail.Text;
            string cIDNum = masktxtIDNum.Text;
            string cCell = txtCellNumber.Text;

            try
            {
                SqlConnection dbConn = new SqlConnection(Properties.Resources.sqlConn);
                dbConn.Open();

                string clientQuery = "INSERT INTO tblClient(clientName, clientSurname, clientAddress, clientEmail, clientIDNum, clientCell) VALUES ('" + masktxtName.Text + "','" + masktxtSurname.Text + "', '" + txtAddress.Text + "','" + txtEmail.Text + "','" + masktxtIDNum.Text + "','" + txtCellNumber.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(clientQuery, dbConn);
                sqlCmd.ExecuteNonQuery();
                dbConn.Close();

                clearAll();

                MessageBox.Show("Added Successfully");
                this.Hide();
                ShootingRangeManager shooter = new ShootingRangeManager();
                shooter.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: Client Not Added Because: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

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
