using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Shapes;

namespace appBugInn.Classes
{
    class Faturamento
    {
        private int _idFaturamento;
        private int _idCheckIn;
        private float _valorTotal;
        private DateTime _dataFaturamento;
        private string _tipoPagamento;
        private float _classificacao;


        public int IdFaturamento
        {
            get => _idFaturamento;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O ID do faturamento não pode ser negativo.");
                }
                _idFaturamento = value;
            }

        }
        public int IdCheckIn
        {
            get => _idCheckIn;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O ID do check-in não pode ser negativo.");
                }
                _idCheckIn = value;
            }
        }
        public float ValorTotal
        {
            get => _valorTotal;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor total não pode ser negativo.");
                }
                _valorTotal = value;
            }
        }
        public DateTime DataFaturamento
        {
            get => _dataFaturamento;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("A data de faturamento não pode ser futura.");
                }
                _dataFaturamento = value;
            }
        }
        public string TipoPagamento
        {
            get => _tipoPagamento;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O tipo de pagamento não pode ser vazio.");
                }
                _tipoPagamento = value;
            }
        }
        public float Classificacao
        {
            get => _classificacao;
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("A classificação deve estar entre 0 e 5.");
                }
                _classificacao = value;
            }
        }
        public int anoFaturamento()
        {
            return _dataFaturamento.Year;
        }
        public int mesFaturamento()
        {
            
            return _dataFaturamento.Month;
            
        }

        public Faturamento(int idFaturamento, int idCheckIn, float valorTotal, DateTime dataFaturamento, string tipoPagamento, float classificacao)
        {
            IdFaturamento = idFaturamento;
            IdCheckIn = idCheckIn;
            ValorTotal = valorTotal;
            DataFaturamento = dataFaturamento;
            TipoPagamento = tipoPagamento;
            Classificacao = classificacao;
        }

        public string linhaBD()
        {
            return $"{IdFaturamento};{IdCheckIn};{ValorTotal};{DataFaturamento};{TipoPagamento};{Classificacao}";
        }
    }
}
