using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn.Classes
{
    internal class CheckIn
    {
        private int _id;
        private string _nomeReserva;
        private double _subtotal;
        private bool _checkOut;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private string _tipoQuarto;
        private int _numQuarto;
        private string _hospede1;
        private string _hospede2;
        private string _hospede3;


        public int Id 
        {
            get => _id;
            set
            {
                if (value > 0)
                    _id = value;
                else
                    throw new ArgumentException("ID deve ser maior que zero.");
            }
        }

        public string NomeReserva 
        { get => _nomeReserva;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new ArgumentException("O nome da reserva não pode estar vazio.");
                _nomeReserva = value;
            }
        }
        public double Subtotal 
        {
            get => _subtotal;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O subtotal não pode ser negativo.");
                _subtotal = value;
            }
        }
        public bool CheckOut 
        {
            get => _checkOut;
            set => _checkOut = value;
        }

        public DateTime DataInicio {
            get => _dataInicio;
            set
            {
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("A data de início deve ser igual ou superior ao dia atual.");
                _dataInicio = value.Date;
            }
        }
        public DateTime DataFim {
            get => _dataFim;
            set
            {
                if (_dataInicio != default(DateTime) && value.Date <= _dataInicio)
                    throw new ArgumentException("A data de fim deve ser superior à data de início.");
                _dataFim = value.Date;
            }
        }
        public string TipoQuarto
        {
            get => _tipoQuarto;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O tipo de quarto não pode estar vazio.");
                _tipoQuarto = value;
            }
        }

        public int NumQuarto {
            get => _numQuarto;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O número do quarto deve ser maior que zero.");
                _numQuarto = value;
            }
        }
        public string Hospede1
        {
            get => _hospede1;
            set
            {
                // Verifica se o nome contém apenas letras e espaços
                // e não está vazio ou nulo
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new ArgumentException("O nome da reserva não pode estar vazio.");
                _hospede1 = value;
            }
        }
        public string Hospede2 {
            get => _hospede2;
            set
            {
                // Verifica se o nome contém apenas letras e espaços
                // e não está vazio ou nulo
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new ArgumentException("O nome da reserva não pode estar vazio.");
                _hospede2 = value;
            }
        }
        public string Hospede3 {
            get => _hospede3;
            set
            {
                // Verifica se o nome contém apenas letras e espaços
                // e não está vazio ou nulo
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new ArgumentException("O nome da reserva não pode estar vazio.");
                _hospede3 = value;
            }
        }

        
        public CheckIn(int id, string nomeReserva, double subtotal, bool checkOut, DateTime dataInicio, DateTime dataFim, string tipoQuarto, int numQuarto, string hospede1, string hospede2, string hospede3)
        {
            Id = id;
            NomeReserva = nomeReserva;
            Subtotal = subtotal;
            CheckOut = checkOut;
            DataInicio = dataInicio;
            DataFim = dataFim;
            TipoQuarto = tipoQuarto;
            NumQuarto = numQuarto;
            Hospede1 = hospede1;
            Hospede2 = hospede2;
            Hospede3 = hospede3;
        }

        public string linhaCheckIn()
        {
            return $"{Id};{NomeReserva};{Subtotal};{CheckOut};{DataInicio:dd/MM/yyyy};{DataFim:dd/MM/yyyy};{TipoQuarto};{NumQuarto};{Hospede1};{Hospede2};{Hospede3}";
        }
    }
}
