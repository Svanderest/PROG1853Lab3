using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace TemperatureConverter
{
    public partial class FrmTemperature : Form
    {
        public FrmTemperature()
        {
            InitializeComponent();
        }

        private void btnCalcFahrenheit_Click(object sender, EventArgs e)
        {
            Double celcius = Convert.ToDouble(txtTemperature.Text);
            Double farenheit = 9 * celcius / 5 + 32;
            lblFahrenheit.Text = farenheit.ToString("F2");
        }

        private void btnCalcCelsius_Click(object sender, EventArgs e)
        {
            Double farenheit = Convert.ToDouble(txtTemperature.Text);
            Double celcius = 5 * (farenheit - 32) / 9;
            lblCelsius.Text = celcius.ToString("F2");
        }
    }
}
