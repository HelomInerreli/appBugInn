using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Reserva
    {
        private int _id;
        private string _nome;
        private string _telefone;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private string _email;



        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O seu ID nao pode ser negativo");
                }
                _id = value;
            }
        }
        public string Nome
        {

            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.All(char.IsLetter)) // esta a verificar se o nome apenas contem letras :)
                {
                    throw new ArgumentException("O nome deve conter apenas letras e nao pode estar vazio.");
                }
                _nome = value;
            }
        }
        public string Telefone
        {
            get => _telefone;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.All(char.IsDigit))
                {
                    throw new ArgumentException("O telefone deve conter apenas digitos numericos e nao pode estar vazio."); // verificar telefone so com numeros
                }
                _telefone = value;
            }
        }

        public DateTime DataInicio
        {
            get => _dataInicio;
            set
            {
                if (value.Date < DateTime.Today)
                {
                    throw new ArgumentException("A data de inicio tem de ser superior ao dia atual");
                }
                _dataInicio = value.Date;

            }
        }
        public DateTime DataFim
        {
            get => _dataFim;
            set
            {
                if (value.Date <= _dataInicio)
                {
                    throw new ArgumentException("A data do fim tem de ser superior a data do inicio da reserva");
                }
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                // Verificar se o e-mail não está vazio e tem o formato correto
                if (string.IsNullOrWhiteSpace(value) || !IsEmailValido(value))
                {
                    throw new ArgumentException("O email fornecido não é válido.");
                }
                _email = value;
            }



        }
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

            string linha = $"{Id};{Nome};{Telefone};{Email};{DataInicio:yyyy-MM-dd};{DataFim:yyyy-MM-dd};{TipoQuarto.NumQuarto}";

            try
            {
                // grava no ficheiro automaticamente
                Funcionalidades.GravarBaseDados("reservas", linha);
            }
            catch (Exception ex)
            {
                // mostra o erro
                Console.WriteLine("Erro ao gravar reserva: " + ex.Message);
               
            }

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

        public bool IsEmailValido(string email)
        {
            //  para validar o formato do e-mail
            var format = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return format.IsMatch(email);
        }
    }
}
