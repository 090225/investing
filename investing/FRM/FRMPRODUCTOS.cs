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
    public partial class FRMPRODUCTOS : Form
    {
        public FRMPRODUCTOS()
        {
            InitializeComponent();
        }

        private void FRMPRODUCTOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet1.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.vENTASDataSet1.PRODUCTOS);

        }
    }
}
