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
    public partial class FFACTURAS : Form
    {
        public FFACTURAS()
        {
            InitializeComponent();
        }
        private void FFACTURAS_Load(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
        }
        private void TNUMFACT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFACTURAS.DataSource =
               DATOSFACTURAS.BUSCARELNUMERO(Convert.ToUInt16(TNUMFACT.Text));
            }
            catch
            {
                TNUMFACT.Focus();
            }
        }
        private void FFACTURAS_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
        }
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARFACT FAF = new FAGREGARFACT();
            FAF.FormClosed += new
           System.Windows.Forms.FormClosedEventHandler(FFACTURAS_FormClosed);
            FAF.Show();
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVFACTURAS.CurrentRow;
            int numero = Convert.ToInt16(FILA.Cells[0].Value);
            FMODIFICARFACT FMF = new FMODIFICARFACT(numero);
            FMF.Show();
            FMF.FormClosed += new
            FormClosedEventHandler(FFACTURAS_FormClosed);
        }
        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR ESTA FACTURA?",
           "ADVERTENCIA DE ELIMINACION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVFACTURAS.CurrentRow;
                int numerofactura = Convert.ToUInt16(FILA.Cells[0].Value);
                DATOSFACTURAS.ELIMINARFACTURA(numerofactura);
                MessageBox.Show(
                "SE HA BORRADO LA FACTURA" + numerofactura, "REGISTRO ELIMINADO");
                DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
            }
        }
        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.BUSCARELCODIGO((TCODIGO.Text));
        }
    }
}
