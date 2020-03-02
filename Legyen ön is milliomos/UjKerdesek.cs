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
            string line = nehezsegiSzint.Text + ";" + kerdes.Text + ";" + valaszA.Text + ";" + valaszB.Text + ";" + valaszC.Text + ";" + valaszD.Text + ";" + helyesValasz.Text + ";" + temakor.Text;
            using (StreamWriter sw = File.AppendText("kerdes.txt"))
            {
                sw.WriteLine();
                sw.WriteLine(line);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
