//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_UserSupplies
    {
        public int pk_PurchaseID { get; set; }
        public string Date { get; set; }
        public string PurchaseDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public Nullable<decimal> ExtCost { get; set; }
        public string StoreName { get; set; }
        public string PurchaseCategory { get; set; }
        public string SupplyTank { get; set; }
        public string Owner { get; set; }
        public int OnHand { get; set; }
    }
}