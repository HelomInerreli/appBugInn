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

        public static bool GravarBaseDados(string baseDados, string linha)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", baseDados + ".txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);
            try
            {
                // Verificar se o arquivo está vazio
                if (new FileInfo(caminhoAbsoluto).Length == 0)
                {
                    // Gravar a linha sem adicionar nova linha
                    File.AppendAllText(caminhoAbsoluto, linha);
                }
                else
                {
                    // Adicionar a linha com nova linha
                    File.AppendAllText(caminhoAbsoluto, Environment.NewLine + linha);
                }
                return true; // Retornar verdadeiro se a gravação for bem-sucedida
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar os dados: " + ex.Message);
            }
        }


        public static int LocalizarLinhaRegisto(string baseDados, int coluna, string valor)
        {
            string[] linhas = LerBaseDados(baseDados);
            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Split(';')[coluna].Equals(valor, StringComparison.OrdinalIgnoreCase))
                {
                    return i; // Retornar o índice do registo encontrado
                }
            }
            return -1; // Retornar -1 se o registo não for encontrado
        }

        public static bool ExcluirRegisto(string baseDados, int linha)
        {
            //Ler a base de dados e excluir a linha informada
            string[] linhas = LerBaseDados(baseDados);
            if (linha < 0 || linha >= linhas.Length)
            {
                throw new ArgumentOutOfRangeException("Linha fora do intervalo.");
            }
            List<string> novaLista = new List<string>(linhas);
            novaLista.RemoveAt(linha); // Remover a linha especificada
            LimparBaseDados(baseDados); // Limpar a base de dados
            for (int i = 0; i < novaLista.Count; i++)
            {
                GravarBaseDados(baseDados, novaLista[i]); // Regravar as linhas restantes
            }
            return true; // Retornar verdadeiro se a exclusão for bem-sucedida
        }

        public static bool EditarRegisto(string baseDados, int linha, string novoValor)
        {
            //Ler a base de dados e editar a linha informada
            string[] linhas = LerBaseDados(baseDados);
            if (linha < 0 || linha >= linhas.Length)
            {
                throw new ArgumentOutOfRangeException("Linha fora do intervalo.");
            }
            linhas[linha] = novoValor; // Editar a linha especificada
            LimparBaseDados(baseDados);
            for (int i = 0; i < linhas.Length; i++)
            {
                GravarBaseDados(baseDados, linhas[i]); // Regravar as linhas restantes
            }

            return true; // Retornar verdadeiro se a edição for bem-sucedida
        }

        public static bool LimparBaseDados(string baseDados)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", baseDados + ".txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);

            if (File.Exists(caminhoAbsoluto))
            {
                try
                {
                    File.WriteAllText(caminhoAbsoluto, string.Empty); // Escreve uma string vazia no arquivo
                    return true; // Retorna verdadeiro se a operação for bem-sucedida
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao limpar o conteúdo do arquivo: " + ex.Message);
                }
            }
            else
            {
                throw new FileNotFoundException("Arquivo de dados não encontrado.");
            }
        }

    }
}
