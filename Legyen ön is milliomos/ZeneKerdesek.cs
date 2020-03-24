using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Legyen_ön_is_milliomos
{
    class ZeneKerdesek
    {
        public Random r = new Random();
        public string[] osszSor = File.ReadAllLines("zenek.txt", Encoding.UTF8);
        public List<Zenek> questions = new List<Zenek>();

        public ZeneKerdesek()
        {
            string HelyesValasz, url, kerdes;
            string[] Valasz = new string[4];
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                url = adatok[0];
                kerdes = adatok[1];
                Valasz[0] = adatok[2];
                Valasz[1] = adatok[3];
                Valasz[2] = adatok[4];
                Valasz[3] = adatok[5];
                HelyesValasz = adatok[6];
                Zenek z = new Zenek(url, kerdes, Valasz, HelyesValasz);
                questions.Add(z);
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

        public string getURL(int sor)
        {
            string url = "";
            url = questions[sor].URL;
            return url;
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
