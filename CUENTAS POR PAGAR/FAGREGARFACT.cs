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
    public partial class FAGREGARFACT : Form
    {
        public FAGREGARFACT()
        {
            InitializeComponent();
        }
        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TCODIGO.Focus();
            }
        }
        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALFACT.Focus();
            }
        }
        private void TVALFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALFACT.Focus();
            }
        }
        private void TFECHAFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALFACT.Focus();
            }
        }
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.INSERTARFACTURA(
            Convert.ToInt16(TNUMFACT.Text),
            TCODIGO.Text,
            Convert.ToDecimal(TVALFACT.Text),
            Convert.ToDateTime(TFECHAFACT.Text),
            Convert.ToDateTime(TFECHAVENC.Text));
            MessageBox.Show("LA FACTURA SE AGREGÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
           
            Close();
        }
        private void FAGREGARFACT_Load(object sender, EventArgs e)
        {
        }
    }
}

