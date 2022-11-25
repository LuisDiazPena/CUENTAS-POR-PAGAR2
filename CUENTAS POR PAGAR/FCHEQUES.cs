using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR
{
    public partial class FCHEQUES : Form
    {
        public FCHEQUES()
        {
            InitializeComponent();
        }
        private void DGVCHEQUES_Load(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVCHEQUES.CurrentRow;
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }
        private void TNUMCHEQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVCHEQUES.DataSource =
               DATOSCHEQUES.BUSCARELNUMERO(int.Parse(TNUMCHEQ.Text));
            }
            catch
            {
                TNUMCHEQ.Focus();
            }
        }
        private void FCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }
        private void TNUMFACT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVCHEQUES.DataSource =
               DATOSCHEQUES.BUSCARNUMERODEFACTURA(int.Parse(TNUMCHEQ.Text));
            }
            catch
            {
                TNUMCHEQ.Focus();
            }
        }
        private void FCHEQUES_Load(object sender, EventArgs e)
        {
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARCHEQUES FAC = new FAGREGARCHEQUES();
            FAC.FormClosed += new
           System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            FAC.Show();
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVCHEQUES.CurrentRow;
            int numero = Convert.ToInt16(FILA.Cells[0].Value);
            FMODIFICARCHEQUES FMC = new FMODIFICARCHEQUES(numero);
            FMC.Show();
            FMC.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
        }
        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR ESTE CHEQUE ? ", "ADVERTENCIA DE ELIMINACION", MessageBoxButtons.YesNo);
        if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVCHEQUES.CurrentRow;
                int numercheque = Convert.ToUInt16(FILA.Cells[0].Value);
                DATOSCHEQUES.ELIMINARCHEQUE(numercheque);
                MessageBox.Show(
                "SE HA BORRADO EL CHEQUE " + numercheque, "REGISTRO ELIMINADO");
                DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            }
        }
    }
}
