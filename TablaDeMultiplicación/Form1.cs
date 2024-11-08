using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaDeMultiplicación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIngresarNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresarNumero.Clear();
            lstTabla.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;

            numero = int.Parse(txtIngresarNumero.Text);
            for (i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                lstTabla.Items.Add(numero + " * " + i + "=  " + resultado);
            }
        }

        private void txtIngresarNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
