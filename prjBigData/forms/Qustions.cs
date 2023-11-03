using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjBigData.forms
{
    public partial class Qustions : Form
    {
        public static String dif;
        public static int nbrq;
        public Qustions()
        {
            InitializeComponent(); 
                  
        }

        private void nbrjr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Qustions_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Please select difficulty !");
            }
        else if(comboBox2.Text == "") {
                MessageBox.Show("Please select nombre of question !");

            }
            else {
                Form1.nbrq = Convert.ToInt32(comboBox2.Text);
                Form1.dif = comboBox1.Text;
                Form1.module = comboBox3.Text;
            this.Close();
               
            Form f = new forms.Formjoueur();


            f.BringToFront();
            f.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
