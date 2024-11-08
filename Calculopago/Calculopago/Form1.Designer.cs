namespace Calculopago
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
            this.LBLtitulo = new System.Windows.Forms.Label();
            this.LBLnumero = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLdiastrabajados = new System.Windows.Forms.Label();
            this.LBLpagopordia = new System.Windows.Forms.Label();
            this.TXTnumero = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTdiastrabajados = new System.Windows.Forms.TextBox();
            this.TXTpagospordias = new System.Windows.Forms.TextBox();
            this.BTNguardarregistro = new System.Windows.Forms.Button();
            this.BTNnuevo = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.LBLtotaldevengado = new System.Windows.Forms.Label();
            this.TXTtotaldevengado = new System.Windows.Forms.TextBox();
            this.BTNcalcularsalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLtitulo
            // 
            this.LBLtitulo.AutoSize = true;
            this.LBLtitulo.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtitulo.Location = new System.Drawing.Point(59, 31);
            this.LBLtitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLtitulo.Name = "LBLtitulo";
            this.LBLtitulo.Size = new System.Drawing.Size(475, 72);
            this.LBLtitulo.TabIndex = 0;
            this.LBLtitulo.Text = "Calculo Nomina de pago";
            // 
            // LBLnumero
            // 
            this.LBLnumero.AutoSize = true;
            this.LBLnumero.Location = new System.Drawing.Point(63, 133);
            this.LBLnumero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLnumero.Name = "LBLnumero";
            this.LBLnumero.Size = new System.Drawing.Size(106, 29);
            this.LBLnumero.TabIndex = 1;
            this.LBLnumero.Text = "Numero";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(62, 190);
            this.LBLnombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(107, 29);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre";
            // 
            // LBLdiastrabajados
            // 
            this.LBLdiastrabajados.AutoSize = true;
            this.LBLdiastrabajados.Location = new System.Drawing.Point(63, 248);
            this.LBLdiastrabajados.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLdiastrabajados.Name = "LBLdiastrabajados";
            this.LBLdiastrabajados.Size = new System.Drawing.Size(202, 29);
            this.LBLdiastrabajados.TabIndex = 3;
            this.LBLdiastrabajados.Text = "Dias trabajados:";
            // 
            // LBLpagopordia
            // 
            this.LBLpagopordia.AutoSize = true;
            this.LBLpagopordia.Location = new System.Drawing.Point(63, 306);
            this.LBLpagopordia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLpagopordia.Name = "LBLpagopordia";
            this.LBLpagopordia.Size = new System.Drawing.Size(183, 29);
            this.LBLpagopordia.TabIndex = 4;
            this.LBLpagopordia.Text = "Pago por dias:";
            // 
            // TXTnumero
            // 
            this.TXTnumero.Location = new System.Drawing.Point(179, 130);
            this.TXTnumero.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTnumero.Name = "TXTnumero";
            this.TXTnumero.Size = new System.Drawing.Size(321, 34);
            this.TXTnumero.TabIndex = 5;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(179, 190);
            this.TXTnombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(321, 34);
            this.TXTnombre.TabIndex = 6;
            // 
            // TXTdiastrabajados
            // 
            this.TXTdiastrabajados.Location = new System.Drawing.Point(316, 248);
            this.TXTdiastrabajados.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTdiastrabajados.Name = "TXTdiastrabajados";
            this.TXTdiastrabajados.Size = new System.Drawing.Size(184, 34);
            this.TXTdiastrabajados.TabIndex = 7;
            // 
            // TXTpagospordias
            // 
            this.TXTpagospordias.Location = new System.Drawing.Point(316, 306);
            this.TXTpagospordias.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTpagospordias.Name = "TXTpagospordias";
            this.TXTpagospordias.Size = new System.Drawing.Size(184, 34);
            this.TXTpagospordias.TabIndex = 8;
            // 
            // BTNguardarregistro
            // 
            this.BTNguardarregistro.Location = new System.Drawing.Point(137, 415);
            this.BTNguardarregistro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTNguardarregistro.Name = "BTNguardarregistro";
            this.BTNguardarregistro.Size = new System.Drawing.Size(300, 42);
            this.BTNguardarregistro.TabIndex = 9;
            this.BTNguardarregistro.Text = "Guardar Registro";
            this.BTNguardarregistro.UseVisualStyleBackColor = true;
            this.BTNguardarregistro.Click += new System.EventHandler(this.BTNguardarregistro_Click);
            // 
            // BTNnuevo
            // 
            this.BTNnuevo.Location = new System.Drawing.Point(14, 467);
            this.BTNnuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTNnuevo.Name = "BTNnuevo";
            this.BTNnuevo.Size = new System.Drawing.Size(140, 42);
            this.BTNnuevo.TabIndex = 10;
            this.BTNnuevo.Text = "Nuevo";
            this.BTNnuevo.UseVisualStyleBackColor = true;
            this.BTNnuevo.Click += new System.EventHandler(this.BTNnuevo_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(429, 467);
            this.BTNsalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(140, 42);
            this.BTNsalir.TabIndex = 11;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // LBLtotaldevengado
            // 
            this.LBLtotaldevengado.AutoSize = true;
            this.LBLtotaldevengado.Location = new System.Drawing.Point(62, 362);
            this.LBLtotaldevengado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLtotaldevengado.Name = "LBLtotaldevengado";
            this.LBLtotaldevengado.Size = new System.Drawing.Size(217, 29);
            this.LBLtotaldevengado.TabIndex = 12;
            this.LBLtotaldevengado.Text = "Total devengado:";
            // 
            // TXTtotaldevengado
            // 
            this.TXTtotaldevengado.Location = new System.Drawing.Point(316, 362);
            this.TXTtotaldevengado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTtotaldevengado.Name = "TXTtotaldevengado";
            this.TXTtotaldevengado.Size = new System.Drawing.Size(184, 34);
            this.TXTtotaldevengado.TabIndex = 13;
            // 
            // BTNcalcularsalario
            // 
            this.BTNcalcularsalario.Location = new System.Drawing.Point(179, 467);
            this.BTNcalcularsalario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTNcalcularsalario.Name = "BTNcalcularsalario";
            this.BTNcalcularsalario.Size = new System.Drawing.Size(228, 42);
            this.BTNcalcularsalario.TabIndex = 14;
            this.BTNcalcularsalario.Text = "Calcular Salario";
            this.BTNcalcularsalario.UseVisualStyleBackColor = true;
            this.BTNcalcularsalario.Click += new System.EventHandler(this.BTNcalcularsalario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(586, 530);
            this.Controls.Add(this.BTNcalcularsalario);
            this.Controls.Add(this.TXTtotaldevengado);
            this.Controls.Add(this.LBLtotaldevengado);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNnuevo);
            this.Controls.Add(this.BTNguardarregistro);
            this.Controls.Add(this.TXTpagospordias);
            this.Controls.Add(this.TXTdiastrabajados);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.TXTnumero);
            this.Controls.Add(this.LBLpagopordia);
            this.Controls.Add(this.LBLdiastrabajados);
            this.Controls.Add(this.LBLnombre);
            this.Controls.Add(this.LBLnumero);
            this.Controls.Add(this.LBLtitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Calculo \"Nomina de pago\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLtitulo;
        private System.Windows.Forms.Label LBLnumero;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLdiastrabajados;
        private System.Windows.Forms.Label LBLpagopordia;
        private System.Windows.Forms.TextBox TXTnumero;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTdiastrabajados;
        private System.Windows.Forms.TextBox TXTpagospordias;
        private System.Windows.Forms.Button BTNguardarregistro;
        private System.Windows.Forms.Button BTNnuevo;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Label LBLtotaldevengado;
        private System.Windows.Forms.TextBox TXTtotaldevengado;
        private System.Windows.Forms.Button BTNcalcularsalario;
    }
}

