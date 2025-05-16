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
        Hotel hotelFunc = new Hotel();

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
                string nome = txt_nome.Text.Trim();
                string telefone = txt_telefone.Text.Trim();
                bool tipoFuncionario = chb_gestor.Checked;
                string password = txt_password.Text.Trim();
                string username = txt_username.Text.Trim();

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (cb_Funcionarios.SelectedIndex >= 0) // Modificar funcionário
                {
                    string nomeSelecionado = cb_Funcionarios.SelectedItem.ToString();
                    hotelFunc.ModificarFuncionario(nomeSelecionado, nome, telefone, tipoFuncionario, password, username);
                }
                else // Criar novo funcionário
                {
                    hotelFunc.AdicionarFuncionarioModificado(nome, telefone, tipoFuncionario, password, username);
                }

                AtualizarComboBox(); // Atualiza a interface
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

     
        private void AtualizarComboBox()
        {
            cb_Funcionarios.Items.Clear(); // Limpa itens antigos

            foreach (Funcionario func in hotelFunc.hfuncionarios) // Pegando da lista e não do txt
            {
                cb_Funcionarios.Items.Add(func.Nome); // Adiciona os nomes dos funcionários na ComboBox
            }
        }
        
        private void cb_Funcionarios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_excluir.Visible = cb_Funcionarios.SelectedIndex >= 0;

            if (cb_Funcionarios.SelectedIndex >= 0)
            {
                btn_criar.Text = "Modificar";

                // Obtém o nome selecionado na ComboBox
                string nomeSelecionado = cb_Funcionarios.SelectedItem.ToString();

                // Busca o funcionário na LISTA, em vez do TXT
                Funcionario funcionarioSelecionado = hotelFunc.hfuncionarios.FirstOrDefault(f => f.Nome == nomeSelecionado);

                if (funcionarioSelecionado != null)
                {
                    txt_nome.Text = funcionarioSelecionado.Nome;
                    txt_telefone.Text = funcionarioSelecionado.Telefone;
                    chb_gestor.Checked = funcionarioSelecionado.TipoFuncionario;
                    txt_password.Text = funcionarioSelecionado.Password;
                    txt_username.Text = funcionarioSelecionado.Username;

                }
            }
            else
            {
                btn_criar.Text = "Criar";
                txt_nome.Text = "";
                txt_telefone.Text = "";
                txt_password.Text = "";
                txt_username.Text = "";
                chb_gestor.Checked = false;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (cb_Funcionarios.SelectedIndex >= 0)
            {
                // Confirmação
                if (MessageBox.Show("Tem certeza que deseja excluir este funcionário?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string nomeFuncionario = cb_Funcionarios.SelectedItem.ToString();

                    Funcionario funcionarioParaExcluir = hotelFunc.hfuncionarios.FirstOrDefault(f => f.Nome == nomeFuncionario);
                    if (funcionarioParaExcluir != null)
                    {
                        hotelFunc.hfuncionarios.Remove(funcionarioParaExcluir);
                        MessageBox.Show($"Funcionário {nomeFuncionario} removido da lista.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hotelFunc.AtualizarBaseDeDados(); // Atualiza o arquivo após a remoção
                        AtualizarComboBox(); // Atualiza a ComboBox
                        txt_nome.Text = "";
                        txt_telefone.Text = "";
                        txt_password.Text = "";
                        txt_username.Text = "";
                        chb_gestor.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show($"Funcionário {nomeFuncionario} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
            }
        }


        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
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
                    mtv_dadosReserva.Columns.Add("Nome", 400, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Telefone", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Email", 300, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de inicio", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de fim", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Tipo de quarto", 200, HorizontalAlignment.Left);

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
               
                hotelFunc.CarregarReservas();
               // hotelFunc.AdicionarReservaModificada(nome, telefone, email, dataInicio, dataFim, tipoQuarto);
                AtualizarListViewReservas();
                mtv_dadosReserva.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar reserva: " + ex.Message);
            }
        }
      
        //private void btn_registarReserva_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "BaseDados", "reservas.txt");
        //        int id = 1;

        //        // Verifica se o ficheiro existe e conta as linhas para gerar ID
        //        if (File.Exists(caminho))
        //        {
        //            var linhas = File.ReadAllLines(caminho)
        //                             .Where(l => !string.IsNullOrWhiteSpace(l))
        //                             .ToList();

        //            if (linhas.Count > 0)
        //            {
        //                string ultimaLinha = linhas.Last();
        //                string[] partes = ultimaLinha.Split(';');

        //                if (partes.Length > 0 && int.TryParse(partes[0], out int ultimoId))
        //                {
        //                    id = ultimoId + 1;
        //                }
        //            }
        //        }

        //        string nome = "";
        //        if (Funcionalidades.ValidarLetras(txt_nomeReserva1.Text))
        //        {
        //            nome = txt_nomeReserva1.Text;
        //        }
        //        else
        //        {
        //            MessageBox.Show("O nome apenas deve contar letras");
        //            return;
        //        }

        //        int telefone = int.Parse(txt_telefoneReserva1.Text);
        //        string email = "";
        //        if (Funcionalidades.IsEmailValido(txt_emailReserva1.Text))
        //        {
        //            email = txt_emailReserva1.Text;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Email em formato incorreto");
        //            return;
        //        }

        //        string tipoQuarto = cb_TipoQuarto.SelectedItem.ToString();
        //        if (string.IsNullOrEmpty(tipoQuarto))
        //        {
        //            MessageBox.Show("Por favor, selecione um tipo de quarto.");
        //            return;
        //        }
        //        DateTime dataInicio = dtp_dataInicioReserva.Value.Date;
        //        DateTime dataFim = dtp_dataFimReserva.Value.Date;

        //        if (dataFim < dataInicio)
        //        {
        //            MessageBox.Show("A data de fim não pode ser anterior à data de início.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        string linhaReserva = $"{id};{nome};{telefone};{email};{dataInicio:yyyy-MM-dd};{dataFim:yyyy-MM-dd};{tipoQuarto}";
        //        Funcionalidades.GravarBaseDados("reservas", linhaReserva);
        //        MessageBox.Show("Reserva registada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Atualiza a lista em memória e o ListView
        //        System.Threading.Thread.Sleep(100); // Teste: aguarde 100ms
        //        hotelFunc.CarregarReservas();
        //        MessageBox.Show("Reservas carregadas: " + hotelFunc.hreservas.Count);
        //        AtualizarListViewReservas();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao gravar reserva: " + ex.Message);
        //    }
        //}

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
                        cb_TipoQuarto.Items.Add("Simples");
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
            hotelFunc.CarregarFuncionarios(); // Adiciona os funcionários existentes à lista
            AtualizarComboBox();
        }// Atualiza o ComboBox com os funcionários existentes
        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {
           dtp_dataInicioReserva.MinDate = DateTime.Today;
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                    mtv_dadosReserva.Columns.Add("Nome", 400, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Telefone", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Email", 300, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de inicio", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de fim", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Tipo de quarto", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Número de Pessoas", 120, HorizontalAlignment.Left);

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
            foreach (Reserva reserva in hotelFunc.hreservas)
            {
                ListViewItem item = new ListViewItem(reserva.Id.ToString());
                item.SubItems.Add(reserva.Nome);
                item.SubItems.Add(reserva.Telefone.ToString());
                item.SubItems.Add(reserva.Email);
                item.SubItems.Add(reserva.DataInicio.ToString("yyyy-MM-dd"));
                item.SubItems.Add(reserva.DataFim.ToString("yyyy-MM-dd"));
                item.SubItems.Add(reserva.TipoQuarto != null ? reserva.TipoQuarto.GetType().Name : "");
                item.SubItems.Add(reserva.NumeroPessoas);        

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
                cb_NumeroPessoas.SelectedItem= item.SubItems[7].Text;
            }
        }
    }
}


