using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
                // Adicionar a linha ao final do arquivo
                File.AppendAllText(caminhoAbsoluto, Environment.NewLine + linha);
                return true; // Retornar verdadeiro se a gravação for bem-sucedida
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar os dados: " + ex.Message);
            }
        }

        public static List<object> CriarObjetosDoTexto(string nomeArquivo, string nomeClasse)
        {
            var resultado = new List<object>();

            // Passo 1: Ler os dados do arquivo
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", nomeArquivo + ".txt");

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo não encontrado.");
                return resultado;
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            if (linhas.Length < 2)
            {
                MessageBox.Show("Arquivo não contém dados suficientes.");
                return resultado;
            }

            var cabecalhos = linhas[0].Split(';');

            // Passo 2: Buscar o tipo da classe dinamicamente
            var tipo = ObterTipoPorNome(nomeClasse);
            if (tipo == null)
            {
                MessageBox.Show($"Classe '{nomeClasse}' não encontrada.");
                return resultado;
            }

            // Passo 3: Buscar o construtor da classe
            var construtor = tipo.GetConstructors().FirstOrDefault();
            if (construtor == null)
            {
                MessageBox.Show($"Construtor não encontrado para a classe '{nomeClasse}'.");
                return resultado;
            }

            // Passo 4: Obter os parâmetros do construtor da classe
            var parametros = construtor.GetParameters();

            // Passo 5: Iterar sobre as linhas do arquivo e criar os objetos
            for (int i = 1; i < linhas.Length; i++)
            {
                var valores = linhas[i].Split(';');
                object[] argumentos = new object[parametros.Length];

                try
                {
                    for (int j = 0; j < parametros.Length; j++)
                    {
                        string nomeParametro = parametros[j].Name;

                        // Encontrar o índice da coluna correspondente ao parâmetro
                        int indiceColuna = Array.FindIndex(cabecalhos, h => string.Equals(h, nomeParametro, StringComparison.OrdinalIgnoreCase));

                        if (indiceColuna == -1)
                            throw new Exception($"Coluna '{nomeParametro}' não encontrada.");

                        // Converter o valor da célula para o tipo correto do parâmetro
                        string valorBruto = valores[indiceColuna];
                        object valorConvertido = Convert.ChangeType(valorBruto, parametros[j].ParameterType);
                        argumentos[j] = valorConvertido;
                    }

                    // Criar o objeto a partir do construtor e adicionar à lista de resultados
                    object instancia = construtor.Invoke(argumentos);
                    resultado.Add(instancia);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na linha {i + 1}: {ex.Message}");
                }
            }

            return resultado;
        }

        public static Type ObterTipoPorNome(string nomeClasse)
        {
            // Tenta localizar diretamente
            var tipo = Type.GetType(nomeClasse);
            if (tipo != null)
                return tipo;

            // Tenta localizar pelo nome simples da classe, ignorando o namespace
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    tipo = assembly.GetTypes()
                        .FirstOrDefault(t => string.Equals(t.Name, nomeClasse, StringComparison.OrdinalIgnoreCase));
                    if (tipo != null)
                        return tipo;
                }
                catch
                {
                    // Ignora assemblies que não podem ser lidos
                }
            }

            return null; // Se não encontrar
        }

        public static string ObterDescricaoPrimeiroObjeto(string texto, string nomeClasse)
        {
            var objetos = CriarObjetosDoTexto(texto, nomeClasse);

            if (objetos.Count == 0)
                return "Nenhum objeto instanciado.";

            // Tenta chamar ToString do objeto real
            try
            {
                return objetos[0].ToString();
            }
            catch
            {
                return "Objeto criado, mas não foi possível exibir.";
            }
        }
    }
}
