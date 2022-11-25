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
    public partial class FAGREGARCHEQUES : Form
    {
        public FAGREGARCHEQUES()
        {
            InitializeComponent();
        }
        private void TNUMCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMFACT.Focus();
            }
        }
        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMFACT.Focus();
            }
        }
        private void TVALCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALCHEQ.Focus();
            }
        }
        private void TFECHACHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHACHEQ.Focus();
            }
        }
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSCHEQUES.INSERTARCHEQUE(
                int.Parse(TNUMCHEQ.Text),
                int.Parse(TNUMFACT.Text),
                decimal.Parse(TVALCHEQ.Text),
                DateTime.Parse(TFECHACHEQ.Text)
                );
                MessageBox.Show("EL CHEQUE SE AGREGÓ SATISFACTORIAMENTE",
               "AGREGAR CHEQUE");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA INVALIDA. TRATE DE NUEVO");
                TNUMCHEQ.Focus();
            }
        }
    }
}

