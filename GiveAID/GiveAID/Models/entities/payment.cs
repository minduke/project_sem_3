//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiveAID.Models.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public int id { get; set; }
        public Nullable<int> post_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<decimal> transaction_amout { get; set; }
        public string transaction_no { get; set; } = "";
        public System.DateTime transaction_date { get; set; }
    
        public virtual post post { get; set; }
        public virtual user user { get; set; }
    }
}
