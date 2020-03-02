using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    class KepJatekKerdesek
    {
        public Random r = new Random();
        string[] osszSor = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
        string[] temakorok = File.ReadAllLines("temak.txt", Encoding.UTF8);
        public int[] nehezsegek = new int[50000];
        public string[] kerdesek = new string[50000];
        public string[] valaszokA = new string[50000];
        public string[] valaszokB = new string[50000];
        public string[] valaszokC = new string[50000];
        public string[] valaszokD = new string[50000];
        public string[] kategoriak = new string[50000];
        public string[] kategoriak2 = new string[50000];
        public string[] helyesValaszok = new string[50000];
        ProfilBeallitasok pf = new ProfilBeallitasok();
        public string[] themakk = new string[50000];

        public KepJatekKerdesek()
        {
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                kategoriak2[i] = adatok[7];
            }
            for (int i = 0; i < temakorok.Length; i++)
            {
                string[] temak = temakorok[i].Split(';');
                themakk[i] = temak[0];
            }

            if (Properties.Settings.Default.nehezseg.Equals("easy"))
            {
                int k = 0;
                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');
                    if (themakk.Contains<string>(kategoriak2[i]))
                    {
                        nehezsegek[k] = Convert.ToInt32(adatok[0]);
                        kerdesek[k] = adatok[1];
                        valaszokA[k] = adatok[2];
                        valaszokB[k] = adatok[3];
                        valaszokC[k] = adatok[4];
                        valaszokD[k] = adatok[5];
                        helyesValaszok[k] = adatok[6];
                        kategoriak[k] = adatok[7];
                        k++;
                    }
                }
            }
            else if (Properties.Settings.Default.nehezseg.Equals("normal"))
            {
                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');
                    nehezsegek[i] = Convert.ToInt32(adatok[0]);
                    kerdesek[i] = adatok[1];
                    valaszokA[i] = adatok[2];
                    valaszokB[i] = adatok[3];
                    valaszokC[i] = adatok[4];
                    valaszokD[i] = adatok[5];
                    helyesValaszok[i] = adatok[6];
                    kategoriak[i] = adatok[7];
                }
            }
            else if (Properties.Settings.Default.nehezseg.Equals("hard"))
            {
                int k = 0;
                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');
                    if (themakk.Contains<string>(kategoriak2[i]))
                    {
                        nehezsegek[k] = Convert.ToInt32(adatok[0]);
                        kerdesek[k] = adatok[1];
                        valaszokA[k] = adatok[2];
                        valaszokB[k] = adatok[3];
                        valaszokC[k] = adatok[4];
                        valaszokD[k] = adatok[5];
                        helyesValaszok[k] = adatok[6];
                        kategoriak[k] = adatok[7];
                        k++;
                    }
                }
            }
        }

        public int getSor(int szint, int random)
        {
            int sor = 0;
            if (szint > 0 && szint < 8)
            {
                sor = random;
            }
            else if (szint > 7 && szint < 16)
            {
                sor = random;
            }
            else
            {
                string message = "You won the whole game!";
                string caption = "You are a millionare!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Jatek.ActiveForm.Close();
                }
            }

            return sor;
        }

        public string getKerdes(int sor, int szint)
        {
            string kerdes = "Nincs semmi";
            int j = sor;
            kerdes = kerdesek[j];
            return kerdes;
        }

        public string getValaszA(int sor, int szint)
        {
            string valaszA = "Nincs semmi";
            int j = sor;
            valaszA = valaszokA[j];
            return valaszA;
        }
        public string getValaszB(int sor, int szint)
        {
            string valaszB = "Nincs semmi";
            int j = sor;
            valaszB = valaszokB[j];
            return valaszB;
        }
        public string getValaszC(int sor, int szint)
        {
            string valaszC = "Nincs semmi";
            int j = sor;
            valaszC = valaszokC[j];
            return valaszC;
        }
        public string getValaszD(int sor, int szint)
        {
            string valaszD = "Nincs semmi";
            int j = sor;
            valaszD = valaszokD[j];
            return valaszD;
        }

        public string helyesBetu(int sor)
        {
            string valasz = "";
            int j = sor;
            valasz = helyesValaszok[j];
            return valasz;
        }
    }
}
