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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }


        private void FrmUser_Load(object sender, EventArgs e)
        {
            chkCambiarPass.Checked = false;
            grpCambiarPass.Enabled = false;
            txtEmail.Text = Program.userActive.email;
            txtTelefono.Text = Program.userActive.telefono.ToString();
            txtNumCuenta.Text = Program.userActive.numCuenta;
            txtContrasena.PasswordChar = '*';
            txtRepContrasena.PasswordChar = '*';
        }

        private void chkCambiarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCambiarPass.Checked)
            {
                grpCambiarPass.Enabled = true;
            }
            else
            {
                grpCambiarPass.Enabled = false;
            }
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome frmH = new FrmHome();
            frmH.Visible = true;
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtTelefono.Text.Equals("") || txtNumCuenta.Text.Equals(""))
            {
                MessageBox.Show("No puede haber datos vacíos.");
                return;
            }
            if (!int.TryParse(txtTelefono.Text, out int telefonoInt) || txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("Número de teléfono inválido");
                return;
            }
            if (txtNumCuenta.Text.Length != 20)
            {
                MessageBox.Show("Número de cuenta inválido");
                return;
            }
            Usuario userFinal;
            string error;
            if (chkCambiarPass.Checked)
            {
                if (txtContrasena.Text.Equals("") || txtRepContrasena.Text.Equals("") || !txtContrasena.Text.Equals(txtRepContrasena.Text))
                {
                    MessageBox.Show("Contraseñas no coinciden.");
                    return;
                }
                userFinal = Program.gestor.ModificarUsuario(Program.userActive.id, txtEmail.Text, telefonoInt, txtNumCuenta.Text, txtContrasena.Text, out error);
            }
            else
            {
                userFinal = Program.gestor.ModificarUsuario(Program.userActive.id, txtEmail.Text, telefonoInt, txtNumCuenta.Text, out error);
            }
            if (userFinal == null)
            {
                MessageBox.Show(error);
                return;
            }
            Program.userActive = userFinal;
            MessageBox.Show("Usuario modificado correctamente.");
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
