using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
    class DATOSFACTURAS
    {
        public static List<FACTURASOMAR> MOSTRARFACTURAS()
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from F in BD.FACTURASOMAR select F).ToList();
                return INFO;
            }
        }
        public static List<FACTURASOMAR> BUSCARELNUMERO(int numerofactura)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from F in BD.FACTURASOMAR
                            where F.NUMEROFACTURA
                           == numerofactura
                            select F).ToList();
                return INFO;
            }
        }
        public static List<FACTURASOMAR> BUSCARELCODIGO(string codigo)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from F in BD.FACTURASOMAR
                            where F.CODIGO == codigo
                            select F).ToList();
                return INFO;
            }
        }
        public static void INSERTARFACTURA
        (
        int numerofactura,
        string codigoproveedor,
        decimal valorfactura,
        DateTime fechafactura,
        DateTime fechavencimiento
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                BD.FACTURASOMAR.Add(new FACTURASOMAR
                {
                    NUMEROFACTURA = numerofactura,
                    CODIGO = codigoproveedor,
                    VALORFACTURA = valorfactura,
                    FECHAFACTURA = fechafactura,
                    FECHAVENCIMIENTO = fechavencimiento,
                });
                BD.SaveChanges();
            }
        }
        public static void MODIFICARFACTURA
        (
        int numerofactura,
        string codigoproveedor,
        decimal valorfactura,
        DateTime fechafactura,
        DateTime fechavencimiento
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var MODIFICAR = (from F in BD.FACTURASOMAR
                                 where F.NUMEROFACTURA == numerofactura
                                 select F).Single();
                MODIFICAR.NUMEROFACTURA = numerofactura;
                MODIFICAR.CODIGO = codigoproveedor;
                MODIFICAR.VALORFACTURA = valorfactura;
                MODIFICAR.FECHAFACTURA = fechafactura;
                MODIFICAR.FECHAVENCIMIENTO = fechavencimiento;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARFACTURA(int numerofactura)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var ELIMINAR = (from F in BD.FACTURASOMAR
                                where F.NUMEROFACTURA == numerofactura
                                select F).Single();
                BD.FACTURASOMAR.Remove(ELIMINAR);
                BD.SaveChanges();
            }
        }
        public static FACTURASOMAR CARGAR(int numerofactura)
        {
            FACTURASOMAR FACTURAS = new FACTURASOMAR();
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from F in BD.FACTURASOMAR
                            where F.NUMEROFACTURA
                           == numerofactura
                            select F).Single();
                FACTURAS.NUMEROFACTURA = INFO.NUMEROFACTURA;
                FACTURAS.CODIGO = INFO.CODIGO;
                FACTURAS.VALORFACTURA = INFO.VALORFACTURA;
                FACTURAS.FECHAFACTURA = INFO.FECHAFACTURA;
                FACTURAS.FECHAVENCIMIENTO = INFO.FECHAVENCIMIENTO;
                return FACTURAS;
            }
        }
    }
}