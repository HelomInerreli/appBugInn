using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Hotel
    {
        public List<Funcionario> funcionarios = new List<Funcionario>();

        public void preencherFuncionarios() {
            List<object> func = Funcionalidades.CriarObjetosDoTexto("funcionarios", "Funcionario");
            foreach (var item in func)
            {
                if (item is Funcionario funcionario)
                {
                    funcionarios.Add(funcionario);
                }

            }
        }

        public void gravarFuncionario()
        {
            string linha = "";
            foreach (var item in funcionarios)
            {
                linha += item.linhaBDFuncionarios() + "\n";
            }
            Funcionalidades.GravarBaseDados("funcionarios", linha);
        }
    }

}
