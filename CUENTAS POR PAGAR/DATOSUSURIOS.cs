using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
    class DATOSUSUARIOS
    {
        public static List<USUARIOSOMAR> MOSTRAR()
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                List<USUARIOSOMAR> INFO = (from U in BD.USUARIOSOMAR
                                           select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSOMAR> BUSCARPORUSUARIO(string usuario)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                List<USUARIOSOMAR> INFO = (from U in BD.USUARIOSOMAR
                                           where U.USUARIO.StartsWith(usuario)
                                           select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSOMAR> BUSCARPORCLAVE(string clave)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                List<USUARIOSOMAR> INFO = (from U in BD.USUARIOSOMAR
                                           where U.CLAVE.StartsWith(clave)
                                           select U).ToList();
                return INFO;
            }
        }
    }

}

