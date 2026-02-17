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
    public partial class FrmListadoInformes : Form
    {
        public FrmListadoInformes()
        {
            InitializeComponent();
        }

        private void FrmListadoInformes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            MostrarAuditoria();

        }

        private void MostrarAuditoria()
        {
            dlistado.DataSource = CNAuditoria.Listar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmListadoClientes form = new FrmListadoClientes();
            form.Show();
            this.Hide();
        }
    }
}
