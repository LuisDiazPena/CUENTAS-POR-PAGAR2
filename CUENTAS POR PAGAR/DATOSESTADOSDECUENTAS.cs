using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
    class DATOSESTADOSDECUENTAS
    {
        public static List<ESTADODECUENTASOMAR> MOSTRARESTADOS()
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from E in BD.ESTADODECUENTASOMAR select E).ToList();
                return INFO;
            }
        }
        public static List<ESTADODECUENTASOMAR> BUSCARPORNUMEROFACTURA(int numerofactura)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from E in BD.ESTADODECUENTASOMAR
                            where E.NUMEROFACTURA == numerofactura
                            select E).ToList();
                return INFO;
            }
        }
        internal void Show()
        {
            throw new NotImplementedException();
        }
        public static List<ESTADODECUENTASOMAR> BUSCARPORCODIGO(string codigo)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from E in BD.ESTADODECUENTASOMAR
                            where E.CODIGO == codigo
                            select E).ToList();
                return INFO;
            }
        }
    }
}
