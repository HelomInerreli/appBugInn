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
    public partial class F_nFunc : Form
    {
        public F_nFunc()
        {
            InitializeComponent();
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            lbl_nome.Visible = true;
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txt_nome.Text.Trim();
                string telefone = txt_telefone.Text.Trim();
                string password = txt_password.Text.Trim();
                bool tipoFuncionario = chb_gestor.Checked;

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (nome.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("O nome só pode conter letras.");
                    return;
                }

                // Ler funcionários existentes
                string[] funcionarios = Funcionalidades.LerBaseDados("funcionarios")
                    .Where(l => !string.IsNullOrWhiteSpace(l)).Skip(1).ToArray();

                // Verifica duplicados
                foreach (string linha in funcionarios)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length < 3) continue;

                    if (partes[1].Equals(nome, StringComparison.OrdinalIgnoreCase) && partes[2] == telefone)
                    {
                        MessageBox.Show("Já existe um funcionário com esse nome e telefone.");
                        return;
                    }
                }

                // Calcula novo ID
                int novoId = funcionarios.Select(l => int.TryParse(l.Split(';')[0], out int id) ? id : 0).DefaultIfEmpty(0).Max() + 1;

                // Cria e grava funcionário
                Funcionario novoFunc = new Funcionario(novoId, nome, telefone, tipoFuncionario);

                bool funcionarioGravado = novoFunc.Gravar();
                bool loginGravado = novoFunc.GravarLogin(password);

                if (funcionarioGravado && loginGravado)
                {
                    MessageBox.Show("Funcionário e login criados com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao gravar os dados.");
                }
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
            lbl_password.Visible = true;
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            txt_telefone.Text = "";
            lbl_telefone.Visible = true;
        }
    }
}
