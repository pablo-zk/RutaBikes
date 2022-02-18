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
using CapaDatos;

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
            List<Estacion> estaciones = Program.gestor.ObtenerEstaciones();
            dgvEstaciones.DataSource = estaciones.Select(est => new
            {
                NumEstacion = est.id,
                Ubicacion = est.ubicacion,
                AnclajesLibres = est.Anclajes.Count(a => a.idBici == null),
                BicisDisponibles = est.Anclajes.Count(a => a.idBici != null),
            }).ToArray();
        }

        private void dgvEstaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAnclaje.DataSource = "";
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgvEstaciones.CurrentRow;
            if (row == null)
            {
                return;
            }
            string idEstacion = row.Cells["NumEstacion"].Value.ToString();
            List<Anclaje> anclajes = Program.gestor.ObtenerAnclajesDeEstacion(int.Parse(idEstacion));
            dgvAnclaje.DataSource = anclajes.Select(a => new { 
                Bicicletas = a.idBici == null ? "Libre" : a.idBici,
            }).ToArray();
        }
    }
}
