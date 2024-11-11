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
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion inciairSesion = new IniciarSesion();
            inciairSesion.Show();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPacientecs registrarPacientecs = new RegistrarPacientecs();
            registrarPacientecs.Show();
        }

        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiCuenta micuenta = new MiCuenta();
            micuenta.Show();
        }

        private void registrarHistorialMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarHistorialMedico registrarHistorialMedico = new RegistrarHistorialMedico();
            registrarHistorialMedico.Show(); 
        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarCita agendarCita = new AgendarCita(); 
            agendarCita.Show();
        }

        private void editarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCita editarCita = new EditarCita();
            editarCita.Show();
        }

        private void eliminarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCita eliminarCita = new EliminarCita(); 
            eliminarCita.Show();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa" , "Saliendo" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
