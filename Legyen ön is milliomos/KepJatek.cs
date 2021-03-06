﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class KepJatek : Form
    {
        public bool dontRunHandler;
        System.Timers.Timer myTimer = new System.Timers.Timer();
        System.Timers.Timer myTimer2 = new System.Timers.Timer();
        public int countDown = 0;
        public int countDown2 = 0;

        public Random r = new Random();
        KepJatekKerdesek jk = new KepJatekKerdesek();
        Pontszam pTsz = new Pontszam();
        private int szintT = 1;
        private int N;
        private string betu = "A";

        public KepJatek()
        {
            InitializeComponent();
            myTimer.Elapsed += new ElapsedEventHandler(customfn);
            myTimer.Interval = 1000;
            myTimer2.Elapsed += new ElapsedEventHandler(customfn2);
            myTimer2.Interval = 1000;
            pTsz.createDatabase();
        }

        private void customfn(object source, ElapsedEventArgs e)
        {
            countDown++;
            if (countDown % 3 == 0)
            {
                myTimer.Stop();
                getAnswear(betu);
            }
        }

        private void customfn2(object source, ElapsedEventArgs e)
        {
            countDown2++;
            if (countDown2 % 3 == 0)
            {
                myTimer2.Stop();
                text();
            }
        }

        public void text()
        {
            try
            {
                if (valaszA.InvokeRequired || valaszB.InvokeRequired || valaszC.InvokeRequired || valaszD.InvokeRequired)
                {
                    valaszA.Invoke(new Action(text));
                    valaszB.Invoke(new Action(text));
                    valaszC.Invoke(new Action(text));
                    valaszD.Invoke(new Action(text));
                    return;
                }
                if (jk.getSor(szintT, r.Next(jk.osszSor.Length)) == 16)
                {
                    szintT = 16;
                    pTsz.insertRow(Properties.Settings.Default.playerName, szintT, "képes");
                    string message = "Megnyerted az egész játékot!";
                    string caption = "Most már milliomos vagy!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.OK)
                    {
                        Jatek.ActiveForm.Close();
                    }
                }
                else
                {
                    N = jk.getSor(szintT, r.Next(jk.osszSor.Length));
                    pictureBox1.Load(jk.getLink(N));
                    if (jk.getKerdes(N).Equals(""))
                    {
                        picQu.Text = "Kié ez a kép?";
                    }
                    else
                    {
                        picQu.Text = jk.getKerdes(N);
                    }
                    valaszA.Text = jk.getValaszA(N);
                    valaszB.Text = jk.getValaszB(N);
                    valaszC.Text = jk.getValaszC(N);
                    valaszD.Text = jk.getValaszD(N);
                }
                valaszA.ForeColor = Color.White;
                valaszB.ForeColor = Color.White;
                valaszC.ForeColor = Color.White;
                valaszD.ForeColor = Color.White;

                valaszA.Visible = true;
                valaszB.Visible = true;
                valaszC.Visible = true;
                valaszD.Visible = true;
                myTimer.Stop();
                myTimer2.Stop();
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
                    case 16:
                        lvl15.BackColor = Color.Green; lvl15.ForeColor = Color.Black; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void error()
        {
            if (szintT >= 5)
            {
                szintT = 5;
            }
            else if (szintT >= 10)
            {
                szintT = 10;
            }
            else
            {
                szintT = 0;
            }
            pTsz.insertRow(Properties.Settings.Default.playerName, szintT, "képes");
            string message = "Wrong! You lost! You only won the " + szintT + ". level!";
            string caption = "Game over!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (valaszA.InvokeRequired || valaszB.InvokeRequired || valaszC.InvokeRequired || valaszD.InvokeRequired)
                    {
                        valaszA.Invoke(new Action(this.Close));
                        valaszB.Invoke(new Action(this.Close));
                        valaszC.Invoke(new Action(this.Close));
                        valaszD.Invoke(new Action(this.Close));
                        return;
                    }
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
                szintT++;
                switch (betu)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                myTimer2.Start();
            }
            else
            {
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                error();
            }
        }

        private void valaszA_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "A";
                valaszA.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "képes");
                string message = "Feladtad ezen a szinten. Megnyerted a  " + (szintT - 1) + ". szintet";
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
                valaszA.ForeColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszB_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "B";
                valaszB.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "képes");
                string message = "Feladtad ezen a szinten. Megnyerted a  " + (szintT - 1) + ". szintet";
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
                valaszB.ForeColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszC_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "C";
                valaszC.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "képes");
                string message = "Feladtad ezen a szinten. Megnyerted a  " + (szintT - 1) + ". szintet";
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
                valaszC.ForeColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszD_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "D";
                valaszD.ForeColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "képes");
                string message = "Feladtad ezen a szinten. Megnyerted a  " + (szintT - 1) + ". szintet";
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
                betu = "D";
                valaszD.ForeColor = Color.Orange;
                myTimer.Start();
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
                case "A": valaszA.ForeColor = Color.Red; break;
                case "B": valaszB.ForeColor = Color.Red; break;
                case "C": valaszC.ForeColor = Color.Red; break;
                case "D": valaszD.ForeColor = Color.Red; break;
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
                case 0: valaszA.Visible = false; break;
                case 1: valaszB.Visible = false; break;
                case 2: valaszC.Visible = false; break;
                case 3: valaszD.Visible = false; break;
            }
            switch (rand2)
            {
                case 0: valaszA.Visible = false; break;
                case 1: valaszB.Visible = false; break;
                case 2: valaszC.Visible = false; break;
                case 3: valaszD.Visible = false; break;
            }
            felezo.Enabled = false;
        }

        private void megallas_Click(object sender, EventArgs e)
        {
            dontRunHandler = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KepJatek_Load(object sender, EventArgs e)
        {
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
    }
}
