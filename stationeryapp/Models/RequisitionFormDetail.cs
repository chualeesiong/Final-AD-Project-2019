//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stationeryapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequisitionFormDetail
    {
        public string FormDetailsNumber { get; set; }
        public string FormNumber { get; set; }
        public string ItemNumber { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Status { get; set; }
    
        public virtual RequisitionForm RequisitionForm { get; set; }
        public virtual StationeryCatalog StationeryCatalog { get; set; }
    }
}
