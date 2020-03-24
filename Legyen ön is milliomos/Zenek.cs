using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_milliomos
{
    class Zenek
    {
        private string url;
        private string[] valaszok = new string[4];
        private string helyesValasz, kerdes;

        public string[] Valaszok { get => valaszok; set => valaszok = value; }
        public string HelyesValasz { get => helyesValasz; set => helyesValasz = value; }
        public string URL { get => url; set => url = value; }
        public string Kerdes { get => kerdes; set => kerdes = value; }

        public Zenek(string url, string kerdes, string[] valaszok, string helyesValasz)
        {
            this.url = url;
            this.kerdes = kerdes;
            this.valaszok[0] = valaszok[0];
            this.valaszok[1] = valaszok[1];
            this.valaszok[2] = valaszok[2];
            this.valaszok[3] = valaszok[3];
            this.helyesValasz = helyesValasz;
        }
    }
}
