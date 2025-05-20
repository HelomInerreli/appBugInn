using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBugInn
{
    public partial class F_nFunc : MaterialForm
    {
        Hotel hotelFunc = new Hotel();

        public F_nFunc()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            //lbl_nome.Visible = true;
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

        private void txt_nome_leave(object sender, EventArgs e)
        {
            if (!Funcionalidades.ValidarLetras(txt_nome.Text))
            {
                MessageBox.Show("O nome apenas deve contar letras e nao pode estar vazio");
                txt_nome.Text = string.Empty;
                txt_nome.Focus();
                return;

            }
        }

        private void txt_telefone_leave(object sender, EventArgs e)
        {
            if(!Funcionalidades.ValidarNumeros(txt_telefone.Text))
            {
                MessageBox.Show("O telefone apenas deve contar números e não pode estar vazio");
                txt_telefone.Text = string.Empty;
                txt_telefone.Focus();
                return;
            }
        }

        private void txt_password_leave(object sender, EventArgs e)
        {
            string texto = string.IsNullOrWhiteSpace(txt_password.Text) ? "atec123" : txt_password.Text;

            // Verifica: mínimo 5 caracteres e sem espaços
            bool tamanhoValido = texto.Length >= 5 && !texto.Contains(' ');

            // Separa as letras e os números da string
            string apenasLetras = new string(texto.Where(char.IsLetter).ToArray());
            string apenasNumeros = new string(texto.Where(char.IsDigit).ToArray());

            // Usa suas funções para validar as partes
            bool contemLetras = !string.IsNullOrEmpty(apenasLetras) && Funcionalidades.ValidarLetras(apenasLetras);
            bool contemNumeros = !string.IsNullOrEmpty(apenasNumeros) && Funcionalidades.ValidarNumeros(apenasNumeros);

            if (!(tamanhoValido && contemLetras && contemNumeros))
            {
                MessageBox.Show("A senha deve ter no mínimo 5 caracteres, conter letras e números, e não conter espaços.");
                txt_password.Clear(); // limpa a caixa após erro
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            //bl_password.Visible = true;
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            txt_telefone.Text = "";
            //lbl_telefone.Visible = true;
        }

        // Adicione este código ao evento F_nFunc_Load
        private void F_nFunc_Load(object sender, EventArgs e)
        {
            
            hotelFunc.CarregarFuncionarios(); // Adiciona os funcionários existentes à lista
            AtualizarComboBox(); // Atualiza o ComboBox com os funcionários existentes
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeSelecionado = cb_Funcionarios.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nomeSelecionado))
                return;

            // Busca o funcionário na lista
            var funcionario = hotelFunc.hfuncionarios
                .FirstOrDefault(f => f.Nome.Equals(nomeSelecionado, StringComparison.OrdinalIgnoreCase));

            if (funcionario != null)
            {
                // Exemplo: mostrar os dados nos TextBox
                txt_nome.Text = funcionario.Nome;
                txt_telefone.Text = funcionario.Telefone;
                chb_gestor.Checked = funcionario.TipoFuncionario;
                // Adicione outros campos se necessário
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        private void cb_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
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
        private void AtualizarComboBox()
        {
            cb_Funcionarios.Items.Clear(); // Limpa itens antigos

            foreach (Funcionario func in hotelFunc.hfuncionarios) // Pegando da lista e não do txt
            {
                cb_Funcionarios.Items.Add(func.Nome); // Adiciona os nomes dos funcionários na ComboBox
            }
        }

    }
}
