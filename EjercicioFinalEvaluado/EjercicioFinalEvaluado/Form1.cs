using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFinalEvaluado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grpIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTot_Click(object sender, EventArgs e)
        {

        }

        private void lblCodeProd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos leidos correctamente","Guardado",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtCodeProd.Clear();
            txtNombreProd.Clear();  
            txtPrice.Clear();
            txtCodeProd.Focus();
            txtSubTot.Clear();
            txtDesc.Clear();
            txtIVA.Clear();
            txtTotal.Clear();   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silvio Ernesto Mejia Garcia - 05/11/2024","Adios jeje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void txtCodeProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) /* || Significa or*/ /*Esto lo hice con los valores de la tabla ascii*/
            {
                MessageBox.Show("Ingrese unicamente letras por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(txtPrice.Text); //Declaramos variable
            int cantidad = int.Parse(txtCant.Text); //Declaramos la variable que va a ingresar usuario
            int subtotal = precio * cantidad;   //Calculamos el subtotal con la formula dle ejercicio
            txtSubTot.Text = subtotal.ToString();

            double subtotalDesc = subtotal; //Revisar todo este codigo para corregir el proceso de descuento, el iva y el total
            if (rbtn0.Checked == true)
            {
                subtotalDesc = subtotal * 0;
                /*subtotalDesc = subtotal - subtotalDesc*/
                txtDesc.Text = subtotalDesc.ToString();
            }
            if (rbtn1.Checked == true)
            {
                subtotalDesc = subtotal * 0.01;
                /*subtotalDesc = subtotal - subtotalDesc;*/
                txtDesc.Text = subtotalDesc.ToString();
            }
            if (rbtn5.Checked == true)
            {
                subtotalDesc = subtotal * 0.05;
                /*subtotalDesc = subtotal - subtotalDesc;*/
                txtDesc.Text = subtotalDesc.ToString();
            }
            if (rbtn10.Checked == true)
            {
                subtotalDesc = subtotal * 0.10;
                /*subtotalDesc = subtotal - subtotalDesc;*/ 
                txtDesc.Text = subtotalDesc.ToString();
            }
            if (rbtn15.Checked == true)
            {
                subtotalDesc = subtotal * 0.15;
                /*subtotalDesc = subtotal - subtotalDesc;*/
                txtDesc.Text = subtotalDesc.ToString();
            }
            double subtotalIVA = subtotal * 0.15;
            txtIVA.Text = subtotalIVA.ToString();

            double total1 = subtotal - subtotalDesc;
            double total2 = total1 + subtotalIVA;
            txtTotal.Text = total2.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
