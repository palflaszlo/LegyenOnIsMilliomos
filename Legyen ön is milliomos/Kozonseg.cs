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
    public partial class Kozonseg : Form
    {
        public string valasz;
        Random r = new Random();
        public Kozonseg(string kozValasz)
        {
            this.valasz = kozValasz;
            InitializeComponent();
        }

        private void Kozonseg_Load(object sender, EventArgs e)
        {
            int rand4 = 65;
            int rand, rand2, rand3;
            string nev = "Series1";
            do
            {
                rand = r.Next(0, 20);
                rand2 = r.Next(0, 20);
                rand3 = r.Next(0, 20);
            } while (rand + rand2 + rand3 > 35);
            if (valasz == "A")
            {
                this.kozonsegChart.Series[nev].Points.AddXY("A", rand4);
                this.kozonsegChart.Series[nev].Points.AddXY("B", rand);
                this.kozonsegChart.Series[nev].Points.AddXY("C", rand2);
                this.kozonsegChart.Series[nev].Points.AddXY("D", rand3);
            }
            else if (valasz == "B")
            {
                this.kozonsegChart.Series[nev].Points.AddXY("A", rand);
                this.kozonsegChart.Series[nev].Points.AddXY("B", rand4);
                this.kozonsegChart.Series[nev].Points.AddXY("C", rand2);
                this.kozonsegChart.Series[nev].Points.AddXY("D", rand3);
            }
            else if (valasz == "C")
            {
                this.kozonsegChart.Series[nev].Points.AddXY("A", rand);
                this.kozonsegChart.Series[nev].Points.AddXY("B", rand2);
                this.kozonsegChart.Series[nev].Points.AddXY("C", rand4);
                this.kozonsegChart.Series[nev].Points.AddXY("D", rand3);
            }
            else if (valasz == "D")
            {
                this.kozonsegChart.Series[nev].Points.AddXY("A", rand);
                this.kozonsegChart.Series[nev].Points.AddXY("B", rand2);
                this.kozonsegChart.Series[nev].Points.AddXY("C", rand3);
                this.kozonsegChart.Series[nev].Points.AddXY("D", rand4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
