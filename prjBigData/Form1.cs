using System;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace prjBigData
{
    public partial class Form1 : Form
    {
        public static listeques list1 = new listeques();
        Random random = new Random();
        public static int nbrq;
        public static String dif;
        public static String module;
        Boolean v = false;
        int seconds = 0, seconds2,pos , plays, att, et;
        String player;
        public static Label jr1, jr2, l1, l2, s1, s2, ls1, ls2;
        private Rectangle paneltitreorig;
        private Rectangle Labeltitreorig;
        private Rectangle add1orig;
        private Rectangle add2orig;
        public SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\khalil\source\repos\prjBigData\prjBigData\clock-ticking-5.wav");
        public SoundPlayer corr = new SoundPlayer(@"C:\Users\khalil\source\repos\prjBigData\prjBigData\corr.wav");

        public SoundPlayer wrong = new SoundPlayer(@"C:\Users\khalil\source\repos\prjBigData\prjBigData\wrong.wav");

        private Rectangle panelmenuorig;
        private Rectangle butonplayorig;
        private Rectangle butonhistoriqueorig;
        private Rectangle label2orig;
        private Rectangle label3orig;
        private Rectangle labeljr1orig;
        private Rectangle labeljr2orig;
        private Rectangle rdyorig;
        private Rectangle label1orig;
        private Rectangle score1orig;
        private Rectangle lscore1orig;
        private Rectangle score2orig;
        private Rectangle lscore2orig;
        private Rectangle labelquestionorig;
        private Rectangle textquestionorig;
        private Rectangle reponse1orig;
        private Rectangle reponse2orig;
        private Rectangle reponse3orig;
        private Rectangle reponse4orig;
        private Rectangle button1orig;
        private Rectangle button2orig;
        private Rectangle timepcorig;

        private Rectangle button3orig;


        private Size formsize;

        private Rectangle panelquestionorig;
        public Form1()
        {
            et = 0;

            InitializeComponent();
            jr1 = this.labeljr1;
            jr2 = this.labeljr2;
            l1 = this.label2;
            l2 = this.label3;
            s1 = this.score1;
            s2 = this.score2;
            ls1 = this.lscore1;
            ls2 = this.lscore2;

        }
        public static void ConvertToSound(string phrase)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US")); // Set the voice to an English language voice
            synthesizer.Volume = 100; // Optional - Sets the volume
            synthesizer.Rate = 0; // Optional - Sets the speaking rate
            synthesizer.SetOutputToDefaultAudioDevice(); // Sets the output device to the default audio device
            synthesizer.Speak(phrase); // Converts the phrase to sound and plays it
        }
        public void game(int pos, String pl)

        {
             pos = index(dif);

            foreach (Control previousBtn in panelquestion.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(221, 221, 221);
                previousBtn.Visible = false;
            }
            if (pl == "player 1")
            {
                label2.BackColor = Color.Green;
                labeljr1.BackColor = Color.Green;
                label3.BackColor = Color.White;
                labeljr2.BackColor = Color.White;
            }
            else
            {
                label3.BackColor = Color.Green;
                labeljr2.BackColor = Color.Green;
                label2.BackColor = Color.White;
                labeljr1.BackColor = Color.White;

            }

            if (et < nbrq)
            {
                et++;
                Labelquestion.Visible = true;
                textquestion.Text = list1.lq[pos].souel;
                   
                textquestion.Visible = true;
                list1.lq[pos].utilise = true;
 
                seconds = 10;
                int i = 0;
                foreach (Control previousBtn in panelquestion.Controls)
                {
                    if (i < list1.lq[pos].Nr)
                    {
                        previousBtn.Visible = true;
                        previousBtn.Text = list1.lq[pos].reponses[i];
                        i++;
                    }
                    else { previousBtn.Visible = false; }
                }
                ConvertToSound(list1.lq[pos].souel);
                Rdy.Visible = false;
                if (seconds2 == 0)
                {
                    label1.ForeColor = Color.Black;
                   
                    soundPlayer.Play(); // Plays the system beep sound
                    Thread.Sleep(1000); // Waits for the specified interval
                    timer2.Start();

                }



            }
            else
            {
                if (Convert.ToInt32(lscore1.Text) > Convert.ToInt32(lscore2.Text))
                {
                    ConvertToSound("Congration " + labeljr1.Text + " win !");

                    MessageBox.Show("Congration " + labeljr1.Text + " win !");
                }
                else
                if (Convert.ToInt32(lscore1.Text) < Convert.ToInt32(lscore2.Text))
                {
                    MessageBox.Show("Congration " + labeljr2.Text + " win !");
                    ConvertToSound("Congration " + labeljr2.Text + " win !");

                }
                else
                {
                    MessageBox.Show("Null");

                }
                Labelquestion.Visible = false;
                textquestion.Visible = false;
            }




        }
public void remplir1()
        {
            for (int i = 0; i < list1.lq.Count(); i++)
            {
                list1.lq[i].utilise = false;
            }
        }
        public void remplir()
        {
            list1.lq.Clear();
            Question q = new Question("Which of the following is not a characteristic of big data?", 4, "Validation", 1, false, "Easy","Big data");

            q.reponses.Add("Volume");
            q.reponses.Add("Velocity");
            q.reponses.Add("Variety");
            q.reponses.Add("Validation");

            list1.lq.Add(q);
            Question qb = new Question("Which of the following is not a technology used in Big Data?", 4, "SQL Server", 3, false, "Easy", "Big data");
            qb.reponses.Add("Hadoop");
            qb.reponses.Add("NoSQL");
            qb.reponses.Add(" SQL Server");
            qb.reponses.Add(" Spark");

            list1.lq.Add(qb);
            qb = new Question("Which of the following is not a cloud service model?", 4, "Hardware as a Service (HaaS)", 3, false, "Easy", "Cloud");
            qb.reponses.Add("Software as a Service (SaaS)");
            qb.reponses.Add("Platform as a Service (PaaS)");
            qb.reponses.Add("Infrastructure as a Service (IaaS)");
            qb.reponses.Add("Hardware as a Service (HaaS)");
   
            list1.lq.Add(qb);
            qb = new Question("A cloud service that provides access to software applications and tools. is ?", 3, "SaaS", 3, false, "Hard","Cloud");
            qb.reponses.Add("SaaS");
            qb.reponses.Add("PaaS");
            qb.reponses.Add("IaaS");


            list1.lq.Add(qb);
            qb = new Question("A cloud service that provides access to virtual machines, storage, and networking resources. is ?", 3, "IaaS", 3, false, "Hard","Cloud");

            qb.reponses.Add("IaaS");
            qb.reponses.Add("PaaS"); ;
            qb.reponses.Add("SaaS");

            list1.lq.Add(qb);
            qb = new Question("A cloud service that provides access to a platform for developing and deploying applications.", 4, "PaaS", 3, false, "Hard", "Cloud");
            qb.reponses.Add("SaaS");
            qb.reponses.Add("IaaS");
            qb.reponses.Add("PaaS");
            qb.reponses.Add("HaaS");

            list1.lq.Add(qb);
            qb = new Question("Which of the following is an example of a public cloud service provider?.", 3, "Amazon Web Services (AWS)", 3, false, "Hard", "Cloud");
            qb.reponses.Add("Amazon Web Services (AWS)");
            qb.reponses.Add("VMware");
            qb.reponses.Add("IBM Cloud");


            list1.lq.Add(qb);
                 qb = new Question("A storage repository that holds a vast amount of raw data in its native format until it is needed what is that ?.", 3, "data lake", 3, false, "Hard", "Data mining");
            qb.reponses.Add("data lake");
            qb.reponses.Add("data mining");
            qb.reponses.Add("data warhouse");


            list1.lq.Add(qb);
            qb = new Question("A database that is optimized for analytical processing. what is it  ?.", 3, "data warehouse", 3, false, "Hard", "Data mining");
            qb.reponses.Add("data lake");
            qb.reponses.Add("data warhouse");
            qb.reponses.Add("data mining");
        


            list1.lq.Add(qb);
            qb = new Question("What is the primary challenge of big data?.", 4, "Processing", 1, false, "Easy", "Big data");
            qb.reponses.Add("Storage");
            qb.reponses.Add("Processinge");
            qb.reponses.Add("Visualization");
            qb.reponses.Add("None of the above");



            list1.lq.Add(qb);
            qb = new Question(" Il existe _______ formes de Big Data?.", 4, "3", 1, false, "Easy", "Big data");
            qb.reponses.Add("7");
            qb.reponses.Add("3");
            qb.reponses.Add("6");
            qb.reponses.Add("1");




            list1.lq.Add(qb);
            qb = new Question(" Les types de Big Data sont _________?.", 4, "Toutes les réponses", 1, false, "Easy", "Big data");
            qb.reponses.Add("Données non structurées");
            qb.reponses.Add("Données structurées");
            qb.reponses.Add("Données semi-structurées");
            qb.reponses.Add("Toutes les réponses");




            list1.lq.Add(qb);
            qb = new Question("________ possède le plus grand cluster Hadoop du monde.", 4, "Facebook", 1, false, "Easy","Data mining");
            qb.reponses.Add("Facebook");
            qb.reponses.Add("IBM");
            qb.reponses.Add("LinkedIn");
            qb.reponses.Add("Google");




            list1.lq.Add(qb);
            qb = new Question("La partie ______ de MapReduce est responsable du traitement d’un ou plusieurs morceaux de données et de la production des résultats de sortie.", 4, "Map", 1, false, "Easy","Data mining");
            qb.reponses.Add("Mapper");
            qb.reponses.Add("IBM");
            qb.reponses.Add("Reduce");
            qb.reponses.Add("Map");




            list1.lq.Add(qb);
            qb = new Question("Le big data concerne des informations de grand volume, de grande vitesse et de grande variété:", 2, "Vrai", 1, false, "Easy","Big data");
            qb.reponses.Add("Vrai");
            qb.reponses.Add("Faux");
            list1.lq.Add(qb);
            qb = new Question(" L’analyse des données volumineuses porte sur les données non structurées, pour lesquelles aucun modèle spécifique n’est défini.", 2, "Vrai", 1, false, "Easy","Big data");
            qb.reponses.Add("Vrai");
            qb.reponses.Add("Faux");
            list1.lq.Add(qb);
            qb = new Question("  Les données structurées se conforment à un modèle ou à un schéma de données et sont souvent stockées sous forme de tableaux.", 2, "Vrai", 1, false, "Easy","Big data");
            qb.reponses.Add("Vrai");
            qb.reponses.Add("Faux");
            list1.lq.Add(qb);
            qb = new Question("  Parmi les éléments suivants, lesquels constituent un exemple de données non structurées:", 3, "Les deux B et C", 1, false, "Easy","Big data");
            qb.reponses.Add("Vidéos");
            qb.reponses.Add("Fichiers audio");
            qb.reponses.Add("Les deux B et C");
            list1.lq.Add(qb);


        }
        private void paneldesk_Paint(object sender, PaintEventArgs e)
        {

        }
        public int index( String diff)
        {
           
            while ( list1.lq[pos].module != module ||list1.lq[pos].utilise == true || diff != list1.lq[pos].diff )
            {
                pos = random.Next(list1.lq.Count());
            }
            return pos;

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            remplir1();
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;


            labeljr1.Text = "";
            pos = 0;
            et=0;
            timer1.Stop();
            timer2.Stop();
            CountTimer.Stop();

            Form f = new forms.Qustions();

            f.BringToFront();
            f.Show();




        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            seconds2--;

            if (seconds2 == -1)
                CountTimer.Stop();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Labelquestion_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { timer2.Stop();
            remplir1();
            et = 0;
            label1.Visible = false;
            pos = 0;
            Rdy.Visible = true;
            Rdy.Text = "Ready ?";
            seconds = 3;
            timer3.Start();

           
              
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            remplir();
            timepcorig = new Rectangle(timepc.Location.X, timepc.Location.Y, timepc.Width, timepc.Height);            paneltitreorig = new Rectangle(paneltitre.Location.X, paneltitre.Location.Y, paneltitre.Width, paneltitre.Height);
            add1orig = new Rectangle(add1.Location.X, add1.Location.Y, add1.Width, add1.Height);
            add2orig = new Rectangle(add2.Location.X, add2.Location.Y, add2.Width, add2.Height);
            pos = 0;

            paneltitreorig = new Rectangle(paneltitre.Location.X, paneltitre.Location.Y, paneltitre.Width, paneltitre.Height);
            Labeltitreorig = new Rectangle(Labeltitre.Location.X, Labeltitre.Location.Y, Labeltitre.Width, Labeltitre.Height);
            panelmenuorig = new Rectangle(panelMenu.Location.X, panelMenu.Location.Y, panelMenu.Width, panelMenu.Height);
            butonplayorig = new Rectangle(btnplay.Location.X, btnplay.Location.Y, btnplay.Width, btnplay.Height);
            butonhistoriqueorig = new Rectangle(btnHistorique.Location.X, btnHistorique.Location.Y, btnHistorique.Width, btnHistorique.Height);
            label2orig = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label3orig = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label1orig = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            score1orig = new Rectangle(score1.Location.X, score1.Location.Y, score1.Width, score1.Height);
            score2orig = new Rectangle(score2.Location.X, score2.Location.Y, score2.Width, score2.Height);
            lscore1orig = new Rectangle(lscore1.Location.X, lscore1.Location.Y, lscore1.Width, lscore1.Height);
            formsize = this.Size;
            labeljr1orig = new Rectangle(labeljr1.Location.X, labeljr1.Location.Y, labeljr1.Width, labeljr1.Height);
            labeljr2orig = new Rectangle(labeljr2.Location.X, labeljr2.Location.Y, labeljr2.Width, labeljr2.Height);
            rdyorig = new Rectangle(Rdy.Location.X, Rdy.Location.Y, Rdy.Width, Rdy.Height);
            add1orig = new Rectangle(add1.Location.X, add1.Location.Y, add1.Width, add1.Height);
            add2orig = new Rectangle(add2.Location.X, add2.Location.Y, add2.Width, add2.Height);

            lscore2orig = new Rectangle(lscore2.Location.X, lscore2.Location.Y, lscore2.Width, lscore2.Height);

            labelquestionorig = new Rectangle(Labelquestion.Location.X, Labelquestion.Location.Y, Labelquestion.Width, Labelquestion.Height);
            textquestionorig = new Rectangle(textquestion.Location.X, textquestion.Location.Y, textquestion.Width, textquestion.Height);
            panelquestionorig = new Rectangle(panelquestion.Location.X, panelquestion.Location.Y, panelquestion.Width, panelquestion.Height);

            reponse1orig = new Rectangle(reponse1.Location.X, reponse1.Location.Y, reponse1.Width, reponse1.Height);

            reponse2orig = new Rectangle(reponse2.Location.X, reponse2.Location.Y, reponse2.Width, reponse2.Height);
            reponse3orig = new Rectangle(reponse3.Location.X, reponse3.Location.Y, reponse3.Width, reponse3.Height);

            reponse4orig = new Rectangle(reponse4.Location.X, reponse4.Location.Y, reponse4.Width, reponse4.Height);

            button1orig = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2orig = new Rectangle(Reset.Location.X, Reset.Location.Y, Reset.Width, Reset.Height);

            button3orig = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);

        }
      
        private void resizeChildrenControls()
        {
            resizeControl(paneltitreorig, paneltitre);
            resizeControl(panelmenuorig, panelMenu);
            resizeControl(Labeltitreorig, Labeltitre);
            resizeControl(button3orig, button3);
            resizeControl(button2orig, Reset);
            resizeControl(button1orig, button1);
            resizeControl(reponse4orig, reponse4);
            resizeControl(reponse3orig, reponse3);
            resizeControl(reponse2orig, reponse2);
            resizeControl(reponse1orig, reponse1);
            resizeControl(timepcorig, timepc);
            resizeControl(add1orig, add1);
            resizeControl(add2orig, add2);
            resizeControl(panelquestionorig, panelquestion);
            resizeControl(textquestionorig, textquestion);
            resizeControl(labelquestionorig, Labelquestion);
            resizeControl(lscore2orig, lscore2);
            resizeControl(lscore1orig, lscore1);
            resizeControl(score2orig, score2);
            resizeControl(score1orig, score1);
            resizeControl(label1orig, label1);
            resizeControl(label2orig, label2);
            resizeControl(label3orig, label3);
            resizeControl(butonhistoriqueorig, btnHistorique);


            resizeControl(butonplayorig, btnplay);
            resizeControl(Labeltitreorig, Labeltitre);
            resizeControl(label1orig, label1);

            resizeControl(labeljr1orig, labeljr1);
            resizeControl(labeljr2orig, labeljr2);
            resizeControl(rdyorig, Rdy);

        }

        private void reponse1_Click(object sender, EventArgs e)
        {
            if (pos < list1.lq.Count())
            {
                verif(sender, pos);
                timer2.Stop();
                att = 4;
                Reponse.Start();
            }

        }

        private void reponse2_Click(object sender, EventArgs e)
        {
            if (pos < list1.lq.Count())
            {
                verif(sender, pos);
                timer2.Stop();
                att = 4;
                Reponse.Start();
            }

        }

        private void reponse3_Click(object sender, EventArgs e)
        {
            if (pos < list1.lq.Count())
            {
                verif(sender, pos);
                timer2.Stop();
                att = 4;
                Reponse.Start();
            }

        }

        public void verif(object sender, int pos)
        {
            soundPlayer.Stop();
            Button b = (Button)sender;
            if (b.Text != list1.lq[pos].reponse)
            {
                b.BackColor = Color.Red;


                timer2.Stop();
                    wrong.Play();
                MessageBox.Show("Wrong Answer");
               
                CountTimer.Stop();


                score(pos, false, player, false);
                wrong.Stop();

            }
            else
            {
                b.BackColor = Color.Green;
                corr.Play();
                MessageBox.Show("Correct Answer");

                score(pos, true, player, false);
                corr.Stop();
            }

        }
        public void score(int pos, Boolean v, string player, Boolean t)
        {
            if (pos < list1.lq.Count())
            {
                if (!t)
                {
                    if (v)
                    {
                        if (player == "player 1")
                        {
                            ls1.Text = ((Convert.ToInt32(ls1.Text) + list1.lq[pos].Np).ToString());
                            add1.Visible = true;
                            add1.ForeColor = Color.Green;
                            add1.Text = "(+" + (list1.lq[pos].Np).ToString() + ")";
                        }
                        else
                        {
                            ls2.Text = ((Convert.ToInt32(ls2.Text) + list1.lq[pos].Np).ToString());
                            add2.Visible = true;
                            add2.ForeColor = Color.Green;
                            add2.Text = "(+" + (list1.lq[pos].Np).ToString() + ")";
                        }
                    }
                    else
                    {
                        if (player == "player 1")
                        {
                            ls1.Text = ((Convert.ToInt32(ls1.Text) - list1.lq[pos].Np).ToString());
                            add1.Visible = true;
                            add1.ForeColor = Color.Red;
                            add1.Text = "(-" + (list1.lq[pos].Np).ToString() + ")";
                        }
                        else
                        {
                            ls2.Text = ((Convert.ToInt32(ls2.Text) - list1.lq[pos].Np).ToString());
                            add2.Visible = true;
                            add2.ForeColor = Color.Red;
                            add2.Text = "(-" + (list1.lq[pos].Np).ToString() + ")";
                        }

                    }
                }
                else
                {
                    if (player == "player 1")
                    {
                        ls1.Text = ((Convert.ToInt32(ls1.Text) - list1.lq[pos].Np).ToString());
                        add1.Visible = true;
                        add1.ForeColor = Color.Red;
                        add1.Text = "(-" + (list1.lq[pos].Np).ToString() + ")";
                    }
                    else
                    {
                        ls2.Text = ((Convert.ToInt32(ls2.Text) - list1.lq[pos].Np).ToString());
                        add2.Visible = true;
                        add2.ForeColor = Color.Red;
                        add2.Text = "(-" + (list1.lq[pos].Np).ToString() + ")";
                    }

                }
            }
        }
        private void reponse4_Click(object sender, EventArgs e)
        {
            if (pos < list1.lq.Count())
            {
                verif(sender, pos);
                timer2.Stop();

                att = 4;
                Reponse.Start();
            }




        }

        private void labeljr2_TextChanged(object sender, EventArgs e)
        {
            Rdy.Text = "Ready ?";
            seconds = 3;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rdy.Text = "Go on !";

            timepc.Visible = true;
            label1.Visible = true;
            Rdy.Visible = true;
            label1.Text = seconds--.ToString();
            if (seconds < 3)
            {
                label1.ForeColor = Color.Red;
            }
            if (seconds == 0)
            {
                Rdy.ForeColor = Color.Green;
                Rdy.Text = "Go on !";
                timer1.Stop();


            }







        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged_1(object sender, EventArgs e)
        {
            resizeChildrenControls();

        }

        private void Rdy_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {

            Form f = new forms.Add();

            f.BringToFront();
            f.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label1.Text = seconds.ToString();
            seconds--;

            label1.Visible = true;

            if (seconds == -1)
                timer3.Stop();
            Rdy.Text = "Go on !";
        }

        private void Rdy_TextChanged(object sender, EventArgs e)
        {
           if(Rdy.Text=="Go on !")
            { 
            plays = 10;
            play.Start();
            }

        }

        private void Reponse_Tick(object sender, EventArgs e)
        {
            att--;
            if (att == 0)
            {
               
                player = change(player);

                game(pos, player);
                add1.Visible = false;
                add2.Visible = false;
            }

        }

        public String change(String ch)
        {
            if (ch == "player 1")
            {
                ch = "player 2";

            }
            else
            {
                ch = "player 1";
            }
            return ch;
        }
        private void play_Tick(object sender, EventArgs e)
        {

            if (plays % 2 == 0)
            {
                label2.BackColor = Color.Green;
                labeljr1.BackColor = Color.Green;
                label3.BackColor = Color.White;
                labeljr2.BackColor = Color.White;
                plays--;
            }
            else
            {
                label3.BackColor = Color.Green;
                labeljr2.BackColor = Color.Green;
                label2.BackColor = Color.White;
                labeljr1.BackColor = Color.White;
                plays--;


            }

            if (plays == 0)
            {

                play.Stop();
                plays = random.Next(2);
                if (plays == 1)
                {
                    player = "player 1";

                }
                else
                {
                    player = "player 2";

                }

                game(pos, player);
            }

        }
        
        private void textquestion_TextChanged(object sender, EventArgs e)
        {


        }
        void timeove()
        { 
            MessageBox.Show("Time is over !");

            score(pos, true, player, true);
            
            player = change(player);
            game(pos, player);

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            label1.Text = seconds--.ToString();
            if (seconds < 3)
            {
                label1.ForeColor = Color.Red;
            }

            if (seconds < 0)
            {
                soundPlayer.Stop();
                Rdy.Visible = false;
                timer2.Stop();
                CountTimer.Stop();
                timeove();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void resizeControl(Rectangle orig, Control contol)
        {
            float xRation = (float)(this.Width) / (float)(formsize.Width);
            float yRation = (float)(this.Height) / (float)(formsize.Height);
            int newX = (int)(orig.X * xRation);
            int newY = (int)(orig.Y * yRation);
            int newwidth = (int)(orig.Width * xRation);
            int newheight = (int)(orig.Height * yRation);
            contol.Location = new Point(newX, newY);
            contol.Size = new Size(newwidth, newheight);





        }
    }
}
