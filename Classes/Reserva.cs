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
        public Quarto tipoQuarto{ get; set; }

        // Construtor

        public Reserva(int id, string nome, string telefone, DateTime dataInicio, DateTime dataFim, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Email = email;
        }
    
    public TimeSpan calcularDuracao()
        {
                TimeSpan duracao= DataFim - DataInicio;
            return duracao;



        }

        public bool validarReserva()
        {
            return DataInicio < DataFim;
        }

        public decimal calcularPrecoTotal()
        {
            int dias = (int)calcularDuracao().TotalDays;
            return dias;  // multiplicar os dias pelo preço do tipo de quarto

        }
    }
}
