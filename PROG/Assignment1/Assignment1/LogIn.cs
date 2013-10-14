using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class LogIn : Form
    {
        string[] userName = new string[5];
        string[] password = new string[5];

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            userName[0] = "DanTromp";
            userName[1] = "TylerDoye";
            userName[2] = "ByronCoetsee";
                 
            password[0] = "locked8";
            password[1] = "Penguin";
            password[2] = "Aloox";
            

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {     
            string usernames = textBox1.Text;
            string passwords = textBox2.Text;

            if (!(userName.Contains(usernames)))
                    
                    {
                        MessageBox.Show("Please enter a valid userName and password or click Register!");                
                    }

             else if (!(password.Contains(passwords)))
            {
                MessageBox.Show("Please enter a valid userName and password or click Register!");
            }

            else 
            {
                papers pp = new papers();
                pp.Show();
            }            
       }
    
        private void Register_Click(object sender, EventArgs e)
        {
            buttonLogin.Hide();
            lblPasswordVerify.Show();
            textBox3.Show();
            Create.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Equals(textBox3.Text))
            {
                if (userName[0].Length == 0)
                {
                    textBox1.Text = userName[0];
                }
                else if (userName[1].Length == 0)
                {
                    textBox1.Text = userName[1];
                }
                else if (userName[2].Length == 0)
                {
                    textBox1.Text = userName[2];
                }
                else if (userName[3].Length == 0)
                {
                    textBox1.Text = userName[3];
                }
                else if (userName[4].Length == 0)
                {
                    textBox1.Text = userName[4];
                }

                
            }

            else
            {
                MessageBox.Show("Please enter matching passwords!");
            }


            papers pp = new papers();
            pp.Show();
        }


            
    } 
}

