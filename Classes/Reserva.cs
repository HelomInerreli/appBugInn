using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Reserva
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Email { get; set; }
        public Quarto TipoQuarto { get; set; } 

        // Construtor
        public Reserva(int id, string nome, string telefone, DateTime dataInicio, DateTime dataFim, string email, Quarto tipoQuarto)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Email = email;
            TipoQuarto = tipoQuarto; // agora guarda o quarto na reserva
        }

        public TimeSpan CalcularDuracao()
        {
            return DataFim - DataInicio;
        }

        public bool ValidarReserva()
        {
            return DataInicio < DataFim;
        }

        public decimal CalcularPrecoTotal()
        {
            int dias = (int)CalcularDuracao().TotalDays;

            if (dias <= 0)
                dias = 1; // Para garantir no mínimo 1 dia (evita erros)

            return (decimal)(dias * TipoQuarto.PrecoPorNoite);
        }
    }
}
