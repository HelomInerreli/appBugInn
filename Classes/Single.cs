using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Single : Quarto

    {
    public Single(int numQuarto, int andar) : base(numQuarto, andar)
        {
            PrecoPorNoite = 70;
        }
    }
}
