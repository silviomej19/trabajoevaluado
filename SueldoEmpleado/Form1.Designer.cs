namespace SueldoEmpleado
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.grpclick = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtsueldocorrespondiente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpdatos.SuspendLayout();
            this.grpclick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Black;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitulo.Location = new System.Drawing.Point(71, 40);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(455, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Determinar sueldo del empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.cmbcargo);
            this.grpdatos.Controls.Add(this.txtnombre);
            this.grpdatos.Controls.Add(this.lblcargo);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Location = new System.Drawing.Point(35, 113);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(548, 146);
            this.grpdatos.TabIndex = 2;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Ingrese datos";
            // 
            // cmbcargo
            // 
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Items.AddRange(new object[] {
            "Contador",
            "Secretaria",
            "Administrador",
            "Gerente"});
            this.cmbcargo.Location = new System.Drawing.Point(210, 93);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(281, 33);
            this.cmbcargo.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(210, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(281, 30);
            this.txtnombre.TabIndex = 2;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(80, 93);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(72, 25);
            this.lblcargo.TabIndex = 1;
            this.lblcargo.Text = "Cargo:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(80, 38);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 25);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // grpclick
            // 
            this.grpclick.Controls.Add(this.btnsalir);
            this.grpclick.Controls.Add(this.btncalcular);
            this.grpclick.Controls.Add(this.btnnuevo);
            this.grpclick.Location = new System.Drawing.Point(35, 290);
            this.grpclick.Name = "grpclick";
            this.grpclick.Size = new System.Drawing.Size(317, 252);
            this.grpclick.TabIndex = 3;
            this.grpclick.TabStop = false;
            this.grpclick.Text = "Hacer Click";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(88, 163);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(141, 40);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(88, 49);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(141, 40);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(88, 106);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(141, 40);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(30, 570);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(225, 25);
            this.lblsueldo.TabIndex = 4;
            this.lblsueldo.Text = "Sueldo correspondiente:";
            // 
            // txtsueldocorrespondiente
            // 
            this.txtsueldocorrespondiente.Location = new System.Drawing.Point(274, 570);
            this.txtsueldocorrespondiente.Name = "txtsueldocorrespondiente";
            this.txtsueldocorrespondiente.Size = new System.Drawing.Size(281, 30);
            this.txtsueldocorrespondiente.TabIndex = 4;
            this.txtsueldocorrespondiente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 652);
            this.Controls.Add(this.txtsueldocorrespondiente);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.grpclick);
            this.Controls.Add(this.grpdatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sueldo Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.grpclick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox grpclick;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtsueldocorrespondiente;
        private System.Windows.Forms.ComboBox cmbcargo;
    }
}

