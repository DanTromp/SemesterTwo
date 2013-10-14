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
   
    public partial class papers : Form
    {
        int[] newArray = new int[20];
        int[] newArray1 = new int[10];
        int[] newArray2 = new int[5];
        int first = 0;
        double second = 0;
        int third = 0;
        int fourth = 0;
        int fifth = 0;
        int final = 0;

        public papers()
        {
            InitializeComponent();
        }

        private void papers_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Passport psp = new Passport();
                psp.Show();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                BirthCertificate birth = new BirthCertificate();
                birth.Show();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                ID ids = new ID();
                ids.Show();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random numb = new Random();
            double s = 0;
            int country = 0;


            if (rbMale.Checked == true)
            {
                s = numb.Next(1000, 5000);
            }

            else if (rbFemale.Checked == true)
            {
                s = numb.Next(5000, 10000);
            }

            if (rbYes.Checked == true)
            {
                country = 0;
            }

            else if (rbNo.Checked == true)
            {
                country = 1;
            }

            string generated = txtbox1.Text + txtbox2.Text + txtbox3.Text + txtbox4.Text + txtbox5.Text + txtbox6.Text + s + country + "8";

            

            for (int i = 0; i < generated.Length; i++)
            {
                newArray[i] = int.Parse(generated.Substring(i , 1));
            }

        

            for (int z = 1; z < newArray.Length; z += 2)
            {
                first = first + newArray[z];
            }

           

            for (int x = 0; x < newArray.Length; x += 2)
            {
                second = second + newArray[x];
            }

            string seconds = second + "";

            second = second * 2;

          for (int c = 0; c < seconds.Length; c++)
            {
                newArray1[c] = int.Parse(seconds.Substring(c, 1));
            }

           
            for (int v = 0; v < newArray1.Length; v++)
            {
                third = third + newArray1[v];
            }

            fourth = first + third;

            string fourths = fourth + "";

            for (int b = 0; b < fourths.Length; b++)
            {
                newArray2[b] = int.Parse(fourths.Substring(b, 1));
            }

            final = 10 - newArray2[1];


            
            txtGenerate.Text = txtbox1.Text + txtbox2.Text + txtbox3.Text + txtbox4.Text + txtbox5.Text + txtbox6.Text + s + country + "8" + final;
        }
    }
}