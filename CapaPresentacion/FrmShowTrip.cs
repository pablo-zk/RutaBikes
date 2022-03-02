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
    public partial class FrmShowTrip : Form
    {
        string idViaje = "";
        public FrmShowTrip(string idViaje)
        {
            this.idViaje = idViaje;
            InitializeComponent();
        }

        private void FrmShowTrip_Load(object sender, EventArgs e)
        {
            ViajeDTO trip = Program.gestorDS.ObtenerViajePorId(int.Parse(idViaje));

            lblUbicI.Text = trip.estacionOrigen;
            lblUbicD.Text = trip.estacionDestino == null ? "En curso" : trip.estacionDestino;

            lblFechaI.Text = $"{trip.fechaInicio}";
            lblFechaD.Text = trip.fechaFin == new DateTime() ? "En curso" : $"{trip.fechaFin}";
            lblPrecio.Text = $"Precio - {trip.precio:0.##}€";
        }

    }
}
