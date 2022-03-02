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
                this.Visible = false;
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
            if (!IsValidEmail(txtSignMail.Text))
            {
                MessageBox.Show("Email incorrecto");
                return;
            } 
            Usuario newUserActive = Program.gestor.Register(txtSignMail.Text, txtSignPass.Text,telefonoInt,txtSignNumCuenta.Text,0, out string error);
            if (newUserActive != null)
            {
                Program.userActive = newUserActive;
                FrmHome frm = new FrmHome();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void grpSignup_Enter(object sender, EventArgs e)
        {

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtSignPass.PasswordChar = '\0';
                txtSignRepeatPass.PasswordChar = '\0';
            }
            else
            {
                txtSignPass.PasswordChar = '*';
                txtSignRepeatPass.PasswordChar = '*';
            }
        }

        private void chkShowPassL_CheckedChanged(object sender, EventArgs e)
        {   
            if (chkShowPassL.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
