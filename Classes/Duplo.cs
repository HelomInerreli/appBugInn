using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Duplo : Quarto

    {
        public double PrecoPorNoite { get; set; } = 100;
        public string TipoCama { get; set; } // Tipo de quarto (2 Solteiros ou 1 Casal)
        public Duplo(int numQuarto, int andar, float conta, bool livre, string status, string tipoCama, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)

        {
            TipoCama = tipoCama; // Inicializa o tipo de cama


        }
        public string linhaBD()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{TipoCama};{Observacoes}";
        }





    }
}
