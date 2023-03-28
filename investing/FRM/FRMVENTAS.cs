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
        private void Guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTA";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@TMP_ID_CLIENTE", CMBCliente.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_ALMACEN", CMBAlmacen.Text);
            cmd.Parameters.AddWithValue("@TMP_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@TMP_SERIE", TxtSerie.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_TIPODOCT", CMBtipDocumento.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_PRODUCTO", TXTPRODUCTO.Text); cmd.Parameters.AddWithValue("@TMP_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@TMP_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@TMP_IVA", TXTIVA.Text);
            cmd.Parameters.AddWithValue("@CO_FECHA", Convert.ToDateTime(DTPFECHA.Text));
            cmd.Parameters.AddWithValue("@TMP_MONTO", TxtMonto.Text);




            MessageBox.Show("SUS DATOS SE GUARDARON");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO SE guardaron" + EX);

            }
            finally
            {
                con.Close();
            }

        }
        private void GuardarV()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VENTA";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@TMP_ID_CLIENTE", CMBCliente.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_ALMACEN", CMBAlmacen.Text);
            cmd.Parameters.AddWithValue("@TMP_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@TMP_SERIE", TxtSerie.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_TIPODOCT", CMBtipDocumento.Text);
            cmd.Parameters.AddWithValue("@TMP_ID_PRODUCTO", TXTPRODUCTO.Text); cmd.Parameters.AddWithValue("@TMP_CANTIDAD", TXTCANTIDAD.Text);
            cmd.Parameters.AddWithValue("@TMP_IMPORTE", TXTIMPORTE.Text);
            cmd.Parameters.AddWithValue("@TMP_IVA", TXTIVA.Text);
            cmd.Parameters.AddWithValue("@CO_FECHA", Convert.ToDateTime(DTPFECHA.Text));
            cmd.Parameters.AddWithValue("@TMP_MONTO", TxtMonto.Text);




            MessageBox.Show("SUS DATOS SE GUARDARON");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO SE guardaron" + EX);

            }
            finally
            {
                con.Close();
            }

        }
        private void eliminar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@TMP_FOLIO", TXTFOLIO.Text);
            cmd.Parameters.AddWithValue("@TMP_SERIE", TxtSerie.Text);

            MessageBox.Show("SUS DATOS SE eliminaron");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO SE eliminaron" + EX);

            }
            finally
            {
                con.Close();
            }


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
        private void mostrar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            string consulta = "select * from UNIDAD";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGVentas.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarV();
            mostrar();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            eliminar();
            mostrar();
        }

        private void BTNAGG_Click(object sender, EventArgs e)
        {
            Guardar();
            mostrar();  
        }
    }
}
