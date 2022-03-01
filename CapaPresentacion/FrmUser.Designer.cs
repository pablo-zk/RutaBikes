
namespace CapaPresentacion
{
    partial class FrmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepContrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCambiarPass = new System.Windows.Forms.GroupBox();
            this.chkCambiarPass = new System.Windows.Forms.CheckBox();
            this.grpCambiarPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(71, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(71, 213);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(187, 20);
            this.txtNumCuenta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de cuenta";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(17, 39);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(187, 20);
            this.txtContrasena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña nueva";
            // 
            // txtRepContrasena
            // 
            this.txtRepContrasena.Location = new System.Drawing.Point(17, 94);
            this.txtRepContrasena.Name = "txtRepContrasena";
            this.txtRepContrasena.Size = new System.Drawing.Size(187, 20);
            this.txtRepContrasena.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Repetir contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "MODIFICAR INFORMACIÓN";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(184, 429);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(72, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpCambiarPass
            // 
            this.grpCambiarPass.Controls.Add(this.txtRepContrasena);
            this.grpCambiarPass.Controls.Add(this.label4);
            this.grpCambiarPass.Controls.Add(this.txtContrasena);
            this.grpCambiarPass.Controls.Add(this.label5);
            this.grpCambiarPass.Location = new System.Drawing.Point(54, 276);
            this.grpCambiarPass.Name = "grpCambiarPass";
            this.grpCambiarPass.Size = new System.Drawing.Size(218, 132);
            this.grpCambiarPass.TabIndex = 14;
            this.grpCambiarPass.TabStop = false;
            // 
            // chkCambiarPass
            // 
            this.chkCambiarPass.AutoSize = true;
            this.chkCambiarPass.Location = new System.Drawing.Point(54, 253);
            this.chkCambiarPass.Name = "chkCambiarPass";
            this.chkCambiarPass.Size = new System.Drawing.Size(120, 17);
            this.chkCambiarPass.TabIndex = 0;
            this.chkCambiarPass.Text = "Cambiar contraseña";
            this.chkCambiarPass.UseVisualStyleBackColor = true;
            this.chkCambiarPass.CheckedChanged += new System.EventHandler(this.chkCambiarPass_CheckedChanged);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 482);
            this.Controls.Add(this.chkCambiarPass);
            this.Controls.Add(this.grpCambiarPass);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.grpCambiarPass.ResumeLayout(false);
            this.grpCambiarPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepContrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpCambiarPass;
        private System.Windows.Forms.CheckBox chkCambiarPass;
    }
}