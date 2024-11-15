using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros_estudiantes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrabarDatos();
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void GrabarDatos()
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt", true))
                {
                    archivo.WriteLine(textBox1.Text);
                    archivo.WriteLine(textBox2.Text);
                    archivo.WriteLine(textBox3.Text);
                    archivo.WriteLine(textBox4.Text); 
                    archivo.WriteLine(textBox5.Text);
                    archivo.WriteLine(comboBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar datos: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt"))
            {
                using (TextWriter archivo = new StreamWriter("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt"))
                {
                    // Se crea el archivo vacio
                }
            }
            else
            {
                try
                {
                    using (StreamReader archivo = new StreamReader("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt"))
                    {
                        while (!archivo.EndOfStream)
                        {
                            string Nombres = archivo.ReadLine();
                            string Apellidos = archivo.ReadLine();
                            string Carrera = archivo.ReadLine();
                            string CIF = archivo.ReadLine();
                            string PromedioGeneral = archivo.ReadLine();
                            string ClasesAprobadas = archivo.ReadLine();
                            dataGridView1.Rows.Add(Nombres, Apellidos, Carrera, CIF, PromedioGeneral, ClasesAprobadas);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer datos: " + ex.Message);
                }
            }
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del estudiante a eliminar
            string nombreAEliminar = textBox1.Text;

            // Buscar la fila con ese nombre
            int filaAEliminar = -1;
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                if (dataGridView1.Rows[f].Cells[0].Value.ToString() == nombreAEliminar)
                {
                    filaAEliminar = f;
                    break;
                }
            }

            // Eliminar la fila de la tabla
            if (filaAEliminar != -1)
            {
                dataGridView1.Rows.RemoveAt(filaAEliminar);
                MessageBox.Show("Se eliminó el estudiante");
            }
            else
            {
                MessageBox.Show("No se encontró el estudiante");
            }

            // Eliminar la información del estudiante del archivo de texto
            try
            {
                List<string> lineas = new List<string>();
                using (StreamReader archivo = new StreamReader("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt"))
                {
                    while (!archivo.EndOfStream)
                    {
                        string nombre = archivo.ReadLine();
                        if (nombre != nombreAEliminar)
                        {
                            lineas.Add(nombre);
                            lineas.Add(archivo.ReadLine());
                            lineas.Add(archivo.ReadLine());
                            lineas.Add(archivo.ReadLine());
                            lineas.Add(archivo.ReadLine());
                            lineas.Add(archivo.ReadLine());
                        }
                        else
                        {
                            // Saltar las 5 líneas correspondientes al estudiante a eliminar
                            for (int i = 0; i < 5; i++)
                            {
                                archivo.ReadLine();
                            }
                        }
                    }
                }

                // Reescribir el archivo sin la información del estudiante eliminado
                using (StreamWriter archivo = new StreamWriter("C:\\Users\\johal\\OneDrive\\Documents\\Nueva carpeta\\agenda.txt"))
                {
                    foreach (string linea in lineas)
                    {
                        archivo.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el estudiante del archivo: " + ex.Message);
            }
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
