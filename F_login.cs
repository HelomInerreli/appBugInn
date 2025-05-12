using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class lb_nome : MaterialForm
    {
        public lb_nome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            txt_password.UseSystemPasswordChar = true;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_nome.Text;
            string apenasLetras = new string(texto.Where(c => char.IsLetter(c)).ToArray());

            if (texto != apenasLetras)
            {
                int pos = txt_nome.SelectionStart - 1;
                txt_nome.Text = apenasLetras;
                txt_nome.SelectionStart = Math.Max(pos, 0); // Mantém o cursor na posição correta
            }
        }

        

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_nome_focusLeave(object sender, EventArgs e)
        {
            if (!Funcionalidades.ValidarLetras(txt_nome.Text))
            {
                MessageBox.Show("O nome apenas deve contar letras e nao pode estar vazio");
                txt_nome.Text = string.Empty;
                txt_nome.Focus();
                return;

            }
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_newuser_Click_1(object sender, EventArgs e)
        {
            F_nFunc f_NFunc = new F_nFunc();
            f_NFunc.Show();
        }

        private void bt_login_Click_1(object sender, EventArgs e)
        {
            string username = txt_nome.Text.Trim();
            string password = txt_password.Text;

            try
            {
                string[] linhas = Funcionalidades.LerBaseDados("logins");

                bool loginValido = false;

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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a base de dados: " + ex.Message);
            }
        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e esconder o texto
           
           // txt_password.UseSystemPasswordChar = !txt_password.UseSystemPasswordChar;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {

        }

        private void flButton_ShowPassowrd_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !txt_password.UseSystemPasswordChar;

        }
    }
}
