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
        Pontszam pt = new Pontszam();
        List<string> modok = new List<string>();
        List<int> pontszamook = new List<int>();
        List<string> nevek = new List<string>();
        List<string> idk = new List<string>();
        List<string> ptList = new List<string>();
        int osszSor = 0;
        public Ponttablazat()
        {
            InitializeComponent();
        }
        public int sorokSzama()
        {
            osszSor = pt.select().Count;
            return osszSor;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listScore.SelectedItems != null)
            {
                for (int i = listScore.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem itm = listScore.SelectedItems[i];
                    string pont = itm.ToString().Substring(15);
                    string pont2 = pont.TrimEnd('}');
                    int pont3 = Convert.ToInt32(pont2);
                    listScore.Items.RemoveAt(itm.Index);
                    pt.deletetRow(pont3);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ponttablazat_Load(object sender, EventArgs e)
        {
            osszSor = sorokSzama();
            ptList = pt.select();
            listScore.Items.Clear();
            for (int i = 0; i < osszSor; i++)
            {
                string[] adatok = ptList[i].Split(';');
                idk.Add(adatok[0]);
                nevek.Add(adatok[1]);
                pontszamook.Add(Convert.ToInt32(adatok[2]));
                modok.Add(adatok[3]);
                var row = new string[] { nevek[i], Convert.ToString(pontszamook[i]), modok[i] };
                ListViewItem lvi = new ListViewItem(idk[i]);
                lvi.SubItems.AddRange(row);
                listScore.Items.Add(lvi);
            }
        }
    }
}
