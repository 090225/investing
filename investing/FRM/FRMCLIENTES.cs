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
    public partial class FRMCLIENTES : Form
    {
        public FRMCLIENTES()
        {
            InitializeComponent();
            CMBREGIMEN.DropDownStyle = ComboBoxStyle.DropDownList;
            BTNDelete.Enabled = false;
            BTNInsert.Enabled = false;
            REGIMEN();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(CL_ID), 0) + 1 FROM CLIENTES";

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
        private void FRMCLIENTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet4.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.vENTASDataSet4.CLIENTES);
         
            consecutivo();

        }
        private void mostrar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            string consulta = "select * from CLIENTES";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGClientes.DataSource = dt;

        }
        private void REGIMEN()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT RE_ID FROM REGIMEN", con);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CMBREGIMEN.Items.Add(registro["RE_ID"].ToString());
            }
            con.Close();
        }
           

        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CL_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@CL_NOMBRE", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@CL_RFC", TxtRfc.Text);
            cmd.Parameters.AddWithValue("@CL_CORREO", TxtCorreo.Text);
            cmd.Parameters.AddWithValue("@CL_LADA", TxtLada.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO", TxtTelefono.Text);
            cmd.Parameters.AddWithValue("@CL_CALLE", TxtCalle.Text);
            cmd.Parameters.AddWithValue("@CL_NUMERO_EXT", TxtNumeroExt.Text);
            cmd.Parameters.AddWithValue("@CL_CTABANCARIA", TxtCuentaBancaria.Text);
            cmd.Parameters.AddWithValue("@CL_CONTACTO", TxtContacto.Text);
            cmd.Parameters.AddWithValue("@CL_TELEF_CONTACTO", TxtTelefonoContacto.Text);
            cmd.Parameters.AddWithValue("@CL_REGIMEN", CMBREGIMEN.Text);



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
        private void actualizar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@CL_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@CL_NOMBRE", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@CL_RFC", TxtRfc.Text);
            cmd.Parameters.AddWithValue("@CL_CORREO", TxtCorreo.Text);
            cmd.Parameters.AddWithValue("@CL_LADA", TxtLada.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO", TxtTelefono.Text);
            cmd.Parameters.AddWithValue("@CL_CALLE", TxtCalle.Text);
            cmd.Parameters.AddWithValue("@CL_NUMERO_EXT", TxtNumeroExt.Text);
            cmd.Parameters.AddWithValue("@CL_CTABANCARIA", TxtCuentaBancaria.Text);
            cmd.Parameters.AddWithValue("@CL_CONTACTO", TxtContacto.Text);
            cmd.Parameters.AddWithValue("@CL_TELEF_CONTACTO", TxtTelefonoContacto.Text);
            cmd.Parameters.AddWithValue("@CL_REGIMEN", CMBREGIMEN.Text);



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
            cmd.CommandText = "SP_CLIENTES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CL_ID", TxtId.Text);

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


        private void BTNInsert_Click_1(object sender, EventArgs e)
        {
            guardar();
            mostrar();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            eliminar();
            mostrar() ;
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
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

        private void TxtLada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNumeroExt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void VALIDARCAMPO()
        {
            var vr =!string.IsNullOrEmpty(TxtNombre.Text) &&
                !string.IsNullOrEmpty(TxtRfc.Text) && !string.IsNullOrEmpty(TxtCorreo.Text) && !string.IsNullOrEmpty(TxtCuentaBancaria.Text) && !string.IsNullOrEmpty(TxtContacto.Text) &&
                !string.IsNullOrEmpty(TxtTelefonoContacto.Text) && !string.IsNullOrEmpty(CMBREGIMEN.Text) &&
                !string.IsNullOrEmpty(TxtLada.Text) && !string.IsNullOrEmpty(TxtTelefono.Text) &&
                !string.IsNullOrEmpty(TxtCalle.Text) && !string.IsNullOrEmpty(TxtNumeroExt.Text);

            BTNInsert.Enabled = vr;
            var rv = !string.IsNullOrEmpty(TxtId.Text);
            BTNDelete.Enabled = rv;


        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtRfc_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtCuentaBancaria_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtContacto_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtTelefonoContacto_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void CMBREGIMEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtLada_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtCalle_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtNumeroExt_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void DTGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
            mostrar();
        }
    }
}
