using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    class JatekKerdesek
    {
        public Random r = new Random();
        string[] osszSor = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
        string[] temakorok = File.ReadAllLines("temak.txt", Encoding.UTF8);
        public List<Kerdes> questions = new List<Kerdes>();
        public List<string> kategoriak2 = new List<string>();
        public string[] themakk = new string[500];
        public string win = "";

        public JatekKerdesek()
        {
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                kategoriak2.Add(adatok[7]);
            }

            for (int i = 0; i < temakorok.Length; i++)
            {
                string[] temak = temakorok[i].Split(';');
                themakk[i] = temak[0];
            }

            if (Properties.Settings.Default.nehezseg.Equals("easy"))
            {
                int Nehezseg;
                string Kerdes_, HelyesValasz, Kategoria;
                string[] Valasz = new string[4];

                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');
                    if (themakk.Contains<string>(kategoriak2[i]))
                    {
                        Nehezseg = Convert.ToInt32(adatok[0]);
                        Kerdes_ = adatok[1];
                        Valasz[0] = adatok[2];
                        Valasz[1] = adatok[3];
                        Valasz[2] = adatok[4];
                        Valasz[3] = adatok[5];
                        HelyesValasz = adatok[6];
                        Kategoria = adatok[7];
                        Kerdes k = new Kerdes(Nehezseg, Kerdes_, Valasz, Kategoria, HelyesValasz);
                        questions.Add(k);
                    }
                }
            }

            else if (Properties.Settings.Default.nehezseg.Equals("normal"))
            {
                int Nehezseg;
                string Kerdes_, HelyesValasz, Kategoria;
                string[] Valasz = new string[4];

                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');

                    Nehezseg = Convert.ToInt32(adatok[0]);
                    Kerdes_ = adatok[1];

                    Valasz[0] = adatok[2];
                    Valasz[1] = adatok[3];
                    Valasz[2] = adatok[4];
                    Valasz[3] = adatok[5];
                    HelyesValasz = adatok[6];
                    Kategoria = adatok[7];
                    Kerdes k = new Kerdes(Nehezseg, Kerdes_, Valasz, Kategoria, HelyesValasz);
                    questions.Add(k);
                }
            }

            else if (Properties.Settings.Default.nehezseg.Equals("hard"))
            {
                int Nehezseg;
                string Kerdes_, HelyesValasz, Kategoria;
                string[] Valasz = new string[4];

                for (int i = 0; i < osszSor.Length; i++)
                {
                    string[] adatok = osszSor[i].Split(';');
                    if (themakk.Contains<string>(kategoriak2[i]))
                    {
                        Nehezseg = Convert.ToInt32(adatok[0]);
                        Kerdes_ = adatok[1];
                        Valasz[0] = adatok[2];
                        Valasz[1] = adatok[3];
                        Valasz[2] = adatok[4];
                        Valasz[3] = adatok[5];
                        HelyesValasz = adatok[6];
                        Kategoria = adatok[7];
                        Kerdes k = new Kerdes(Nehezseg, Kerdes_, Valasz, Kategoria, HelyesValasz);
                        questions.Add(k);
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
                return 16;
            }

            return sor;
        }

        public string getKerdes(int sor)
        {
            string kerdes = "Nincs semmi";
            kerdes = questions[sor].Kerdes_;
            return kerdes;
        }
        public string getValaszA(int sor)
        {
            string valaszA = "Nincs semmi";
            valaszA = questions[sor].Valaszok[0];
            return valaszA;
        }
        public string getValaszB(int sor)
        {
            string valaszB = "Nincs semmi";
            valaszB = questions[sor].Valaszok[1];
            return valaszB;
        }
        public string getValaszC(int sor)
        {
            string valaszC = "Nincs semmi";
            valaszC = questions[sor].Valaszok[2];
            return valaszC;
        }
        public string getValaszD(int sor)
        {
            string valaszD = "Nincs semmi";
            valaszD = questions[sor].Valaszok[3];
            return valaszD;
        }
        public string helyesBetu(int sor)
        {
            string valasz = "";
            valasz = questions[sor].HelyesValasz;
            return valasz;
        }
    }
}
