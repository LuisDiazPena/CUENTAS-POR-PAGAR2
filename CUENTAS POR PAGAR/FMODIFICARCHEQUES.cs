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
    public partial class FMODIFICARCHEQUES : Form
    {
        private int numero;
        public FMODIFICARCHEQUES(int numerocheque)
        {
            InitializeComponent();
            numero = numerocheque;
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSCHEQUES.MODIFICARCHEQUE(
                int.Parse(TNUMFACT.Text),
                int.Parse(TNUMFACT.Text),
                Convert.ToDecimal(TVALCHEQ.Text),
                Convert.ToDateTime(TFECHACHEQ.Text)
                );
                MessageBox.Show("EL CHEUQUE SE MODIFICÓ SATISFACTORIAMENTE","AGREGAR FACTURA");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA IVÁLIDA. TRATE DE NUEVO", "ERROR DE ENTRADA");
            }
        }
        private void FMODIFICARCHEQUES_Load_1(object sender, EventArgs e)
        {
            CHEQUESOMAR chq = DATOSCHEQUES.CARGAR(numero);
            numero = chq.NUMEROCHEQUE;
            TNUMCHEQ.Text = Convert.ToString(numero);
            TNUMFACT.Text = Convert.ToString(chq.NUMEROFACTURA);
            TVALCHEQ.Text = Convert.ToString(chq.VALORCHEQUE);
            TFECHACHEQ.Text = Convert.ToString(chq.FECHACHEQUE);
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
        private void FMODIFICARCHEQUES_Load(object sender, EventArgs e)
        {
            CHEQUESOMAR chec = DATOSCHEQUES.CARGAR(numero);
            numero = chec.NUMEROCHEQUE;
            TNUMCHEQ.Text = Convert.ToString(chec.NUMEROCHEQUE);
            TNUMFACT.Text = Convert.ToString(chec.NUMEROFACTURA);
            TVALCHEQ.Text = Convert.ToString(chec.VALORCHEQUE);
            TFECHACHEQ.Text = Convert.ToString(chec.FECHACHEQUE);
        }
        private void TNUMCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMCHEQ.Focus();
            }
        }
        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMCHEQ.Focus();
            }
        }
        private void TVALCHEQ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMCHEQ.Focus();
            }
        }
        private void TFECHACHEQ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMCHEQ.Focus();
            }
        }
    }
}
