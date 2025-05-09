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

namespace appBugInn
{
    public partial class F_telaInicial : MaterialForm
    {
        public F_telaInicial()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            //bar
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2024",
                    Values = new ChartValues<double> { 16, 15, 14, 13, 15, 15, 16, 15, 17, 16, 14, 16 }
}
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2025",
                Values = new ChartValues<double> { 15, 15, 13, 12, 7, 0, 0, 0, 0, 0, 0, 0 }
            });

            //also adding values updates and animates the chart automatically
            //cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Meses",
                Labels = new[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }

            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Faturamento",
                LabelFormatter = value => value.ToString("N")
            });

        }

        private void F_telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void sw_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if (sw_darkMode.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        

    }
}
