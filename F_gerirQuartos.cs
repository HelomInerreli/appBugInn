using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appBugInn
{
    public partial class F_gerirQuartos : MaterialForm
    {
        public F_gerirQuartos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void mtv_dadosReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefoneReserva1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
