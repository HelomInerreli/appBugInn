using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
        public static bool ValidarLetras(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.All(char.IsLetter);
        }
        public static bool ValidarNumeros(string valor)
        {
            // Verifica se a string não está vazia e contém apenas dígitos
            return !string.IsNullOrWhiteSpace(valor) && valor.All(char.IsDigit);
        }
        public static bool IsEmailValido(string email)
        {
            //  para validar o formato do e-mail
            var format = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return format.IsMatch(email);
        }
        public static bool ValidarDataComFormato(string dataStr, string formato, out DateTime dataValida)
        {
            dataValida = DateTime.MinValue;

            // Tenta converter a string para DateTime com o formato específico
            bool isValida = DateTime.TryParseExact(dataStr, formato,
                                                   System.Globalization.CultureInfo.InvariantCulture,
                                                   System.Globalization.DateTimeStyles.None,
                                                   out dataValida);

            return isValida;
        }

        public static bool ValidarTipoQuarto(string tipoQuarto)
        {
            // Lista dos tipos válidos de quarto
            var tiposValidos = new List<string> { "Simples", "Duplo", "Deluxe", "Suite" };

            // Verifica se o tipo de quarto fornecido está na lista de tipos válidos (ignora maiúsculas e minúsculas)
            return tiposValidos.Contains(tipoQuarto, StringComparer.OrdinalIgnoreCase);
        }

    }

}

