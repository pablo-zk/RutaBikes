
namespace CapaPresentacion
{
    partial class FrmSelectTrip
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
            this.dgvEstaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAnclaje = new System.Windows.Forms.DataGridView();
            this.lblAnclaje = new System.Windows.Forms.Label();
            this.btnIniciarViaje = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnclaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstaciones
            // 
            this.dgvEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstaciones.Location = new System.Drawing.Point(315, 74);
            this.dgvEstaciones.Name = "dgvEstaciones";
            this.dgvEstaciones.Size = new System.Drawing.Size(436, 150);
            this.dgvEstaciones.TabIndex = 0;
            this.dgvEstaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstaciones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTACIONES";
            // 
            // dgvAnclaje
            // 
            this.dgvAnclaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnclaje.Location = new System.Drawing.Point(315, 275);
            this.dgvAnclaje.Name = "dgvAnclaje";
            this.dgvAnclaje.Size = new System.Drawing.Size(436, 150);
            this.dgvAnclaje.TabIndex = 2;
            // 
            // lblAnclaje
            // 
            this.lblAnclaje.AutoSize = true;
            this.lblAnclaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnclaje.Location = new System.Drawing.Point(622, 247);
            this.lblAnclaje.Name = "lblAnclaje";
            this.lblAnclaje.Size = new System.Drawing.Size(129, 25);
            this.lblAnclaje.TabIndex = 3;
            this.lblAnclaje.Text = "ANCLAJES";
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnIniciarViaje.FlatAppearance.BorderSize = 0;
            this.btnIniciarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarViaje.Location = new System.Drawing.Point(73, 333);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Size = new System.Drawing.Size(156, 48);
            this.btnIniciarViaje.TabIndex = 4;
            this.btnIniciarViaje.Text = "ABRIR VIAJE";
            this.btnIniciarViaje.UseVisualStyleBackColor = false;
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.FotoTripSelectB;
            this.pictureBox1.Location = new System.Drawing.Point(-79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSelectTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarViaje);
            this.Controls.Add(this.lblAnclaje);
            this.Controls.Add(this.dgvAnclaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstaciones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSelectTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSelectTrip_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnclaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnclaje;
        private System.Windows.Forms.Label lblAnclaje;
        private System.Windows.Forms.Button btnIniciarViaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}