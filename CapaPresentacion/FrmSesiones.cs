using CapaNegocio;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static CapaPresentacion.FrmLogin;

namespace CapaPresentacion
{
    public partial class FrmSesiones : Form
    {
        public FrmSesiones()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
        }

        private void FrmSesiones_Load(object sender, EventArgs e)
        {
            CargarSesiones();
        }

        private void CargarSesiones()
        {
            DataTable dt = CNLogin.ListarSesiones();
            dgvSesiones.DataSource = dt;

            // 🔹 Personalización de columnas
            dgvSesiones.Columns["id"].HeaderText = "ID";
            dgvSesiones.Columns["nombre"].HeaderText = "Empleado";
            dgvSesiones.Columns["fecha_inicio"].HeaderText = "Hora Inicio";
            dgvSesiones.Columns["fecha_fin"].HeaderText = "Hora Fin";
            dgvSesiones.Columns["tiempo_total_minutos"].HeaderText = "Tiempo (Min)";
            dgvSesiones.Columns["estado"].HeaderText = "Estado";

            dgvSesiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarSesiones();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            // Registrar fin de sesión
            if (SesionActual.SesionId > 0)
            {
                CNLogin.RegistrarFin(SesionActual.SesionId);
            }

            // Volver al login
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Close();
        }
    }

}

