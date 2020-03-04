using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class MentettJatek : Form
    {
        public MentettJatek()
        {
            InitializeComponent();
            t.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            t.Interval = 1000;
            t2.Elapsed += new ElapsedEventHandler(OnTimeEvent2);
            t2.Interval = 1000;
            pTsz.createDatabase();
            mentett.createDatabase();
            label1.Text = mentett.select();
        }

        public bool dontRunHandler;
        System.Timers.Timer t = new System.Timers.Timer();
        System.Timers.Timer t2 = new System.Timers.Timer();
        public int countDown = 0;
        public int countDown2 = 0;

        public Random r = new Random();
        JatekKerdesek jk = new JatekKerdesek();
        Pontszam pTsz = new Pontszam();
        mentes mentett = new mentes();
        private int szintT = 1;
        private int N;
        private string betu = "A";
        public int[] tomb = new int[50000];

        public int pontszam = 1;

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            countDown++;
            if (countDown % 3 == 0)
            {
                t.Stop();
                getAnswear(betu);
            }
        }

        private void OnTimeEvent2(object sender, ElapsedEventArgs e)
        {
            countDown2++;
            if (countDown2 % 3 == 0)
            {
                t2.Stop();
                text();
            }
        }

        public void text()
        {
            try
            {
                if (firstAnswer.InvokeRequired || secondAnswear.InvokeRequired || thirdAnswear.InvokeRequired || forthAnswear.InvokeRequired)
                {
                    firstAnswer.Invoke(new Action(text));
                    secondAnswear.Invoke(new Action(text));
                    thirdAnswear.Invoke(new Action(text));
                    forthAnswear.Invoke(new Action(text));
                    return;
                }
                if (!mentett.select().Equals("") && Properties.Settings.Default.mentes)
                {
                    try
                    {
                        Properties.Settings.Default.mentes = false;
                        string mentettAllas = mentett.select();
                        string[] adatok = mentettAllas.Split(';');
                        N = Convert.ToInt32(adatok[4]);
                        szintT = Convert.ToInt32(adatok[3]);
                        pontszam = Convert.ToInt32(adatok[2]);
                        Properties.Settings.Default.playerName = adatok[1];
                        Question.Text = szintT + ".  " + jk.getKerdes(N);
                        firstAnswer.Text = jk.getValaszA(N);
                        secondAnswear.Text = jk.getValaszB(N);
                        thirdAnswear.Text = jk.getValaszC(N);
                        forthAnswear.Text = jk.getValaszD(N);
                        switch (szintT)
                        {
                            case 1: lvl1.BackColor = Color.Orange; lvl1.ForeColor = Color.Black; break;
                            case 2:
                                lvl2.BackColor = Color.Orange; lvl2.ForeColor = Color.Black; lvl1.BackColor = Color.Green; break;
                            case 3:
                                lvl3.BackColor = Color.Orange; lvl3.ForeColor = Color.Black; lvl2.BackColor = Color.Green;
                                lvl1.BackColor = Color.Green; break;
                            case 4:
                                lvl4.BackColor = Color.Orange; lvl4.ForeColor = Color.Black; lvl3.BackColor = Color.Green;
                                lvl2.BackColor = Color.Green; lvl1.BackColor = Color.Green; break;
                            case 5:
                                lvl5.BackColor = Color.Orange; lvl5.ForeColor = Color.Black; lvl4.BackColor = Color.Green; 
                                lvl3.BackColor = Color.Green;  lvl2.BackColor = Color.Green; lvl1.BackColor = Color.Green; break;
                            case 6:
                                lvl6.BackColor = Color.Orange; lvl6.ForeColor = Color.Black; lvl5.BackColor = Color.Green;    
                                lvl4.BackColor = Color.Green;  lvl3.BackColor = Color.Green; lvl2.BackColor = Color.Green;
                                lvl1.BackColor = Color.Green; break;
                            case 7:
                                lvl7.BackColor = Color.Orange; lvl7.ForeColor = Color.Black; lvl6.BackColor = Color.Green;
                                lvl5.BackColor = Color.Green;  lvl4.BackColor = Color.Green; lvl3.BackColor = Color.Green;
                                lvl2.BackColor = Color.Green;  lvl1.BackColor = Color.Green; break;
                            case 8:
                                lvl8.BackColor = Color.Orange; lvl8.ForeColor = Color.Black; lvl7.BackColor = Color.Green;  
                                lvl6.BackColor = Color.Green;  lvl5.BackColor = Color.Green; lvl4.BackColor = Color.Green;
                                lvl3.BackColor = Color.Green;  lvl2.BackColor = Color.Green; lvl1.BackColor = Color.Green; break;
                            case 9:
                                lvl9.BackColor = Color.Orange; lvl9.ForeColor = Color.Black; lvl8.BackColor = Color.Green;
                                lvl7.BackColor = Color.Green;  lvl6.BackColor = Color.Green; lvl5.BackColor = Color.Green;
                                lvl4.BackColor = Color.Green;  lvl3.BackColor = Color.Green; lvl2.BackColor = Color.Green;
                                lvl1.BackColor = Color.Green; break;
                            case 10:
                                lvl10.BackColor = Color.Orange; lvl10.ForeColor = Color.Black; lvl9.BackColor = Color.Green;
                                lvl8.BackColor = Color.Green;   lvl7.BackColor = Color.Green;  lvl6.BackColor = Color.Green;
                                lvl5.BackColor = Color.Green;   lvl4.BackColor = Color.Green;  lvl3.BackColor = Color.Green;
                                lvl2.BackColor = Color.Green;   lvl1.BackColor = Color.Green; break;
                            case 11:
                                lvl11.BackColor = Color.Orange; lvl11.ForeColor = Color.Black; lvl10.BackColor = Color.Green;
                                lvl9.BackColor = Color.Green;   lvl8.BackColor = Color.Green;  lvl7.BackColor = Color.Green;
                                lvl6.BackColor = Color.Green;   lvl5.BackColor = Color.Green;  lvl4.BackColor = Color.Green;
                                lvl3.BackColor = Color.Green;   lvl2.BackColor = Color.Green;  lvl1.BackColor = Color.Green; break;
                            case 12:
                                lvl12.BackColor = Color.Orange; lvl12.ForeColor = Color.Black; lvl11.BackColor = Color.Green;
                                lvl10.BackColor = Color.Green;  lvl9.BackColor = Color.Green;  lvl8.BackColor = Color.Green;
                                lvl7.BackColor = Color.Green;   lvl6.BackColor = Color.Green;  lvl5.BackColor = Color.Green;
                                lvl4.BackColor = Color.Green;   lvl3.BackColor = Color.Green;  lvl2.BackColor = Color.Green;
                                lvl1.BackColor = Color.Green; break;
                            case 13:
                                lvl13.BackColor = Color.Orange; lvl13.ForeColor = Color.Black; lvl12.BackColor = Color.Green;
                                lvl11.BackColor = Color.Green;  lvl10.BackColor = Color.Green; lvl9.BackColor = Color.Green;
                                lvl8.BackColor = Color.Green;   lvl7.BackColor = Color.Green;  lvl6.BackColor = Color.Green;
                                lvl5.BackColor = Color.Green;   lvl4.BackColor = Color.Green;  lvl3.BackColor = Color.Green;
                                lvl2.BackColor = Color.Green;   lvl1.BackColor = Color.Green; break;
                            case 14:
                                lvl14.BackColor = Color.Orange; lvl14.ForeColor = Color.Black; lvl13.BackColor = Color.Green;
                                lvl12.BackColor = Color.Green;  lvl11.BackColor = Color.Green; lvl10.BackColor = Color.Green;
                                lvl9.BackColor = Color.Green;   lvl8.BackColor = Color.Green;  lvl7.BackColor = Color.Green;
                                lvl6.BackColor = Color.Green;   lvl5.BackColor = Color.Green;  lvl4.BackColor = Color.Green;
                                lvl3.BackColor = Color.Green;   lvl2.BackColor = Color.Green;  lvl1.BackColor = Color.Green; break;
                            case 15:
                                lvl15.BackColor = Color.Orange; lvl15.ForeColor = Color.Black; lvl14.BackColor = Color.Green;
                                lvl13.BackColor = Color.Green;  lvl12.BackColor = Color.Green; lvl11.BackColor = Color.Green;
                                lvl10.BackColor = Color.Green;  lvl9.BackColor = Color.Green;  lvl8.BackColor = Color.Green;
                                lvl7.BackColor = Color.Green;   lvl6.BackColor = Color.Green;  lvl5.BackColor = Color.Green;
                                lvl4.BackColor = Color.Green;   lvl3.BackColor = Color.Green;  lvl2.BackColor = Color.Green;
                                lvl1.BackColor = Color.Green; break;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        StreamWriter newFile = new StreamWriter("save.txt");
                    }

                }
                else
                {
                    if (szintT == 16)
                    {
                        jk.win = "won";
                        pontszam = 16;
                        pTsz.insertRow(Properties.Settings.Default.playerName, pontszam);
                        jk.win = "";
                        Properties.Settings.Default.vege = false;
                        Properties.Settings.Default.Save();
                        string message = "You won the whole game!";
                        string caption = "You are a millionare!";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            // Closes the parent form.
                            MentettJatek.ActiveForm.Close();
                        }
                    }
                    else
                    {
                        N = jk.getSor(szintT, tomb[szintT]);
                        Question.Text = szintT + ".  " + jk.getKerdes(N);
                        firstAnswer.Text = jk.getValaszA(N);
                        secondAnswear.Text = jk.getValaszB(N);
                        thirdAnswear.Text = jk.getValaszC(N);
                        forthAnswear.Text = jk.getValaszD(N);
                    }
                }
                if (szintT != 1)
                {
                    pontszam++;
                }
                firstAnswer.ForeColor = Color.White;
                secondAnswear.ForeColor = Color.White;
                thirdAnswear.ForeColor = Color.White;
                forthAnswear.ForeColor = Color.White;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                t.Stop();
                t2.Stop();
                switch (szintT)
                {
                    case 1: lvl1.BackColor = Color.Orange; lvl1.ForeColor = Color.Black; break;
                    case 2:
                        lvl2.BackColor = Color.Orange; lvl2.ForeColor = Color.Black;
                        lvl1.BackColor = Color.Green; break;
                    case 3:
                        lvl3.BackColor = Color.Orange; lvl3.ForeColor = Color.Black;
                        lvl2.BackColor = Color.Green; break;
                    case 4:
                        lvl4.BackColor = Color.Orange; lvl4.ForeColor = Color.Black;
                        lvl3.BackColor = Color.Green; break;
                    case 5:
                        lvl5.BackColor = Color.Orange; lvl5.ForeColor = Color.Black;
                        lvl4.BackColor = Color.Green; break;
                    case 6:
                        lvl6.BackColor = Color.Orange; lvl6.ForeColor = Color.Black;
                        lvl5.BackColor = Color.Green; break;
                    case 7:
                        lvl7.BackColor = Color.Orange; lvl7.ForeColor = Color.Black;
                        lvl6.BackColor = Color.Green; break;
                    case 8:
                        lvl8.BackColor = Color.Orange; lvl8.ForeColor = Color.Black;
                        lvl7.BackColor = Color.Green; break;
                    case 9:
                        lvl9.BackColor = Color.Orange; lvl9.ForeColor = Color.Black;
                        lvl8.BackColor = Color.Green; break;
                    case 10:
                        lvl10.BackColor = Color.Orange; lvl10.ForeColor = Color.Black;
                        lvl9.BackColor = Color.Green; break;
                    case 11:
                        lvl11.BackColor = Color.Orange; lvl11.ForeColor = Color.Black;
                        lvl10.BackColor = Color.Green; break;
                    case 12:
                        lvl12.BackColor = Color.Orange; lvl12.ForeColor = Color.Black;
                        lvl11.BackColor = Color.Green; break;
                    case 13:
                        lvl13.BackColor = Color.Orange; lvl13.ForeColor = Color.Black;
                        lvl12.BackColor = Color.Green; break;
                    case 14:
                        lvl14.BackColor = Color.Orange; lvl14.ForeColor = Color.Black;
                        lvl13.BackColor = Color.Green; break;
                    case 15:
                        lvl15.BackColor = Color.Orange; lvl15.ForeColor = Color.Black;
                        lvl14.BackColor = Color.Green; break;
                    case 16: lvl15.BackColor = Color.Green; lvl15.ForeColor = Color.Black; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void error()
        {
            jk.win = "lost";
            Properties.Settings.Default.vege = true;
            if (pontszam / 4 >= 5)
            {
                pontszam = 5;
            }
            else if (pontszam / 4 >= 10)
            {
                pontszam = 10;
            }
            else
            {
                pontszam = 0;
            }
            pTsz.insertRow(Properties.Settings.Default.playerName, pontszam);
            jk.win = "";
            Properties.Settings.Default.vege = false;
            Properties.Settings.Default.Save();
            string message = "Worng! You lost! You only won the " + pontszam + ". level!";
            string caption = "Game over!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (firstAnswer.InvokeRequired || secondAnswear.InvokeRequired || thirdAnswear.InvokeRequired || forthAnswear.InvokeRequired)
                    {
                        firstAnswer.Invoke(new Action(error));
                        secondAnswear.Invoke(new Action(error));
                        thirdAnswear.Invoke(new Action(error));
                        forthAnswear.Invoke(new Action(error));
                        return;
                    }
                    MentettJatek.ActiveForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getAnswear(string betu)
        {
            string helyes = jk.helyesBetu(N);
            if (jk.helyesBetu(N).Equals(betu))
            {
                t2.Start();
                szintT++;
                switch (betu)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                //ide még egy zene jön
            }
            else
            {
                switch (helyes)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                error();
            }
        }

        private void MentettJatek_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < jk.questions.Count - 1; i++)
            {
                tomb[i] = r.Next(0, 4999);
            }
            text();
            string segit = "Felező";
            string[] segitsegek = Properties.Settings.Default.helps.Split(',');
            if (segitsegek.Contains<string>(segit))
            {
                felezo.Enabled = true;
            }
            else
            {
                felezo.Enabled = false;
            }
            segit = "Közönség";
            if (segitsegek.Contains<string>(segit))
            {
                telefonos.Enabled = true;
            }
            else
            {
                telefonos.Enabled = false;
            }
            segit = "Telefonos";
            if (segitsegek.Contains<string>(segit))
            {
                kozonseg.Enabled = true;
            }
            else
            {
                kozonseg.Enabled = false;
            }
        }

        private void firstAnswer_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "A";
                firstAnswer.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + (szintT - 1) + ". level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "A";
                firstAnswer.ForeColor = Color.Orange;
                t.Start();
            }
        }

        private void secondAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "B";
                secondAnswear.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + (szintT - 1) + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "B";
                secondAnswear.ForeColor = Color.Orange;
                t.Start();
            }
        }

        private void thirdAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "C";
                thirdAnswear.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + (szintT - 1) + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "C";
                thirdAnswear.ForeColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
        }

        private void forthAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "D";
                forthAnswear.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.ForeColor = Color.Green; break;
                    case "B": secondAnswear.ForeColor = Color.Green; break;
                    case "C": thirdAnswear.ForeColor = Color.Green; break;
                    case "D": forthAnswear.ForeColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + (szintT - 1) + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    //Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "D";
                forthAnswear.ForeColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
        }

        private void kozonseg_Click(object sender, EventArgs e)
        {
            string helyesvalasz = jk.helyesBetu(N);
            Kozonseg asdads = new Kozonseg(helyesvalasz);
            asdads.ShowDialog();
            kozonseg.Enabled = false;
        }

        private void telefonos_Click(object sender, EventArgs e)
        {
            string helyesvalasz = jk.helyesBetu(N);
            switch (helyesvalasz)
            {
                case "A": firstAnswer.ForeColor = Color.Pink; break;
                case "B": secondAnswear.ForeColor = Color.Pink; break;
                case "C": thirdAnswear.ForeColor = Color.Pink; break;
                case "D": forthAnswear.ForeColor = Color.Pink; break;
            }
            telefonos.Enabled = false;
        }

        private void felezo_Click(object sender, EventArgs e)
        {
            string helyesvalasz = jk.helyesBetu(N);
            int HV = 0;
            switch (helyesvalasz)
            {
                case "A": HV = 0; break;
                case "B": HV = 1; break;
                case "C": HV = 2; break;
                case "D": HV = 3; break;
            }
            int rand, rand2;
            do
            {
                rand = r.Next(0, 4);
                rand2 = r.Next(0, 4);
            } while (rand == rand2 || rand == HV || rand2 == HV);
            switch (rand)
            {
                case 0: firstAnswer.Visible = false; break;
                case 1: secondAnswear.Visible = false; break;
                case 2: thirdAnswear.Visible = false; break;
                case 3: forthAnswear.Visible = false; break;
            }
            switch (rand2)
            {
                case 0: firstAnswer.Visible = false; break;
                case 1: secondAnswear.Visible = false; break;
                case 2: thirdAnswear.Visible = false; break;
                case 3: forthAnswear.Visible = false; break;
            }
            felezo.Enabled = false;
        }

        private void megallas_Click(object sender, EventArgs e)
        {
            dontRunHandler = true;
            jk.win = "quit";
            Properties.Settings.Default.vege = true;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            mentett.insertRow(Properties.Settings.Default.playerName, pontszam, szintT, N);
            jk.win = "";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
