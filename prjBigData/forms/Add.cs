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
   
    public partial class Add : Form
    {
        public static int i=0;
        public static Int32 nbrq;
        public static String Ans;
        public static Question q;
        public Add()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nbrjr_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.i = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Write Question !");
            }
            else
            { if(textBox2.Text=="")
                {
                    MessageBox.Show("Write number of point  !");

                }
            else
                { if(comboBox1.Text=="" || (comboBox1.Text !="Hard" && comboBox1.Text !="Easy"&&comboBox1.Text!= "Intermediate"))
                    {
                        MessageBox.Show("choose level Difficulty !");

                    }
                else
                    {
                        if(comboBox2.Text=="" ||Convert.ToInt32( comboBox2.Text)<=0 || Convert.ToInt32(comboBox2.Text)>4)
                        {
                            MessageBox.Show("choose a correct Number of Suggested Answers!");

                        }
                        else
                        {
                            nbrq = Convert.ToInt32(comboBox2.Text);
                            Ans = textBox3.Text;
                            q = new Question(textBox1.Text, Convert.ToInt32(comboBox2.Text), textBox3.Text, Convert.ToInt32(textBox2.Text), false, comboBox1.Text,comboBox3.Text);

                            Form f = new forms.sugg();

                            f.BringToFront();
                            f.Show();


                         

                        }
                    }

                }

            }


        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
