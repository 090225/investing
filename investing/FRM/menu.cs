using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investing.FRM
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMALMACEN frm = new FRMALMACEN();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMCLIENTES clientes = new FRMCLIENTES();
            clientes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRMCOMPRAS compras = new FRMCOMPRAS();
            compras.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRMPRODUCTOS productos = new FRMPRODUCTOS();
            productos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRMPROVEDORES proveedores = new FRMPROVEDORES();    
            proveedores.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMUNIDAD unidad = new FRMUNIDAD();
            unidad.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRMVENTAS VENTAS = new FRMVENTAS();
            VENTAS.Show();
        }
    }
}
