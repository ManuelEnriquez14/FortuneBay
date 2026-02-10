using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoClientes : Form
    {
        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNCliente.Listar();
        }

        // Método para buscar clientes por nombre en el DataGridView
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNCliente.BuscarNombre(this.txtbuscar.Text);
        }

        public void BuscarDni()
        {
            this.dlistado.DataSource = CNCliente.BuscarDni(this.txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtndni.Checked)
            {
                BuscarDni();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda.", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Edit = true;

            form.txtidcliente.Text = this.dlistado.CurrentRow.Cells["id"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtfechanac.Text = this.dlistado.CurrentRow.Cells["fecha_nac"].Value.ToString();
            form.txtdocumento.Text = this.dlistado.CurrentRow.Cells["documento"].Value.ToString();
            form.txtemail.Text = this.dlistado.CurrentRow.Cells["email"].Value.ToString();

            string estatus = this.dlistado.CurrentRow.Cells["estatus"].Value.ToString();

            if (estatus == "ACTIVO")
            {
                form.rbtactivo.Checked = true;
            }
            else
            {
                form.rbtinactivo.Checked = true;
            }

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlistado.SelectedRows.Count > 0)
                {
                    string idcliente = dlistado.SelectedRows[0].Cells["id"].Value.ToString();
                    CNCliente.Eliminar(Convert.ToInt32(idcliente));

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
