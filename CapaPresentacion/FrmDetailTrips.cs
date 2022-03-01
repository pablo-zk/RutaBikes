using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CapaPresentacion
{
    public partial class FrmDetailTrips : Form
    {
        public FrmDetailTrips()
        {
            InitializeComponent();
        }

        private void FrmDetailTrips_Load(object sender, EventArgs e)
        {
            
            List<ViajeDTO> viajes = Program.gestorDS.HistorialViajesUser(Program.userActive.id);
            dgvTrips.DataSource = viajes.Select(viaje => new
            {
                IdViaje = viaje.id,
                FechaIncial = viaje.fechaInicio == new DateTime() ? "-" : viaje.fechaInicio.Date.ToShortDateString(),
                EstacionOrigen = viaje.estacionOrigen + " - " + viaje.idAnclajeIni,
                EstacionDestino = viaje.estacionDestino == null ? "-" : viaje.estacionDestino + " - " + viaje.idAnclajeFin,
                Estado = viaje.estacionDestino == null ? "En curso" : "Finalizado"
            }).ToArray();
            dgvTrips.Columns["IdViaje"].Visible = false;
        }
        private void FrmDetailTrips_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Visible = true;
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTrips.CurrentRow;
            if (row == null)
            {
                return;
            }
            string idViaje = row.Cells["IdViaje"].Value.ToString();
            string estacionO = row.Cells["EstacionOrigen"].Value.ToString();
            string estacionD = row.Cells["EstacionDestino"].Value.ToString();

            DialogResult respuesta = MessageBox.Show($"¿Seguro que quieres ver la información del viaje {estacionO} - {estacionD}?", "", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                FrmShowTrip frm = new FrmShowTrip(idViaje);
                frm.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
