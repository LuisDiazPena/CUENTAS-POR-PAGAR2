using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CUENTAS_POR_PAGAR
{
    public class DATOSPROVEEDORES
    {
        public static List<PROVEEDORESOMAR> MOSTRARDATOS()
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORCODIGO(string codigo)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where P.CODIGO.StartsWith(codigo)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORNOMBRES(string nombres)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where P.NOMBRES.StartsWith(nombres)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORAPELLIDOS(string apellidos)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where
P.APELLIDOS.StartsWith(apellidos)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORDIRECCION(string direccion)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where
P.DIRECCION.StartsWith(direccion)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORCIUDAD(string ciudad)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where P.CIUDAD.StartsWith(ciudad)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESOMAR> BUSCARPORTELEFONO(string telefono)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where P.TELEFONO.StartsWith(telefono)
                            select P).ToList();
                return INFO;
            }
        }
        public static void INSERTARPROVEEDOR
        (
        string codigo,
        string nombres,
        string apellidos,
        string direccion,
        string ciudad,
        string telefono
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                BD.PROVEEDORESOMAR.Add(new PROVEEDORESOMAR
                {
                    CODIGO = codigo,
                    NOMBRES = nombres,
                    APELLIDOS = apellidos,
                    DIRECCION = direccion,
                    CIUDAD = ciudad,
                    TELEFONO = telefono
                });
                BD.SaveChanges();
            }
        }
        public static void MODIFICARPROVEEDOR
        (
        string codigo,
        string nombres,
        string apellidos,
        string direccion,
        string ciudad,
        string telefono
        )
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var MODIFICAR = (from P in BD.PROVEEDORESOMAR
                                 where P.CODIGO == codigo
                                 select
P).Single();
                MODIFICAR.CODIGO = codigo;
                MODIFICAR.NOMBRES = nombres;
                MODIFICAR.APELLIDOS = apellidos;
                MODIFICAR.DIRECCION = direccion;
                MODIFICAR.CIUDAD = ciudad;
                MODIFICAR.TELEFONO = telefono;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARPROVEEDOR(string codigo)
        {
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var ELIMINA = (from P in BD.PROVEEDORESOMAR
                               where P.CODIGO == codigo
                               select
P).Single();
                BD.PROVEEDORESOMAR.Remove(ELIMINA);
                BD.SaveChanges();
            }
        }
        public static PROVEEDORESOMAR CARGAR(string codigo)
        {
            PROVEEDORESOMAR proveedores = new PROVEEDORESOMAR();
            using (SCXPOMAREntities BD = new SCXPOMAREntities())
            {
                var INFO = (from P in BD.PROVEEDORESOMAR
                            where P.CODIGO == codigo
                            select
P).Single();
                proveedores.CODIGO = INFO.CODIGO;
                proveedores.NOMBRES = INFO.NOMBRES;
                proveedores.APELLIDOS = INFO.APELLIDOS;
                proveedores.DIRECCION = INFO.DIRECCION;
                proveedores.CIUDAD = INFO.CIUDAD;
                proveedores.TELEFONO = INFO.TELEFONO;
                return proveedores;
            }
        }
    }
}
