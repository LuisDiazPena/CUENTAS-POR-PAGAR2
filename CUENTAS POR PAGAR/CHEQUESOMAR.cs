//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUENTAS_POR_PAGAR
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHEQUESOMAR
    {
        public int NUMEROCHEQUE { get; set; }
        public Nullable<int> NUMEROFACTURA { get; set; }
        public Nullable<decimal> VALORCHEQUE { get; set; }
        public Nullable<System.DateTime> FECHACHEQUE { get; set; }
    
        public virtual FACTURASOMAR FACTURASOMAR { get; set; }
    }
}
