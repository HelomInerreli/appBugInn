using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Duplo : Quarto

    {
        public double PrecoPorNoite { get; set; } // Preço por noite
        public string TipoCama { get; set; } // Tipo de quarto (2 Solteiros ou 1 Casal)
        public Duplo(int numQuarto, int andar, float conta, bool livre, string status, double precoPorNoite, string tipoCama, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)

        {
            PrecoPorNoite = precoPorNoite;
            TipoCama = tipoCama; // Inicializa o tipo de cama


        }
        public string linhaBD()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{PrecoPorNoite};{TipoCama};{Observacoes}";
        }





    }
}
