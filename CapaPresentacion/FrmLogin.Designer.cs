
namespace CapaPresentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignRepeatPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSignPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSignNumCuenta = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.chkShowPassL = new System.Windows.Forms.CheckBox();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSignup = new System.Windows.Forms.GroupBox();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(30, 247);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(138, 244);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 22);
            this.txtPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(98, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "INICIA SESIÓN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(102, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignup.Location = new System.Drawing.Point(105, 313);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(142, 36);
            this.btnSignup.TabIndex = 15;
            this.btnSignup.Text = "Registrarse";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegistrarse.Location = new System.Drawing.Point(107, 37);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(139, 24);
            this.lblRegistrarse.TabIndex = 14;
            this.lblRegistrarse.Text = "REGÍSTRATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Repetir contraseña";
            // 
            // txtSignRepeatPass
            // 
            this.txtSignRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignRepeatPass.Location = new System.Drawing.Point(164, 169);
            this.txtSignRepeatPass.Name = "txtSignRepeatPass";
            this.txtSignRepeatPass.Size = new System.Drawing.Size(148, 22);
            this.txtSignRepeatPass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // txtSignPass
            // 
            this.txtSignPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPass.Location = new System.Drawing.Point(134, 123);
            this.txtSignPass.Name = "txtSignPass";
            this.txtSignPass.Size = new System.Drawing.Size(178, 22);
            this.txtSignPass.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // txtSignMail
            // 
            this.txtSignMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignMail.Location = new System.Drawing.Point(134, 77);
            this.txtSignMail.Name = "txtSignMail";
            this.txtSignMail.Size = new System.Drawing.Size(178, 22);
            this.txtSignMail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teléfono";
            // 
            // txtSignTelefono
            // 
            this.txtSignTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignTelefono.Location = new System.Drawing.Point(134, 216);
            this.txtSignTelefono.Name = "txtSignTelefono";
            this.txtSignTelefono.Size = new System.Drawing.Size(178, 22);
            this.txtSignTelefono.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Numero cuenta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSignNumCuenta
            // 
            this.txtSignNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignNumCuenta.Location = new System.Drawing.Point(149, 263);
            this.txtSignNumCuenta.Name = "txtSignNumCuenta";
            this.txtSignNumCuenta.Size = new System.Drawing.Size(163, 22);
            this.txtSignNumCuenta.TabIndex = 18;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.chkShowPassL);
            this.grpLogin.Controls.Add(this.linkSignup);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.pictureBox1);
            this.grpLogin.Location = new System.Drawing.Point(0, -6);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(347, 423);
            this.grpLogin.TabIndex = 20;
            this.grpLogin.TabStop = false;
            // 
            // chkShowPassL
            // 
            this.chkShowPassL.AutoSize = true;
            this.chkShowPassL.Location = new System.Drawing.Point(322, 249);
            this.chkShowPassL.Name = "chkShowPassL";
            this.chkShowPassL.Size = new System.Drawing.Size(15, 14);
            this.chkShowPassL.TabIndex = 25;
            this.chkShowPassL.UseVisualStyleBackColor = true;
            this.chkShowPassL.CheckedChanged += new System.EventHandler(this.chkShowPassL_CheckedChanged);
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.Location = new System.Drawing.Point(143, 356);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(60, 13);
            this.linkSignup.TabIndex = 23;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Registrarse";
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignup_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(51, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // grpSignup
            // 
            this.grpSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpSignup.Controls.Add(this.chkShowPass);
            this.grpSignup.Controls.Add(this.lblRegistrarse);
            this.grpSignup.Controls.Add(this.linkLogin);
            this.grpSignup.Controls.Add(this.label7);
            this.grpSignup.Controls.Add(this.txtSignMail);
            this.grpSignup.Controls.Add(this.txtSignNumCuenta);
            this.grpSignup.Controls.Add(this.label6);
            this.grpSignup.Controls.Add(this.label3);
            this.grpSignup.Controls.Add(this.txtSignPass);
            this.grpSignup.Controls.Add(this.txtSignTelefono);
            this.grpSignup.Controls.Add(this.label5);
            this.grpSignup.Controls.Add(this.btnSignup);
            this.grpSignup.Controls.Add(this.txtSignRepeatPass);
            this.grpSignup.Controls.Add(this.label2);
            this.grpSignup.Location = new System.Drawing.Point(0, -6);
            this.grpSignup.Name = "grpSignup";
            this.grpSignup.Size = new System.Drawing.Size(347, 421);
            this.grpSignup.TabIndex = 21;
            this.grpSignup.TabStop = false;
            this.grpSignup.Enter += new System.EventHandler(this.grpSignup_Enter);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(318, 149);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(15, 14);
            this.chkShowPass.TabIndex = 23;
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Location = new System.Drawing.Point(123, 359);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(107, 13);
            this.linkLogin.TabIndex = 22;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Ya tengo una cuenta";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(345, 412);
            this.Controls.Add(this.grpSignup);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSignup.ResumeLayout(false);
            this.grpSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignRepeatPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSignPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSignTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSignNumCuenta;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.LinkLabel linkSignup;
        private System.Windows.Forms.GroupBox grpSignup;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.CheckBox chkShowPassL;
    }
}

