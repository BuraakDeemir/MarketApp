//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayers
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOrderDetails
    {
        public int OrderDetailId { get; set; }
        public Nullable<int> orderId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string PersonAdress { get; set; }
        public string PersonContact { get; set; }
        public Nullable<int> ProductId { get; set; }
    }
}
