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
    public partial class F_testesHelom : Form
    {
        public F_testesHelom()
        {
            InitializeComponent();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            int linha = Funcionalidades.LocalizarLinhaRegisto(txt_vBaseDados.Text, int.Parse(txt_colunaProcurar.Text), txt_vProcurar.Text);
            lbl_resultado.Text = linha != -1 ? $"Registo encontrado na linha: {linha}" : "Registo não encontrado.";
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            int linha = Funcionalidades.LocalizarLinhaRegisto(txt_vBaseDados.Text, int.Parse(txt_colunaProcurar.Text), txt_vProcurar.Text);
            bool resultado = Funcionalidades.ExcluirRegisto(txt_vBaseDados.Text, linha);
            if (resultado)
            {
                MessageBox.Show("Registo excluído com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registo.");
            }
        }

        private void txt_colunaProcurar_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
