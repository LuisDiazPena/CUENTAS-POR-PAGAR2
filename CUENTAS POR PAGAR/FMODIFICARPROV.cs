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
    public partial class FMODIFICARPROV : Form
    {
        private string CODIGO;
        public FMODIFICARPROV(string CODIGOPROVEEDOR)
        {
            InitializeComponent();
            CODIGO = CODIGOPROVEEDOR;
        }
        public FMODIFICARPROV()
        {
        }
        private void FMODIFICARPROV_Load(object sender, EventArgs e)
        {
            PROVEEDORESOMAR prov = DATOSPROVEEDORES.CARGAR(CODIGO);
            TCODIGO.Text = prov.CODIGO;
            TNOMBRES.Text = prov.NOMBRES;
            TAPELLIDOS.Text = prov.APELLIDOS;
            TDIRECCION.Text = prov.DIRECCION;
            TCIUDAD.Text = prov.CIUDAD;
            TTELEFONO.Text = prov.TELEFONO;
        }
        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {
            DATOSPROVEEDORES.MODIFICARPROVEEDOR
            (TCODIGO.Text,
            TNOMBRES.Text,
            TAPELLIDOS.Text,
            TDIRECCION.Text,
            TCIUDAD.Text,
            TTELEFONO.Text);
            MessageBox.Show("EL REGISTRO SE MODIFICÓ EXITOSAMENTE.",
           "MODIFICACIÓN");
            Close();
        }
    }
}

