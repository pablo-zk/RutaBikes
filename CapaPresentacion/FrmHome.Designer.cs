
namespace CapaPresentacion
{
    partial class FrmHome
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnclaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstaciones
            // 
            this.dgvEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstaciones.Location = new System.Drawing.Point(37, 107);
            this.dgvEstaciones.Name = "dgvEstaciones";
            this.dgvEstaciones.Size = new System.Drawing.Size(421, 150);
            this.dgvEstaciones.TabIndex = 0;
            this.dgvEstaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstaciones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTACIONES";
            // 
            // dgvAnclaje
            // 
            this.dgvAnclaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnclaje.Location = new System.Drawing.Point(330, 272);
            this.dgvAnclaje.Name = "dgvAnclaje";
            this.dgvAnclaje.Size = new System.Drawing.Size(421, 150);
            this.dgvAnclaje.TabIndex = 2;
            // 
            // lblAnclaje
            // 
            this.lblAnclaje.AutoSize = true;
            this.lblAnclaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnclaje.Location = new System.Drawing.Point(651, 237);
            this.lblAnclaje.Name = "lblAnclaje";
            this.lblAnclaje.Size = new System.Drawing.Size(100, 20);
            this.lblAnclaje.TabIndex = 3;
            this.lblAnclaje.Text = "ANCLAJES";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnclaje);
            this.Controls.Add(this.dgvAnclaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstaciones);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnclaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnclaje;
        private System.Windows.Forms.Label lblAnclaje;
    }
}