using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazDental
{
    public partial class RegistrarHistorialMedico : Form
    {
        public RegistrarHistorialMedico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            if (rbtnSiAlergia.Checked == true)
            {
                txtAlergia.Enabled = true;
            }
            else
            { 
                txtAlergia.Enabled = false;
            }
            if (rbtnSiEnfermedad.Checked == true)
            {
                txtEnfermedad.Enabled = true;
            }
            else
            {
                txtEnfermedad.Enabled = false;
            }
            if (rbtnSiTratamiento.Checked == true)
            {
                txtTratamiento.Enabled = true;
            }
            else
            {
                txtTratamiento.Enabled = false;
            }
        }

        private void rbtnNoAlergia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSiEnfermedad_Click(object sender, EventArgs e)
        {
        }

        private void rbtnSiEnfermedad_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
