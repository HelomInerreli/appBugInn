using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Deluxe : Quarto
    {
        public Deluxe(int numQuarto, int andar, float conta, bool livre, string status, double precoPorNoite, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)
        {
            float PrecoPorNoite = 200;
        }



    }
}
