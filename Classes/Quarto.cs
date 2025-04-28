using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Quarto
    {
        private int _numQuarto;
        private int _andar;
        private float _conta;
        private bool _livre;
        private string _status;

        public List<string> ProdutosMinibar { get; set; } = new List<string>(); // Lista de produtos para o minibar

        public virtual double PrecoPorNoite { get; set; }
        public int NumQuarto
        {
            get => _numQuarto;
            set
            {
                if (value < 100)
                {
                    throw new ArgumentException("O número do quarto deve ser maior ou igual a 100.");
                }
                _numQuarto = value;
            }
        }

        public int Andar
        {
            get => _andar;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O andar não pode ser negativo.");
                }
                _andar = value;
            }
        }

        public float Conta
        {
            get => _conta;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A conta não pode ser negativa.");
                }
                _conta = value;
            }
        }

        public bool Livre
        {
            get => _livre;
            set
            {
                _livre = value; // Corrigido: não faz sentido testar aqui, só definir.
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Status não pode ser vazio.");
                }
                _status = value;
            }
        }

        public Quarto(int numQuarto, int andar)
        {
            NumQuarto = numQuarto;
            Andar = andar;
            Livre = true;        // Ao criar, o quarto começa livre
            Status = "Disponível";
            Conta = 0;
        }

        // Método para alterar status manualmente
        public void AlterarStatus(string novoStatus)
        {
            if (!string.IsNullOrEmpty(novoStatus))
            {
                Status = novoStatus;
            }
        }

        // Método para alterar ocupação
        public bool AlterarOcupacao(bool opLivre)
        {
            Livre = opLivre;
            Status = opLivre ? "Disponível" : "Ocupado";
            return Livre;
        }

        // Método para alterar a conta
        public double AlterarConta(int dias, double precoPorNoite, double consumiveis, double reparacoes)
        {
            double total = (dias * precoPorNoite) + consumiveis + reparacoes;
            Conta += (float)total;
            return Conta;
        }
    }
}
