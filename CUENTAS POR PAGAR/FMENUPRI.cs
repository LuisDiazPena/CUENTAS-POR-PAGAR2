using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace CUENTAS_POR_PAGAR
//{
//    public partial class FMENUPRI : Form
//    {
//        public FMENUPRI()
//        {
//            InitializeComponent();
//        }

//        private void FMENUPRI_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}

namespace CUENTAS_POR_PAGAR
{
    public partial class FMENUPRI : Form
    {
        public FMENUPRI()
        {
            InitializeComponent();
        }
        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FESTADODECUENTAS FEDC = new FESTADODECUENTAS();
            FEDC.Show();
        }
        private void mantenimientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FPROVEEDORES PF = new FPROVEEDORES();
            PF.Show();
        }
        private void mantenimientofacturasToolStripMenuItem1_Click(object sender,EventArgs e)
        {
            FFACTURAS FF = new FFACTURAS();
            FF.Show();
        }
        private void reporteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FCHEQUES FRC = new FCHEQUES();
            FRC.Show();
        }
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFACTURAS FRF = new FFACTURAS();
            FRF.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void reporteProveedoresToolStripMenuItem_Click(object sender,EventArgs e)
        {
            FPROVEEDORES FRP = new FPROVEEDORES();
            FRP.Show();
        }
        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCHEQUES FC = new FCHEQUES();
            FC.Show();
        }
        private void reporteDeEstadoDeCuentasToolStripMenuItem_Click(object sender,EventArgs e)
        {
            FESTADODECUENTAS FREC = new FESTADODECUENTAS();
            FREC.Show();
        }

        private void FMENUPRI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}

