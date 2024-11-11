namespace interfazDental
{
    partial class IniciarSesion
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpIngreso = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.Info;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(162, 33);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Digite su id: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Info;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(268, 33);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Digite su contrasenia:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(280, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 30);
            this.txtID.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(378, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // grpIngreso
            // 
            this.grpIngreso.Controls.Add(this.btnLogIn);
            this.grpIngreso.Controls.Add(this.txtPassword);
            this.grpIngreso.Controls.Add(this.txtID);
            this.grpIngreso.Controls.Add(this.lblPassword);
            this.grpIngreso.Controls.Add(this.lblID);
            this.grpIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngreso.Location = new System.Drawing.Point(9, 7);
            this.grpIngreso.Name = "grpIngreso";
            this.grpIngreso.Size = new System.Drawing.Size(970, 302);
            this.grpIngreso.TabIndex = 4;
            this.grpIngreso.TabStop = false;
            this.grpIngreso.Text = "Ingreso Datos";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogIn.ForeColor = System.Drawing.Color.Sienna;
            this.btnLogIn.Location = new System.Drawing.Point(321, 176);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(359, 100);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Iniciar Sesion";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(387, 336);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(247, 39);
            this.txtResult.TabIndex = 5;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 402);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grpIngreso);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            this.grpIngreso.ResumeLayout(false);
            this.grpIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpIngreso;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtResult;
    }
}