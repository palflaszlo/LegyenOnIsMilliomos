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
        public string[] osszSor = File.ReadAllLines("kepek.txt", Encoding.UTF8);
        public string[] path = File.ReadAllLines("fajlut.txt", Encoding.UTF8);
        public List<Kepek> questions = new List<Kepek>();

        public KepJatekKerdesek()
        {
            string HelyesValasz, link, kerdes;
            string[] Valasz = new string[4];
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                link = adatok[0];
                kerdes = adatok[1];
                Valasz[0] = adatok[2];
                Valasz[1] = adatok[3];
                Valasz[2] = adatok[4];
                Valasz[3] = adatok[5];
                HelyesValasz = adatok[6];
                Kepek k = new Kepek(link, kerdes, Valasz, HelyesValasz);
                questions.Add(k);
            }
        }

        public int getSor(int szint, int random)
        {
            int sor = 0;
            if (szint > 0 && szint < 8)
            {
                sor = random;
            }
            else if (szint > 6 && szint < 16)
            {
                sor = random;
            }
            else
            {
                return 16;
            }

            return sor;
        }

        public string getLink(int sor)
        {
            string link2 = "";
            for (int i = 0; i < path.Length; i++)
            {
                string[] adatok = path[i].Split(';');
                 link2 = adatok[0];
            }
            string link = "";
            link = questions[sor].Link;
            return link2+link;
        }

        public string getKerdes(int sor)
        {
            string kerdes = "";
            kerdes = questions[sor].Kerdes;
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
