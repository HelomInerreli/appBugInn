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
    public partial class CriarObjeto : Form
    {
        public CriarObjeto()
        {
            InitializeComponent();
        }

        private void txt_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_objeto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objetos = Funcionalidades.CriarObjetosDoTexto(txt_txt.Text, txt_objeto.Text);
            listBoxObjetos.Items.Clear();

            foreach (var obj in objetos)
            {
                listBoxObjetos.Items.Add(obj.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
