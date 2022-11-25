using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{

    class DATOSCHEQUES
    {

        public static List<CHEQUESOMAR> MOSTRARCHEQUES()
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from C in BD.CHEQUESOMAR select C).ToList();
                return INFO;
            }
        }
        public static List<CHEQUESOMAR> BUSCARELNUMERO(int numerocheque)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from C in BD.CHEQUESOMAR
                            where C.NUMEROCHEQUE == numerocheque
                            select C).ToList();
                return INFO;
            }
        }
        public static List<CHEQUESOMAR> BUSCARNUMERODEFACTURA(int NUMERO_FACTURA)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from C in BD.CHEQUESOMAR
                            where C.NUMEROFACTURA == NUMERO_FACTURA
                            select C).ToList();
                return INFO;
            }
        }
        public static void INSERTARCHEQUE
        (
        int numerocheque,
        int numerofactura,
        decimal valorcheque,
        DateTime fechacheque
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                BD.CHEQUESOMAR.Add(new CHEQUESOMAR
                {
                    NUMEROCHEQUE = numerocheque,
                    NUMEROFACTURA = numerofactura,
                    VALORCHEQUE = valorcheque,
                    FECHACHEQUE = fechacheque,
                });
                BD.SaveChanges();
            }
        }
        internal static void INSERTARCHEQUE(int v1, int v2, decimal v3, DateTime
       dateTime, StoreGeneratedPattern storeGeneratedPattern)
        {
            throw new NotImplementedException();
        }
        public static void MODIFICARCHEQUE
        (
        int numerocheque,
        int numerofactura,
        decimal valorcheque,
        DateTime fechacheque
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var MODIFICAR = (from F in BD.CHEQUESOMAR
                                 where F.NUMEROCHEQUE == numerocheque
                                 select F).Single();
                MODIFICAR.NUMEROCHEQUE = numerocheque;
                MODIFICAR.NUMEROCHEQUE = numerofactura;
                MODIFICAR.VALORCHEQUE = valorcheque;
                MODIFICAR.FECHACHEQUE = fechacheque;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARCHEQUE(int numerocheque)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var ELIMINAR = (from F in BD.CHEQUESOMAR
                                where F.NUMEROCHEQUE == numerocheque
                                select F).Single();
                BD.CHEQUESOMAR.Remove(ELIMINAR);
                BD.SaveChanges();
            }
        }
        public static CHEQUESOMAR CARGAR(int numerocheque)
        {
            CHEQUESOMAR CHEQUES = new CHEQUESOMAR();
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from F in BD.CHEQUESOMAR
                            where F.NUMEROCHEQUE == numerocheque
                            select F).Single();
                CHEQUES.NUMEROCHEQUE = INFO.NUMEROCHEQUE;
                CHEQUES.NUMEROFACTURA = INFO.NUMEROFACTURA;
                CHEQUES.VALORCHEQUE = INFO.VALORCHEQUE;
                CHEQUES.FECHACHEQUE = INFO.FECHACHEQUE;
                return CHEQUES;
            }
        }
    }
}

