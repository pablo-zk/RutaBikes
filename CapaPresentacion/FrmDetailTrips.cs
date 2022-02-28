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
                EstacionOrigen = viaje.estacionOrigen + " - " + viaje.idAnclajeIni,
                EstacionDestino = viaje.estacionDestino == null ? "-" : viaje.estacionDestino + " - " + viaje.idAnclajeFin,
                FechaIncial = viaje.fechaInicio == new DateTime()? "-" : viaje.fechaInicio.ToString(),
                FechaFin = viaje.fechaFin == new DateTime() ? "-" : viaje.fechaFin.ToString(),
                Precio = viaje.precio,
                Estado = viaje.estacionDestino == null ? "En curso" : "Finalizado"
            }).ToArray();
        }
    }
}
