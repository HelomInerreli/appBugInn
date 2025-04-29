using System;
using System.Collections.Generic;
using System.IO;

namespace appBugInn
{
    internal static class Funcionalidades
    {
        public static string[] LerBaseDados(string baseDados) // Método permanece estático
        {
            List<string> dados = new List<string>(); // Usar uma lista para armazenar todas as linhas
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", baseDados + ".txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);

            if (!File.Exists(caminhoAbsoluto))
            {
                throw new Exception("Arquivo de dados não encontrado.");
            }
            else
            {
                string[] linhas = File.ReadAllLines(caminhoAbsoluto);
                foreach (string linha in linhas)
                {
                    dados.Add(linha); // Adicionar cada linha à lista
                }
            }

            return dados.ToArray(); // Converter a lista para um array e retornar
        }
    }
}
