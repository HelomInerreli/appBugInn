using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class F_dadosReserva : MaterialForm
    {
        private F_telaInicial telaInicial;

        public F_dadosReserva(F_telaInicial telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }


        private void CarregarDadosReserva()
        {
            try
            {
                string[] dados = Funcionalidades.LerBaseDados("reservas");

                if (dados.Length > 0)
                {
                    mtv_dadosReserva.Clear();

                    mtv_dadosReserva.Columns.Add("ID", 60, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Email", 250, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de inicio", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Data de fim", 150, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Tipo de quarto", 170, HorizontalAlignment.Left);
                    mtv_dadosReserva.Columns.Add("Número de Pessoas", 180, HorizontalAlignment.Left);

                    for (int i = 1; i < dados.Length; i++)
                    {
                        string[] campos = dados[i].Split(';');
                        ListViewItem item = new ListViewItem(campos[0]);
                        for (int j = 1; j < campos.Length; j++)
                        {
                            item.SubItems.Add(campos[j]);
                        }
                        mtv_dadosReserva.Items.Add(item);
                    }

                    mtv_dadosReserva.View = View.Details;
                    mtv_dadosReserva.FullRowSelect = true;
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                }
            }
            
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato nos dados. Detalhes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }

        private void mtv_dadosReserva_MouseDC(object sender, MouseEventArgs e)
        {
            if (mtv_dadosReserva.SelectedItems.Count > 0 && telaInicial != null)
            {
                ListViewItem item = mtv_dadosReserva.SelectedItems[0];

                string nome = item.SubItems[1].Text;
                string telefone = item.SubItems[2].Text;
                string email = item.SubItems[3].Text;
                DateTime dataInicio = DateTime.Parse(item.SubItems[4].Text);
                DateTime dataFim = DateTime.Parse(item.SubItems[5].Text);
                string tipoQuarto = item.SubItems[6].Text;
                int numeroPessoas = int.Parse(item.SubItems[7].Text);

                telaInicial.receberDadoseReserva(nome, telefone, email, dataInicio, dataFim, tipoQuarto, numeroPessoas);
                telaInicial.Focus(); // Opcional: traz a tela inicial para frente
                this.Close(); // Fecha a lista de reservas, se desejar
            }
        }

        private void mtv_dadosReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_dadosReserva_Load(object sender, EventArgs e)
        {
            CarregarDadosReserva();
        }
    }
}
