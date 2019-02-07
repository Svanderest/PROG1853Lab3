using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace ElectricalCurrent
{
    public partial class FrmElectricalCurrent : Form
    {
        public FrmElectricalCurrent()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double voltage = Convert.ToDouble(txtBatteryVoltage.Text);
            Double resistance = Convert.ToDouble(txtResistance.Text);
            Double capacitance = Convert.ToDouble(txtCapacitance.Text);
            Double time = Convert.ToDouble(txtTime.Text);
            Double current = voltage * Math.Pow(Math.E, -time / (resistance * capacitance)) / resistance;
            lblCurrent.Text = current.ToString("E2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBatteryVoltage.Text = "";
            txtCapacitance.Text = "";
            txtResistance.Text = "";
            txtTime.Text = "";
            lblCurrent.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
