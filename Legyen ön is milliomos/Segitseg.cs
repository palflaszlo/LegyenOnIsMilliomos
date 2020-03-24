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
    public partial class Segitseg : Form
    {
        public Segitseg()
        {
            InitializeComponent();
            label6.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label4.Visible = false;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.Text = "A négy válasz közül bármelyikre kattintva dől el, hogy jól válaszolt-e vagy sem.";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Itt található a kérdés és a négy válaszlehetőség.";
        }

        private void btnExitGame_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void megallas_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void lvl15_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void lvl15_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
            label7.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
            label7.Visible = false;
        }

        private void megallas_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void btnExitGame_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
