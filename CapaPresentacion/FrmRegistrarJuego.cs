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
    public partial class FrmRegistrarJuego : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarJuego()
        {
            InitializeComponent();
        }

        private void FrmRegistrarJuego_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtnombre.Text == string.Empty || this.txttipo.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el nombre del juego", "Sistema de Casino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNJuego.Registrar(this.txtnombre.Text, this.txttipo.Text);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Casino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNJuego.Editar(Convert.ToInt32(this.txtidjuego.Text),
                            this.txtnombre.Text,
                            this.txttipo.Text);

                        MessageBox.Show("Cliente editado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoJuegos form = new FrmListadoJuegos();
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
            FrmListadoJuegos form = new FrmListadoJuegos();
            form.Show();
            this.Hide();
        }
    }
}
