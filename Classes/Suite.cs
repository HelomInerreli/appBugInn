using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Suite : Quarto
    {
        public double PrecoPorNoite { get; set; } = 150;
        public string TipoVista { get; set; } // Tipo de vista (Mar, Montanha, etc.)
        public Suite(int numQuarto, int andar, float conta, bool livre, string status, string tipoVista, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)
        {
            TipoVista = tipoVista;

        }

        public string linhaBD()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{TipoVista};{Observacoes}";
        }

        public string linhaBD()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{TipoVista};{Observacoes}";
        }
    }
}