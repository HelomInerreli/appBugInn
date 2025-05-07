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
    public partial class F_inicial: Form
    {
        public F_inicial()
        {
            InitializeComponent();
        }

        private void lbl_teste_Click(object sender, EventArgs e)
        {

        }

        private void btn_lerFicheiro_Click(object sender, EventArgs e)
        {
            string[] dados = Funcionalidades.LerBaseDados(txt_basedados.Text);
            if (dados.Length > 0)
            {
                string[] linha = dados[1].Split(';'); // Supondo que os dados estejam separados por ponto e vírgula
                string texto = "";
                foreach (var item in dados)
                {
                    texto += item + "\n";
                }
                rtxt_caixa.Text = texto; // Exibir o primeiro dado lido
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado.");
            }

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            bool resultado = Funcionalidades.GravarBaseDados(txt_basedados.Text, txt_addLinha.Text);
            if (resultado)
            {
                MessageBox.Show("Gravação bem-sucedida.");
            }
            else
            {
                MessageBox.Show("Erro ao gravar os dados.");
            }
        }

        private void F_inicial_Load(object sender, EventArgs e)
        {

        } 

        private void btn_logins_Click(object sender, EventArgs e)
        {
            F_login flogin = new F_login();

            flogin.Show();
        }

        private void txt_basedados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_testesHelom_Click(object sender, EventArgs e)
        {
            F_testesHelom fteste = new F_testesHelom();

            fteste.Show();
        }
        private void btn_criarObjeto_Click(object sender, EventArgs e)
        {
            CriarObjeto fcriarObjeto = new CriarObjeto();

            fcriarObjeto.Show();
        }

        private void btn_testeHelom_Click(object sender, EventArgs e)
        {
            F_testesHelom fteste = new F_testesHelom();

            fteste.Show();
        }
        private void btn_reservasInicial_Click(object sender, EventArgs e)
        {
            F_reserva f_Reserva = new F_reserva();
            f_Reserva.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Enter(object sender, EventArgs e)
        {
            materialTextBox21.Text = "";
            lbl_teste.Visible = true;



        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            dtp_data.Value = dtp_data.Value.AddDays(-1);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            dtp_data.Value = dtp_data.Value.AddDays(1);
        }

        private void sw_load_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_teste.Value == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    pb_teste.Value = pb_teste.Value + 4;
                    System.Threading.Thread.Sleep(100);

                }
                
            }
        }
    }
}
