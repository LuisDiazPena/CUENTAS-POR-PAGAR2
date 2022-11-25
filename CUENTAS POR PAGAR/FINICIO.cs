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
    public partial class FINICIO : Form
    {
        public FINICIO()
        {
            InitializeComponent();
        }
        private void FINICIO_Load(object sender, EventArgs e)
        {
            //Para mostrar los datos de los usuarios
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();
            //Para ocultar la clave.
            DAGVUSUARIOS.Columns[1].Visible = false;
            //Disfrazar los caracteres escritos en el TextBox TCLAVE
            TCLAVE.PasswordChar = '*';
        }
        private void TUSUARIO_TextChanged(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORUSUARIO(TUSUARIO.Text);
        }
        private void TCLAVE_TextChanged(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORCLAVE(TCLAVE.Text);
        }
        private void BENTRADA_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DAGVUSUARIOS.CurrentRow;
                //Para copiar los valores de las columnas en las variables US y CL
                string US = Convert.ToString(FILA.Cells[0].Value);
                string CL = Convert.ToString(FILA.Cells[1].Value);
                //Para validar el usuario y la contraseña
                if (TUSUARIO.Text == US & TCLAVE.Text == CL)
                {
                    FMENUPRI FP = new FMENUPRI();
                    FP.Show();
                }
                else
                {
                    MessageBox.Show("DEBE ESCRIBIR EL NOMBRE DEL USUARIO Y CONTRASEÑA INVÁLIDOS");
                }
            }
            catch
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INVÁLIDOS");
                TUSUARIO.Focus();
            }
        }
    }
}
