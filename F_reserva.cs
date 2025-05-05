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
    public partial class F_reserva : Form
    {
        public F_reserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registarReserva_Click(object sender, EventArgs e)
        {
            string nome = txt_nomeReserva.Text;
            string telefone = txt_telefoneReserva.Text;
            string email = txt_emailreserva.Text;
            string dataInicio = txt_dataInicioReserva.ToString();
            string dataFim = txt_dataFimReserva.ToString();
            string tipoQuarto = txt_tipoQuartoReserva.Text;

            string linha = $"{nome};{telefone};{email};{dataInicio};{dataFim};{tipoQuarto}";

            // Define o caminho do arquivo
            string caminho = @"reservas.txt";

            try
            {
                // grava no ficheiro automaticamente
                Funcionalidades.GravarBaseDados("reservas", linha);
            }
            catch (Exception ex)
            {
                // mostra o erro
                Console.WriteLine("Erro ao gravar reserva: " + ex.Message);

            }

            MessageBox.Show("Reserva salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
