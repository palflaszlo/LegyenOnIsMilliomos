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
    public partial class UjKerdesek : Form
    {
        public UjKerdesek()
        {
            InitializeComponent();
        }

        private void btnQuestionPlusz_Click(object sender, EventArgs e)
        {
            string line = nehezseg.Text + ";" + kerdes.Text + ";" + valaszA.Text + ";" + valaszB.Text + ";" + valaszC.Text + ";" + valaszD.Text + ";" + helyesValasz.Text + ";" + comboBox1.Text;
            using (StreamWriter sw = File.AppendText("kerdes.txt"))
            {
                sw.WriteLine(line);
            }
            string message = "Sikeresen felvette a kérdést a tárolóba!";
            string caption = "Üzenet!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                nehezseg.SelectedIndex = -1;
                kerdes.Clear();
                valaszA.Clear();
                valaszB.Clear();
                valaszC.Clear();
                valaszD.Clear();
                helyesValasz.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
