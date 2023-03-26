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
    public partial class FRMUNIDAD : Form
    {
        public FRMUNIDAD()
        {
            InitializeComponent();
            BTNInsert.Enabled = false;
            
        }

        private void FRMUNIDAD_Load(object sender, EventArgs e)
        {
            consecutivo();
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet7.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.vENTASDataSet7.UNIDAD);
            

        }
        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(UN_ID), 0) + 1 FROM UNIDAD";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid.Text = dr.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontarn" + ex);
            }
            finally { con.Close(); }
        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@UN_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@UN_DESCRIPCION", txtdesc.Text);

            MessageBox.Show("SUS DATOS SE GUARDARON");

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
        private void mostrar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            string consulta = "select * from UNIDAD";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGUNIDAD.DataSource = dt;

        }
        private void eliminar ()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@UN_ID", txtid.Text);

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
            var vr = !string.IsNullOrEmpty(txtid.Text) && !string.IsNullOrEmpty(txtdesc.Text);

            BTNInsert.Enabled = vr;
            var rv = !string.IsNullOrEmpty(txtid.Text);
            ;


        }
        private void BTNInsert_Click(object sender, EventArgs e)
        {
            guardar();
            mostrar();

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            
        }
       
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
        }
    }
}
