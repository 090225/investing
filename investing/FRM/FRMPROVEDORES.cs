using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace investing.FRM
{
    public partial class FRMPROVEDORES : Form
    {
        public FRMPROVEDORES()
        {
            InitializeComponent();
            BTNDelete.Enabled = false;
            BTNInsert.Enabled = false;
            btnactualizar.Enabled = false;
            REGIMEN();
            CMBREGIMEN.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRMPROVEDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet6.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet6.PROVEEDORES);
            consecutivo();


        }
        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(PRO_ID), 0) + 1 FROM PROVEEDORES";

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
            string consulta = "select * from PROVEEDORES";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGProveedores.DataSource = dt;

        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PRO_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE", txtnombre.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", txtrfc.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", txtcorreo.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", txtlada.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", txttelefono.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", txtcalle.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", txtnumext.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", txtcuentab.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", txtcontacto.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", txttelefonoc.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", CMBREGIMEN.Text);
            MessageBox.Show("SUS DATOS SE AGREGARON");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show("NO SE GUARDARON" + EX);

            }
            finally
            {
                con.Close();
            }
        }
        private void ACTUALIZAR()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("",con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@PRO_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE", txtnombre.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", txtrfc.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", txtcorreo.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", txtlada.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", txttelefono.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", txtcalle.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", txtnumext.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", txtcuentab.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", txtcontacto.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", txttelefonoc.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", CMBREGIMEN.Text);
            MessageBox.Show("SUS DATOS SE ACTUALIZARON");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX) 
            {
                MessageBox.Show("NO SE ACTUALIZARON"+ EX);
                
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
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PRO_ID", TxtId.Text);

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
        private void VALIDARCAMPO()
        {
            var vr =  !string.IsNullOrEmpty(txtnombre.Text) &&
                 !string.IsNullOrEmpty(txtrfc.Text) && !string.IsNullOrEmpty(txtcorreo.Text) && !string.IsNullOrEmpty(txtcuentab.Text) &&
                !string.IsNullOrEmpty(txtcontacto.Text) && !string.IsNullOrEmpty(txttelefonoc.Text) && !string.IsNullOrEmpty(CMBREGIMEN.Text) &&
                !string.IsNullOrEmpty(txtlada.Text) && !string.IsNullOrEmpty(txttelefono.Text) &&
                !string.IsNullOrEmpty(txtcalle.Text) && !string.IsNullOrEmpty(txtnumext.Text);

            BTNInsert.Enabled = vr;
            btnactualizar.Enabled = vr;
            var rv = !string.IsNullOrEmpty(TxtId.Text);
            BTNDelete.Enabled = rv;


        }
        private void BTNInsert_Click(object sender, EventArgs e)
        {
            guardar();
            mostrar();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
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

        private void txtlada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnumext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrfc_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtcuentab_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtcontacto_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txttelefonoc_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void CMBREGIMEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtlada_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtcalle_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtnumext_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txttelefonoc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            
            ACTUALIZAR();
            mostrar();
        }
    }
}
