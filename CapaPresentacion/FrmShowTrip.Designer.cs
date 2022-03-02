
namespace CapaPresentacion
{
    partial class FrmShowTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowTrip));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUbicD = new System.Windows.Forms.Label();
            this.lblUbicI = new System.Windows.Forms.Label();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.lblFechaD = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIAJE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.linea_viaje;
            this.pictureBox2.Location = new System.Drawing.Point(47, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.FotoViaje;
            this.pictureBox1.Location = new System.Drawing.Point(233, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUbicD
            // 
            this.lblUbicD.AutoSize = true;
            this.lblUbicD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicD.Location = new System.Drawing.Point(79, 211);
            this.lblUbicD.Name = "lblUbicD";
            this.lblUbicD.Size = new System.Drawing.Size(97, 25);
            this.lblUbicD.TabIndex = 5;
            this.lblUbicD.Text = "En curso";
            // 
            // lblUbicI
            // 
            this.lblUbicI.AutoSize = true;
            this.lblUbicI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicI.Location = new System.Drawing.Point(79, 132);
            this.lblUbicI.Name = "lblUbicI";
            this.lblUbicI.Size = new System.Drawing.Size(76, 25);
            this.lblUbicI.TabIndex = 2;
            this.lblUbicI.Text = "Villava";
            // 
            // lblFechaI
            // 
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaI.Location = new System.Drawing.Point(82, 160);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(49, 20);
            this.lblFechaI.TabIndex = 6;
            this.lblFechaI.Text = "10:30";
            // 
            // lblFechaD
            // 
            this.lblFechaD.AutoSize = true;
            this.lblFechaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaD.Location = new System.Drawing.Point(79, 238);
            this.lblFechaD.Name = "lblFechaD";
            this.lblFechaD.Size = new System.Drawing.Size(72, 20);
            this.lblFechaD.TabIndex = 7;
            this.lblFechaD.Text = "En curso";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(66, 339);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(134, 25);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio - 2.5€";
            // 
            // FrmShowTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblFechaD);
            this.Controls.Add(this.lblFechaI);
            this.Controls.Add(this.lblUbicD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblUbicI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmShowTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver viaje";
            this.Load += new System.EventHandler(this.FrmShowTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUbicD;
        private System.Windows.Forms.Label lblUbicI;
        private System.Windows.Forms.Label lblFechaI;
        private System.Windows.Forms.Label lblFechaD;
        private System.Windows.Forms.Label lblPrecio;
    }
}