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

                // Ler todos os funcionários, ignorando a primeira linha (cabeçalho)
                string[] funcionarios = Funcionalidades.LerBaseDados("funcionarios").Where(l => !string.IsNullOrWhiteSpace(l)).Skip(1).ToArray();

                // Verificar se já existe um funcionário com o mesmo nome e telefone
                foreach (string linha in funcionarios)
                {
                    string[] partes = linha.Split(';');
                    string nomeExistente = partes[1];
                    string telefoneExistente = partes[2];

                    if (nomeExistente.Equals(nome, StringComparison.OrdinalIgnoreCase) && telefoneExistente.Equals(telefone))
                    {
                        MessageBox.Show("Já existe um funcionário com esse nome e telefone.");
                        return;
                    }
                }

                // Obter o novo ID
                int novoId = 1;
                foreach (string linha in funcionarios)
                {
                    string[] partes = linha.Split(';');
                    if (int.TryParse(partes[0], out int idAtual) && idAtual >= novoId)
                        novoId = idAtual + 1;
                }

                string novaLinha = $"{novoId};{nome};{telefone};{tipoFuncionario}";

                if (Funcionalidades.GravarBaseDados("funcionarios", novaLinha))
                {
                    MessageBox.Show("Funcionário criado com sucesso!");
                    this.Close();
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
    }
}
