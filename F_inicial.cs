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
                string texto = dados[1];
                //foreach (var item in dados)
                //{
                //    texto += item + "\n";
                //}
                rtxt_caixa.Text = linha[2]; // Exibir o primeiro dado lido
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado.");
            }

        }
    }
}
