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
    public partial class F_gerirQuartos : Form
    {
        public F_gerirQuartos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event here  
        }



        private void button1_Click(object sender, EventArgs e) //mostra o que está no quartos.txt

        {
            string[] texto = Funcionalidades.LerBaseDados("quartos");

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < texto.Length; i++) // começa no index 1, ignora o index 0
            {
                sb.AppendLine(texto[i]);
            }

            label1.Text = sb.ToString(); // o label não é o ideal para mostrar textos grandes
        } 

    }

}

    




