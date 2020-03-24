using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class UjKepvagyZene : Form
    {
        public UjKepvagyZene()
        {
            InitializeComponent();
        }

        private void btnFelvétel_Click(object sender, EventArgs e)
        {
            string line;
            if(tbKerdes.Text == "")
            {
                line = tbFajlnev.Text + ";" + "Mi van a képen?" + ";" + tbA.Text + ";" + tbB.Text + ";" + tbB.Text + ";" + tbD.Text + ";" + helyesValasz.Text;
            }
            else
            {
                line = tbFajlnev.Text + ";" + tbKerdes.Text + ";" + tbA.Text + ";" + tbB.Text + ";" + tbB.Text + ";" + tbD.Text + ";" + helyesValasz.Text;
            }           
            if(comboBox1.Text == "KÉP")
            {
                using (StreamWriter sw = File.AppendText("kepek.txt"))
                {
                    sw.WriteLine(line);
                }
            }
            if (comboBox1.Text == "ZENE")
            {
                using (StreamWriter sw = File.AppendText("zenek.txt"))
                {
                    sw.WriteLine(line);
                }
            }
            string message = "Sikeresen felvette a kérdést a tárolóba!";
            string caption = "Üzenet!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                tbFajlnev.Clear();
                tbKerdes.Clear();
                tbA.Clear();
                tbB.Clear();
                tbC.Clear();
                tbD.Clear();
                helyesValasz.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFajlUt_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("fajlut.txt"))
            {
                sw.WriteLine(tbFajlUt.Text);
            }
        }
    }
}
