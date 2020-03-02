using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class Ponttablazat : Form
    {
        Jatek jatek = new Jatek();
        string[] osszSor = File.ReadAllLines("pontszamok.txt", Encoding.UTF8);
        public int[] pontszamook = new int[50000];
        public string[] nevek = new string[50000];
        public int[] idk = new int[50000];

        public Ponttablazat()
        {
            InitializeComponent();
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                pontszamook[i] = Convert.ToInt32(adatok[1]);
                nevek[i] = adatok[0];
            }
        }

        private List<Pontszam> GetPontszamList()
        {
            var list = new List<Pontszam>();
            for (int i = 0; i < osszSor.Length; i++)
            {
                list.Add(new Pontszam()
                {
                    YourName = nevek[i],
                    Highscore = pontszamook[i]
                });
            }
            return list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listScore.SelectedItems != null)
            {
                for (int i = listScore.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem itm = listScore.SelectedItems[i];
                    listScore.Items[itm.Index].Remove();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Ponttablazat_Load(object sender, EventArgs e)
        {
            var pontSZ = GetPontszamList();
            foreach (var person in pontSZ)
            {
                var row = new string[] { person.YourName, Convert.ToString(person.Highscore) };
                var lvi = new ListViewItem(row);
                listScore.Items.Add(lvi);
            }
        }

        private void Ponttablazat_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter outputFile = new StreamWriter("pontszamok.txt");
            var pontSZ = GetPontszamList();
            foreach (var person in pontSZ)
            {
                var row = new string[] { person.YourName, Convert.ToString(person.Highscore) };
                outputFile.WriteLine(row[0] + ";" + row[1]);
            }
            outputFile.Close();
        }
    }
}
