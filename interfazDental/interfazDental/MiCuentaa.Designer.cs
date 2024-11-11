namespace interfazDental
{
    partial class MiCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpSalida = new System.Windows.Forms.GroupBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblHistorialCitas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.Info;
            this.lblId.Location = new System.Drawing.Point(26, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(143, 26);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID de cuenta: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.SystemColors.Info;
            this.lblUserName.Location = new System.Drawing.Point(26, 158);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(205, 26);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Nombre de usuario: ";
            this.lblUserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpSalida
            // 
            this.grpSalida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpSalida.Controls.Add(this.textBox2);
            this.grpSalida.Controls.Add(this.textBox1);
            this.grpSalida.Controls.Add(this.lblHistorialCitas);
            this.grpSalida.Controls.Add(this.lblHistorial);
            this.grpSalida.Controls.Add(this.lblId);
            this.grpSalida.Controls.Add(this.lblUserName);
            this.grpSalida.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalida.Location = new System.Drawing.Point(12, 12);
            this.grpSalida.Name = "grpSalida";
            this.grpSalida.Size = new System.Drawing.Size(991, 556);
            this.grpSalida.TabIndex = 2;
            this.grpSalida.TabStop = false;
            this.grpSalida.Text = "Salida de datos";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.SystemColors.Info;
            this.lblHistorial.Location = new System.Drawing.Point(26, 283);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(180, 26);
            this.lblHistorial.TabIndex = 2;
            this.lblHistorial.Text = "Historial Medico: ";
            this.lblHistorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHistorialCitas
            // 
            this.lblHistorialCitas.AutoSize = true;
            this.lblHistorialCitas.BackColor = System.Drawing.SystemColors.Info;
            this.lblHistorialCitas.Location = new System.Drawing.Point(26, 414);
            this.lblHistorialCitas.Name = "lblHistorialCitas";
            this.lblHistorialCitas.Size = new System.Drawing.Size(185, 26);
            this.lblHistorialCitas.TabIndex = 3;
            this.lblHistorialCitas.Text = "Historial de Citas: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(226, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 33);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(257, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 33);
            this.textBox2.TabIndex = 5;
            // 
            // MiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 580);
            this.Controls.Add(this.grpSalida);
            this.Name = "MiCuenta";
            this.Text = "IniciarSesion";
            this.grpSalida.ResumeLayout(false);
            this.grpSalida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox grpSalida;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHistorialCitas;
    }
}