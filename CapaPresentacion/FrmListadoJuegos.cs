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
    public partial class FrmListadoJuegos : Form
    {
        public FrmListadoJuegos()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            dlistado.DataSource = CNJuego.Listar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarJuego form = new FrmRegistrarJuego();
            form.Insert = true;
            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarJuego form = new FrmRegistrarJuego();

            form.Edit = true;

            form.txtidjuego.Text = this.dlistado.CurrentRow.Cells["id"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txttipo.Text = this.dlistado.CurrentRow.Cells["tipo"].Value.ToString();

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?", "Sistema de casino", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlistado.SelectedRows.Count > 0)
                {
                    string idjuego = dlistado.SelectedRows[0].Cells["id"].Value.ToString();
                    CNJuego.Eliminar(Convert.ToInt32(idjuego));

                    MessageBox.Show("Registro eliminado correctamente");
                    Mostrar();
                }
                Mostrar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmListadoJuegos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmListadoInformes form = new FrmListadoInformes();
            form.Show();
            this.Close();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        // Método para buscar clientes por nombre en el DataGridView
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNJuego.BuscarJuegoNombre(this.txtbusqueda.Text);
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarNombre();
        }
    }
}
