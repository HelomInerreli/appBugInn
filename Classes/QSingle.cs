using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class QSingle : Quarto

    {
        public double PrecoPorNoite { get; set; } = 70;
        public QSingle(int numQuarto, int andar, float conta, bool livre, string status, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)
            {
                
            }
        public string linhaBDSingle()
            {
                return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{Observacoes}";
            }
        
    }
}
