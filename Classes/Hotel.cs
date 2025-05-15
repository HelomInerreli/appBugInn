using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBugInn
{
    internal class Hotel
    {
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public List<Reserva> reservas = new List<Reserva>();
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
        
        public void preencherReservas()
        {
            List<object> func = Funcionalidades.CriarObjetosDoTexto("reservas", "Reserva");
            foreach (var item in func)
            {
                if (item is Reserva reserva)
                {
                    reservas.Add(reserva);
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

        public void gravarReserva()
        {
            //apagar base de dados
            string linha = "";
            foreach (var item in reservas)
            {
                linha += item.linhaBDReservas() + "\n";
         
            }
            Funcionalidades.GravarBaseDados("reservas", linha);
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




        public List<Funcionario> hfuncionarios = new List<Funcionario>();

        public Hotel() 
        {
            
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (!hfuncionarios.Any(f => f.Nome == funcionario.Nome))
            {
                hfuncionarios.Add(funcionario);
                MessageBox.Show($"Funcionário {funcionario.Nome} adicionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"Funcionário {funcionario.Nome} já está na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ExcluirFuncionario(string nome)
        {
            Funcionario funcionario = hfuncionarios.FirstOrDefault(f => f.Nome == nome);
            if (funcionario != null)
            {
                hfuncionarios.Remove(funcionario);
                MessageBox.Show($"Funcionário {nome} removido da lista.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Funcionário {nome} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarFuncionarios()
        {
            string[] linhas = Funcionalidades.LerBaseDados("funcionarios"); // Lê os dados do txt

            foreach (string linha in linhas.Skip(1)) // Ignora o cabeçalho
            {
                string[] dados = linha.Split(';'); // Supondo o formato: "ID;Nome;Telefone;Gestor"

                if (dados.Length >= 5) // Verifica se os dados são válidos
                {
                    int id = int.Parse(dados[0]);
                    string nome = dados[1];
                    string telefone = dados[2];
                    bool tipoFuncionario = bool.Parse(dados[3]); // Converte "true" ou "false"
                    string password = dados[4];
                    string username = dados[5];

                    // Criando um objeto Funcionario corretamente
                    Funcionario novoFuncionario = new Funcionario(id, nome, telefone, tipoFuncionario, password, username);

                    // Agora, passamos o objeto para a função AdicionarFuncionario
                    AdicionarFuncionario(novoFuncionario);
                }
            }

           // MessageBox.Show("Funcionários carregados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AtualizarBaseDeDados()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "funcionarios.txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoAbsoluto, false)) // `false` para sobrescrever o arquivo
                {
                    sw.WriteLine("ID;Nome;Telefone;Gestor;Password;Username"); // Escreve o cabeçalho novamente

                    foreach (Funcionario func in hfuncionarios)
                    {
                        sw.WriteLine($"{func.Id};{func.Nome};{func.Telefone};{func.TipoFuncionario};{func.Password};{func.Username}");
                    }
                }

                //MessageBox.Show("Base de dados atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar base de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AdicionarFuncionarioModificado(string nome, string telefone, bool tipoFuncionario, string password, string username)
        {
            int novoId = hfuncionarios.Any() ? hfuncionarios.Max(f => f.Id) + 1 : 1;
            Funcionario novoFuncionario = new Funcionario(novoId, nome, telefone, tipoFuncionario, password, username);

            hfuncionarios.Add(novoFuncionario);
            AtualizarBaseDeDados(); // Atualiza o .txt

            MessageBox.Show($"Funcionário {nome} adicionado com sucesso");
        }
        

        public void ModificarFuncionario(string nomeSelecionado, string novoNome, string novoTelefone, bool novoTipoFuncionario, string novaPassword, string novoUsername)
        {
            Funcionario funcionarioExistente = hfuncionarios.FirstOrDefault(f => f.Nome == nomeSelecionado);

            if (funcionarioExistente != null)
            {
                funcionarioExistente.Nome = novoNome;
                funcionarioExistente.Telefone = novoTelefone;
                funcionarioExistente.TipoFuncionario = novoTipoFuncionario;
                funcionarioExistente.Password = novaPassword;
                funcionarioExistente.Username = novoUsername; // Atualiza o username para o novo nome em minúsculas

                AtualizarBaseDeDados(); // Atualiza o .txt

                MessageBox.Show($"Funcionário {nomeSelecionado} modificado com sucesso");
            }
        }

    }

}
