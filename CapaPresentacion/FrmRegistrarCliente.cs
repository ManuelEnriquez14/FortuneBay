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
    public partial class FrmRegistrarCliente : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            bool estatus = rbtactivo.Checked ? true : false;

            try
            {
                if (this.txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el nombre del cliente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Registrar(this.txtnombre.Text,
                            Convert.ToDateTime(this.txtfechanac.Text),
                            this.txtdocumento.Text,
                            this.txttelefono.Text,
                            estatus,
                            this.txtemail.Text);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(Convert.ToInt32(this.txtidcliente.Text),
                            this.txtnombre.Text,
                            this.txtdocumento.Text,
                            Convert.ToDateTime(this.txtfechanac.Text),
                            this.txttelefono.Text,
                            estatus,
                            this.txtemail.Text
                        );

                        MessageBox.Show("Cliente editado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoClientes form = new FrmListadoClientes();
                    form.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoClientes form = new FrmListadoClientes();
            form.Show();
            this.Hide();

        }
    }
    }
