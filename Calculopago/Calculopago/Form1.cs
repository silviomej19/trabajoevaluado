using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculopago
{
    public partial class Form1 : Form
    {
        Empleado emp1 = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }
        private void BTNguardarregistro_Click(object sender, EventArgs e)
        {
            emp1.numero = Convert.ToInt32(TXTnumero.Text);
            emp1.Nombre = TXTnombre.Text;
            emp1.Diastrabajados = Convert.ToInt32(TXTdiastrabajados.Text);
            emp1.saldia = Convert.ToDecimal(TXTpagospordias.Text);
            MessageBox.Show("Registro guardado");
        }

        private void BTNcalcularsalario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TXTdiastrabajados.Text, out int diasTrabajados) &&decimal.TryParse(TXTpagospordias.Text, out decimal pagosDia))
            {
                decimal totalDevengado = diasTrabajados * pagosDia;
                TXTtotaldevengado.Text = totalDevengado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            TXTdiastrabajados.Clear();
            TXTnumero.Clear();
            TXTpagospordias.Clear();
            TXTnombre.Clear();
            TXTtotaldevengado.Clear();
            TXTdiastrabajados.Clear();
        }
    }
}
