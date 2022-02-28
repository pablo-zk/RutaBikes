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
            List<EstacionDTO> estaciones = Program.gestorDS.ObtenerEstaciones();
            dgvEstaciones.DataSource = estaciones.Select(est => new
            {
                NumEstacion = est.id,
                Ubicacion = est.ubicacion,
                AnclajesLibres = est.anclajes.Count(a => a.idBici == null),
                BicisDisponibles = est.anclajes.Count(a => a.idBici != null),
            }).ToArray();
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
            List<Anclaje> anclajes = Program.gestorDS.ObtenerAnclajesDeEstacion(int.Parse(idEstacion));
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
            string idAnclajeIni = dgvAnclaje.CurrentRow.Cells["IdentificadorAnclaje"].Value.ToString();
            if (idAnclajeIni != null)
            {
                string result = Program.gestor.IniciarViaje(Program.userActive.id, int.Parse(idAnclajeIni), new DateTime());
                MessageBox.Show(result);
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
    }
}
