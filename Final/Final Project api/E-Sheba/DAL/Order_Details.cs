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
    
    public partial class Order_Details
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int service_id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public double unit_price { get; set; }
        public int quantity { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}
