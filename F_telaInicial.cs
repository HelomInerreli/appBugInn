using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appBugInn
{
    public partial class F_telaInicial : MaterialForm
    {
        Hotel hotel = new Hotel();

        public F_telaInicial()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);


            // No F_telaInicial



            //bar
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2024",
                    Values = new ChartValues<double> { 16, 15, 14, 13, 15, 15, 16, 15, 17, 16, 14, 16 }
}
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2025",
                Values = new ChartValues<double> { 15, 15, 13, 12, 7, 0, 0, 0, 0, 0, 0, 0 }
            });

            //also adding values updates and animates the chart automatically
            //cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Meses",
                Labels = new[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }

            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Faturamento",
                LabelFormatter = value => value.ToString("N")
            });

        }

        private void F_telaInicial_Load(object sender, EventArgs e)
        {
            mtv_dadosFunc.DoubleClick += mtv_dadosFunc_DoubleClick;

        }

        private void sw_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if (sw_darkMode.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CarregarReservasNaLista()
        {
            string caminhoFicheiro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "reservas.txt");

            if (!File.Exists(caminhoFicheiro))
            {
                MessageBox.Show("Ficheiro 'reservas.txt' não encontrado.");
                return;
            }

            var linhas = File.ReadAllLines(caminhoFicheiro);

            if (linhas.Length == 0)
            {
                MessageBox.Show("O ficheiro está vazio.");
                return;
            }

            mtv_dadosReserva.Clear();

            string[] cabecalhos = linhas[0].Split(';');

            foreach (string cabecalho in cabecalhos)
            {
                mtv_dadosReserva.Columns.Add(cabecalho, -2, HorizontalAlignment.Left);
            }

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] campos = linhas[i].Split(';');
                ListViewItem item = new ListViewItem(campos[0]);

                for (int j = 1; j < campos.Length; j++)
                {
                    item.SubItems.Add(campos[j]);
                }

                mtv_dadosReserva.Items.Add(item);
            }

            mtv_dadosReserva.View = View.Details;
            mtv_dadosReserva.FullRowSelect = true
               ;
            if (mtv_dadosReserva.Items.Count == 0)
            {
                MessageBox.Show("Nenhum item foi carregado.");
            }

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txt_nomeFuncionarios.Text.Trim();
                string telefone = txt_telefoneFuncionarios.Text.Trim();
                bool tipoFuncionario = chb_gestorFuncionarios.Checked;
                string password = txt_passwordFuncionarios.Text.Trim();
                string username = txt_usernameFuncionarios.Text.Trim();

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (mtv_dadosFunc.SelectedItems.Count > 0) // Modificar funcionário
                {
                    ListViewItem itemSelecionado = mtv_dadosFunc.SelectedItems[0];

                    // Pega o nome do funcionário na coluna 1 (Nome)
                    string nomeSelecionado = itemSelecionado.SubItems[1].Text;

                    // Chama o método para modificar usando o nome selecionado
                    hotel.ModificarFuncionario(nomeSelecionado, nome, telefone, tipoFuncionario, password, username);
                }
                else // Criar novo funcionário
                {
                    hotel.AdicionarFuncionarioModificado(nome, telefone, tipoFuncionario, password, username);
                }

                AtualizarListView(); // Atualiza a interface

                // Limpa seleção e campos
                mtv_dadosFunc.SelectedItems.Clear();
                LimparCamposFuncionario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void AtualizarListView()
        {
            mtv_dadosFunc.Clear(); // Limpa colunas e itens

            // Adiciona colunas com base no ficheiro
            mtv_dadosFunc.Columns.Add("ID", 60, HorizontalAlignment.Left);
            mtv_dadosFunc.Columns.Add("Nome", 300, HorizontalAlignment.Left);
            mtv_dadosFunc.Columns.Add("Telefone", 200, HorizontalAlignment.Left);
            mtv_dadosFunc.Columns.Add("Tipo de Funcionario", 150, HorizontalAlignment.Left);
            mtv_dadosFunc.Columns.Add("Password", 150, HorizontalAlignment.Left);
            mtv_dadosFunc.Columns.Add("Username", 200, HorizontalAlignment.Left);

            // Adiciona os dados da lista hfuncionarios
            foreach (Funcionario func in hotel.hfuncionarios)
            {
                ListViewItem item = new ListViewItem(func.Id.ToString());
                item.SubItems.Add(func.Nome);
                item.SubItems.Add(func.Telefone);
                item.SubItems.Add(func.TipoFuncionario ? "Gestor" : "Funcionario");
                item.SubItems.Add(func.Password);
                item.SubItems.Add(func.Username);

                mtv_dadosFunc.Items.Add(item);
            }

            mtv_dadosFunc.View = View.Details;
            mtv_dadosFunc.FullRowSelect = true;
        }

        private void LimparCamposFuncionario()
        {
            txt_nomeFuncionarios.Text = "";
            txt_telefoneFuncionarios.Text = "";
            txt_passwordFuncionarios.Text = "";
            txt_usernameFuncionarios.Text = "";
            chb_gestorFuncionarios.Checked = false;
            mtv_dadosFunc.SelectedItems.Clear();
            btn_criarFunciornarios.Text = "Criar";
            btn_excluirFuncionarios.Visible = false;
            btn_limparFuncionarios.Visible = false;
        }

        private void mtv_dadosFunc_DoubleClick(object sender, EventArgs e)
        {
            if (mtv_dadosFunc.SelectedItems.Count > 0)
            {
                btn_limparFuncionarios.Visible = true;
                btn_excluirFuncionarios.Visible = true;
                btn_criarFunciornarios.Text = "Modificar";

                // Pega o item selecionado na ListView
                ListViewItem itemSelecionado = mtv_dadosFunc.SelectedItems[0];

                // Obtém o nome do funcionário (coluna 1)
                string nomeSelecionado = itemSelecionado.SubItems[1].Text;

                // Busca o funcionário na lista
                Funcionario funcionarioSelecionado = hotel.hfuncionarios.FirstOrDefault(f => f.Nome == nomeSelecionado);

                if (funcionarioSelecionado != null)
                {
                    txt_nomeFuncionarios.Text = funcionarioSelecionado.Nome;
                    txt_telefoneFuncionarios.Text = funcionarioSelecionado.Telefone;
                    chb_gestorFuncionarios.Checked = funcionarioSelecionado.TipoFuncionario;
                    txt_passwordFuncionarios.Text = funcionarioSelecionado.Password;
                    txt_usernameFuncionarios.Text = funcionarioSelecionado.Username;
                }
            }
            else
            {
                LimparCamposFuncionario();
            }
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (mtv_dadosReserva.SelectedItems.Count > 0)
            {
                // Confirmação
                if (MessageBox.Show("Tem certeza que deseja excluir esta reserva?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListViewItem itemSelecionado = mtv_dadosReserva.SelectedItems[0];

                    // Considerando que a coluna ID é a primeira (índice 0)
                    int idReserva = int.Parse(itemSelecionado.SubItems[0].Text);

                    Reserva reservaParaExcluir = hotel.hreservas.FirstOrDefault(r => r.Id == idReserva);
                    if (reservaParaExcluir != null)
                    {
                        hotel.hreservas.Remove(reservaParaExcluir);
                        MessageBox.Show($"Reserva para {reservaParaExcluir.Nome} removida da lista.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        hotel.AtualizarBaseDadosReservas(); // Atualiza o arquivo após a remoção
                        AtualizarListViewReservas(); // Atualiza a ListView

                        // Limpa seleção se necessário
                        mtv_dadosReserva.SelectedItems.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Reserva com ID {idReserva} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para excluir.");
            }

        }

        private void materialListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {



        }


        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {

                string[] dados = Funcionalidades.LerBaseDados("funcionarios");

                if (dados.Length > 0)
                {
                    mtv_dadosFunc.Clear(); // Limpar tudo (colunas + itens)

                    string[] colunas = dados[0].Split(';');

                    // Adicionar colunas

                    mtv_dadosFunc.Columns.Add("ID", 60, HorizontalAlignment.Left);
                    mtv_dadosFunc.Columns.Add("Nome", 180, HorizontalAlignment.Left);
                    mtv_dadosFunc.Columns.Add("Telefone", 120, HorizontalAlignment.Left);
                    mtv_dadosFunc.Columns.Add("Tipo Funcionario", 180, HorizontalAlignment.Left);
                    mtv_dadosFunc.Columns.Add("Password", 120, HorizontalAlignment.Left);
                    mtv_dadosFunc.Columns.Add("Username", 140, HorizontalAlignment.Left);

                    // Adicionar linhas
                    for (int i = 1; i < dados.Length; i++)
                    {
                        string[] campos = dados[i].Split(';');
                        ListViewItem item = new ListViewItem(campos[0]);
                        for (int j = 1; j < campos.Length; j++)
                        {
                            // Verifica se é a coluna "Tipo de Funcionario" (índice 3)
                            if (j == 3)
                            {
                                string tipo = campos[j].ToLower() == "true" ? "Gestor" : "Funcionario";
                                item.SubItems.Add(tipo);
                            }
                            else
                            {
                                item.SubItems.Add(campos[j]);
                            }
                        }

                        mtv_dadosFunc.Items.Add(item);
                    }

                    mtv_dadosFunc.View = View.Details;
                    mtv_dadosFunc.FullRowSelect = true;
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Erro: O ficheiro não foi encontrado. Detalhes: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato nos dados. Detalhes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }

        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomeReserva1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_registarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "reservas.txt");
                int id = 1;

                // Verifica se o ficheiro existe e conta as linhas para gerar ID
                if (File.Exists(caminho))
                {
                    var linhas = File.ReadAllLines(caminho)
                                     .Where(l => !string.IsNullOrWhiteSpace(l))
                                     .ToList();

                    if (linhas.Count > 0)
                    {
                        string ultimaLinha = linhas.Last();
                        string[] partes = ultimaLinha.Split(';');

                        if (partes.Length > 0 && int.TryParse(partes[0], out int ultimoId))
                        {
                            id = ultimoId + 1;
                        }
                    }
                }

                string nome = "";
                if (Funcionalidades.ValidarLetras(txt_nomeReserva1.Text))
                {
                    nome = txt_nomeReserva1.Text;
                }
                else
                {
                    MessageBox.Show("O nome apenas deve contar letras");
                    return;
                }

                int telefone = int.Parse(txt_telefoneReserva1.Text);
                string email = "";
                if (Funcionalidades.IsEmailValido(txt_emailReserva1.Text))
                {
                    email = txt_emailReserva1.Text;
                }
                else
                {
                    MessageBox.Show("Email em formato incorreto");
                    return;
                }

                string tipoQuarto = cb_TipoQuarto.SelectedItem.ToString();
                if (string.IsNullOrEmpty(tipoQuarto))
                {
                    MessageBox.Show("Por favor, selecione um tipo de quarto.");
                    return;
                }
                DateTime dataInicio = dtp_dataInicioReserva.Value.Date;
                DateTime dataFim = dtp_dataFimReserva.Value.Date;

                if (dataFim < dataInicio)
                {
                    MessageBox.Show("A data de fim não pode ser anterior à data de início.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Obtenha o número de pessoas do ComboBox
                string numeroPessoas = cb_NumeroPessoas.SelectedItem?.ToString() ?? "";

                string linhaReserva = $"{id};{nome};{telefone};{email};{dataInicio:yyyy-MM-dd};{dataFim:yyyy-MM-dd};{tipoQuarto};{numeroPessoas}";
                // string linhaReserva = $"{id};{nome};{telefone};{email};{dataInicio:yyyy-MM-dd};{dataFim:yyyy-MM-dd};{tipoQuarto}";
                Funcionalidades.GravarBaseDados("reservas", linhaReserva);
                MessageBox.Show("Reserva registada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a lista em memória e o ListView

                //  hotel.AdicionarReservaModificada(nome, telefone, email, dataInicio, dataFim, tipoQuarto, int.Parse(numeroPessoas));
                //  AtualizarListViewReservas();
                mtv_dadosReserva.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar reserva: " + ex.Message);
            }
        }



        private void cb_NumeroPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica se há algo selecionado no comboBox
            if (cb_NumeroPessoas.SelectedItem != null)
            {
                string textoSelecionado = cb_NumeroPessoas.SelectedItem.ToString();
                int numeroPessoas = int.Parse(textoSelecionado.Split(' ')[0]); // Extrai o número de pessoas

                // Limpa o ComboBox de tipo de quarto para adicionar as opções corretas
                cb_TipoQuarto.Items.Clear();

                // Adiciona apenas o quarto válido com base no número de pessoas
                switch (numeroPessoas)
                {
                    case 1:
                        cb_TipoQuarto.Items.Add("Single");
                        cb_TipoQuarto.Items.Add("Duplo");
                        cb_TipoQuarto.Items.Add("Suite");
                        cb_TipoQuarto.Items.Add("Deluxe");
                        break;
                    case 2:
                        cb_TipoQuarto.Items.Add("Duplo");
                        cb_TipoQuarto.Items.Add("Suite");
                        cb_TipoQuarto.Items.Add("Deluxe");
                        break;
                    case 3:
                        cb_TipoQuarto.Items.Add("Suite");
                        cb_TipoQuarto.Items.Add("Deluxe");
                        break;
                    case 4:
                        cb_TipoQuarto.Items.Add("Deluxe");
                        break;
                }
                cb_TipoQuarto.Enabled = true; // Habilita o ComboBox de tipo de quarto

                // Seleciona automaticamente a primeira opção (se houver)
                if (cb_TipoQuarto.Items.Count > 0)
                {
                    cb_TipoQuarto.SelectedIndex = 0;
                }
            }
        }

        private void cb_TipoQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há algo selecionado no comboBox de tipo de quarto
            if (cb_TipoQuarto.SelectedItem != null)
            {
                string tipoQuarto = cb_TipoQuarto.SelectedItem.ToString();
            }
        }


        private void btn_avançaDiaReserva_Click(object sender, EventArgs e)
        {
            dtp_dataInicioReserva.Value = dtp_dataInicioReserva.Value.AddDays(1);
        }

        private void btn_recuaDiaReserva_Click(object sender, EventArgs e)
        {
            dtp_dataFimReserva.Value = dtp_dataFimReserva.Value.AddDays(-1);
        }

        private void btn_avançarDiaFimReserva_Click(object sender, EventArgs e)
        {
            dtp_dataFimReserva.Value = dtp_dataFimReserva.Value.AddDays(1);
        }

        private void btn_recuarDiaInicioReserva_Click(object sender, EventArgs e)
        {
            dtp_dataInicioReserva.Value = dtp_dataInicioReserva.Value.AddDays(-1);
        }

        private void btn_recuarDiaFimReserva_Click(object sender, EventArgs e)
        {
            dtp_dataFimReserva.Value = dtp_dataFimReserva.Value.AddDays(-1);
        }
        private void txt_nomeReserva1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nomeReserva1.Text))
                return; // Não valida se estiver vazio

            if (!Funcionalidades.ValidarLetras(txt_nomeReserva1.Text))
            {
                MessageBox.Show("O nome apenas deve conter letras e espaços, e não pode estar vazio");
                txt_nomeReserva1.Text = string.Empty;
                txt_nomeReserva1.Focus();
                return;
            }
        }

        private void txt_telefoneReserva1_Leave(object sender, EventArgs e)
        {
            if (!Funcionalidades.ValidarNumeros(txt_telefoneReserva1.Text))
            {
                MessageBox.Show("O telefone deve contar apenas numeros e nao pode estar vazio");
                txt_telefoneReserva1.Text = string.Empty;
                txt_telefoneReserva1.Focus();
                return;
            }
        }

        private void txt_emailReserva1_Leave(object sender, EventArgs e)
        {
            if (!Funcionalidades.IsEmailValido(txt_emailReserva1.Text))
            {
                MessageBox.Show("Email com formato incorreto");
                txt_emailReserva1.Text = string.Empty;
                txt_emailReserva1.Focus();
                return;
            }
        }
        private void F_telainicial_Load(object sender, EventArgs e)
        {
            dtp_dataInicioReserva.Value = DateTime.Today;
            dtp_dataInicioReserva.MinDate = DateTime.Today;
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtp_dataInicioReserva_Leave(object sender, EventArgs e)
        {
            dtp_dataFimReserva.MinDate = dtp_dataInicioReserva.Value.AddDays(1);
        }

        private void cb_NumeroPessoas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_funcionarios_Enter(object sender, EventArgs e)
        {
            hotel.CarregarFuncionarios(); // Adiciona os funcionários existentes à lista
            AtualizarListView();
        }// Atualiza o ListeView com os funcionários existentes
        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {
            dtp_dataInicioReserva.MinDate = DateTime.Today;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtv_dadosFunc_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCamposFuncionario();
        }

        private void tb_funcionarios_Leave(object sender, EventArgs e)
        {
            LimparCamposFuncionario();
        }

        private void dtp_dataInicioReserva_ValueChanged_1(object sender, EventArgs e)
        {
            //
        }

        private void dtp_dataFimReserva_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_dataFimReserva_Leave(object sender, EventArgs e)
        {

        }

        private void tb_reservas_Enter(object sender, EventArgs e)
        {
            try
            {

                string[] dados = Funcionalidades.LerBaseDados("reservas");

                if (dados.Length > 0)
                {
                    mtv_dadosReserva.Clear(); // Limpar tudo (colunas + itens)

                    string[] colunas = dados[0].Split(';');

                    // Adicionar colunas

                    mtv_dadosReserva.Columns.Add("ID", 60, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Email", 250, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de inicio", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de fim", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Tipo de quarto", 170, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Número de Pessoas", 180, HorizontalAlignment.Left);

                    // Adicionar linhas
                    for (int i = 1; i < dados.Length; i++)
                    {
                        string[] campos = dados[i].Split(';');
                        ListViewItem item = new ListViewItem(campos[0]);
                        for (int j = 1; j < campos.Length; j++)
                        {
                            item.SubItems.Add(campos[j]);
                        }
                        mtv_dadosReserva.Items.Add(item);
                    }

                    mtv_dadosReserva.View = View.Details;
                    mtv_dadosReserva.FullRowSelect = true;
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Erro: O ficheiro não foi encontrado. Detalhes: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato nos dados. Detalhes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }

        }

        public void AtualizarListViewReservas()
        {

            mtv_dadosReserva.Clear(); // Limpa colunas e itens

            // Adiciona colunas com base no ficheiro
            mtv_dadosReserva.Columns.Add("ID", 60, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Telefone", 120, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Email", 200, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Data de Início", 120, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Data de Fim", 120, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Tipo de Quarto", 120, HorizontalAlignment.Left);
            mtv_dadosReserva.Columns.Add("Número de Pessoas", 120, HorizontalAlignment.Left);

            // Adiciona os dados da lista hreservas
            foreach (Reserva reserva in hotel.hreservas)
            {
                ListViewItem item = new ListViewItem(reserva.Id.ToString());
                item.SubItems.Add(reserva.Nome);
                item.SubItems.Add(reserva.Telefone.ToString());
                item.SubItems.Add(reserva.Email);
                item.SubItems.Add(reserva.DataInicio.ToString("yyyy-MM-dd"));
                item.SubItems.Add(reserva.DataFim.ToString("yyyy-MM-dd"));
                item.SubItems.Add(reserva.TipoQuarto ?? "");
                item.SubItems.Add(reserva.NumeroPessoas.ToString());

                mtv_dadosReserva.Items.Add(item);
            }

            mtv_dadosReserva.View = View.Details;
            mtv_dadosReserva.FullRowSelect = true;


        }

        private void mtv_dadosReserva_Click(object sender, EventArgs e)
        {



        }

        private void mtv_dadosReserva_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mtv_dadosReserva.SelectedItems.Count > 0)
            {
                ListViewItem item = mtv_dadosReserva.SelectedItems[0];

                // Preenche os campos com os valores da linha selecionada
                txt_nomeReserva1.Text = item.SubItems[1].Text;
                txt_telefoneReserva1.Text = item.SubItems[2].Text;
                txt_emailReserva1.Text = item.SubItems[3].Text;

                // Datas
                DateTime dataInicio, dataFim;
                if (DateTime.TryParse(item.SubItems[4].Text, out dataInicio))
                    dtp_dataInicioReserva.Value = dataInicio;
                if (DateTime.TryParse(item.SubItems[5].Text, out dataFim))
                    dtp_dataFimReserva.Value = dataFim;

                // Tipo de quarto
                cb_TipoQuarto.SelectedItem = item.SubItems[6].Text;
                cb_NumeroPessoas.SelectedItem = item.SubItems[7].Text;
            }
        }

        private void btn_excluirReserva_Click(object sender, EventArgs e)
        {

            if (mtv_dadosReserva.SelectedItems.Count > 0)
            {
                hotel.CarregarReservas();
                // Confirmação
                if (MessageBox.Show("Tem certeza que deseja excluir esta reserva?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListViewItem itemSelecionado = mtv_dadosReserva.SelectedItems[0];

                    // Considerando que a coluna Nome é a segunda (índice 1)
                    string nomeReserva = itemSelecionado.SubItems[1].Text;

                    Reserva reservaParaExcluir = hotel.hreservas.FirstOrDefault(r => r.Nome == nomeReserva);
                    if (reservaParaExcluir != null)
                    {
                        hotel.hreservas.Remove(reservaParaExcluir);
                        MessageBox.Show($"Reserva para {nomeReserva} removida da lista.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        hotel.AtualizarBaseDadosReservas(); // Atualiza o arquivo após a remoção
                        AtualizarListViewReservas(); // Atualiza a ListView

                        // Limpa seleção se necessário
                        mtv_dadosReserva.SelectedItems.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Reserva para {nomeReserva} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para excluir.");
            }

        }

        private void materialListView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }


        private void mtv_dadosQuartos_Enter(object sender, EventArgs e)
        {
            try
            {

                //Limpa as colunas
                mtv_dadosQuartos.Clear();

                hotel.preencherQuartos();

                // Adiciona as colunas
                mtv_dadosQuartos.Columns.Add("Nº", 60, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Andar", 100, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Tipo", 100, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Conta", 100, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Livre", 100, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Status", 100, HorizontalAlignment.Left);
                mtv_dadosQuartos.Columns.Add("Observações", 300, HorizontalAlignment.Left);

                // Adiciona os quartos Singles
                foreach (var quarto in hotel.qSingles)
                {
                    ListViewItem item = new ListViewItem(quarto.NumQuarto.ToString());
                    item.SubItems.Add(quarto.Andar.ToString());
                    item.SubItems.Add("Single");
                    item.SubItems.Add(quarto.Conta.ToString());
                    item.SubItems.Add(quarto.Livre.ToString());
                    item.SubItems.Add(quarto.Status);
                    item.SubItems.Add(quarto.Observacoes);
                    mtv_dadosQuartos.Items.Add(item);
                }

                // Adiciona os quartos Duplos
                foreach (var quarto in hotel.qDuplos)
                {
                    ListViewItem item = new ListViewItem(quarto.NumQuarto.ToString());
                    item.SubItems.Add(quarto.Andar.ToString());
                    item.SubItems.Add("Duplo");
                    item.SubItems.Add(quarto.Conta.ToString());
                    item.SubItems.Add(quarto.Livre.ToString());
                    item.SubItems.Add(quarto.Status);
                    item.SubItems.Add(quarto.Observacoes);
                    mtv_dadosQuartos.Items.Add(item);
                }

                // Adiciona os quartos Suite
                foreach (var quarto in hotel.qSuites)
                {
                    ListViewItem item = new ListViewItem(quarto.NumQuarto.ToString());
                    item.SubItems.Add(quarto.Andar.ToString());
                    item.SubItems.Add("Suite");
                    item.SubItems.Add(quarto.Conta.ToString());
                    item.SubItems.Add(quarto.Livre.ToString());
                    item.SubItems.Add(quarto.Status);
                    item.SubItems.Add(quarto.Observacoes);
                    mtv_dadosQuartos.Items.Add(item);
                }

                // Adiciona os quartos Deluxe
                foreach (var quarto in hotel.qDeluxes)
                {
                    ListViewItem item = new ListViewItem(quarto.NumQuarto.ToString());
                    item.SubItems.Add(quarto.Andar.ToString());
                    item.SubItems.Add("Deluxe");
                    item.SubItems.Add(quarto.Conta.ToString());
                    item.SubItems.Add(quarto.Livre.ToString());
                    item.SubItems.Add(quarto.Status);
                    item.SubItems.Add(quarto.Observacoes);
                    mtv_dadosQuartos.Items.Add(item);
                }


                mtv_dadosQuartos.View = View.Details;
                mtv_dadosQuartos.FullRowSelect = true;

                if (mtv_dadosQuartos.Items.Count == 0)
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Erro: O ficheiro não foi encontrado. Detalhes: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato nos dados. Detalhes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }

        private void tb_gerirQuartos_Leave(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tb_gerirQuartos)
            {
                LimparCampos();
            }
        }
        public void LimparCampos()
        {
            txt_nQuarto.Text = "";
            txt_tQuarto.Text = "";
            txt_Conta.Text = "";
            txt_Andar.Text = "";
            txt_Status.Text = "";
            txt_Vista.Text = "";

            sw_banheira.Checked = false;
            sw_camaCasal.Checked = false;
            sw_miniBar.Checked = false;

        }

        private void ModificarQuartoSingle(int numQuarto, bool livre)
        {
            // Encontra o quarto Single
            var quarto = hotel.qSingles.FirstOrDefault(q => q.NumQuarto == numQuarto);
            if (quarto != null)
            {
                // Atualiza o status
                quarto.AlterarOcupacao(livre);
                quarto.Status = txt_Status.Text;
                // Atualiza a base de dados
                hotel.AtualizarBaseDadosQuartos("single");
            }
        }

        private void ModificarQuartoDuplo(int numQuarto, bool livre)
        {
            // Encontra o quarto Duplo
            var quarto = hotel.qDuplos.FirstOrDefault(q => q.NumQuarto == numQuarto);
            if (quarto != null)
            {
                // Atualiza o status
                quarto.AlterarOcupacao(livre);
                quarto.Status = txt_Status.Text;
                // Atualiza o tipo de cama
                quarto.TipoCama = sw_camaCasal.Checked ? "Casal" : "Solteiro";
                // Atualiza a base de dados
                hotel.AtualizarBaseDadosQuartos("duplo");
            }
        }

        private void ModificarQuartoSuite(int numQuarto, bool livre)
        {
            // Encontra o quarto Suite
            var quarto = hotel.qSuites.FirstOrDefault(q => q.NumQuarto == numQuarto);
            if (quarto != null)
            {
                // Atualiza o status
                quarto.AlterarOcupacao(livre);
                quarto.Status = txt_Status.Text;
                // Atualiza a vista
                quarto.TipoVista = txt_Vista.Text;
                // Atualiza a base de dados
                hotel.AtualizarBaseDadosQuartos("suite");
            }
        }

        private void ModificarQuartoDeluxe(int numQuarto, bool livre)
        {
            // Encontra o quarto Deluxe
            var quarto = hotel.qDeluxes.FirstOrDefault(q => q.NumQuarto == numQuarto);
            if (quarto != null)
            {
                // Atualiza o status
                quarto.AlterarOcupacao(livre);
                quarto.Status = txt_Status.Text;
                // Atualiza a vista
                quarto.TipoVista = txt_Vista.Text;
                // Atualiza a banheira
                quarto.Banheira = sw_banheira.Checked;
                // Atualiza a base de dados
                hotel.AtualizarBaseDadosQuartos("deluxe");
            }
        }

        private void mtv_dadosQuartos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Verifica se existe pelo menos um item selecionado na ListView
            if (mtv_dadosQuartos.SelectedItems.Count > 0)
            {
                // Obtém o primeiro item selecionado (assume que só há um selecionado)
                ListViewItem selectedItem = mtv_dadosQuartos.SelectedItems[0];

                // Preenche a TextBox do número do quarto com o valor da primeira coluna
                if (txt_nQuarto != null)
                    txt_nQuarto.Text = selectedItem.SubItems[0].Text;

                if (txt_Andar != null)
                    txt_Andar.Text = selectedItem.SubItems[1].Text;

                if (txt_tQuarto != null)
                    txt_tQuarto.Text = selectedItem.SubItems[2].Text;

                if (txt_Conta != null)
                    txt_Conta.Text = selectedItem.SubItems[3].Text;

                if (txt_Status != null)
                {
                    string livreValue = selectedItem.SubItems[4].Text;
                    txt_Status.Text = (livreValue == "True" || livreValue == "true") ? "Livre" : "Ocupado";
                }


                // Desativa switches por padrão
                if (sw_banheira != null)
                    sw_banheira.Checked = false;
                if (sw_camaCasal != null)
                    sw_camaCasal.Checked = false;
                if (sw_miniBar != null)
                    sw_miniBar.Checked = false;


                // Identifica o tipo de quarto
                string tipoQuarto = selectedItem.SubItems[2].Text.Trim();

                // Só mostra a vista para Suite e Deluxe
                if (txt_Vista != null)
                {
                    if (tipoQuarto.Equals("Suite", StringComparison.OrdinalIgnoreCase))
                    {
                        // Busca o número do quarto selecionado
                        if (int.TryParse(selectedItem.SubItems[0].Text, out int numQuarto))
                        {
                            var suite = hotel.qSuites.FirstOrDefault(q => q.NumQuarto == numQuarto);
                            txt_Vista.Text = suite != null ? suite.TipoVista : string.Empty;
                        }
                        else
                        {
                            txt_Vista.Text = string.Empty;
                        }
                    }
                    else if (tipoQuarto.Equals("Deluxe", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(selectedItem.SubItems[0].Text, out int numQuarto))
                        {
                            var deluxe = hotel.qDeluxes.FirstOrDefault(q => q.NumQuarto == numQuarto);
                            txt_Vista.Text = deluxe != null ? deluxe.TipoVista : string.Empty;
                        }
                        else
                        {
                            txt_Vista.Text = string.Empty;
                        }
                    }
                    else
                    {
                        txt_Vista.Text = string.Empty;
                    }
                }

                // Desativa switches por padrão
                if (sw_banheira != null)
                    sw_banheira.Checked = false;
                if (sw_camaCasal != null)
                    sw_camaCasal.Checked = false;
                if (sw_miniBar != null)
                    sw_miniBar.Checked = false;

                // Identifica o tipo de quarto
                string quarto = selectedItem.SubItems[2].Text.Trim();
                string numeroQuarto = selectedItem.SubItems[0].Text.Trim();

                // Ativa o switch de banheira se o número do quarto terminar em 4 (Deluxe)
                if (sw_banheira != null)
                    sw_banheira.Checked = numeroQuarto.EndsWith("4");

                // Só ativa o switch de cama de casal se o tipo de cama for "Casal"
                if (sw_camaCasal != null && selectedItem.SubItems.Count > 5)
                {
                    string tipoCama = selectedItem.SubItems[5].Text.Trim();
                    sw_camaCasal.Checked = tipoCama.Equals("Casal", StringComparison.OrdinalIgnoreCase);
                }

                // Ativa o switch de cama de casal apenas para Duplo com cama de casal
                if (tipoQuarto.Equals("Duplo", StringComparison.OrdinalIgnoreCase))
                {
                    if (int.TryParse(numeroQuarto, out int numQuarto))
                    {
                        var duplo = hotel.qDuplos.FirstOrDefault(q => q.NumQuarto == numQuarto);
                        if (duplo != null && duplo.TipoCama != null)
                        {
                            sw_camaCasal.Checked = duplo.TipoCama.Equals("Casal", StringComparison.OrdinalIgnoreCase);
                        }
                        else
                        {
                            sw_camaCasal.Checked = false;
                        }
                    }
                    else
                    {
                        sw_camaCasal.Checked = false;
                    }
                }
                else
                {
                    sw_camaCasal.Checked = false;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se um quarto está selecionado
                if (string.IsNullOrEmpty(txt_nQuarto.Text))
                {
                    MessageBox.Show("Selecione um quarto para modificar.");
                    return;
                }

                // Obtém o número do quarto
                if (!int.TryParse(txt_nQuarto.Text, out int numQuarto))
                {
                    MessageBox.Show("Número de quarto inválido.");
                    return;
                }

                // Obtém o tipo de quarto
                string tipoQuarto = txt_tQuarto.Text.Trim().ToLower();

                // Obtém o status (verifica se está marcado como "Livre")
                bool livre = txt_Status.Text.Equals("Livre", StringComparison.OrdinalIgnoreCase);

                // Modifica o quarto conforme seu tipo
                switch (tipoQuarto)
                {
                    case "single":
                        ModificarQuartoSingle(numQuarto, livre);
                        break;

                    case "duplo":
                        ModificarQuartoDuplo(numQuarto, livre);
                        break;

                    case "suite":
                        ModificarQuartoSuite(numQuarto, livre);
                        break;

                    case "deluxe":
                        ModificarQuartoDeluxe(numQuarto, livre);
                        break;

                    default:
                        MessageBox.Show("Tipo de quarto não reconhecido.");
                        return;
                }

                // Atualiza a lista visual de quartos
                mtv_dadosQuartos_Enter(null, null);

                // Limpa os campos após a modificação
                LimparCampos();

                // Feedback ao usuário
                MessageBox.Show("Quarto modificado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao modificar quarto: {ex.Message}");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
    
