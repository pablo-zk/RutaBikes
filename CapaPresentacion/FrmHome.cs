using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenid@ {Program.userActive.email}";
            if (Program.gestor.UserHasActiveTrip(Program.userActive.id))
            {
                btnViaje.Text = "Terminar Viaje";
            }
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {
            FrmSelectTrip frmST = new FrmSelectTrip();
            frmST.Show();
            this.Visible = false;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmDetailTrips frmD = new FrmDetailTrips();
            frmD.Show();
            this.Visible = false;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.Show();
            this.Visible = false;
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmLogin frmL = new FrmLogin();
            //frmL.Visible = true;
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.userActive = null;
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Visible = false;
        }
    }
}
