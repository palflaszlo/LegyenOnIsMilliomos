using System;
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
        public fomenu()
        {
            InitializeComponent();
        }
        public bool btnLoadSave = false;
        private void btmStart_Click(object sender, EventArgs e)
        {
            Jatekmenuk jatekFormok = new Jatekmenuk();
            this.Hide();
            jatekFormok.ShowDialog();
            this.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoadSave = true;
            Properties.Settings.Default.mentes = true;
            Properties.Settings.Default.Save();
            Jatek GameForm = new Jatek();
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
    }
}
