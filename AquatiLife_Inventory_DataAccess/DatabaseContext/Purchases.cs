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
    
    public partial class Purchases
    {
        public int pk_PurchaseID { get; set; }
        public string ItemName { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int fk_StoreID { get; set; }
        public int fk_PurchaseType { get; set; }
        public double Cost { get; set; }
        public Nullable<int> fk_UserFish { get; set; }
        public Nullable<int> fk_UserTank { get; set; }
    
        public virtual PurchaseTypes PurchaseTypes { get; set; }
        public virtual Stores Stores { get; set; }
        public virtual UserFish UserFish { get; set; }
        public virtual UserTanks UserTanks { get; set; }
    }
}
