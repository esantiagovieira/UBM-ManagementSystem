//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBMMS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class log_documents
    {
        public string tracking_id { get; set; }
        public string op_code { get; set; }
        public string op_description { get; set; }
        public Nullable<System.DateTime> op_date { get; set; }
        public Nullable<int> op_user { get; set; }
        public Nullable<int> op_user_team { get; set; }
        public Nullable<System.TimeSpan> action_time { get; set; }
        public long id { get; set; }
        public string op_refer_code { get; set; }
        public string op_refer_comments { get; set; }
        public Nullable<int> destination_team { get; set; }
    }
}
