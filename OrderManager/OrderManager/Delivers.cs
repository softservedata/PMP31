//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivers
    {
        public Delivers()
        {
            this.Items = new HashSet<Items>();
        }
    
        public int id_deliver { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Items> Items { get; set; }
    }
}
