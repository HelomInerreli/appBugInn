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
        private int _telefone;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private string _email;
        private int _numeroPessoas;
        private string _tipoQuarto;



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
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || c == ' '))
                {
                    throw new ArgumentException("O nome deve conter apenas letras e espaços, e não pode estar vazio.");
                }
                _nome = value;
            }
        }
        public int Telefone
        {
            get => _telefone;
            set
            {

                string numero = value.ToString();

                // Verifica se tem exatamente 9 dígitos
                if (numero.Length != 9 || !numero.All(char.IsDigit))
                    throw new ArgumentException("O número de telefone deve ter exatamente 9 dígitos numéricos.");


                _telefone = value;
            }
        }

        public DateTime DataInicio
        {
            get => _dataInicio;
            set
            {
                    _dataInicio = value.Date;

            }
        }
        public DateTime DataFim
        {
            get => _dataFim;
            set
            {
                if (_dataInicio != default(DateTime) && value.Date <= _dataInicio)
                {
                    throw new ArgumentException("A data do fim tem de ser superior a data do inicio da reserva");
                }
                _dataFim = value.Date;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                // Verificar se o e-mail não está vazio e tem o formato correto
                if (string.IsNullOrWhiteSpace(value) || !Funcionalidades.IsEmailValido(value))
                {
                    throw new ArgumentException("O email fornecido não é válido.");
                }
                _email = value;
            }



        }
        public string TipoQuarto
        {
            get => _tipoQuarto;
            set
            {
                // Lista de tipos válidos (pode ser expandida se necessário)
                string[] tiposValidos = { "single", "duplo", "suite", "deluxe" };

                if (string.IsNullOrWhiteSpace(value) || !tiposValidos.Contains(value.Trim().ToLower()))
                {
                    throw new ArgumentException("Tipo de quarto inválido. Os tipos válidos são: Single, Duplo, Suite, Deluxe.");
                }
                _tipoQuarto = value.Trim();
            }
        }
        public int NumeroPessoas
        {
            get => _numeroPessoas;
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("O número de pessoas deve ser entre 1 e 4.");
                }
                _numeroPessoas = value;
            }
        }

        // Construtor
        internal Reserva(int id, string nome, int telefone, string email, DateTime dataInicio, DateTime dataFim, string tipoQuarto, int numeroPessoas)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Email = email;
            TipoQuarto = tipoQuarto; // agora é string
            NumeroPessoas = numeroPessoas;

            string linha = $"{Id};{Nome};{Telefone};{Email};{DataInicio:yyyy-MM-dd};{DataFim:yyyy-MM-dd};{TipoQuarto};{NumeroPessoas}";

            //try
            //{
            //    Funcionalidades.GravarBaseDados("reservas", linha);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao gravar reserva: " + ex.Message);
            //}
        }

        public string linhaBDReservas()
        {
            return $"{Id};{Nome};{Telefone};{Email};{DataInicio:yyyy-MM-dd};{DataFim:yyyy-MM-dd};{TipoQuarto};{NumeroPessoas}";
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
                dias = 1; // Para garantir no mínimo 1 dia

            // Defina os preços para cada tipo de quarto
            decimal precoPorNoite = 0;
            switch (TipoQuarto.ToLower())
            {
               
                case "single":
                    precoPorNoite = 70m;
                    break;
                case "duplo":
                    precoPorNoite = 100m;
                    break;
                case "suite":
                    precoPorNoite = 150m;
                    break;
                case "deluxe":
                    precoPorNoite = 200m;
                    break;
                default:
                    precoPorNoite = 0m; // Ou lance uma exceção se preferir
                    break;
            }

            return dias * precoPorNoite;
        }

  
    }
}

