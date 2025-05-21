using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Deluxe : Quarto
    {
        public string TipoVista { get; set; } // Tipo de vista (Mar, Montanha, etc.)
        public bool Banheira { get; set; } // Indica se o quarto tem banheira
        public double PrecoPorNoite { get; set; } = 200; // Preço por noite para o quarto Deluxe
        public Deluxe(int numQuarto, int andar, float conta, bool livre, string status, string tipoVista, bool banheira, string observacoes) : base(numQuarto, andar, conta, livre, status, observacoes)
        {
            TipoVista = tipoVista; // Inicializa o tipo de vista
            Banheira = banheira; // Define que o quarto Deluxe tem banheira

        }

        public string linhaBD()
        {
            return $"{NumQuarto};{Andar};{Conta};{Livre};{Status};{TipoVista};{Banheira};{Observacoes}";
        }

    }
}