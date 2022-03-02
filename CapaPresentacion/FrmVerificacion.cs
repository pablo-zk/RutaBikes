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
    public partial class FrmVerificacion : Form
    {
        public FrmVerificacion()
        {
            InitializeComponent();
        }


        private void FrmVerificacion_Load(object sender, EventArgs e)
        {
            txtVerifyPass.PasswordChar = '*';
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Program.userActive.contrasena != txtVerifyPass.Text)
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
