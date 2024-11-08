using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_bonificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LBLnombreempleado_Click(object sender, EventArgs e)
        {

        }

        private void GRPbonificaciones_Enter(object sender, EventArgs e)
        {

        }

        private void TXTsalariobasico_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = TXTnombreempleado.Text;
            decimal salarioBasico;

            if (decimal.TryParse(TXTsalariobasico.Text, out salarioBasico))
            {
                decimal bonificacion = 0;
                if (RBTN10.Checked)
                    bonificacion = salarioBasico * 0.10m;
                else if (RBTN20.Checked)
                    bonificacion = salarioBasico * 0.20m;
                else if (RBTN35.Checked)
                    bonificacion = salarioBasico * 0.35m;

                decimal retencion = salarioBasico >= 10000 ? salarioBasico * 0.05m : 0;
                decimal totalARecibir = salarioBasico + bonificacion - retencion;

                TXTbonificacion.Text = bonificacion.ToString("C");
                TXTretencion.Text = retencion.ToString("C");
                TXTtotalarecibir.Text = totalARecibir.ToString("C");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un salario básico válido.");
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXTnombreempleado.Clear();
            TXTsalariobasico.Clear();
            TXTbonificacion.Clear();
            TXTretencion.Clear();
            TXTtotalarecibir.Clear();
            RBTN10.Checked = false;
            RBTN20.Checked = false;
            RBTN35.Checked = false;
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas segura de querer salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void RBTN10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTN20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTN35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TXTbonificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTretencion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTtotalarecibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnombreempleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
