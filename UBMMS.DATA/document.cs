//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBMMS.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class document
    {
        public string tracking_id { get; set; }
        public string document_type { get; set; }
        public string id_project_code { get; set; }
        public string sstem_user { get; set; }
        public Nullable<bool> finalized { get; set; }
        public Nullable<bool> referred { get; set; }
        public Nullable<int> id_team { get; set; }
    
        public virtual team team { get; set; }
        public virtual project_codes project_codes { get; set; }
    }
}
