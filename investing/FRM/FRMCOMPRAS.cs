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
    public partial class FRMCOMPRAS : Form
    {
        public FRMCOMPRAS()
        {
            
            InitializeComponent();
            CMBTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBAlmacen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FRMCOMPRAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet11.COMPRAS_DETALLE' Puede moverla o quitarla según sea necesario.
            this.cOMPRAS_DETALLETableAdapter.Fill(this.vENTASDataSet11.COMPRAS_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet5.COMPRAS' Puede moverla o quitarla según sea necesario.
            this.cOMPRASTableAdapter.Fill(this.vENTASDataSet5.COMPRAS);
            idprov();
            idalmacen();
            TIPDOCTO();
            consecutivo();

        }
        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(CO_FOLIO), 0) + 1 FROM COMPRAS";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtFolio.Text = dr.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontarn" + ex);
            }
            finally { con.Close(); }
        }
        private void mostrar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            string consulta = "select * from COMPRAS";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGCompras.DataSource = dt;

        }
        private void idprov()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PRO_ID FROM PROVEEDORES", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBProveedor.Items.Add(registro["PRO_ID"].ToString());
            }


            con.Close();

        }
        private void TIPDOCTO()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_TIPODOCTO FROM TIPO_DOCUMENTO ", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBTipoDocumento.Items.Add(registro["ID_TIPODOCTO"].ToString());
            }


            con.Close();

        }
        private void idalmacen()
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
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_COMPRAS";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CO_FOLIO", TxtFolio.Text);
            cmd.Parameters.AddWithValue("@CO_SERIE", TxtSerie.Text);
            cmd.Parameters.AddWithValue("@CO_ID_TIPODOCTO", CMBTipoDocumento.Text);
            cmd.Parameters.AddWithValue("@CO_ID_PROVEEDOR", CMBProveedor.Text);
            cmd.Parameters.AddWithValue("@CO_ID_ALMACEN", CMBAlmacen.Text);
            cmd.Parameters.AddWithValue("@CO_FACTURA", TxtFactura.Text);
            cmd.Parameters.AddWithValue("@CO_FECHA", Convert.ToDateTime(DTMFecha.Text));
     



            MessageBox.Show("SUS DATOS SE GUARDARON");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO SE ACTUALIZARON" + EX);

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
            cmd.CommandText = "SP_COMPRAS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CO_FOLIO", TxtFolio.Text);

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

       

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            eliminar();
            mostrar() ;
        }

        private void CMBTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BTNInsert_Click_1(object sender, EventArgs e)
        {
            guardar();
            mostrar();
        }

        private void DTMFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
