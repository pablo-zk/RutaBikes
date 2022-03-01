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
    public partial class FrmSelectTrip : Form
    {
        public FrmSelectTrip()
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
                    Viaje viaje = Program.gestor.FinalizarViaje(Program.userActive.id, int.Parse(idAnclaje), DateTime.Now, out string error);
                    MessageBox.Show(error == "" ?
                        $"Viaje finalizado con exito\n" +
                        $"Origen: {viaje.Anclaje.Estacion.ubicacion}\n" +
                        $"Destino: {viaje.Anclaje1.Estacion.ubicacion}\n" +
                        $"Fecha inicio: {viaje.fechaInicio}\n" +
                        $"Fecha fin: {viaje.fechaFin}\n" +
                        $"Precio: {viaje.precio}\n" +
                        $"Para más información dirigete a 'Mis viajes'" :
                        error);
                    if (error == "")
                    {
                        Close();
                    }
                    
                }
                else
                {
                    string result = Program.gestor.IniciarViaje(Program.userActive.id, int.Parse(idAnclaje), DateTime.Now);
                    MessageBox.Show(result);
                    if (result.Contains("creado"))
                    {
                        Close();
                    }
                    
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

        private void FrmSelectTrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome frmH = new FrmHome();
            frmH.Visible = true;
        }
    }
}
