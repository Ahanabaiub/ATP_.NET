//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public Nullable<int> application_status { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public System.DateTime created_at { get; set; }
        public string application_subject { get; set; }
        public string application_type { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
