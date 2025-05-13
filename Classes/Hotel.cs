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
        List<Single> qSingles = new List<Single>();
        List<Duplo> qDuplos = new List<Duplo>();

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

        public void preencherQuartos()
        {
            List<object> qSing = Funcionalidades.CriarObjetosDoTexto("Single", "Single");
            foreach (var item in qSing)
            {
                if (item is Single single)
                {
                    qSingles.Add(single);
                }
            }

            //List<object> qDuplo = Funcionalidades.CriarObjetosDoTexto("Duplo", "Duplo");
            //foreach (var item in qDuplo)
            //{
            //    if (item is Duplo duplo)
            //    {
            //        qDuplos.Add(duplo);
            //    }
            //}
        }

        public void gravarFuncionario()
        {
            //Apagar a base de dados
            string linha = "";
            foreach (var item in funcionarios)
            {
                linha += item.linhaBDFuncionarios() + "\n";
            }
            Funcionalidades.GravarBaseDados("funcionarios", linha);
        }

        public void gravarQuartos()
        {
            //Apagar a base de dados
            string linha = "";
            foreach (var item in qSingles)
            {
                linha += item.linhaBDSingle() + "\n";
            }
            Funcionalidades.GravarBaseDados("Single", linha);
            ////Apagar a base de dados
            //linha = "";
            //foreach (var item in qDuplos)
            //{
            //    linha += item.linhaBDQuarto() + "\n";
            //}
            //Funcionalidades.GravarBaseDados("Duplo", linha);
        }

        public List<int> verificaQuartosVaziosSingle()
        {
            List<int> retorno = new List<int>();
            for (int i = 0; i < qSingles.Count; i++)
            {
                if (qSingles[i].Livre == true)
                {
                    retorno.Add(qSingles[i].NumQuarto);
                }

            }

            return retorno;
        }




    }

}
