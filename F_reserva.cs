using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.ComTypes;
namespace appBugInn
{
    public partial class F_reserva : Form
    {
        public F_reserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = @"reservas.txt";
                int id = 1;

                // Verifica se o ficheiro existe e conta as linhas para gerar ID
                if (File.Exists(caminho))
                {
                    // Lê todas as linhas do arquivo
                    var linhas = File.ReadAllLines(caminho);

                    // Se o arquivo não estiver vazio, pega o último ID e incrementa
                    if (linhas.Length > 0)
                    {
                        string ultimaLinha = linhas.Last();
                        string[] partes = ultimaLinha.Split(';');
                        id = int.Parse(partes[0]) + 1; // Incrementa o último ID
                    }
                }

                string nome = "";
                // Captura os dados do formulário
                if (Funcionalidades.ValidarLetras(txt_nomeReserva.Text))
                {
                    nome = txt_nomeReserva.Text;
                }
                else
                {
                    MessageBox.Show("O nome apenas deve contar letras");
                    return;
                }

                int telefone = int.Parse(txt_telefoneReserva.Text);
                string email = "";
                if (Funcionalidades.IsEmailValido(txt_emailreserva.Text))
                {
                    email = txt_emailreserva.Text;
                }
                else
                {
                    MessageBox.Show("Email em formato incorreto");
                    return; // Impede continuar se o email for inválido
                }

                //DateTime dataInicio, dataFim;
                //string dataInicioStr = txt_dataInicioReserva.Text;
                //string dataFimStr = txt_dataFimReserva.Text;

                // Validação e conversão das datas
                //if (Funcionalidades.ValidarDataComFormato(dataInicioStr, "dd/MM/yyyy", out dataInicio))
                //{
                //    // Atribui o valor correto para a data
                //    dataInicio = DateTime.ParseExact(dataInicioStr, "dd/MM/yyyy", null);
                //}
                //else
                //{
                //    MessageBox.Show("Data de início incorreta!");
                //    return; // Impede continuar se a data for inválida
                //}

                //if (Funcionalidades.ValidarDataComFormato(dataFimStr, "dd/MM/yyyy", out dataFim))
                //{
                //    // Atribui o valor correto para a data
                //    dataFim = DateTime.ParseExact(dataFimStr, "dd/MM/yyyy", null);
                //}
                //else
                //{
                //    MessageBox.Show("Data de fim incorreta!");
                //    return; // Impede continuar se a data for inválida
                //}

                //string tipoQuarto = txt_tipoQuartoReserva.Text;

                //if (Funcionalidades.ValidarTipoQuarto(tipoQuarto))
                //{
                //    tipoQuarto = txt_tipoQuartoReserva.Text;
                //}
                //else
                //{
                //    MessageBox.Show("Tipo de quarto não existe");
                //    return; // Impede continuar se o tipo de quarto for inválido
                //}
                // Captura o tipo de quarto selecionado
                string tipoQuarto = cb_TipoQuarto.SelectedItem.ToString();

                // Validação do tipo de quarto
                if (string.IsNullOrEmpty(tipoQuarto))
                {
                    MessageBox.Show("Por favor, selecione um tipo de quarto.");
                    return;
                }


                // Monta a linha com ID e sem hora nas datas
             //   string linha = $"{id};{nome};{telefone};{email};{dataInicio:dd/MM/yyyy};{dataFim:dd/MM/yyyy};{tipoQuarto}";

                // Usa a função para gravar no ficheiro
              //  Funcionalidades.GravarBaseDados("reservas", linha);
                MessageBox.Show($"Reserva salva com sucesso! (ID: {id})", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar reserva: " + ex.Message);
            }
        }

        private void txt_nomeReserva_Leave(object sender, EventArgs e)
        {
            if (!Funcionalidades.ValidarLetras(txt_nomeReserva.Text))
            {
                MessageBox.Show("O nome apenas deve contar letras e nao pode estar vazio");
                txt_nomeReserva.Text = string.Empty;
                txt_nomeReserva.Focus();
                return;

            }
           
        }

        private void txt_tipoQuartoReserva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_telefoneReserva_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_telefoneReserva_Leave(object sender, EventArgs e)
        {
            string texto = txt_telefoneReserva.Text;

            // Verifica se está vazio ou contém caracteres não numéricos
            if (string.IsNullOrWhiteSpace(texto) || !texto.All(char.IsDigit))
            {
                // Opcional: limpar o campo ou exibir mensagem
                MessageBox.Show("O telefone deve conter apenas números e não pode estar vazio.");
                txt_telefoneReserva.Text = string.Empty;
                txt_telefoneReserva.Focus();
                return;
            }
        }

        private void txt_emailreserva_Leave(object sender, EventArgs e)
        {
            if (!Funcionalidades.IsEmailValido(txt_emailreserva.Text))
            {
                MessageBox.Show("Email com formato incorreto");
                txt_emailreserva.Text = string.Empty;
                txt_emailreserva.Focus();
                return;
            }
        }

        //private void txt_dataInicioReserva_Leave(object sender, EventArgs e)
        //{
        //    DateTime dataInicio;
        //    string dataInicioStr = txt_dataInicioReserva.Text;

        //    if (!Funcionalidades.ValidarDataComFormato(dataInicioStr, "dd/MM/yyyy", out dataInicio))
        //    {
        //        MessageBox.Show("Data incorreta");
        //        txt_dataInicioReserva.Text = string.Empty;
        //        txt_dataInicioReserva.Focus();
        //        return;
        //    }
        //}

        //private void txt_dataFimReserva_Leave(object sender, EventArgs e)
        //{
        //    DateTime dataFim;

        //    string dataFimStr = txt_dataFimReserva.Text;
        //    if (!Funcionalidades.ValidarDataComFormato(dataFimStr, "dd/MM/yyyy", out dataFim))
        //    {
        //        MessageBox.Show("Data incorreta");
        //        txt_dataFimReserva.Text = string.Empty;
        //        txt_dataFimReserva.Focus();
        //        return;
        //    }
        //}

        private void txt_tipoQuartoReserva_Leave(object sender, EventArgs e)
        {
            //string tipoQuarto = txt_tipoQuartoReserva.Text;
            //if (!Funcionalidades.ValidarTipoQuarto(tipoQuarto))
            //{
            //    MessageBox.Show("Tipo de quarto nao existe");
            //    txt_tipoQuartoReserva.Text = string.Empty;
            //    txt_tipoQuartoReserva.Focus();
            //    return;
            //}
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

                // Exibe o tipo de quarto selecionado (exemplo simples)
              //  MessageBox.Show("Você escolheu o tipo de quarto: " + tipoQuarto, "Tipo de Quarto Selecionado");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtp_dataFimReserva.MinDate = dtp_dataInicioReserva.Value.AddDays(1);
        }

        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            dtp_dataInicioReserva.Value = dtp_dataInicioReserva.Value.AddDays(1);
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            dtp_dataFimReserva.Value = dtp_dataFimReserva.Value.AddDays(-1);
        }
    }

}
