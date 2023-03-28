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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace investing.FRM
{
    public partial class FRMALMACEN : Form
    {
        public FRMALMACEN()
        {
            InitializeComponent();
            BTNInsert.Enabled = false;
            BTNDelete.Enabled = false;
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FRMALMACEN_Load(object sender, EventArgs e)
        {
            

            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet2.ALMACENES' Puede moverla o quitarla según sea necesario.
            this.aLMACENESTableAdapter.Fill(this.vENTASDataSet2.ALMACENES);
            consecutivo();
        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@AL_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE", TxtNombre.Text);

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
        private void ACTUALIZAR()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@AL_ID", TxtId.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE", TxtNombre.Text);

            MessageBox.Show("SUS DATOS SE ACTUALIZARON");

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

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("",con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(AL_ID), 0) + 1 FROM ALMACENES";

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
                MessageBox.Show("No se encontarn"  + ex);
            }
            finally { con.Close(); }
        }
        private void mostrar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            string consulta = "select * from ALMACENES";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DTGAlmacen.DataSource = dt;
            
        }
        private void eliminar()
        {
            SqlConnection con = new SqlConnection(Conexion.conect());
            SqlCommand cmd = new SqlCommand("", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@AL_ID", TxtId.Text);

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

        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            guardar();
            mostrar();
        }

      
       
        private void VALIDARCAMPO()
        {
            var vr = !string.IsNullOrEmpty(TxtNombre.Text);
           
            BTNInsert.Enabled = vr;
            


        }
        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
           VALIDARCAMPO();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            VALIDARCAMPO();
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

      

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ACTUALIZAR();
            mostrar();
        }
    } 
}