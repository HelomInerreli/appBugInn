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
    public partial class F_inicial : Form
    {
        public F_inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_login loginForm = new F_login();
            //this.Hide(); // Esconde o formulário atual
            loginForm.Show();
            
        }
    }
}
