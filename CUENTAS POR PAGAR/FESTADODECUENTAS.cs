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
    public partial class FESTADODECUENTAS : Form
    {
        public FESTADODECUENTAS()
        {
            InitializeComponent();
        }
        private void FESTADODECUENTAS_Load(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADOS();
        }
        private void TPORCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource =
           DATOSESTADOSDECUENTAS.BUSCARPORCODIGO(TPORCODIGO.Text);
        }
        private void TPORNUMFACT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVESTADOCUENTAS.DataSource =
               DATOSESTADOSDECUENTAS.BUSCARPORNUMEROFACTURA(int.Parse(TPORNUMFACT.Text));
            }
            catch
            {
                TPORNUMFACT.Focus();
            }
        }
        private void BVERTODOS_Click(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADOS();
        }
    }
}
