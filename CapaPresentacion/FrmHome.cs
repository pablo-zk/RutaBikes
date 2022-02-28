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
            this.Text = $"Bienvenido {Program.userActive.email}!!";
            List<Estacion> estaciones = Program.gestor.ObtenerEstaciones();
            dgvEstaciones.DataSource = estaciones.Select(est => new
            {
                NumEstacion = est.id,
                Ubicacion = est.ubicacion,
                AnclajesLibres = est.Anclajes.Count(a => a.idBici == null),
                BicisDisponibles = est.Anclajes.Count(a => a.idBici != null),
            }).ToArray();
            if (Program.gestor.UserHasActiveTrip(Program.userActive.id)){
                btnIniciarViaje.Text = "CERRAR VIAJE";
            }
            btnIniciarViaje.Enabled = false;
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
            btnIniciarViaje.Enabled = true;
            string idEstacion = row.Cells["NumEstacion"].Value.ToString();
            List<Anclaje> anclajes = Program.gestor.ObtenerAnclajesDeEstacion(int.Parse(idEstacion));
            dgvAnclaje.DataSource = anclajes.Select(a => new { 
                IdentificadorAnclaje = a.id,
                Bicicletas = a.idBici == null ? "Libre" : a.idBici,
            }).ToArray();
        }

        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            if(dgvAnclaje.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar una estación y después una bicicleta");
                return;
            }
            string idAnclaje = dgvAnclaje.CurrentRow.Cells["IdentificadorAnclaje"].Value.ToString();
            string idBici = dgvAnclaje.CurrentRow.Cells["Bicicletas"].Value.ToString();
            if (idAnclaje != null)
            {
                if (btnIniciarViaje.Text.Contains("CERRAR"))
                {
                    string result = Program.gestor.FinalizarViaje(Program.userActive.id, int.Parse(idAnclaje), DateTime.Now);
                    MessageBox.Show(result);
                }
                else
                {
                    string result = Program.gestor.IniciarViaje(Program.userActive.id, int.Parse(idAnclaje), DateTime.Now, idBici);
                    MessageBox.Show(result);
                }
            }
            //NO ME CONVENCE NADA
            if (Program.gestor.UserHasActiveTrip(Program.userActive.id))
            {
                btnIniciarViaje.Text = "CERRAR VIAJE";
            }
            else
            {
                btnIniciarViaje.Text = "ABRIR VIAJE";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.userActive = null;
            //TODO No sé si se abren 500000 formularios de inicio de sesión o solo se muestra el primero que le hacemos Hide()
            FrmLogin frm = new FrmLogin();
            frm.Show();
            Close();
        }

        private void misViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetailTrips frm = new FrmDetailTrips();
            frm.Show();
        }
    }
}
