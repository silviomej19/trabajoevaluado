namespace interfazDental
{
    partial class MenuP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuP));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHistorialMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.registrarPacienteToolStripMenuItem,
            this.agendarCitaToolStripMenuItem,
            this.salirDelProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1748, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCuentaToolStripMenuItem});
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.miCuentaToolStripMenuItem.Text = "Mi cuenta ";
            this.miCuentaToolStripMenuItem.Click += new System.EventHandler(this.miCuentaToolStripMenuItem_Click);
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHistorialMedicoToolStripMenuItem});
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar paciente ";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // registrarHistorialMedicoToolStripMenuItem
            // 
            this.registrarHistorialMedicoToolStripMenuItem.Name = "registrarHistorialMedicoToolStripMenuItem";
            this.registrarHistorialMedicoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.registrarHistorialMedicoToolStripMenuItem.Text = "Registrar historial medico ";
            this.registrarHistorialMedicoToolStripMenuItem.Click += new System.EventHandler(this.registrarHistorialMedicoToolStripMenuItem_Click);
            // 
            // agendarCitaToolStripMenuItem
            // 
            this.agendarCitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCitaToolStripMenuItem,
            this.eliminarCitaToolStripMenuItem});
            this.agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            this.agendarCitaToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.agendarCitaToolStripMenuItem.Text = "Agendar cita ";
            this.agendarCitaToolStripMenuItem.Click += new System.EventHandler(this.agendarCitaToolStripMenuItem_Click);
            // 
            // editarCitaToolStripMenuItem
            // 
            this.editarCitaToolStripMenuItem.Name = "editarCitaToolStripMenuItem";
            this.editarCitaToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.editarCitaToolStripMenuItem.Text = "Editar cita";
            this.editarCitaToolStripMenuItem.Click += new System.EventHandler(this.editarCitaToolStripMenuItem_Click);
            // 
            // eliminarCitaToolStripMenuItem
            // 
            this.eliminarCitaToolStripMenuItem.Name = "eliminarCitaToolStripMenuItem";
            this.eliminarCitaToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.eliminarCitaToolStripMenuItem.Text = "Eliminar cita";
            this.eliminarCitaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCitaToolStripMenuItem_Click);
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir del programa";
            this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirDelProgramaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1748, 716);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(416, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(939, 96);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bienvenido a DentalClinic";
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1748, 719);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHistorialMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
    }
}

