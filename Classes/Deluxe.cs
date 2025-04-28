using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Deluxe : Quarto
    {
        public Deluxe(int numQuarto, int andar) : base(numQuarto, andar)
        {
            float PrecoPorNoite = 200;
        }



    }
}
