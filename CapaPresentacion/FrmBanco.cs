using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            string numCuenta = Program.userActive.numCuenta;
            lbl1.Text = numCuenta.Substring(0, 5);
            lbl2.Text = numCuenta.Substring(5, 5);
            lbl3.Text = numCuenta.Substring(10, 5);
            lbl4.Text = numCuenta.Substring(15, 5);
            lblSaldo.Text = $"Saldo - {Program.userActive.monedero:0.##}€";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            string pass = Interaction.InputBox("Verificación", "Introduce contraseña", "");

            if (!pass.Equals(Program.userActive.contrasena))
            {
                MessageBox.Show("Contraseña incorrecta. Introduce otra.");
                return;
            }
            if (!double.TryParse(txtCantidad.Text.Replace('.',','),out double cantidad))
            {
                MessageBox.Show("Número incorrecto. Introduzca un valor numérico.");
                return;
            }
            if(cantidad > 25 || cantidad <= 0)
            {
                MessageBox.Show("Recuerda que únicamente se permite una cantidad máxima de 25€ por cada recarga.");
                return;
            }
            if (Program.gestor.RecargarMondedero(Program.userActive.id, cantidad))
            {
                MessageBox.Show("Recarga completada. Saldo actual: " + Program.userActive.monedero);
                Close();
            }
            else
            {
                MessageBox.Show("Error. No se ha podido completar la recarga. Intentelo de nuevo más tarde.");
            }
        }
    }
}
