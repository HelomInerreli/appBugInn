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

       public int NumQuarto
        {
            get => _numQuarto;
            set
            {
                if (value < 100)
                {
                    //alguma coisa
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
                    //receber algo}
                }
                _andar = value;
            }
        }

       public float Conta
        {
            get => _conta;
            set
            {
                if (_conta < 0)
                {
                    //algo
                }
                _conta = value;
            }
        }
       public bool Livre 
        { get => _livre;
            set
            {
                if (_livre = false)
                {

                }
                _livre = value;
            }
        }

       public string Status
        {
            get => _status;
            set
            {
                if(_status != value)
                {
                    //
                }
                _status = value;
            }
        }
        //criar lista de produtos para o minibar.


        public Quarto(int numQuarto, int andar) { }

        void alterarStatus() { }

        bool alterarOcupacao(bool opLivre) 
        {
            if (opLivre = true) 
            { 
                return Livre = true; 
            }
            else { return Livre = false; }
        }

        double alterarConta(int dias, int consumiveis) 
        {
            //dias * preco do quarto + consumiveis + reparacoes
            return 0;
        }


        
    }
}
