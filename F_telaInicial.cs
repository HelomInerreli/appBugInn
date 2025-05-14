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
        }

       

        private void tab_Funcionarios(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tb_funcionarios_Enter(object sender, EventArgs e)
        {
            hotelFunc.CarregarFuncionarios(); // Adiciona os funcionários existentes à lista
            AtualizarComboBox(); // Atualiza o ComboBox com os funcionários existentes
        }
    }
}
