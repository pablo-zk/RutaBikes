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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return;
            }
            if (Program.gestor.Login(txtEmail.Text, txtContrasena.Text))
            {
                FrmHome frm = new FrmHome();
                this.Hide();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrecto.");
            }
        }
    }
}
