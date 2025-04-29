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
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*'; // Começa com senha oculta
        }

        private void bt_login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e esconder a senha
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0'; // Mostra a senha
            }
            else
            {
                txt_password.PasswordChar = '*'; // Oculta a senha
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }
    }
}
