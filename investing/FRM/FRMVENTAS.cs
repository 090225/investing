using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investing.FRM
{
    public partial class FRMVENTAS : Form
    {
        public FRMVENTAS()
        {
            InitializeComponent();
            Cliente();
            ALMACEN();
            tipodocto();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FRMVENTAS_Load(object sender, EventArgs e)
        {

        }

        private void DTGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Cliente()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CL_ID FROM CLIENTES", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBCliente.Items.Add(registro["CL_ID"].ToString());
            }
            con.Close();
        }

        private void tipodocto()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_TIPODOCTO FROM TIPO_DOCUMENTO", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBtipDocumento.Items.Add(registro["ID_TIPODOCTO"].ToString());
            }
            con.Close();
        }
       
        private void ALMACEN()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT AL_ID FROM ALMACENES", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBAlmacen.Items.Add(registro["AL_ID"].ToString());
            }
            con.Close();
        }
    }
}
