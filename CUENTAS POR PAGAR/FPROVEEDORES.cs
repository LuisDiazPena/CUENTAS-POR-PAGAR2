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
    public partial class FPROVEEDORES : Form
    {
        private void FAGREGARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }
        private void FMODIFICARARPROV_FormClosed(object sender,FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }
        private void FPROVEEDORES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DVGPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }
        public FPROVEEDORES()
        {
            InitializeComponent();
        }
        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORCODIGO(TCODIGO.Text);
        }
        private void TNOMBRES_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORNOMBRES(TNOMBRES.Text);
        }
        private void TAPELLIDOS_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORAPELLIDOS(TAPELLIDOS.Text);
        }
        private void TDIRECCION_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORDIRECCION(TDIRECCION.Text);
        }
        private void TCIUDAD_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORCIUDAD(TCIUDAD.Text);
        }
        private void TTELEFONO_TextChanged(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource =
           DATOSPROVEEDORES.BUSCARPORTELEFONO((TTELEFONO.Text));
        }
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARPROV FAP = new FAGREGARPROV();
            FAP.FormClosed += new
           FormClosedEventHandler(FPROVEEDORES_FormClosed);
            FAP.Show();
        }
        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR EL PROVEEDOR ? ", "BORRAR PROVEEDOR", MessageBoxButtons.YesNo);
        if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DVGPROVEEDORES.CurrentRow;
                string codigo = Convert.ToString(FILA.Cells[0].Value);
                DATOSPROVEEDORES.ELIMINARPROVEEDOR(codigo);
                MessageBox.Show("SE HA BORRADO EL PROVEEDOR" + TNOMBRES.Text + " " + TAPELLIDOS.Text, "REGISTRO ELIMINADO");
               
                DVGPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            }
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DVGPROVEEDORES.CurrentRow;
            string codigo = Convert.ToString(FILA.Cells[0].Value);
            FMODIFICARPROV FMP = new FMODIFICARPROV(codigo);
            {
                FMP.Show();
                FMP.FormClosed += new
               FormClosedEventHandler(FPROVEEDORES_FormClosed);
            }
        }
        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            DVGPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }
    }
}

