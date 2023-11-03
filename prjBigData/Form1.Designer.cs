namespace prjBigData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorique = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.paneltitre = new System.Windows.Forms.Panel();
            this.Labeltitre = new System.Windows.Forms.Label();
            this.CountTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timepc = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeljr1 = new System.Windows.Forms.Label();
            this.labeljr2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.lscore1 = new System.Windows.Forms.Label();
            this.lscore2 = new System.Windows.Forms.Label();
            this.Labelquestion = new System.Windows.Forms.Label();
            this.textquestion = new System.Windows.Forms.Label();
            this.paneldesk = new System.Windows.Forms.Panel();
            this.add2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.Rdy = new System.Windows.Forms.Label();
            this.panelquestion = new System.Windows.Forms.Panel();
            this.reponse4 = new System.Windows.Forms.Button();
            this.reponse3 = new System.Windows.Forms.Button();
            this.reponse2 = new System.Windows.Forms.Button();
            this.reponse1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.play = new System.Windows.Forms.Timer(this.components);
            this.Reponse = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.paneltitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepc)).BeginInit();
            this.paneldesk.SuspendLayout();
            this.panelquestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.btnHistorique);
            this.panelMenu.Controls.Add(this.btnplay);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 370);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnHistorique
            // 
            this.btnHistorique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorique.FlatAppearance.BorderSize = 0;
            this.btnHistorique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorique.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistorique.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorique.Image")));
            this.btnHistorique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorique.Location = new System.Drawing.Point(0, 60);
            this.btnHistorique.Name = "btnHistorique";
            this.btnHistorique.Size = new System.Drawing.Size(220, 60);
            this.btnHistorique.TabIndex = 5;
            this.btnHistorique.Text = "Add Question";
            this.btnHistorique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorique.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorique.UseVisualStyleBackColor = true;
            this.btnHistorique.Click += new System.EventHandler(this.btnHistorique_Click);
            // 
            // btnplay
            // 
            this.btnplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnplay.FlatAppearance.BorderSize = 0;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnplay.Image = ((System.Drawing.Image)(resources.GetObject("btnplay.Image")));
            this.btnplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplay.Location = new System.Drawing.Point(0, 0);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(220, 60);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = " Play";
            this.btnplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // paneltitre
            // 
            this.paneltitre.BackColor = System.Drawing.Color.Silver;
            this.paneltitre.Controls.Add(this.Labeltitre);
            this.paneltitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitre.Location = new System.Drawing.Point(0, 0);
            this.paneltitre.Name = "paneltitre";
            this.paneltitre.Size = new System.Drawing.Size(849, 80);
            this.paneltitre.TabIndex = 4;
            // 
            // Labeltitre
            // 
            this.Labeltitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labeltitre.AutoSize = true;
            this.Labeltitre.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeltitre.ForeColor = System.Drawing.Color.AliceBlue;
            this.Labeltitre.Location = new System.Drawing.Point(306, 29);
            this.Labeltitre.Name = "Labeltitre";
            this.Labeltitre.Size = new System.Drawing.Size(216, 27);
            this.Labeltitre.TabIndex = 2;
            this.Labeltitre.Text = "Knowledge Sword";
            // 
            // CountTimer
            // 
            this.CountTimer.Interval = 1000;
            this.CountTimer.Tick += new System.EventHandler(this.CountTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "New game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(421, 294);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 32);
            this.Reset.TabIndex = 43;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(503, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 44;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // timepc
            // 
            this.timepc.Image = ((System.Drawing.Image)(resources.GetObject("timepc.Image")));
            this.timepc.Location = new System.Drawing.Point(497, 19);
            this.timepc.Name = "timepc";
            this.timepc.Size = new System.Drawing.Size(30, 23);
            this.timepc.TabIndex = 46;
            this.timepc.TabStop = false;
            this.timepc.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Motken noqta ii", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Player 1 :";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Motken noqta ii", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(241, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Player 2 :";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labeljr1
            // 
            this.labeljr1.AutoSize = true;
            this.labeljr1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljr1.Location = new System.Drawing.Point(112, 10);
            this.labeljr1.Name = "labeljr1";
            this.labeljr1.Size = new System.Drawing.Size(0, 28);
            this.labeljr1.TabIndex = 49;
            this.labeljr1.Visible = false;
            // 
            // labeljr2
            // 
            this.labeljr2.AutoSize = true;
            this.labeljr2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljr2.Location = new System.Drawing.Point(337, 10);
            this.labeljr2.Name = "labeljr2";
            this.labeljr2.Size = new System.Drawing.Size(0, 28);
            this.labeljr2.TabIndex = 50;
            this.labeljr2.Visible = false;
            this.labeljr2.TextChanged += new System.EventHandler(this.labeljr2_TextChanged);
            this.labeljr2.Click += new System.EventHandler(this.label5_Click);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Motken noqta ii", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.score1.Location = new System.Drawing.Point(16, 48);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(65, 20);
            this.score1.TabIndex = 51;
            this.score1.Text = "Score :";
            this.score1.Visible = false;
            this.score1.Click += new System.EventHandler(this.label4_Click);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Motken noqta ii", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.score2.Location = new System.Drawing.Point(241, 48);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(65, 20);
            this.score2.TabIndex = 53;
            this.score2.Text = "Score :";
            this.score2.Visible = false;
            // 
            // lscore1
            // 
            this.lscore1.AutoSize = true;
            this.lscore1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lscore1.Location = new System.Drawing.Point(87, 44);
            this.lscore1.Name = "lscore1";
            this.lscore1.Size = new System.Drawing.Size(0, 21);
            this.lscore1.TabIndex = 54;
            this.lscore1.Visible = false;
            // 
            // lscore2
            // 
            this.lscore2.AutoSize = true;
            this.lscore2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lscore2.Location = new System.Drawing.Point(313, 45);
            this.lscore2.Name = "lscore2";
            this.lscore2.Size = new System.Drawing.Size(0, 21);
            this.lscore2.TabIndex = 55;
            this.lscore2.Visible = false;
            // 
            // Labelquestion
            // 
            this.Labelquestion.AutoSize = true;
            this.Labelquestion.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelquestion.Location = new System.Drawing.Point(21, 118);
            this.Labelquestion.Name = "Labelquestion";
            this.Labelquestion.Size = new System.Drawing.Size(91, 24);
            this.Labelquestion.TabIndex = 56;
            this.Labelquestion.Text = "Question 1 :";
            this.Labelquestion.Visible = false;
            this.Labelquestion.Click += new System.EventHandler(this.Labelquestion_Click);
            // 
            // textquestion
            // 
            this.textquestion.AutoSize = true;
            this.textquestion.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textquestion.Location = new System.Drawing.Point(118, 118);
            this.textquestion.Name = "textquestion";
            this.textquestion.Size = new System.Drawing.Size(91, 24);
            this.textquestion.TabIndex = 57;
            this.textquestion.Text = "Question 1 :";
            this.textquestion.Visible = false;
            this.textquestion.TextChanged += new System.EventHandler(this.textquestion_TextChanged);
            // 
            // paneldesk
            // 
            this.paneldesk.Controls.Add(this.add2);
            this.paneldesk.Controls.Add(this.add1);
            this.paneldesk.Controls.Add(this.Rdy);
            this.paneldesk.Controls.Add(this.panelquestion);
            this.paneldesk.Controls.Add(this.textquestion);
            this.paneldesk.Controls.Add(this.Labelquestion);
            this.paneldesk.Controls.Add(this.lscore2);
            this.paneldesk.Controls.Add(this.lscore1);
            this.paneldesk.Controls.Add(this.score2);
            this.paneldesk.Controls.Add(this.score1);
            this.paneldesk.Controls.Add(this.labeljr2);
            this.paneldesk.Controls.Add(this.labeljr1);
            this.paneldesk.Controls.Add(this.label3);
            this.paneldesk.Controls.Add(this.label2);
            this.paneldesk.Controls.Add(this.timepc);
            this.paneldesk.Controls.Add(this.label1);
            this.paneldesk.Controls.Add(this.button3);
            this.paneldesk.Controls.Add(this.Reset);
            this.paneldesk.Controls.Add(this.button1);
            this.paneldesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesk.Location = new System.Drawing.Point(220, 80);
            this.paneldesk.Name = "paneldesk";
            this.paneldesk.Size = new System.Drawing.Size(629, 370);
            this.paneldesk.TabIndex = 5;
            this.paneldesk.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesk_Paint);
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2.Location = new System.Drawing.Point(338, 45);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(0, 21);
            this.add2.TabIndex = 61;
            this.add2.Visible = false;
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1.Location = new System.Drawing.Point(115, 44);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(0, 21);
            this.add1.TabIndex = 60;
            this.add1.Visible = false;
            // 
            // Rdy
            // 
            this.Rdy.AutoSize = true;
            this.Rdy.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdy.Location = new System.Drawing.Point(420, 18);
            this.Rdy.Name = "Rdy";
            this.Rdy.Size = new System.Drawing.Size(67, 24);
            this.Rdy.TabIndex = 59;
            this.Rdy.Text = "Ready ?";
            this.Rdy.Visible = false;
            this.Rdy.TextChanged += new System.EventHandler(this.Rdy_TextChanged);
            this.Rdy.Click += new System.EventHandler(this.Rdy_Click);
            // 
            // panelquestion
            // 
            this.panelquestion.Controls.Add(this.reponse4);
            this.panelquestion.Controls.Add(this.reponse3);
            this.panelquestion.Controls.Add(this.reponse2);
            this.panelquestion.Controls.Add(this.reponse1);
            this.panelquestion.Location = new System.Drawing.Point(8, 182);
            this.panelquestion.Name = "panelquestion";
            this.panelquestion.Size = new System.Drawing.Size(572, 49);
            this.panelquestion.TabIndex = 58;
            // 
            // reponse4
            // 
            this.reponse4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse4.Location = new System.Drawing.Point(20, 8);
            this.reponse4.Name = "reponse4";
            this.reponse4.Size = new System.Drawing.Size(97, 32);
            this.reponse4.TabIndex = 65;
            this.reponse4.Text = "Response";
            this.reponse4.UseVisualStyleBackColor = true;
            this.reponse4.Visible = false;
            this.reponse4.Click += new System.EventHandler(this.reponse4_Click);
            // 
            // reponse3
            // 
            this.reponse3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse3.Location = new System.Drawing.Point(167, 8);
            this.reponse3.Name = "reponse3";
            this.reponse3.Size = new System.Drawing.Size(102, 32);
            this.reponse3.TabIndex = 64;
            this.reponse3.Text = "Response";
            this.reponse3.UseVisualStyleBackColor = true;
            this.reponse3.Visible = false;
            this.reponse3.Click += new System.EventHandler(this.reponse3_Click);
            // 
            // reponse2
            // 
            this.reponse2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse2.Location = new System.Drawing.Point(310, 8);
            this.reponse2.Name = "reponse2";
            this.reponse2.Size = new System.Drawing.Size(96, 32);
            this.reponse2.TabIndex = 63;
            this.reponse2.Text = "Response";
            this.reponse2.UseVisualStyleBackColor = true;
            this.reponse2.Visible = false;
            this.reponse2.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // reponse1
            // 
            this.reponse1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse1.Location = new System.Drawing.Point(459, 8);
            this.reponse1.Name = "reponse1";
            this.reponse1.Size = new System.Drawing.Size(101, 32);
            this.reponse1.TabIndex = 62;
            this.reponse1.Text = "Response";
            this.reponse1.UseVisualStyleBackColor = true;
            this.reponse1.Visible = false;
            this.reponse1.Click += new System.EventHandler(this.reponse1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // play
            // 
            this.play.Interval = 600;
            this.play.Tick += new System.EventHandler(this.play_Tick);
            // 
            // Reponse
            // 
            this.Reponse.Interval = 700;
            this.Reponse.Tick += new System.EventHandler(this.Reponse_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.paneldesk);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.paneltitre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged_1);
            this.panelMenu.ResumeLayout(false);
            this.paneltitre.ResumeLayout(false);
            this.paneltitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepc)).EndInit();
            this.paneldesk.ResumeLayout(false);
            this.paneldesk.PerformLayout();
            this.panelquestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHistorique;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Panel paneltitre;
        private System.Windows.Forms.Label Labeltitre;
        private System.Windows.Forms.Timer CountTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox timepc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeljr1;
        private System.Windows.Forms.Label labeljr2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label lscore1;
        private System.Windows.Forms.Label lscore2;
        private System.Windows.Forms.Label Labelquestion;
        private System.Windows.Forms.Label textquestion;
        private System.Windows.Forms.Panel paneldesk;
        private System.Windows.Forms.Panel panelquestion;
        private System.Windows.Forms.Button reponse4;
        private System.Windows.Forms.Button reponse3;
        private System.Windows.Forms.Button reponse2;
        private System.Windows.Forms.Button reponse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Rdy;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer play;
        private System.Windows.Forms.Timer Reponse;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.Timer timer3;
    }
}

