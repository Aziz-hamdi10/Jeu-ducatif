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
    public partial class Formjoueur : Form
    {
        public static Label ljr;
        public Formjoueur()
        {
        InitializeComponent();
            ljr = this.nbrjr;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="")
            {
               
                MessageBox.Show("Enter your Name !");}
            
            else
            if (textBox1.Text==Form1.jr1.Text)
          
                {
                    MessageBox.Show("Eror :Same name ! ");

                }
                else
            {
                if (Form1.jr1.Text == "")
                {
                    Form1.jr1.Text = textBox1.Text;
                    this.Close();
                    Form f = new forms.Formjoueur();
                    forms.Formjoueur.ljr.Text = "joueur 2 :";

                    f.BringToFront();
                    f.Show();


                }
                else
                {
                    Form1.jr2.Text = textBox1.Text;
                    this.Close();
                    Form1.jr2.Visible = true;
                    Form1.jr1.Visible = true;
                    Form1.l1.Visible = true;
                    Form1.l2.Visible = true;

                    Form1.s1.Visible = true;
                    Form1.s2.Visible = true;
                    Form1.ls1.Text = "0";
                    Form1.ls1.Visible = true;
                        Form1.ls2.Text = "0";
                    Form1.ls2.Visible = true;

                    




                }

            }
           
        }

        private void Formjoueur_Load(object sender, EventArgs e)
        {

        }
    }
}
