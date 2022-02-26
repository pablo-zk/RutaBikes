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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            grpSignup.Visible = false;
            txtPass.PasswordChar = '*';
            txtSignPass.PasswordChar = '*';
            txtSignRepeatPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return;
            }
            Usuario userActive = Program.gestor.Login(txtEmail.Text, txtPass.Text);
            if (userActive != null)
            {
                Program.userActive = userActive;
                FrmHome frm = new FrmHome();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrecto.");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpLogin.Visible = false;
            grpSignup.Visible = true;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpLogin.Show();
            grpSignup.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSignMail.Text) || String.IsNullOrWhiteSpace(txtSignPass.Text) || String.IsNullOrWhiteSpace(txtSignRepeatPass.Text) || String.IsNullOrWhiteSpace(txtSignTelefono.Text) || String.IsNullOrWhiteSpace(txtSignNumCuenta.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return;
            }
            if (!txtSignPass.Text.Equals(txtSignRepeatPass.Text))
            {
                MessageBox.Show("Las contraseñas deben coincidir");
                return;
            }
            if(!int.TryParse(txtSignTelefono.Text,out int telefonoInt) || txtSignTelefono.Text.Length != 9){
                MessageBox.Show("Número de teléfono inválido");
                return;
            }
            if (txtSignNumCuenta.Text.Length != 20)
            {
                MessageBox.Show("Número de cuenta inválido");
                return;
            }
            //Le paso como monedero 0€. Pensar si poner otro txt o frm con los datos de la cuenta y que meta el diner qeu tiene
            Usuario newUserActive = Program.gestor.Register(txtSignMail.Text, txtSignPass.Text,telefonoInt,txtSignNumCuenta.Text,0, out string error);
            if (newUserActive != null)
            {
                Program.userActive = newUserActive;
                FrmHome frm = new FrmHome();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
