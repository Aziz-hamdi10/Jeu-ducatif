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
    public partial class sugg : Form
    {
        public  string ch1;
        public  string ch2;
        public  string ch3;
        public  string ch4;
        public static List<String> l;

        public sugg()
        {
            InitializeComponent();
        }

        private void sugg_Load(object sender, EventArgs e)
        {
           
            sugges.Text = "Suggested Answer " + (Add.i+1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.i++;

            if (Add.i < Add.nbrq)
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("write answer pls !");
                }
                else
                {
                    ch1 = textBox1.Text;
                    MessageBox.Show(ch1);
                    Add.q.reponses.Add(ch1);

                    this.Close();
                    
                    Form f = new forms.sugg();

                    f.BringToFront();
                    f.Show();
                }

              

            }
            else
            {
                ch1 = textBox1.Text;
                MessageBox.Show(ch1);
                Add.q.reponses.Add(ch1);
                Form1.list1.lq.Add(Add.q);
 
                MessageBox.Show(Add.q.reponses[0]);



                this.Close();
               
                

            }

        }
    }
}
