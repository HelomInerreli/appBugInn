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
        Hotel hFuncionarios = new Hotel();
        
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

                // Se um funcionário está selecionado, MODIFICAR
                if (cb_Funcionarios.SelectedIndex >= 0)
                {
                    // Encontrar a linha do funcionário pelo nome
                    string[] funcionarios = Funcionalidades.LerBaseDados("funcionarios");
                    int linhaFuncionario = Array.FindIndex(funcionarios, l => l.Split(';')[1] == cb_Funcionarios.SelectedItem.ToString());

                    if (linhaFuncionario > 0) // >0 para ignorar o cabeçalho
                    {
                        string[] partes = funcionarios[linhaFuncionario].Split(';');
                        string id = partes[0];

                        // Monta a nova linha do funcionário
                        string novaLinhaFuncionario = $"{id};{nome};{telefone};{tipoFuncionario}";

                        // Edita o registro do funcionário
                        Funcionalidades.EditarRegisto("funcionarios", linhaFuncionario, novaLinhaFuncionario);

                        // Edita o registro do login
                        string[] logins = Funcionalidades.LerBaseDados("logins");
                        int linhaLogin = Array.FindIndex(logins, l => l.Split(';')[0] == id);
                        if (linhaLogin > 0)
                        {
                            string novaLinhaLogin = $"{id};{nome};{password}";
                            Funcionalidades.EditarRegisto("logins", linhaLogin, novaLinhaLogin);
                        }

                        MessageBox.Show("Funcionário modificado com sucesso!");
                        this.Close();
                        return;
                    }
                }
                else // Se não, CRIAR novo
                {
                    // Ler funcionários existentes (sem pular cabeçalho)
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
            hFuncionarios.preencherFuncionarios();

            cb_Funcionarios.Items.Clear();
            foreach (var func in hFuncionarios.funcionarios)
            {
                cb_Funcionarios.Items.Add(func.Nome);
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeSelecionado = cb_Funcionarios.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nomeSelecionado))
                return;

            // Busca o funcionário na lista
            var funcionario = hFuncionarios.funcionarios
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

                // Lê todos os funcionários
                string[] funcionarios = Funcionalidades.LerBaseDados("funcionarios")
                    .Where(l => !string.IsNullOrWhiteSpace(l)).Skip(1).ToArray();

                // Pega o nome selecionado
                string nomeSelecionado = cb_Funcionarios.SelectedItem.ToString();

                // Procura o funcionário pelo nome
                string linhaFuncionario = funcionarios.FirstOrDefault(l => l.Split(';')[1] == nomeSelecionado);

                if (linhaFuncionario != null)
                {
                    string[] partes = linhaFuncionario.Split(';');
                    if (partes.Length >= 4)
                    {
                        txt_nome.Text = partes[1];
                        txt_telefone.Text = partes[2];
                        chb_gestor.Checked = partes[3] == "True" || partes[3] == "1";

                        // Agora busca a password no logins.txt usando o ID
                        string idFuncionario = partes[0];
                        string[] logins = Funcionalidades.LerBaseDados("logins")
                            .Where(l => !string.IsNullOrWhiteSpace(l)).Skip(1).ToArray();

                        string linhaLogin = logins.FirstOrDefault(l => l.Split(';')[0] == idFuncionario);
                        if (linhaLogin != null)
                        {
                            string[] partesLogin = linhaLogin.Split(';');
                            if (partesLogin.Length >= 2)
                                txt_password.Text = partesLogin[2];
                            else
                                txt_password.Text = "";
                        }
                        else
                        {
                            txt_password.Text = "";
                        }
                    }
                }
            }
            else
            {
                btn_criar.Text = "Criar";
                txt_nome.Text = "";
                txt_telefone.Text = "";
                txt_password.Text = "";
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
                    string nomeSelecionado = cb_Funcionarios.SelectedItem.ToString();

                    // Remove da lista em memória
                    var funcionarioRemover = hFuncionarios.funcionarios
                        .FirstOrDefault(f => f.Nome.Equals(nomeSelecionado, StringComparison.OrdinalIgnoreCase));
                    if (funcionarioRemover != null)
                    {
                        hFuncionarios.funcionarios.Remove(funcionarioRemover);

                        // Remove do TXT sobrescrevendo o arquivo com a lista atualizada
                        SalvarFuncionariosNoTxt();

                        // Remove login correspondente do TXT
                        string caminhoLogins = "basedados/logins.txt";
                        var linhasLogins = System.IO.File.ReadAllLines(caminhoLogins).ToList();
                        // Supondo que o ID é a primeira coluna
                        linhasLogins = linhasLogins.Where(l => !l.StartsWith(funcionarioRemover.Id + ";")).ToList();
                        System.IO.File.WriteAllLines(caminhoLogins, linhasLogins, Encoding.UTF8);

                        MessageBox.Show("Funcionário excluído com sucesso!");
                        this.Close();
                    }
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Atualiza a lista antes de salvar, se necessário
            // hFuncionarios.preencherFuncionarios(); // Descomente se quiser garantir atualização

            // Salva todos os funcionários da lista no TXT
            SalvarFuncionariosNoTxt();
        }

        private void SalvarFuncionariosNoTxt()
        {
            // Caminho do arquivo
            string caminho = "basedados/funcionarios.txt";

            // Cabeçalho (ajuste conforme seu arquivo)
            string cabecalho = "Id;Nome;Telefone;TipoFuncionario";

            var linhas = new List<string> { cabecalho };
            foreach (var func in hFuncionarios.funcionarios)
            {
                linhas.Add(func.linhaBDFuncionarios());
            }

            System.IO.File.WriteAllLines(caminho, linhas, Encoding.UTF8);
        }

               
    }
}
