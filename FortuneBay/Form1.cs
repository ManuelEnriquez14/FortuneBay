using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace FortuneBay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(CDTestConexion.Probar());
            MessageBox.Show(CDPruebaClientes.ProbarListar());
            MessageBox.Show(CDPruebaExisteSP.Existe("dbo.sp_registrar_cliente"));
            MessageBox.Show(CDPruebaInsertCliente.ProbarInsert());

        }
    }
}