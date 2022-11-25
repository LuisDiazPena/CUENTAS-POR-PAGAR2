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
    public partial class FMODIFICARFACT : Form
    {
        public FMODIFICARFACT()
        {
            InitializeComponent();
        }
        private int numero;
        public FMODIFICARFACT(int numerofactura)
        {
            InitializeComponent();
            numero = numerofactura;
        }
        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.MODIFICARFACTURA(
            Convert.ToInt16(TNUMFACT.Text)
            ,TCODIGO.Text,
            Convert.ToDecimal(TVALFACT.Text),
            Convert.ToDateTime(TFECHAFACT.Text),
            Convert.ToDateTime(TFECHAVENC.Text));
            MessageBox.Show("LA FACTURA SE MODIFICÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
           
            Close();
        }
        private void FMODIFICARFACT_Load(object sender, EventArgs e)
        {
            FACTURASOMAR fact = DATOSFACTURAS.CARGAR(numero);
            TNUMFACT.Text = Convert.ToString(fact.NUMEROFACTURA);
            TCODIGO.Text = fact.CODIGO;
            TVALFACT.Text = Convert.ToString(fact.VALORFACTURA);
            TFECHAFACT.Text = Convert.ToString(fact.FECHAFACTURA);
            TFECHAVENC.Text = Convert.ToString(fact.FECHAVENCIMIENTO);
        }
    }
}

