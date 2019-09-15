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
    
    public partial class UserTanks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTanks()
        {
            this.UserFishInventory = new HashSet<UserFishInventory>();
            this.UserLivePlants = new HashSet<UserLivePlants>();
            this.UserPurchases = new HashSet<UserPurchases>();
            this.UserTankSupplyInventory = new HashSet<UserTankSupplyInventory>();
            this.UserTankTemperatureLogs = new HashSet<UserTankTemperatureLogs>();
            this.UserTankTests = new HashSet<UserTankTests>();
        }
    
        public int pk_UserTankID { get; set; }
        public int fk_TankOwner { get; set; }
        public int TankSize { get; set; }
        public string TankHeight { get; set; }
        public string TankWidth { get; set; }
        public int fk_TankWaterType { get; set; }
        public int fk_TankType { get; set; }
        public string TankDisplayName { get; set; }
        public bool IsActiveTank { get; set; }
        public Nullable<int> fk_UserPurchaseID { get; set; }
    
        public virtual List_TankTypes List_TankTypes { get; set; }
        public virtual List_WaterTypes List_WaterTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFishInventory> UserFishInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLivePlants> UserLivePlants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPurchases> UserPurchases { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTankSupplyInventory> UserTankSupplyInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTankTemperatureLogs> UserTankTemperatureLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTankTests> UserTankTests { get; set; }
    }
}
