using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Funcionario
    {
        public int Id  { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool TipoFuncionario { get; set; }

        public Funcionario(int id, string nome, string telefone, bool tipoFuncionario)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            TipoFuncionario = tipoFuncionario;
       
        }

        public override string ToString()
        {
            return $"{Id}: {Nome} - {Telefone} - {(TipoFuncionario ? "Gerente" : "Funcionário")}";
        }





    }
}
