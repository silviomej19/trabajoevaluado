namespace EjercicioFinalEvaluado
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpIngreso = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCodeProd = new System.Windows.Forms.TextBox();
            this.lblCodeProd = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.grpSalida = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.rbtn15 = new System.Windows.Forms.RadioButton();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpIngreso.SuspendLayout();
            this.grpSalida.SuspendLayout();
            this.grpDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMERCIAL \"EL TRIUNFO\"";
            // 
            // grpIngreso
            // 
            this.grpIngreso.Controls.Add(this.btnGuardar);
            this.grpIngreso.Controls.Add(this.txtCant);
            this.grpIngreso.Controls.Add(this.txtPrice);
            this.grpIngreso.Controls.Add(this.txtNombreProd);
            this.grpIngreso.Controls.Add(this.txtCodeProd);
            this.grpIngreso.Controls.Add(this.lblCodeProd);
            this.grpIngreso.Controls.Add(this.lblPrice);
            this.grpIngreso.Controls.Add(this.lblCant);
            this.grpIngreso.Controls.Add(this.lblNombreProd);
            this.grpIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngreso.Location = new System.Drawing.Point(16, 52);
            this.grpIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.grpIngreso.Name = "grpIngreso";
            this.grpIngreso.Padding = new System.Windows.Forms.Padding(4);
            this.grpIngreso.Size = new System.Drawing.Size(560, 245);
            this.grpIngreso.TabIndex = 1;
            this.grpIngreso.TabStop = false;
            this.grpIngreso.Text = "Ingreso Datos";
            this.grpIngreso.Enter += new System.EventHandler(this.grpIngreso_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(401, 172);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 52);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(136, 186);
            this.txtCant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(168, 24);
            this.txtCant.TabIndex = 11;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(106, 135);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(168, 24);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(239, 76);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(168, 24);
            this.txtNombreProd.TabIndex = 9;
            this.txtNombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProd_KeyPress);
            // 
            // txtCodeProd
            // 
            this.txtCodeProd.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeProd.Location = new System.Drawing.Point(226, 29);
            this.txtCodeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeProd.Name = "txtCodeProd";
            this.txtCodeProd.Size = new System.Drawing.Size(168, 24);
            this.txtCodeProd.TabIndex = 8;
            this.txtCodeProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeProd_KeyPress);
            // 
            // lblCodeProd
            // 
            this.lblCodeProd.AutoSize = true;
            this.lblCodeProd.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeProd.Location = new System.Drawing.Point(12, 31);
            this.lblCodeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeProd.Name = "lblCodeProd";
            this.lblCodeProd.Size = new System.Drawing.Size(157, 22);
            this.lblCodeProd.TabIndex = 7;
            this.lblCodeProd.Text = "Codigo producto: ";
            this.lblCodeProd.Click += new System.EventHandler(this.lblCodeProd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 138);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 22);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Precio: ";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(12, 189);
            this.lblCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(93, 22);
            this.lblCant.TabIndex = 5;
            this.lblCant.Text = "Cantidad: ";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(12, 79);
            this.lblNombreProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(165, 22);
            this.lblNombreProd.TabIndex = 0;
            this.lblNombreProd.Text = "Nombre producto: ";
            // 
            // grpSalida
            // 
            this.grpSalida.Controls.Add(this.btnClean);
            this.grpSalida.Controls.Add(this.btnClose);
            this.grpSalida.Controls.Add(this.btnCalc);
            this.grpSalida.Controls.Add(this.txtTotal);
            this.grpSalida.Controls.Add(this.txtIVA);
            this.grpSalida.Controls.Add(this.txtDesc);
            this.grpSalida.Controls.Add(this.txtSubTot);
            this.grpSalida.Controls.Add(this.lblSubTot);
            this.grpSalida.Controls.Add(this.lblIVA);
            this.grpSalida.Controls.Add(this.lblTotal);
            this.grpSalida.Controls.Add(this.lblDesc);
            this.grpSalida.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalida.Location = new System.Drawing.Point(16, 305);
            this.grpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.grpSalida.Name = "grpSalida";
            this.grpSalida.Padding = new System.Windows.Forms.Padding(4);
            this.grpSalida.Size = new System.Drawing.Size(560, 242);
            this.grpSalida.TabIndex = 2;
            this.grpSalida.TabStop = false;
            this.grpSalida.Text = "Salida Programa";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClean.Location = new System.Drawing.Point(401, 168);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(131, 52);
            this.btnClean.TabIndex = 17;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(401, 96);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalc.Location = new System.Drawing.Point(401, 28);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(131, 52);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(96, 209);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(168, 24);
            this.txtTotal.TabIndex = 15;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(80, 149);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(168, 24);
            this.txtIVA.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(149, 94);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(168, 24);
            this.txtDesc.TabIndex = 13;
            // 
            // txtSubTot
            // 
            this.txtSubTot.Enabled = false;
            this.txtSubTot.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTot.Location = new System.Drawing.Point(135, 41);
            this.txtSubTot.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(168, 24);
            this.txtSubTot.TabIndex = 12;
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(12, 44);
            this.lblSubTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(92, 22);
            this.lblSubTot.TabIndex = 4;
            this.lblSubTot.Text = "SubTotal: ";
            this.lblSubTot.Click += new System.EventHandler(this.lblSubTot_Click);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(12, 151);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(48, 22);
            this.lblIVA.TabIndex = 3;
            this.lblIVA.Text = "IVA: ";
            this.lblIVA.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 211);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 22);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 96);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(103, 22);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descuento: ";
            this.lblDesc.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpDesc
            // 
            this.grpDesc.Controls.Add(this.rbtn15);
            this.grpDesc.Controls.Add(this.rbtn10);
            this.grpDesc.Controls.Add(this.rbtn5);
            this.grpDesc.Controls.Add(this.rbtn1);
            this.grpDesc.Controls.Add(this.rbtn0);
            this.grpDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDesc.Location = new System.Drawing.Point(602, 56);
            this.grpDesc.Margin = new System.Windows.Forms.Padding(4);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Padding = new System.Windows.Forms.Padding(4);
            this.grpDesc.Size = new System.Drawing.Size(170, 255);
            this.grpDesc.TabIndex = 3;
            this.grpDesc.TabStop = false;
            this.grpDesc.Text = "Descuento";
            this.grpDesc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtn15
            // 
            this.rbtn15.AutoSize = true;
            this.rbtn15.Location = new System.Drawing.Point(8, 206);
            this.rbtn15.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn15.Name = "rbtn15";
            this.rbtn15.Size = new System.Drawing.Size(66, 26);
            this.rbtn15.TabIndex = 4;
            this.rbtn15.Text = "15%";
            this.rbtn15.UseVisualStyleBackColor = true;
            this.rbtn15.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Location = new System.Drawing.Point(8, 166);
            this.rbtn10.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(66, 26);
            this.rbtn10.TabIndex = 3;
            this.rbtn10.Text = "10%";
            this.rbtn10.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(8, 126);
            this.rbtn5.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(56, 26);
            this.rbtn5.TabIndex = 2;
            this.rbtn5.Text = "5%";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(8, 89);
            this.rbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(56, 26);
            this.rbtn1.TabIndex = 1;
            this.rbtn1.Text = "1%";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Location = new System.Drawing.Point(8, 49);
            this.rbtn0.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(56, 26);
            this.rbtn0.TabIndex = 0;
            this.rbtn0.Text = "0%";
            this.rbtn0.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 331);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(797, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDesc);
            this.Controls.Add(this.grpSalida);
            this.Controls.Add(this.grpIngreso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mini Factura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIngreso.ResumeLayout(false);
            this.grpIngreso.PerformLayout();
            this.grpSalida.ResumeLayout(false);
            this.grpSalida.PerformLayout();
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpIngreso;
        private System.Windows.Forms.GroupBox grpSalida;
        private System.Windows.Forms.Label lblCodeProd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtCodeProd;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.RadioButton rbtn15;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

