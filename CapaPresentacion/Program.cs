using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDatos;

namespace CapaPresentacion
{
    static class Program
    {
        static public Gestion gestor = new Gestion();
        static public GestionDS gestorDS;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            gestorDS = new GestionDS(out string error);
            if (error != "")
            {
                MessageBox.Show("ERROR en la lectura de la base de datos. Motivo: " + error);
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
