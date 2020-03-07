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
        public string[] osszSor = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
        public List<Kerdes> questions = new List<Kerdes>();

        public JatekKerdesek()
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

        public int getSor(int szint, int random)
        {
            int sor = 0;
            int nehez = questions[random].Nehezseg;
            if (szint > 0 && szint < 5)
            {
                if (nehez > 0 && nehez < 5)
                    sor = random;
                else getSor(szint, r.Next(0, osszSor.Length));
            }
            else if (szint > 4 && szint < 8)
            {
                if (szint > 4 && szint < 8)
                    sor = random;
                else getSor(szint, r.Next(0, osszSor.Length));
            }
            else if (szint > 7 && szint < 11)
            {
                if (szint > 7 && szint < 11)
                    sor = random;
                else getSor(szint, r.Next(0, osszSor.Length));
            }
            else if (szint > 10 && szint < 16)
            {
                if (szint > 10 && szint < 16)
                    sor = random;
                else getSor(szint, r.Next(0, osszSor.Length));
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
        public string getKategoria(int sor)
        {
            string kategoria = "";
            kategoria = questions[sor].Kategoria;
            return kategoria;
        }
    }
}
