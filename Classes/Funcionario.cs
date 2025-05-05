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
        public bool Gravar()
        {
            string linha = $"{Id};{Nome};{Telefone};{TipoFuncionario}";
            return Funcionalidades.GravarBaseDados("funcionarios", linha);
        }

        public bool GravarLogin(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                password = "atec123";
            }
            string linha = $"{Id};{Nome};{password}";
            return Funcionalidades.GravarBaseDados("logins", linha);
        }
    }
}
