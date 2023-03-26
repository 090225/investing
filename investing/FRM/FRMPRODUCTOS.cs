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
    public partial class FRMPRODUCTOS : Form
    {
        public FRMPRODUCTOS()
        {
            InitializeComponent();
            CMBUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
         
            BTNGUARDAR.Enabled = false;
        }

        private void FRMPRODUCTOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet10.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.vENTASDataSet10.PRODUCTOS);

            TIPPTOD();
            UNIDAD();
            consecutivo();
        }
        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(PR_ID), 0) + 1 FROM PRODUCTOS";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtId.Text = dr.GetInt32(0).ToString();
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
            string consulta = "select * from PRODUCTOS";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgproductos.DataSource = dt;

        }
        private void TIPPTOD()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TP_ID_TP FROM TIPO_PRODUCTO", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBTipoProducto.Items.Add(registro["TP_ID_TP"].ToString());
            }


            con.Close();

        }
        private void UNIDAD()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UN_ID FROM UNIDAD", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBUnidad.Items.Add(registro["UN_ID"].ToString());
            }


            con.Close();

        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PR_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", CMBUnidad.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", TxtStockMinimo.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", TxtStockMaximo.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", CMBTipoProducto.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", TxtPrecio.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", TxtIva.Text);




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
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PR_ID", TxtId.Text);

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
        private void VALIDARCAMPO()
        {
            var vr =  !string.IsNullOrEmpty(TxtNombre.Text) &&
                !string.IsNullOrEmpty(CMBTipoProducto.Text) && !string.IsNullOrEmpty(TxtStockMinimo.Text) && !string.IsNullOrEmpty(TxtStockMaximo.Text) && !string.IsNullOrEmpty(CMBUnidad.Text) &&
                !string.IsNullOrEmpty(TxtPrecio.Text) && !string.IsNullOrEmpty(TxtIva.Text);

            BTNGUARDAR.Enabled = vr;
            var rv = !string.IsNullOrEmpty(TxtId.Text);
          


        }



        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            guardar();
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
            mostrar();
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }


            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void CMBUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtStockMinimo_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtStockMaximo_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void CMBTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtPrecio_TextChanged_1(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtIva_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }
    }
}
