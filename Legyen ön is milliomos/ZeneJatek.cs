using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WMPLib;
using System.Timers;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class ZeneJatek : Form
    {
        public bool dontRunHandler;
        public System.Timers.Timer myTimer = new System.Timers.Timer();
        public System.Timers.Timer myTimer2 = new System.Timers.Timer();
        public int countDown = 0;
        public int countDown2 = 0;

        public Random r = new Random();
        ZeneKerdesek zk = new ZeneKerdesek();
        Pontszam pTsz = new Pontszam();
        private int szintT = 1;
        private int N;
        private string betu = "A";
        public string path = @"";

        WindowsMediaPlayer Player;

        private void PlayFile(string path, string url)
        {
            Player = new WindowsMediaPlayer();
            Player.PlayStateChange +=
                new _WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new _WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = path + url;

        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPPlayState)NewState == WMPPlayState.wmppsStopped)
            {
                Player.controls.stop();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
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

        public ZeneJatek()
        {
            InitializeComponent();
            myTimer.Elapsed += new ElapsedEventHandler(customfn);
            myTimer.Interval = 1000;
            myTimer2.Elapsed += new ElapsedEventHandler(customfn2);
            myTimer2.Interval = 1000;
            StreamReader olv = new StreamReader("fajlut.txt", Encoding.Default);
            path += olv.ReadLine();
            olv.Close();
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
                if (zk.getSor(szintT, r.Next(zk.osszSor.Length)) == 16)
                {
                    szintT = 16;
                    pTsz.insertRow(Properties.Settings.Default.playerName, szintT, "zenés");
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
                    N = zk.getSor(szintT, r.Next(zk.osszSor.Length));
                    valaszA.Text = zk.getValaszA(N);
                    valaszB.Text = zk.getValaszB(N);
                    valaszC.Text = zk.getValaszC(N);
                    valaszD.Text = zk.getValaszD(N);
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
            pTsz.insertRow(Properties.Settings.Default.playerName, szintT, "zenés");
            string message = "Hibás válasz! Vesztettél! Megnyerted a(z) " + szintT + ". szintet!";
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
            string helyes = zk.helyesBetu(N);
            if (zk.helyesBetu(N).Equals(betu))
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
                string helyes = zk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "zenés");
                string message = "Feladtad ezen a szinten. Megnyerted a  " + (szintT-1) + ". szintet";
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
                string helyes = zk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "zenés");
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
                string helyes = zk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "zenés");
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
                string helyes = zk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.ForeColor = Color.Green; break;
                    case "B": valaszB.ForeColor = Color.Green; break;
                    case "C": valaszC.ForeColor = Color.Green; break;
                    case "D": valaszD.ForeColor = Color.Green; break;
                }
                pTsz.insertRow(Properties.Settings.Default.playerName, szintT - 1, "zenés");
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

        private void btnZene_Click(object sender, EventArgs e)
        {
            PlayFile(path, zk.getURL(N));
            Player.controls.play();        
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player_PlayStateChange(1);
        }

        private void kozonseg_Click(object sender, EventArgs e)
        {
            string helyesvalasz = zk.helyesBetu(N);
            Kozonseg asdads = new Kozonseg(helyesvalasz);
            asdads.ShowDialog();
            kozonseg.Enabled = false;
        }

        private void telefonos_Click(object sender, EventArgs e)
        {
            string helyesvalasz = zk.helyesBetu(N);
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
            string helyesvalasz = zk.helyesBetu(N);
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

        private void ZeneJatek_Load(object sender, EventArgs e)
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
                kozonseg.Enabled = true;
            }
            else
            {
                kozonseg.Enabled = false;
            }
            segit = "Telefonos";
            if (segitsegek.Contains<string>(segit))
            {
                telefonos.Enabled = true;
            }
            else
            {
                telefonos.Enabled = false;
            }
        }
    }
}
