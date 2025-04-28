using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Suite : Quarto
    {


        public Suite(int numQuarto, int andar) : base(numQuarto, andar)
        {
            PrecoPorNoite = 150;


        }
    }
}
