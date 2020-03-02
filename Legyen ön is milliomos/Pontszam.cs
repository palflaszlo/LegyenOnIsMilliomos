using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_milliomos
{
    class Pontszam
    {
        public string YourName { get; set; }
        public int Highscore { get; set; }

        public Pontszam() { }

        public override string ToString()
        {
            var details = string.Format("{0} {1}", YourName, Highscore);
            return details;
        }
    }
}
