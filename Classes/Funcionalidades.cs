using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

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

        public static List<object> CriarObjetosDoTexto(string nomeArquivo, string nomeClasse)
        {
            //Inicializacao da lista de resultados
            var resultado = new List<object>();

            //Ler os dados do arquivo
            string[] linhas;

            try
            {
                linhas = LerBaseDados(nomeArquivo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return resultado;
            }

            //Garante que ha uma linha de cabecalho e um de dados
            if (linhas.Length < 2)
            {
                MessageBox.Show("Arquivo não contém dados suficientes.");
                return resultado;
            }

            //separa o nome das colunas
            var cabecalhos = linhas[0].Split(';');

            //Buscar o tipo da classe dinamicamente
            var tipo = ObterTipoPorNome(nomeClasse);
            if (tipo == null)
            {
                MessageBox.Show($"Classe '{nomeClasse}' não encontrada.");
                return resultado;
            }

            //Obtem o primeiro construtor publico da class
            var construtor = tipo.GetConstructors().FirstOrDefault();

            if (construtor == null)
            {
                MessageBox.Show($"Construtor não encontrado para a classe '{nomeClasse}'.");
                return resultado;
            }

            //Obter os parâmetros do construtor da classe
            var parametros = construtor.GetParameters();

            // Iterar sobre as linhas do arquivo e criar os objetos
            for (int i = 1; i < linhas.Length; i++)
            {
                //serapara os valores e inicializa um array para os argumentos
                var valores = linhas[i].Split(';');
                object[] argumentos = new object[parametros.Length];

                try
                {
                    for (int j = 0; j < parametros.Length; j++)//percorre todos os parametros da classe
                    {
                        string nomeParametro = parametros[j].Name; //obtem o nome do parametro atual

                        // Encontrar o índice da coluna correspondente ao parâmetro
                        int indiceColuna = Array.FindIndex(cabecalhos, h => string.Equals(h, nomeParametro, StringComparison.OrdinalIgnoreCase));//procura o indice da coluna onde tem o mesmo no que o parametro

                        if (indiceColuna == -1)//valida se ela existe
                            throw new Exception($"Coluna '{nomeParametro}' não encontrada.");

                        // Converter o valor da célula para o tipo correto do parâmetro
                        string valorBruto = valores[indiceColuna];//pega no valor da celula
                        object valorConvertido = Convert.ChangeType(valorBruto, parametros[j].ParameterType);//converte o valor da celula para o tipo do construtor
                        argumentos[j] = valorConvertido;//armazena o valor convertido na posicao correta do array
                    }

                    //Criar o objeto a partir do construtor e adicionar à lista de resultados
                    object instancia = construtor.Invoke(argumentos);//instacia o objeto dinamicamento com os argumentos do array
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
        
        public static bool ValidarLetras(string texto)
        {
            // Se estiver vazio ou só com espaços, está ok
            if (string.IsNullOrWhiteSpace(texto))
                return true;

            // Permitir letras e espaços
            return texto.All(c => char.IsLetter(c) || c == ' ');
        }
        
        public static bool ValidarNumeros(string valor)
        {
            // Se estiver vazio ou só com espaços, está ok
            if (string.IsNullOrWhiteSpace(valor))
                return true;

            // Se não estiver vazio, deve conter apenas dígitos
            return valor.All(char.IsDigit);
        }
        
        public static bool IsEmailValido(string email)
        {
            // Se estiver vazio ou só com espaços, está ok
            if (string.IsNullOrWhiteSpace(email))
                return true;
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

