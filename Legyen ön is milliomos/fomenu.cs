﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class fomenu : Form
    {
        mentes mentett = new mentes();
        ProfilBeallitasok profil = new ProfilBeallitasok();
        public fomenu()
        {
            InitializeComponent();
            if (!mentett.select().Equals(""))
            {
                btnLoad.Enabled = true;
            }
            else
            {
                btnLoad.Enabled = false;
            }
            profil.difficulty = "normal";
            profil.yourName = "jatekos";
        }
        
        private void btmStart_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.playerName.Equals("") || Properties.Settings.Default.nehezseg.Equals(""))
            {
                string message = "Nem állítottál be profilt magadnak!";
                string caption = "Figyelem!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    profil.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                Jatekmenuk jatekFormok = new Jatekmenuk();
                this.Hide();
                jatekFormok.ShowDialog();
                this.Show();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mentes = true;
            Properties.Settings.Default.Save();
            MentettJatek GameForm = new MentettJatek();
            this.Hide();
            GameForm.ShowDialog();
            this.Show();
        }

        private void btnKerdes_Click(object sender, EventArgs e)
        {
            UjKerdesek kerdes = new UjKerdesek();
            this.Hide();
            kerdes.ShowDialog();
            this.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfilBeallitasok profil = new ProfilBeallitasok();
            this.Hide();
            profil.ShowDialog();
            this.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            Ponttablazat pontszam = new Ponttablazat();
            this.Hide();
            pontszam.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasikKerdes_Click(object sender, EventArgs e)
        {
            UjKepvagyZene bonyi = new UjKepvagyZene();
            this.Hide();
            bonyi.ShowDialog();
            this.Show();
        }
    }
}
