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
    public partial class Jatekmenuk : Form
    {
        public Jatekmenuk()
        {
            InitializeComponent();
        }

        private void szoveges_Click(object sender, EventArgs e)
        {
            Jatek GameForm = new Jatek();
            this.Hide();
            GameForm.ShowDialog();
            this.Show();
        }

        private void kepes_Click(object sender, EventArgs e)
        {
            KepJatek kepek = new KepJatek();
            this.Hide();
            kepek.ShowDialog();
            this.Show();
        }

        private void zenes_Click(object sender, EventArgs e)
        {
            ZeneJatek zene = new ZeneJatek();
            this.Hide();
            zene.ShowDialog();
            this.Show();
        }

        private void segitE_Click(object sender, EventArgs e)
        {
            Segitseg intr = new Segitseg();
            this.Hide();
            intr.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
