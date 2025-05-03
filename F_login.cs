using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBugInn
{
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*'; // Começa com senha oculta
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = txt_nome.Text.Trim();
            string password = txt_password.Text;

            string caminhoArquivo = Path.Combine(Application.StartupPath, "BaseDados", "logins.txt");

            if (File.Exists(caminhoArquivo))
            {
                bool loginValido = false;
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                foreach (string linha in linhas.Skip(1)) // Pula o cabeçalho
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3)
                    {
                        string nome = partes[1];
                        string senha = partes[2];

                        if (username == nome && password == senha)
                        {
                            loginValido = true;
                            break;
                        }
                    }
                }

                if (loginValido)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    F_Principal form = new F_Principal();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            else
            {
                MessageBox.Show($"Arquivo de usuários não encontrado em: {caminhoArquivo}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e esconder a senha
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0'; // Mostra a senha
            }
            else
            {
                txt_password.PasswordChar = '*'; // Oculta a senha
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }
    }
}
