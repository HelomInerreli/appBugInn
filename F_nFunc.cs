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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void chb_gestor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
