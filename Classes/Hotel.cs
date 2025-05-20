using appBugInn.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBugInn
{
    internal class Hotel
    {
        public List<Funcionario> hfuncionarios = new List<Funcionario>();
        public List<Reserva> hreservas = new List<Reserva>();
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public List<Reserva> reservas = new List<Reserva>();
        public List<QSingle> qSingles = new List<QSingle>();
        public List<Duplo> qDuplos = new List<Duplo>();
        public List<Suite> qSuites = new List<Suite>();
        public List<Deluxe> qDeluxes = new List<Deluxe>();
        public List<Faturamento> faturamentos = new List<Faturamento>();
        //Teste de commit

        public List<CheckIn> checkIn = new List<CheckIn>();
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
            List<object> qSing = Funcionalidades.CriarObjetosDoTexto("qSingle", "QSingle");
            foreach (var item in qSing)
            {
                if (item is QSingle single)
                {
                    qSingles.Add(single);
                }
            }

            List<object> qDuplo = Funcionalidades.CriarObjetosDoTexto("qDuplos", "Duplo");
            foreach (var item in qDuplo)
            {
                if (item is Duplo duplo)
                {
                    qDuplos.Add(duplo);
                }
            }
            List<object> qSuite = Funcionalidades.CriarObjetosDoTexto("qSuites", "Suite");
            foreach (var item in qSuite)
            {
                if (item is Suite suite)
                {
                    qSuites.Add(suite);
                }
            }
            List<object> qDeluxe = Funcionalidades.CriarObjetosDoTexto("qDeluxes", "Deluxe");
            foreach (var item in qDeluxe)
            {
                if (item is Deluxe deluxe)
                {
                    qDeluxes.Add(deluxe);
                }
            }
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
                linha += item.linhaBD() + "\n";
            }
            Funcionalidades.GravarBaseDados("Single", linha);

            linha = "";
            foreach (var item in qDuplos)
            {
                linha += item.linhaBD() + "\n";
            }
            Funcionalidades.GravarBaseDados("Duplo", linha);

            linha = "";
            foreach (var item in qSuites)
            {
                linha += item.linhaBD() + "\n";
            }
            Funcionalidades.GravarBaseDados("Suite", linha);
            
            linha = "";
            foreach (var item in qDeluxes)
            {
                linha += item.linhaBD() + "\n";
            }
            Funcionalidades.GravarBaseDados("Deluxe", linha);

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
        public List<int> verificaQuartosVaziosDuplo()
        {
            List<int> retorno = new List<int>();
            for (int i = 0; i < qDuplos.Count; i++)
            {
                if (qDuplos[i].Livre == true)
                {
                    retorno.Add(qDuplos[i].NumQuarto);
                }
            }
            return retorno;
        }
        public List<int> verificaQuartosVaziosSuite()
        {
            List<int> retorno = new List<int>();
            for (int i = 0; i < qSuites.Count; i++)
            {
                if (qSuites[i].Livre == true)
                {
                    retorno.Add(qSuites[i].NumQuarto);
                }
            }
            return retorno;
        }
        public List<int> verificaQuartosVaziosDeluxe()
        {
            List<int> retorno = new List<int>();
            for (int i = 0; i < qDeluxes.Count; i++)
            {
                if (qDeluxes[i].Livre == true)
                {
                    retorno.Add(qDeluxes[i].NumQuarto);
                }
            }
            return retorno;
        }


        public Hotel() 
        {
            
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (!hfuncionarios.Any(f => f.Nome == funcionario.Nome))
            {
                hfuncionarios.Add(funcionario);
                //MessageBox.Show($"Funcionário {funcionario.Nome} adicionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"Funcionário {funcionario.Nome} já está na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AdicionarReserva(Reserva reserva)
        {
            if (hreservas == null)
                hreservas = new List<Reserva>();

            if (!hreservas.Any(r => r.Nome == reserva.Nome))
            {
                hreservas.Add(reserva);
            
                MessageBox.Show($"Reserva para {reserva.Nome} adicionada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Reserva para {reserva.Nome} já existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void ExcluirReserva(string nome)
        {
            Reserva reserva = hreservas.FirstOrDefault(r => r.Nome == nome);
            if (reserva != null)
            {
                hreservas.Remove(reserva);
                MessageBox.Show($"Reserva para {nome} removida da lista.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Reserva para {nome} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public void CarregarReservas()
        {
            hreservas.Clear();
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "reservas.txt");
            if (!File.Exists(caminho))
                return;

            var linhas = File.ReadAllLines(caminho);
            for (int i = 1; i < linhas.Length; i++) // Ignora cabeçalho
            {
                var campos = linhas[i].Split(';');
                if (campos.Length < 8) continue;

                if (!int.TryParse(campos[0], out int id)) continue;
                string nome = campos[1];
                if (!int.TryParse(campos[2], out int telefone)) continue;
                string email = campos[3];
                if (!DateTime.TryParse(campos[4], out DateTime dataInicio)) continue;
                if (!DateTime.TryParse(campos[5], out DateTime dataFim)) continue;
                string tipoQuarto = campos[6];
                int numeroPessoas = 1;
                if (!int.TryParse(campos[7], out numeroPessoas)) numeroPessoas = 1;

                // Agora tipoQuarto é string
                var reserva = new Reserva(id, nome, telefone, email, dataInicio, dataFim, tipoQuarto, numeroPessoas);
                hreservas.Add(reserva);
            }
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

        public void AtualizarBaseDadosReservas()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "reservas.txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoAbsoluto, false)) // false para sobrescrever
                {
                    sw.WriteLine("ID;Nome;Telefone;Email;DataInicio;DataFim;TipoQuarto;NumeroPessoas"); // Cabeçalho correto
                    foreach (Reserva reserva in hreservas)
                    {
                        // Só escreve reservas válidas (ignora nulos ou vazios)
                        if (reserva != null)
                            sw.WriteLine(reserva.linhaBDReservas());
                    }
                }
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
        public void AdicionarReservaModificada(string nome, int telefone, string email, DateTime dataInicio, DateTime dataFim, string tipoQuarto, int numeroPessoas)
        {
            int novoId = hreservas.Any() ? hreservas.Max(r => r.Id) + 1 : 1;

            // Agora tipoQuarto é string, não precisa buscar o objeto Quarto
            Reserva novaReserva = new Reserva(novoId, nome, telefone, email, dataInicio, dataFim, tipoQuarto, numeroPessoas);
            hreservas.Add(novaReserva);
            AtualizarBaseDadosReservas(); // Atualiza o .txt
            MessageBox.Show($"Reserva para {nome} adicionada com sucesso");
        }

        public void ModificarReserva(string nomeSelecionado, string novoNome, int novoTelefone, string novoEmail, DateTime novaDataInicio, DateTime novaDataFim, string novoTipoQuarto)
        {
            Reserva reservaExistente = hreservas.FirstOrDefault(r => r.Nome == nomeSelecionado);
            if (reservaExistente != null)
            {
                reservaExistente.Nome = novoNome;
                reservaExistente.Telefone = novoTelefone;
                reservaExistente.Email = novoEmail;
                reservaExistente.DataInicio = novaDataInicio;
                reservaExistente.DataFim = novaDataFim;
                reservaExistente.TipoQuarto = novoTipoQuarto; // Agora é string

                AtualizarBaseDadosReservas(); // Atualiza o .txt
                MessageBox.Show($"Reserva para {nomeSelecionado} modificada com sucesso");
            }
            else
            {
                MessageBox.Show($"Reserva para {nomeSelecionado} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void preencherFaturamento()
        {
            List<object> func = Funcionalidades.CriarObjetosDoTexto("faturamentos", "Faturamento");
            foreach (var item in func)
            {
                if (item is Faturamento faturamento)
                {
                    faturamentos.Add(faturamento);
                }
            }
        }
        //-------------------------CHECKIn--------------------------------------
     
        public void AdicionarCheckIn(string nomeReserva, double subtotal, bool checkOut, DateTime dataInicio, DateTime dataFim, string tipoQuarto, int numQuarto, string hospede1, string hospede2, string hospede3)
        {
            int novoId = checkIn.Any() ? checkIn.Max(c => c.Id) + 1 : 1;
            CheckIn novoCheckIn = new CheckIn(novoId,nomeReserva, subtotal, checkOut, dataInicio, dataFim, tipoQuarto, numQuarto, hospede1, hospede2, hospede3);
             checkIn.Add(novoCheckIn);
            Funcionalidades.GravarBaseDados("checkin", novoCheckIn.linhaCheckIn());
        }

        public void gravarCheckIn()
        {
            //Apagar a base de dados
            string linha = "";
            foreach (var item in checkIn)
            {
                linha += item.linhaCheckIn() + "\n";
            }
            Funcionalidades.GravarBaseDados("checkin", linha);
        }

        public void preencherCheckIn()
        {
            List<object> func = Funcionalidades.CriarObjetosDoTexto("checkin", "CheckIn");
            foreach (var item in func)
            {
                if (item is CheckIn checkin)
                {
                    checkIn.Add(checkin);
                }
            }
        }

        public void gravarFaturamento()
        {
            //apagar base de dados
            string linha = "";
            foreach (var item in faturamentos)
            {
                linha += item.linhaBD() + "\n";
            }
            Funcionalidades.GravarBaseDados("faturamentos", linha);
        }

        public void AtualizarBaseDeDadosCheckIn()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "checkin.txt");
            string caminhoAbsoluto = Path.GetFullPath(caminho);

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoAbsoluto, false)) // `false` para sobrescrever o arquivo
                {
                    sw.WriteLine("id;nomeReserva;subtotal;checkOut;dataCheckIn;dataCheckOut;tipoQuarto;numQuarto;hospede1;hospede2;hospede3\r\n"); // Escreve o cabeçalho novamente

                    foreach (CheckIn func in checkIn)
                    {
                        sw.WriteLine($"{func.Id};{func.NomeReserva};{func.Subtotal};{func.CheckOut};{func.DataInicio:dd/MM/yyyy};{func.DataFim:dd/MM/yyyy};{func.TipoQuarto};{func.NumQuarto};{func.Hospede1};{func.Hospede2};{func.Hospede3}");
                    }

                }

                //MessageBox.Show("Base de dados atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar base de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
