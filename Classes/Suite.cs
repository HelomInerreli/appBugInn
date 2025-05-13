using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Suite : Quarto
    {
        private bool miniBar;
        private string vistaQuarto;

        public Suite(int numQuarto, int andar) : base(numQuarto, andar)
        {
            PrecoPorNoite = 150;

        }
        public string linhaBDDuplo()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{miniBar};{vistaQuarto}";
        }
    }
}
