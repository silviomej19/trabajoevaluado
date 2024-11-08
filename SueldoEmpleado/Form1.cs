using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SueldoEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string cargo;
            cargo = cmbcargo.Text;
            if (cargo == "Gerente")
            {
                txtsueldocorrespondiente.Text = "32,500";
            }
            if (cargo == "Administrador")
            {
                txtsueldocorrespondiente.Text = "10,000";
            }
            if (cargo == "Secretaria")
            {
                txtsueldocorrespondiente.Text = "5,500";
            }
            if (cargo == "Contador")
            {
                txtsueldocorrespondiente.Text = "6,000";
            }
        }
    }
}
