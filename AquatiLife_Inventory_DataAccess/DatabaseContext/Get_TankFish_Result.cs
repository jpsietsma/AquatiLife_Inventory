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
    
    public partial class Get_TankFish_Result
    {
        public int pk_FishID { get; set; }
        public Nullable<int> fk_UserID { get; set; }
        public int fk_UserFishID { get; set; }
        public Nullable<int> fk_UserPurchaseID { get; set; }
        public Nullable<int> fk_FishType { get; set; }
        public Nullable<int> fk_UserTank { get; set; }
    }
}
