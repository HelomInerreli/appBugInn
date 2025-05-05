using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal static class Hotel
    {
        public static List<Suite> listarQuartos = new List<Suite>();



        public static List<Suite> CarregarTodosQuartosDoArquivo(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                throw new FileNotFoundException($"O arquivo {caminhoArquivo} não foi encontrado.");

            var quartos = new List<Suite>();
            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas.Skip(1)) // Ignora o cabeçalho
            {
                var dados = linha.Split(';');
                if (dados.Length == 3)
                {
                    int numQuarto = int.Parse(dados[0]);
                    int andar = int.Parse(dados[1]);
                    bool livre = dados[2].Trim().Equals("disponivel", StringComparison.OrdinalIgnoreCase);

                    var suite = new Suite(numQuarto, andar) { Livre = livre };
                    quartos.Add(suite);
                }
            }

            return quartos;
        }
    }
}
