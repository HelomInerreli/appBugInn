using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appBugInn.Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace appBugInn
{
    public partial class F_checkOut : MaterialForm
    {
        private Hotel hotel;

        internal F_checkOut(Hotel hotelExistente)
        {
            InitializeComponent();
            this.hotel = hotelExistente;
        
        var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AtualizarListViewCheckinsAtivos()
        {
            mtv_dadosCheckOut.Items.Clear();
            mtv_dadosCheckOut.Columns.Clear();

            mtv_dadosCheckOut.Columns.Add("ID", 50);
            mtv_dadosCheckOut.Columns.Add("Nome", 150);
            mtv_dadosCheckOut.Columns.Add("Tipo Quarto", 100);
            mtv_dadosCheckOut.Columns.Add("Nº Quarto", 80);
            mtv_dadosCheckOut.Columns.Add("Subtotal", 100);
            mtv_dadosCheckOut.Columns.Add("Check-in", 100);
            mtv_dadosCheckOut.Columns.Add("Check-out", 100);

            foreach (var check in hotel.checkIn.Where(c => !c.CheckOut))
            {
                ListViewItem item = new ListViewItem(check.Id.ToString());
                item.SubItems.Add(check.NomeReserva);
                item.SubItems.Add(check.TipoQuarto);
                item.SubItems.Add(check.NumQuarto.ToString());
                item.SubItems.Add(check.Subtotal.ToString("F2") + " €");
                item.SubItems.Add(check.DataInicio.ToString("dd/MM/yyyy"));
                item.SubItems.Add(check.DataFim.ToString("dd/MM/yyyy"));

                mtv_dadosCheckOut.Items.Add(item);
            }

            mtv_dadosCheckOut.View = View.Details;
            mtv_dadosCheckOut.FullRowSelect = true;
        }

        private void dc_mtvDadosCheckOut(object sender, MouseEventArgs e)
        {
            if (mtv_dadosCheckOut.SelectedItems.Count == 0)
            {
                return;     
            }

            var item = mtv_dadosCheckOut.SelectedItems[0];
            int idCheckIn = int.Parse(item.SubItems[0].Text);

            var check = hotel.checkIn.FirstOrDefault(c => c.Id == idCheckIn && !c.CheckOut);
            if (check == null) return;

            btn_checkoutConfirmar.Tag = check.Id;
            txt_nomeCheckOut.Text = check.NomeReserva;
            txt_quartoCheckOut.Text = check.TipoQuarto;
            txt_idQuartoCheckOut.Text = check.NumQuarto.ToString();
            txt_subtotalCheckOut.Text = check.Subtotal.ToString("F2") + " €";

            // 🔧 CORREÇÃO AQUI
            txt_nAndarCheckOut.Text = (check.NumQuarto / 100).ToString();
            
            txt_dataInCheckOut.Text = check.DataInicio.ToString("dd/MM/yyyy");
            txt_dataFimCheckOut.Text = check.DataFim.ToString("dd/MM/yyyy");

            

        }

        private void LimparCampos()
        {
            txt_nomeCheckOut.Clear();
            txt_quartoCheckOut.Clear();
            txt_idQuartoCheckOut.Clear();
            txt_subtotalCheckOut.Clear();
            txt_nAndarCheckOut.Clear();
            txt_dataInCheckOut.Clear();
            txt_dataFimCheckOut.Clear();
        }

        private void F_checkOut_Load(object sender, EventArgs e)
        {
           
            AtualizarListViewCheckinsAtivos(); // Preenche a ListView
                                               // Preenche o ComboBox de método de pagamento
            cb_metodoPagamento.Items.Clear();
            cb_metodoPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão", "Fatura" });
            cb_metodoPagamento.SelectedIndex = 0;

            // Preenche o ComboBox de review (1 a 5 estrelas)
            cb_review.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cb_review.Items.Add($"{i} ★");
            }
            cb_review.SelectedIndex = 4; // valor padrão: 5 estrelas

            // Esconde o campo extra se "Outro" ainda não for selecionado
            txt_outroPagamento.Visible = false;

            // Evento para alternar visibilidade da textbox de "Outro"
            cb_metodoPagamento.SelectedIndexChanged += (s, ev) =>
            {
                txt_outroPagamento.Visible = cb_metodoPagamento.SelectedItem.ToString() == "Outro";
            };
        }

        private void btn_checkoutConfirmar_Click_1(object sender, EventArgs e)
        {
            if (btn_checkoutConfirmar.Tag == null)
            {
                MessageBox.Show("Nenhum check-in selecionado.");
                return;
            }

            int id = (int)btn_checkoutConfirmar.Tag;

            
            var check = hotel.checkIn.FirstOrDefault(c => c.Id == id);
            if (check == null) return;

            // ✅ Marcar checkOut e atualizar
            check.CheckOut = true;
            hotel.AtualizarBaseDeDadosChecks();

            // ✅ Método de pagamento
            string pagamento = cb_metodoPagamento.SelectedItem?.ToString();
            if (pagamento == "Outro")
                pagamento = txt_outroPagamento.Text.Trim();

            if (string.IsNullOrWhiteSpace(pagamento))
            {
                MessageBox.Show("Método de pagamento inválido.");
                return;
            }


            // ✅ Classificação (review)
            float classificacao = float.Parse(cb_review.SelectedItem.ToString().Split(' ')[0]);

            // ✅ RECARREGA lista para evitar duplicações
            hotel.preencherFaturamento();

            // ✅ ID baseado na lista atualizada
            int novoId = hotel.faturamentos.Any() ? hotel.faturamentos.Max(f => f.IdFaturamento) + 1 : 1;

            // ✅ Cria fatura
            Faturamento fatura = new Faturamento(
                novoId,
                check.Id,
                (float)check.Subtotal,
                DateTime.Now,
                pagamento,
                classificacao
            );

            hotel.faturamentos.Add(fatura);
            hotel.gravarFaturamento(); // ✅ grava sem linhas extras

            MessageBox.Show("Check-out finalizado com sucesso!");

            LimparCampos();
            AtualizarListViewCheckinsAtivos();
        }
    }
}
   
