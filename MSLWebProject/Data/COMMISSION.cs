//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSLWebProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMMISSION
    {
        public decimal SQ_COMMISSION { get; set; }
        public decimal SQ_COMMISSION_VERSION { get; set; }
        public string AC_COMPANY { get; set; }
        public decimal SQ_OPERATION { get; set; }
        public string AC_COMMISSION_TYPE { get; set; }
        public decimal SQ_RECEIPT { get; set; }
        public Nullable<decimal> AM_COMMISSION { get; set; }
        public string AC_CURRENCY { get; set; }
        public Nullable<decimal> SQ_OBSERVATION { get; set; }
        public Nullable<System.DateTime> DT_VALID_FROM { get; set; }
        public Nullable<System.DateTime> DT_VALID_TO { get; set; }
        public bool FG_CURRENT_VERSION { get; set; }
        public string AC_CREATION_USER { get; set; }
        public System.DateTime TS_CREATION { get; set; }
        public string AC_LAST_UPDATE_USER { get; set; }
        public System.DateTime TS_LAST_UPDATE { get; set; }
    }
}
