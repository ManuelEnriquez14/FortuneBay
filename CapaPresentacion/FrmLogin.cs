using CapaNegocio;
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
        public static class SesionActual
        {
            public static int EmpleadoId { get; set; }
            public static int SesionId { get; set; }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmAccesoInformes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            DataTable resultado = CNLogin.Login(username, password);

            if (resultado.Rows.Count > 0)
            {
                int empleadoId = Convert.ToInt32(resultado.Rows[0]["id"]);

                // Guardamos empleado actual
                SesionActual.EmpleadoId = empleadoId;

                // Registramos inicio de sesión
                SesionActual.SesionId = CNLogin.RegistrarInicio(empleadoId);

                // Login correcto
                FrmSesiones frm = new FrmSesiones();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas",
                    "Acceso Denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmListadoClientes form = new FrmListadoClientes();
            form.Show();
            this.Hide();
        }

    }
}
